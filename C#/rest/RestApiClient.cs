using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ExchangeRestApiDemo.utils;
namespace ApiClient.rest
{
    class RestApiClient
    {
        /**
         * ------------------------------------------------------------------
         * @param apiKey        必须
         * @param secretKey     必须
         * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
         * ------------------------------------------------------------------
         */
        private String apiKey;
        private String secretKey;
        private String tradePwd;
        //
        private String WEB_BASE = ""; //

        //
        /**
         * ------------------------------------------------------------------
         * @param apiKey        必须
         * @param secretKey     必须
         * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
         * ------------------------------------------------------------------
         */
        public RestApiClient(String api_key, String secret_key)
        {
            this.apiKey = api_key;
            this.secretKey = secret_key;
            this.tradePwd = "";
        }
        public RestApiClient(String api_key, String secret_key, String tradePwd)
        {
            this.apiKey = api_key;
            this.secretKey = secret_key;
            this.tradePwd = tradePwd;
        }
        public void setServerUrl(String apiUrl)
        {
            this.WEB_BASE = apiUrl;
        }
        public void resetConfig(String api_key, String secret_key, String tradePwd)
        {
            this.apiKey = api_key;
            this.secretKey = secret_key;
            this.tradePwd = tradePwd;
        }
        private String market_api(String path, Dictionary<String, String> paras)
        {
            String result = "";
            String strparas = SignUtil.createLinkString(paras);
            try
            {
                if (this.WEB_BASE.Equals(""))
                {
                    return "";
                }
                result = HttpUtilManager.getInstance().requestHttpGet(this.WEB_BASE, path, strparas);
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
        private String sign_api(String path, Dictionary<String, String> paras)
        {
            String result = "";
            //
            String timeStamp = GetTimeStamp();
            paras.Add("apiKey", this.apiKey);
            paras.Add("timeStamp", timeStamp);
            paras.Add("nonce", timeStamp.Substring(0, 6));
            String sign = SignUtil.buildSign(paras, this.secretKey);
            paras.Add("sign", sign);
            //
            try
            {
                result = HttpUtilManager.getInstance().requestHttpPost(this.WEB_BASE, path, paras);
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        //-------------------交易接口-----------------------------------------
        /**
         * ------------------------------------------------------------------
         * 个人资产 (Get user open orders)
         * ------------------------------------------------------------------
         */
        public String getUserAssets()
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            return this.sign_api("/Assets/getUserAssets",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 获取个人当前委托单列表 (Get user open orders)
         * @parame coinFrom	eth
         * @parame coinTo	btc
         * @parame type		integer	1:买,2:卖
         * ------------------------------------------------------------------
         */
        public String getUserNowEntrustSheet(String coinFrom, String coinTo)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            paras.Add("coinFrom", coinFrom);
            paras.Add("coinTo", coinTo);
            return this.sign_api("/Trade/getUserNowEntrustSheet",paras);
        }
        public String getUserNowEntrustSheet(String coinFrom, String coinTo, String type)
        {
            Dictionary<String, String> paras = new Dictionary<String, String>();
            paras.Add("coinFrom", coinFrom);
            paras.Add("coinTo", coinTo);
            paras.Add("type", type);
            return this.sign_api("/Trade/getUserNowEntrustSheet", paras);
        }
        public String getUserNowEntrustSheet(String coinFrom, String coinTo, String type, String page, String pageSize)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            paras.Add("coinFrom", coinFrom);
            paras.Add("coinTo", coinTo);
            paras.Add("type", type);
            paras.Add("page", page);
            paras.Add("pageSize", pageSize);
            return this.sign_api("/Trade/getUserNowEntrustSheet",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 获取个人历史委托单列表 (Get user history entrust)
         * ------------------------------------------------------------------
         */
        public String getUserHistoryEntrustSheet(String coinFrom, String coinTo)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            paras.Add("coinFrom", coinFrom);
            paras.Add("coinTo", coinTo);
            paras.Add("startTime", "1532857729");
            //paras.Add("type", type);
            return this.sign_api("/Trade/getUserHistoryEntrustSheet",paras);
        }
        public String getUserHistoryEntrustSheet(String coinFrom, String coinTo, String type, String page, String pageSize)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
        paras.Add("coinFrom", coinFrom);
        paras.Add("coinTo", coinTo);
        paras.Add("type", type);
        paras.Add("page", page);
        paras.Add("pageSize", pageSize);
            paras.Add("startTime", "1532857729");
            return this.sign_api("/Trade/getUserHistoryEntrustSheet",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 提交委托单 (Place an order)
         * @param symbol        string "eth_btc"
         * @param number        float
         * @param price         float
         * @param type          string  "1":"buy"   "2":"sale"
         * ------------------------------------------------------------------
         */
        public String addEntrustSheet(String symbol, String number, String price, String type)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
        paras.Add("symbol", symbol);
        paras.Add("number", number);
        paras.Add("price", price);
        paras.Add("type", type);
        paras.Add("tradePwd", this.tradePwd); // 委托单 必须 传递 tradePwd 交易密码
            return this.sign_api("/Trade/addEntrustSheet",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 提交委托单详情 (Get the detail of an order)
         * @param entrustSheetId    string
         * ------------------------------------------------------------------
         */
        public String getEntrustSheetInfo(String entrustSheetId)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
        paras.Add("entrustSheetId", entrustSheetId);
            return this.sign_api("/Trade/getEntrustSheetInfo",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 撤销委托单 (Cancel the order)
         * @param entrustSheetId    string
         * ------------------------------------------------------------------
         */
        public String cancelEntrustSheet(String entrustSheetId)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
        paras.Add("entrustSheetId", entrustSheetId);
            return this.sign_api("/Trade/cancelEntrustSheet",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 批量撤销委托单 (cancel the all entrust)
         * @param ids    string     "id1,id2,id3"
         * ------------------------------------------------------------------
         */
        public String cancelAllEntrustSheet(String entrustSheetIds)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
        paras.Add("ids", entrustSheetIds);
            return this.sign_api("/Trade/cancelAllEntrustSheet",paras);
        }

        //-------------------行情接口-----------------------------------------
        /**
         * ------------------------------------------------------------------
         * 获取牌价数据 (Get the price data)
         * @param symbol    eth_btc
         * ------------------------------------------------------------------
         */
        public String ticker(String symbol)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
        paras.Add("symbol", symbol);
            return this.market_api("/Market/ticker",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 获取所有牌价数据 (Get the price of all symbol)
         * ------------------------------------------------------------------
         */
        public String tickerall()
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            return this.market_api("/Market/tickerall",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 获取最新交易记录 (Get the last orders)
         * @param symbol    eth_btc
         * ------------------------------------------------------------------
         */
        public String orders(String symbol)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            paras.Add("symbol", symbol);
            return this.market_api("/Market/order",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 获取深度数据 (Get depth data)
         * @param symbol    eth_btc
         * ------------------------------------------------------------------
         */
        public String depth(String symbol)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            paras.Add("symbol", symbol);
            return this.market_api("/Market/depth",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 获取深度数据 (Get depth data)
         * @param symbol        string eth_btc
         * @param resolution    string [1min 、5min 、15min 、30min 、60min、 4hour 、 1day 、5day 、1week、 1mon]
         * @param size          number 1 ~ 300 (can empty)
         * ------------------------------------------------------------------
         */
        public String kline(String symbol, String resolution)
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            paras.Add("symbol", symbol);
            paras.Add("resolution", resolution);
            return this.market_api("/Market/kline",paras);
        }
        public String kline(String symbol, String resolution, int size)
        {
            // 构造参数签名
            Dictionary< String, String > paras = new Dictionary<String, String>();
            paras.Add("symbol", symbol);
            paras.Add("resolution", resolution);
            paras.Add("size", size.ToString());
            return this.market_api("/Market/kline",paras);
        }
        /**
         * ------------------------------------------------------------------
         * 获取所有交易对的详细信息 (Get the detail of erery symbol)
         * ------------------------------------------------------------------
         */
        public String symbolList()
        {
            Dictionary< String, String > paras = new Dictionary<String, String>();
            return this.market_api("/Market/symbolList",paras);
        }

        /**
         * ------------------------------------------------------------------
         * 同时获取
         * @param symbol        string eth_btc
         * ------------------------------------------------------------------
         */
        public String marketList(String symbol)
        {
            Dictionary<String, String> paras = new Dictionary<String, String>();
            paras.Add("symbol", symbol);
            return this.market_api("/Market/marketList", paras);
        }


    }
}
