namespace ExchangeRestApiDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.entrustSheetInfo = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApiServer = new System.Windows.Forms.TextBox();
            this.orderId = new System.Windows.Forms.TextBox();
            this.getUserAssets = new System.Windows.Forms.Button();
            this.historyEntrust = new System.Windows.Forms.Button();
            this.nowEntrust = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.coinFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coinTo = new System.Windows.Forms.TextBox();
            this.resolution = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.txtTradePwd = new System.Windows.Forms.TextBox();
            this.saveKey = new System.Windows.Forms.Button();
            this.tickerall = new System.Windows.Forms.Button();
            this.ticker = new System.Windows.Forms.Button();
            this.kline = new System.Windows.Forms.Button();
            this.depth = new System.Windows.Forms.Button();
            this.symbolList = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.marketList = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addEntrustSheet = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entrustSheetInfo
            // 
            resources.ApplyResources(this.entrustSheetInfo, "entrustSheetInfo");
            this.entrustSheetInfo.Name = "entrustSheetInfo";
            this.entrustSheetInfo.UseVisualStyleBackColor = true;
            this.entrustSheetInfo.Click += new System.EventHandler(this.entrustSheetInfo_Click);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label2);
            this.flowLayoutPanel6.Controls.Add(this.txtApiServer);
            this.flowLayoutPanel6.Controls.Add(this.label3);
            this.flowLayoutPanel6.Controls.Add(this.orderId);
            resources.ApplyResources(this.flowLayoutPanel6, "flowLayoutPanel6");
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtApiServer
            // 
            resources.ApplyResources(this.txtApiServer, "txtApiServer");
            this.txtApiServer.Name = "txtApiServer";
            // 
            // orderId
            // 
            resources.ApplyResources(this.orderId, "orderId");
            this.orderId.Name = "orderId";
            // 
            // getUserAssets
            // 
            resources.ApplyResources(this.getUserAssets, "getUserAssets");
            this.getUserAssets.Name = "getUserAssets";
            this.getUserAssets.UseVisualStyleBackColor = true;
            this.getUserAssets.Click += new System.EventHandler(this.getUserAssets_Click);
            // 
            // historyEntrust
            // 
            resources.ApplyResources(this.historyEntrust, "historyEntrust");
            this.historyEntrust.Name = "historyEntrust";
            this.historyEntrust.UseVisualStyleBackColor = true;
            this.historyEntrust.Click += new System.EventHandler(this.button1_Click);
            // 
            // nowEntrust
            // 
            resources.ApplyResources(this.nowEntrust, "nowEntrust");
            this.nowEntrust.Name = "nowEntrust";
            this.nowEntrust.UseVisualStyleBackColor = true;
            this.nowEntrust.Click += new System.EventHandler(this.nowEntrust_Click);
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Controls.Add(this.coinFrom);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.coinTo);
            this.flowLayoutPanel4.Controls.Add(this.resolution);
            this.flowLayoutPanel4.Controls.Add(this.comboBox1);
            this.flowLayoutPanel4.Controls.Add(this.txtApiKey);
            this.flowLayoutPanel4.Controls.Add(this.txtSecretKey);
            this.flowLayoutPanel4.Controls.Add(this.txtTradePwd);
            this.flowLayoutPanel4.Controls.Add(this.saveKey);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // coinFrom
            // 
            resources.ApplyResources(this.coinFrom, "coinFrom");
            this.coinFrom.Name = "coinFrom";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // coinTo
            // 
            resources.ApplyResources(this.coinTo, "coinTo");
            this.coinTo.Name = "coinTo";
            // 
            // resolution
            // 
            resources.ApplyResources(this.resolution, "resolution");
            this.resolution.Name = "resolution";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // txtApiKey
            // 
            resources.ApplyResources(this.txtApiKey, "txtApiKey");
            this.txtApiKey.Name = "txtApiKey";
            // 
            // txtSecretKey
            // 
            resources.ApplyResources(this.txtSecretKey, "txtSecretKey");
            this.txtSecretKey.Name = "txtSecretKey";
            // 
            // txtTradePwd
            // 
            resources.ApplyResources(this.txtTradePwd, "txtTradePwd");
            this.txtTradePwd.Name = "txtTradePwd";
            // 
            // saveKey
            // 
            resources.ApplyResources(this.saveKey, "saveKey");
            this.saveKey.Name = "saveKey";
            this.saveKey.UseVisualStyleBackColor = true;
            this.saveKey.Click += new System.EventHandler(this.saveKey_Click_1);
            // 
            // tickerall
            // 
            resources.ApplyResources(this.tickerall, "tickerall");
            this.tickerall.Name = "tickerall";
            this.tickerall.Click += new System.EventHandler(this.tickerall_Click);
            // 
            // ticker
            // 
            resources.ApplyResources(this.ticker, "ticker");
            this.ticker.Name = "ticker";
            this.ticker.UseVisualStyleBackColor = true;
            this.ticker.Click += new System.EventHandler(this.ticker_Click);
            // 
            // kline
            // 
            resources.ApplyResources(this.kline, "kline");
            this.kline.Name = "kline";
            this.kline.UseVisualStyleBackColor = true;
            this.kline.Click += new System.EventHandler(this.kline_Click);
            // 
            // depth
            // 
            resources.ApplyResources(this.depth, "depth");
            this.depth.Name = "depth";
            this.depth.UseVisualStyleBackColor = true;
            this.depth.Click += new System.EventHandler(this.depth_Click);
            // 
            // symbolList
            // 
            resources.ApplyResources(this.symbolList, "symbolList");
            this.symbolList.Name = "symbolList";
            this.symbolList.UseVisualStyleBackColor = true;
            this.symbolList.Click += new System.EventHandler(this.symbolList_Click);
            // 
            // orders
            // 
            resources.ApplyResources(this.orders, "orders");
            this.orders.Name = "orders";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // marketList
            // 
            resources.ApplyResources(this.marketList, "marketList");
            this.marketList.Name = "marketList";
            this.marketList.UseVisualStyleBackColor = true;
            this.marketList.Click += new System.EventHandler(this.marketList_Click);
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.tickerall);
            this.flowLayoutPanel2.Controls.Add(this.ticker);
            this.flowLayoutPanel2.Controls.Add(this.kline);
            this.flowLayoutPanel2.Controls.Add(this.depth);
            this.flowLayoutPanel2.Controls.Add(this.symbolList);
            this.flowLayoutPanel2.Controls.Add(this.orders);
            this.flowLayoutPanel2.Controls.Add(this.marketList);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.getUserAssets);
            this.flowLayoutPanel2.Controls.Add(this.historyEntrust);
            this.flowLayoutPanel2.Controls.Add(this.nowEntrust);
            this.flowLayoutPanel2.Controls.Add(this.addEntrustSheet);
            this.flowLayoutPanel2.Controls.Add(this.entrustSheetInfo);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // addEntrustSheet
            // 
            resources.ApplyResources(this.addEntrustSheet, "addEntrustSheet");
            this.addEntrustSheet.Name = "addEntrustSheet";
            this.addEntrustSheet.UseVisualStyleBackColor = true;
            this.addEntrustSheet.Click += new System.EventHandler(this.addEntrustSheet_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.txtConsole, "txtConsole");
            this.txtConsole.Name = "txtConsole";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.txtConsole);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button entrustSheetInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApiServer;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.Button getUserAssets;
        private System.Windows.Forms.Button historyEntrust;
        private System.Windows.Forms.Button nowEntrust;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox coinFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coinTo;
        private System.Windows.Forms.Label resolution;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.TextBox txtTradePwd;
        private System.Windows.Forms.Button saveKey;
        private System.Windows.Forms.Button tickerall;
        private System.Windows.Forms.Button ticker;
        private System.Windows.Forms.Button kline;
        private System.Windows.Forms.Button depth;
        private System.Windows.Forms.Button symbolList;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Button marketList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button addEntrustSheet;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
    }
}

