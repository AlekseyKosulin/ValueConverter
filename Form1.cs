namespace ValueConverter
{
    public partial class Form1 : Form
    {
        RestAPI api = new RestAPI();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            btnConvert.Click += btnConvert_Click;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> currencies = await api.GetCurrencies();

                foreach (string code in currencies.Keys)
                {
                    CurrCurrency.Items.Add(code);
                    ConvCurrency.Items.Add(code);
                }

                CurrCurrency.SelectedItem = "USD";
                ConvCurrency.SelectedItem = "EUR";
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить валюты. Проверьте интернет.");
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(CurrValue.Text);
            string from = CurrCurrency.SelectedItem.ToString();
            string to = ConvCurrency.SelectedItem.ToString();

            decimal rate = await api.GetRate(from, to);
            decimal result = amount * rate;

            ConvValue.Text = result.ToString();
        }
    }
}
