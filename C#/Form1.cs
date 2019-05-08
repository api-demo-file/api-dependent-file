using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ExchangeRestApiDemo.utils;
using ApiClient.rest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ExchangeRestApiDemo
{
    public partial class Form1 : Form
    {
        RestApiClient restClient;
        /**
         * ------------------------------------------------------------------
         * @param apiServer     必须
         * @param apiKey        必须
         * @param secretKey     必须
         * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
         * ------------------------------------------------------------------
         */
        String apiServer = "";
        String apiKey = "";
        String secretKey = "";
        String tradePwd = ""; // 需要下单交易时必须传

        String inifile;
        iniOperate ini;

        public object ConfigurationUserLevel { get; }

        public Form1()
        {
            InitializeComponent();

            this.inifile = System.Windows.Forms.Application.StartupPath + "\\keys.ini";
            Console.WriteLine(inifile);
            this.ini = new iniOperate();

            this.apiServer = ini.ReadIniData("keys", "apiServer", "", inifile);
            this.apiKey = ini.ReadIniData("keys", "apiKey", "", inifile);
            this.secretKey = ini.ReadIniData("keys", "secretKey", "", inifile);
            this.tradePwd = ini.ReadIniData("keys", "tradePwd", "", inifile);

            this.txtApiServer.Text = this.apiServer;
            this.txtApiKey.Text = this.apiKey;
            this.txtSecretKey.Text = this.secretKey;
            this.txtTradePwd.Text = this.tradePwd;

            //
            this.restClient = new RestApiClient(this.apiKey, this.secretKey, this.tradePwd);
            if (this.txtApiServer.Text.Equals(""))
            {
                MessageBox.Show("Api Server Url Empty. Please setting first!");
            }
            
            this.restClient.setServerUrl(this.txtApiServer.Text);
            
        }

        private bool checkConfig()
        {
            string pattern = "(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]";

            if (!StringUtil.IsMatch(pattern, this.apiServer))
            {
                MessageBox.Show("Api Server Url Empty. Please setting first!");
                return false;
            }
            return true;
        }

        private void tickerall_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String data = this.restClient.tickerall();
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }


        private void ticker_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String data = this.restClient.ticker(symbol);
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void kline_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String ktype = comboBox1.Text;
            String data = this.restClient.kline(symbol, ktype);
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void symbolList_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String data = this.restClient.symbolList();
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void getUserAssets_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String data = this.restClient.getUserAssets();
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String cFrom = coinFrom.Text;
            String cTo = coinTo.Text;
            String data = this.restClient.getUserHistoryEntrustSheet(cFrom, cTo, "2", "1", "15");
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void addEntrustSheet_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String data = this.restClient.addEntrustSheet(symbol, "10", "1.0", "2");
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void nowEntrust_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String cFrom = coinFrom.Text;
            String cTo = coinTo.Text;
            String data = this.restClient.getUserNowEntrustSheet(cFrom, cTo, "1");
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }

        private void depth_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String data = this.restClient.depth(symbol);
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String data = this.restClient.orders(symbol);
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void entrustSheetInfo_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String entrustSheetId = this.orderId.Text;
            String data = this.restClient.getEntrustSheetInfo(entrustSheetId);
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }

        private void marketList_Click(object sender, EventArgs e)
        {
            if (this.checkConfig() == false) return;
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String data = this.restClient.marketList(symbol);
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
       
        private void saveKey_Click_1(object sender, EventArgs e)
        {
            this.apiServer= this.txtApiServer.Text;
            this.apiKey = this.txtApiKey.Text;
            this.secretKey = this.txtSecretKey.Text;
            this.tradePwd = this.txtTradePwd.Text;
            //
            ini.WriteIniData("keys", "apiServer", this.txtApiServer.Text, inifile);
            ini.WriteIniData("keys", "apiKey", this.txtApiKey.Text, inifile);
            ini.WriteIniData("keys", "secretKey", this.txtSecretKey.Text, inifile);
            ini.WriteIniData("keys", "tradePwd", this.txtTradePwd.Text, inifile);
            //
            this.restClient.resetConfig(this.apiKey, this.secretKey, this.tradePwd);
            this.restClient.setServerUrl(this.apiServer);
        }

    }
}
