namespace CoinBaseClient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Coin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Wallet = new System.Windows.Forms.TabPage();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.BSaveSettings = new System.Windows.Forms.Button();
            this.TSelectCoins = new System.Windows.Forms.TextBox();
            this.LTitleChooseCoins = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TradeCoinsPage.SuspendLayout();
            this.PricesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Wallet.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.PricesPage.Controls.Add(this.dataGridView1);
            this.PricesPage.Controls.Add(this.label1);
            this.PricesPage.Location = new System.Drawing.Point(4, 22);
            this.PricesPage.Name = "PricesPage";
            this.PricesPage.Padding = new System.Windows.Forms.Padding(3);
            this.PricesPage.Size = new System.Drawing.Size(795, 422);
            this.PricesPage.TabIndex = 2;
            this.PricesPage.Text = "Prices";
            this.PricesPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coin,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 399);
            this.dataGridView1.TabIndex = 4;
            // 
            // Coin
            // 
            this.Coin.DataPropertyName = "Coin";
            this.Coin.HeaderText = "Coin";
            this.Coin.Name = "Coin";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
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
            this.Wallet.Controls.Add(this.dataGridView2);
            this.Wallet.Controls.Add(this.label2);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 399);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Coin";
            this.dataGridViewTextBoxColumn1.HeaderText = "Coin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Wallet.ResumeLayout(false);
            this.Wallet.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSaveSettings;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
    }
}

