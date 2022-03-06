using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotacaoDolarHG
{
    public partial class FrmCotacaoDolar : Form
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void FrmCotacaoDolar_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strUrl = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=9f04b821";

            using(HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(strUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    Market market = JsonConvert.DeserializeObject<Market>(result);

                    lblBay.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"),"{0:C}", market.Currency.Buy);
                    lblSell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                    lblVariation.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);
                }
            }
        }
    }
}
