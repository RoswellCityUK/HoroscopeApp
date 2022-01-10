using Newtonsoft.Json;
using RestSharp;

namespace Week5Ex1HoroscopeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpDOB.Format = DateTimePickerFormat.Custom;
            cbxDay.SelectedIndex = 0;
            _ = getZodiacSign(dtpDOB.Value);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string zodiacSign = getZodiacSign(dtpDOB.Value);
            string day = cbxDay.Text;
            Task<RestResponse> response = GetHoroscopeJsonAsync(zodiacSign, day);
            Horoscope horoscope = DeserialiseHoroscopeJson(await response);
            txtHoroscope.Text = horoscope.description.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<RestResponse> GetHoroscopeJsonAsync(string zodiac, string day)
        {
            string url = "https://sameer-kumar-aztro-v1.p.rapidapi.com/?sign=" + zodiac + "&day=" + day;

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest("", Method.Post);

            request.AddHeader("x-rapidapi-host", "sameer-kumar-aztro-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", APIkeys.HoroscopeApiKey);

            RestResponse response = await client.ExecuteAsync(request);

            return response;
        }

        private Horoscope DeserialiseHoroscopeJson(RestResponse response)
        {
            Horoscope horoscope = new Horoscope();
            horoscope = JsonConvert.DeserializeObject<Horoscope>(response.Content);

            return horoscope;
        }

        private string getZodiacSign(DateTime date)
        {
            string zodiacSign = "";
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            string str = string.Empty;
            if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
            {
                zodiacSign = "aires";
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
            {
                zodiacSign = "taurus";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
            {
                zodiacSign = "gemini";
            }
            else if ((month == 6 && day >= 22 ) || (month == 7 && day <= 22))
            {
                zodiacSign = "cancer";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                zodiacSign = "leo";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 21))
            {
                zodiacSign = "virgo";
            }
            else if ((month == 9 && day >= 22) || (month == 10 && day <= 22))
            {
                zodiacSign = "libra";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                zodiacSign = "scorpio";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                zodiacSign = "sagittarius";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 20))
            {
                zodiacSign = "capricorn";
            }
            else if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
            {
                zodiacSign = "aquarius";
            }
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
            {
                zodiacSign = "pisces";
            }

            lblZodiacSign.Text = char.ToUpper(zodiacSign[0]) + zodiacSign.Substring(1);

            return zodiacSign;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            _ = getZodiacSign(dtpDOB.Value);
        }
    }

    public class Horoscope
    {
        public string date_range { get; set; }
        public string current_date { get; set; }
        public string description { get; set; }
    }
}