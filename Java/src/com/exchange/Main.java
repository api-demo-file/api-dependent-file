package com.exchange;

import com.exchange.restapi.ApiRestClient;
import com.exchange.utils.SignUtil;

public class Main {
    public static void main(String[] args) {
        /**
         * ------------------------------------------------------------------
         * @param apiServer     必须
         * @param apiKey        必须
         * @param secretKey     必须
         * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
         * ------------------------------------------------------------------
         */
        String apiServer    = "";
        String apiKey 		= "";
        String secretKey 	= "";
        String tradePwd 	= ""; // 委托单 必须 传递 tradePwd 交易密码
	    // write your code here
        ApiRestClient restClient = new ApiRestClient(apiServer,apiKey,secretKey,tradePwd);

        //
        String tmp = "";

//         getUserAssets
         // tmp  = restClient.getUserAssets();

        // getUserNowEntrustSheet
        // tmp = restClient.getUserNowEntrustSheet("bz","usdt","2","1","5");

        // getUserHistoryEntrustSheet
        // tmp = restClient.getUserHistoryEntrustSheet("bz","usdt","1","1","5");

        // addEntrustSheet
        // tmp = restClient.addEntrustSheet("eth_btc","1","1.0","2");

        // getEntrustSheetInfo
        // tmp = restClient.getEntrustSheetInfo("657055834");

        // cancelEntrustSheet
        // tmp = restClient.cancelEntrustSheet("657055834");

        // cancelAllEntrustSheet
//        tmp = restClient.cancelAllEntrustSheet("1,2,3,5");

        // ticker
        // tmp = restClient.ticker("eth_btc");

        // tickerall
        //tmp = restClient.tickerall();

        // kline
//         tmp = restClient.kline("eth_btc","5min");

        // symbolList
        tmp = restClient.symbolList();

        System.out.print(tmp);


    }
}
