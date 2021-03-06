﻿namespace CoinBaseClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TradeCoinsPage = new System.Windows.Forms.TabControl();
            this.PricesPage = new System.Windows.Forms.TabPage();
            this.dataGridViewerPrices = new System.Windows.Forms.DataGridView();
            this.LLastUpdatePrices = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Wallet = new System.Windows.Forms.TabPage();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.BSaveSettings = new System.Windows.Forms.Button();
            this.TSelectCoins = new System.Windows.Forms.TextBox();
            this.LTitleChooseCoins = new System.Windows.Forms.Label();
            this.dataGridViewWallet = new System.Windows.Forms.DataGridView();
            this.LLastUpdateWallet = new System.Windows.Forms.Label();
            this.PCoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WCoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeCoinsPage.SuspendLayout();
            this.PricesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewerPrices)).BeginInit();
            this.Wallet.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // TradeCoinsPage
            // 
            this.TradeCoinsPage.Controls.Add(this.PricesPage);
            this.TradeCoinsPage.Controls.Add(this.tabPage3);
            this.TradeCoinsPage.Controls.Add(this.Wallet);
            this.TradeCoinsPage.Controls.Add(this.SettingsPage);
            this.TradeCoinsPage.Location = new System.Drawing.Point(0, 2);
            this.TradeCoinsPage.Name = "TradeCoinsPage";
            this.TradeCoinsPage.SelectedIndex = 0;
            this.TradeCoinsPage.Size = new System.Drawing.Size(803, 448);
            this.TradeCoinsPage.TabIndex = 1;
            // 
            // PricesPage
            // 
            this.PricesPage.Controls.Add(this.dataGridViewerPrices);
            this.PricesPage.Controls.Add(this.LLastUpdatePrices);
            this.PricesPage.Location = new System.Drawing.Point(4, 22);
            this.PricesPage.Name = "PricesPage";
            this.PricesPage.Padding = new System.Windows.Forms.Padding(3);
            this.PricesPage.Size = new System.Drawing.Size(795, 422);
            this.PricesPage.TabIndex = 2;
            this.PricesPage.Text = "Prices";
            this.PricesPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewerPrices
            // 
            this.dataGridViewerPrices.AllowUserToAddRows = false;
            this.dataGridViewerPrices.AllowUserToDeleteRows = false;
            this.dataGridViewerPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewerPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCoin,
            this.PPrice});
            this.dataGridViewerPrices.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewerPrices.Name = "dataGridViewerPrices";
            this.dataGridViewerPrices.Size = new System.Drawing.Size(240, 399);
            this.dataGridViewerPrices.TabIndex = 4;
            // 
            // LLastUpdatePrices
            // 
            this.LLastUpdatePrices.AutoSize = true;
            this.LLastUpdatePrices.Location = new System.Drawing.Point(0, 402);
            this.LLastUpdatePrices.Name = "LLastUpdatePrices";
            this.LLastUpdatePrices.Size = new System.Drawing.Size(66, 13);
            this.LLastUpdatePrices.TabIndex = 3;
            this.LLastUpdatePrices.Text = "Last update:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(795, 422);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Trade Coins";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Wallet
            // 
            this.Wallet.Controls.Add(this.dataGridViewWallet);
            this.Wallet.Controls.Add(this.LLastUpdateWallet);
            this.Wallet.Location = new System.Drawing.Point(4, 22);
            this.Wallet.Name = "Wallet";
            this.Wallet.Size = new System.Drawing.Size(795, 422);
            this.Wallet.TabIndex = 5;
            this.Wallet.Text = "Wallet";
            this.Wallet.UseVisualStyleBackColor = true;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.BSaveSettings);
            this.SettingsPage.Controls.Add(this.TSelectCoins);
            this.SettingsPage.Controls.Add(this.LTitleChooseCoins);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(795, 422);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // BSaveSettings
            // 
            this.BSaveSettings.Location = new System.Drawing.Point(12, 226);
            this.BSaveSettings.Name = "BSaveSettings";
            this.BSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.BSaveSettings.TabIndex = 2;
            this.BSaveSettings.Text = "Save";
            this.BSaveSettings.UseVisualStyleBackColor = true;
            this.BSaveSettings.Click += new System.EventHandler(this.BSaveSettings_Click);
            // 
            // TSelectCoins
            // 
            this.TSelectCoins.Location = new System.Drawing.Point(9, 21);
            this.TSelectCoins.Name = "TSelectCoins";
            this.TSelectCoins.Size = new System.Drawing.Size(263, 20);
            this.TSelectCoins.TabIndex = 1;
            // 
            // LTitleChooseCoins
            // 
            this.LTitleChooseCoins.AutoSize = true;
            this.LTitleChooseCoins.Location = new System.Drawing.Point(9, 4);
            this.LTitleChooseCoins.Name = "LTitleChooseCoins";
            this.LTitleChooseCoins.Size = new System.Drawing.Size(263, 13);
            this.LTitleChooseCoins.TabIndex = 0;
            this.LTitleChooseCoins.Text = "Fill the coins to follow below (seperate with semicolon):";
            // 
            // dataGridViewWallet
            // 
            this.dataGridViewWallet.AllowUserToAddRows = false;
            this.dataGridViewWallet.AllowUserToDeleteRows = false;
            this.dataGridViewWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WCoin,
            this.WPrice,
            this.WAmount});
            this.dataGridViewWallet.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWallet.Name = "dataGridViewWallet";
            this.dataGridViewWallet.Size = new System.Drawing.Size(240, 399);
            this.dataGridViewWallet.TabIndex = 6;
            // 
            // LLastUpdateWallet
            // 
            this.LLastUpdateWallet.AutoSize = true;
            this.LLastUpdateWallet.Location = new System.Drawing.Point(0, 402);
            this.LLastUpdateWallet.Name = "LLastUpdateWallet";
            this.LLastUpdateWallet.Size = new System.Drawing.Size(66, 13);
            this.LLastUpdateWallet.TabIndex = 5;
            this.LLastUpdateWallet.Text = "Last update:";
            // 
            // PCoin
            // 
            this.PCoin.DataPropertyName = "Coin";
            this.PCoin.HeaderText = "Coin";
            this.PCoin.Name = "PCoin";
            this.PCoin.ReadOnly = true;
            // 
            // PPrice
            // 
            this.PPrice.DataPropertyName = "Price";
            this.PPrice.HeaderText = "Price";
            this.PPrice.Name = "PPrice";
            this.PPrice.ReadOnly = true;
            // 
            // WCoin
            // 
            this.WCoin.DataPropertyName = "Coin";
            this.WCoin.HeaderText = "Coin";
            this.WCoin.Name = "WCoin";
            this.WCoin.ReadOnly = true;
            this.WCoin.Width = 45;
            // 
            // WPrice
            // 
            this.WPrice.DataPropertyName = "Price";
            this.WPrice.HeaderText = "Price";
            this.WPrice.Name = "WPrice";
            this.WPrice.ReadOnly = true;
            this.WPrice.Width = 60;
            // 
            // WAmount
            // 
            this.WAmount.DataPropertyName = "Amount";
            this.WAmount.HeaderText = "Amount";
            this.WAmount.Name = "WAmount";
            this.WAmount.ReadOnly = true;
            this.WAmount.Width = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TradeCoinsPage);
            this.Name = "Form1";
            this.Text = "Coinbase Client";
            this.TradeCoinsPage.ResumeLayout(false);
            this.PricesPage.ResumeLayout(false);
            this.PricesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewerPrices)).EndInit();
            this.Wallet.ResumeLayout(false);
            this.Wallet.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWallet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TradeCoinsPage;
        private System.Windows.Forms.TabPage PricesPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Label LTitleChooseCoins;
        private System.Windows.Forms.TextBox TSelectCoins;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage Wallet;
        private System.Windows.Forms.Label LLastUpdatePrices;
        private System.Windows.Forms.Button BSaveSettings;
        private System.Windows.Forms.DataGridView dataGridViewerPrices;
        private System.Windows.Forms.DataGridView dataGridViewWallet;
        private System.Windows.Forms.Label LLastUpdateWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn WCoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn WPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAmount;
    }
}

