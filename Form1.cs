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
                MessageBox.Show("Проверьте интернет подключение");
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            btnConvert.Enabled = false;
            if (!decimal.TryParse(CurrValue.Text, out decimal amount))
            {
                MessageBox.Show("Введите число");
                return;
            }
            string from = CurrCurrency.SelectedItem.ToString();
            string to = ConvCurrency.SelectedItem.ToString();
            try
            {
                decimal rate = await api.GetRate(from, to);
                decimal result = amount * rate;
                ConvValue.Text = result.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Ошибка конвертации. Проверьте интернет.");
            }
            btnConvert.Enabled = true;
        }
    }
}
