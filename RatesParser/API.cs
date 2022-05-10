using System.Text;

namespace RatesParser
{
    public class API
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task<string[]> GetInfoAsArrayAsync()
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // important to avoid exception!!
                HttpResponseMessage response = await httpClient.GetAsync("https://www.cbr.ru/scripts/XML_daily.asp?date_req=");
                response.EnsureSuccessStatusCode();

                string dateString = await response.Content.ReadAsStringAsync();
                return dateString.Split("</Valute>",
                    StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            }
            catch (Exception e)
            {
                if(e.Message.Contains("443")) MainForm.MainFormError("Проверьте подключение к интернету.");
                else MainForm.MainFormError(e.Message);
                throw;
            }

            
        }
    }
}
