﻿using System;
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

            //Update the prices at the start
            updatePrices();

            //Start a timer to update the prices
            this.timer = new Timer { Interval = 10000 };
            this.timer.Tick += OnTick;
            this.timer.Start();
            label1.Text = "1";
        }

        //getters
        public String get() { return ""; }

        private void OnTick(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Start();

            //update the prices
            updatePrices();
            int updates = Int32.Parse(label1.Text);
            updates++;
            label1.Text = updates.ToString();
        }

        public void updatePrices()
        {
            for (int i = 0; i < coinsEnabled.Count; i++)
            {
                // flag so we know if there was one dupe
                bool updated = false;

                // go through every row
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // check if there already is a row with the same id
                    if (row.Cells["Coin"].Value.ToString() == coinsEnabled[i].ToString())
                    {
                        // update your row
                        row.Cells["Price"].Value = getFromAPI.Get_spotprice(this.currency, coinsEnabled[i].ToString());
                        row.Cells["Coin"].Value = coinsEnabled[i].ToString();

                        updated = true;
                        break; // no need to go any further
                    }
                }

                // if not found, so it's a new one
                if (!updated)
                {
                    int index = dataGridView1.Rows.Add();

                    dataGridView1.Rows[index].Cells["Price"].Value = getFromAPI.Get_spotprice(this.currency, coinsEnabled[i].ToString());
                    dataGridView1.Rows[index].Cells["Coin"].Value = coinsEnabled[i].ToString();
                }
            }
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
        }
    }
}
