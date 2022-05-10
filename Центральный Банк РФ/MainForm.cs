namespace RatesParser
{
    public partial class MainForm : Form
    {
        private static List<string> comboBoxContent = new List<string>();
        private static string[] apiData = Array.Empty<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            // Creating content for ComboBox
            List<string> _comboBoxContent = await DownLoadCurrencyList();
            comboBoxContent = _comboBoxContent;
            for (int i = 0; i < _comboBoxContent.Count; i++) comboBoxCurrency.Items.Add(_comboBoxContent[i]);
            // --------------------------------------------
        }
        private async void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (comboBoxCurrency.SelectedIndex == -1) MainFormError("Вы не выбрали валюту");
            else
            {
                await Parse.ParseInfo(apiData, comboBoxContent[comboBoxCurrency.SelectedIndex]);
               
                PictureCentralBank.Visible = true; // show rus. bank picture

                textCurName.Visible = true;
                textCurName.Text = $"Валюта: {Parse.parseResult[0]}";

                textCurNumCode.Visible = true;
                textCurNumCode.Text = $"Цифровой код: {Parse.parseResult[1]}";

                textCurCharCode.Visible = true;
                textCurCharCode.Text = $"Буквенный код: {Parse.parseResult[2]}";

                textCurNominal.Visible = true;
                textCurNominal.Text = $"Номинал: {Parse.parseResult[3]}";

                textCurValue.Visible = true;
                textCurValue.Text = $"Курс к 1 RUB: {Parse.parseResult[4]}";

                Parse.parseResult = new List<string>(); // reset result for reusebly work of programm
            }
        }
        private static async Task<List<string>> DownLoadCurrencyList()
        {
            string[] data = await API.GetInfoAsArrayAsync();
            apiData = data;
            return Parse.ParseCurrencyNames(data);
        }
        public static void MainFormError(string message)
        {
            MessageBox.Show
                (message, // text
                "Ошибка!", // caption
                MessageBoxButtons.OK, 
                MessageBoxIcon.Stop, 
                MessageBoxDefaultButton.Button1, 
                MessageBoxOptions.ServiceNotification);
        }
    }
}