using System;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;

namespace CoinBaseClient
{
    public partial class Form1 : Form
    {

        private GetFromAPI getFromAPI;
        private Timer timer;
        private ArrayList coinsEnabled;
        private string currency;

        public Form1()
        {
            //Security Protocol Tls12 is needed for the Coinbase API Library
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //Initia the basic
            InitializeComponent();
            this.getFromAPI = new GetFromAPI();
            this.currency = "EUR";
            this.coinsEnabled = new ArrayList() { "BTC" };
            TSelectCoins.Text = "BTC";

            //Use below for debugging
            //client.EnableFiddlerDebugProxy("http://localhost.:8888");

            //Update the data at the start
            updatePrices();
            updateWallet();

            //Start a timer to update the prices
            this.timer = new Timer { Interval = 10000 };
            this.timer.Tick += OnTick;
            this.timer.Start();
        }

        //getters
        public String get() { return ""; }

        private void OnTick(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Start();

            //update the prices
            updatePrices();
            updateWallet();
        }

        public void updatePrices()
        {
            for (int i = 0; i < coinsEnabled.Count; i++)
            {
                // flag so we know if there was one dupe
                bool updated = false;

                //Create variables to save API calls
                var coin = coinsEnabled[i].ToString();
                var price = getFromAPI.Get_spotprice(this.currency, coin);

                // go through every row
                foreach (DataGridViewRow row in dataGridViewerPrices.Rows)
                {
                    // check if there already is a row with the same id
                    if (row.Cells["PCoin"].Value.ToString() == coin)
                    {
                        // update your row
                        row.Cells["PPrice"].Value = price;
                        row.Cells["PCoin"].Value = coin;

                        updated = true;
                        break; // no need to go any further
                    }
                }

                // if not found, so it's a new one
                if (!updated)
                {
                    int index = dataGridViewerPrices.Rows.Add();

                    dataGridViewerPrices.Rows[index].Cells["PPrice"].Value = price;
                    dataGridViewerPrices.Rows[index].Cells["PCoin"].Value = coin;
                }
            }
            //Update the label time
            var time = DateTime.Now.ToString("HH:mm:ss");
            LLastUpdatePrices.Text = $"Last update: {time}";
        }

        public void updateWallet()
        {
            for (int i = 0; i < coinsEnabled.Count; i++)
            {
                // flag so we know if there was one dupe
                bool updated = false;

                //Create variables to save API calls
                var amount = getFromAPI.Get_CoinsFromWallet(coinsEnabled[i].ToString());
                var coin = coinsEnabled[i].ToString();
                float amountI = float.Parse(amount);
                float price = float.Parse(getFromAPI.Get_spotprice(this.currency, coin));

                //Calculate worth of coin in account
                var calc = (price * amountI).ToString("n2");

                // go through every row
                foreach (DataGridViewRow row in dataGridViewWallet.Rows)
                {
                    // check if there already is a row with the same id
                    if (row.Cells["WCoin"].Value.ToString() == coin)
                    {
                        // update your row
                        row.Cells["WPrice"].Value = calc;
                        row.Cells["WCoin"].Value = coin;
                        row.Cells["WAmount"].Value = amount;

                        updated = true;
                        break; // no need to go any further
                    }
                }

                // if not found, so it's a new one
                if (!updated)
                {
                    int index = dataGridViewWallet.Rows.Add();

                    dataGridViewWallet.Rows[index].Cells["WPrice"].Value = calc;
                    dataGridViewWallet.Rows[index].Cells["WCoin"].Value = coin;
                    dataGridViewWallet.Rows[index].Cells["WAmount"].Value = amount;
                }
            }
            //Update the label time
            var time = DateTime.Now.ToString("HH:mm:ss");
            LLastUpdateWallet.Text = $"Last update: {time}";
        }

        private void BSaveSettings_Click(object sender, EventArgs e)
        {
            this.coinsEnabled.Clear();
            var coinEnabledPiece = TSelectCoins.Text.Split(';');
            for (int i = 0; i < coinEnabledPiece.Length; i++)
            {
                if (coinEnabledPiece[i] != "")
                {
                    // TODO: trim for spaces and check if exist
                    this.coinsEnabled.Add(coinEnabledPiece[i]);
                }
            }
            updatePrices();
            updateWallet();
        }
    }
}
