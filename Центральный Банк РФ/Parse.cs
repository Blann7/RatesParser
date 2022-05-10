using System.Text.RegularExpressions;


namespace RatesParser
{
    public class Parse
    {
        /// <summary>
        /// List[0] - currency Name,
        /// List[1] - currency numcode,
        /// List[2] - currency charcode,
        /// List[3] - currency nominal,
        /// List[4] - currency value.
        /// </summary>
        public static List<string> parseResult = new List<string>();
        private static string currency = String.Empty;
        public static List<string> ParseCurrencyNames(string[] contentArray)
        {
            List<string> currencyNames = new List<string>();

            int i = 0;
            for (; i < contentArray.Length - 1; i++)
            {
                Match match = Regex.Match(contentArray[i], @"<Name>(.*?)</Name>");
                currencyNames.Add(match.Groups[1].Value);
            }

            return currencyNames;
        }
        public static async Task ParseInfo(string[] contentArray, string currencyName)
        {
            for (int i = 0; i < contentArray.Length - 1; i++)
            {
                if(contentArray[i].Contains(currencyName))
                {
                    currency = contentArray[i];
                    try
                    {
                        parseResult.Add(currencyName); // name
                        await Task.Factory.StartNew(() => parseResult.Add(ParseNumCode())); // numcode
                        await Task.Factory.StartNew(() => parseResult.Add(ParseCharCode())); // charcode
                        await Task.Factory.StartNew(() => parseResult.Add(ParseNominal())); // nominal
                        await Task.Factory.StartNew(() => parseResult.Add(ParseValue())); // value
                    }
                    catch (Exception e)
                    {
                        MainForm.MainFormError(e.Message);
                    }
                }
            }
        }
        private static string ParseNumCode()
        {
            Match match = Regex.Match(currency, @"<NumCode>(.*?)</NumCode>");
            return match.Groups[1].Value;
        }
        private static string ParseCharCode()
        {
            Match match = Regex.Match(currency, @"<CharCode>(.*?)</CharCode>");
            return match.Groups[1].Value;
        }
        private static string ParseNominal()
        {
            Match match = Regex.Match(currency, @"<Nominal>(.*?)</Nominal>");
            return match.Groups[1].Value;
        }
        private static string ParseValue()
        {
            Match match = Regex.Match(currency, @"<Value>(.*?)</Value>");
            return match.Groups[1].Value;
        }
    }
}
