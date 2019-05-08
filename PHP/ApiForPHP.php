<?php
/**
 * Created
 */

class api
{
    protected $secretKey = '';

    protected $apiKey = '';

    protected $tradePwd = '';

    protected $base_url  = '';


    protected $url = '';
    public function __construct($options = null)
    {
        $this->url = $this->base_url;
        try {
            if (is_array($options))
            {
                foreach ($options as $option => $value)
                {
                    $this->$option = $value;
                }
            }
            else
            {
                return false;
            }
        }
        catch (PDOException $e) {
            throw new Exception($e->getMessage());
        }
    }


    /**
     * 获取单个牌价数据
     * @param symbol  必填 string
     * @return array
     */
    public function ticker(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/ticker?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取k线数据
     * @param symbol     必填 string
     * @param resolution 必填 string
     * @param size       选填 int
     * @param to         选填 int
     * @return array
     */
    public function kline(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/kline?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取深度数据
     * @param symbol   必填  string
     * @return array
     */
    public function depth(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/depth?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取成交单
     * @param symbol  必填  string
     * @return array
     */
    public function order(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/order?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取所有牌价数据
     * @param symbols  选填  string
     * @return array
     */
    public function tickerall(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/tickerall?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取交易对
     * @param symbols  选填  string
     * @return array
     */
    public function symbolList(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/symbolList?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取当前法币汇率信息
     * @param symbols  选填  string
     * @return array
     */
    public function currencyRate(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/currencyRate?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取虚拟货币法币汇率信息
     * @param coins  选填  string
     * @return array
     */
    public function currencyCoinRate(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/currencyCoinRate?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取币种对应汇率信息
     * @param coins  选填  string
     * @return array
     */
    public function coinRate(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Market/coinRate?'.http_build_query($sendData);
        return $this->httpRequest($url);
    }


    /**
     * 获取个人资产
     * @return array
     */
    public function getUserAssets(){
        $sendData  = $this->getData();
        $url = $this->url.'/Assets/getUserAssets';
        return $this->httpRequest($url,$sendData);
    }

    /**
     * 提交委托单
     * @param symbol   必填  eth_btc
     * @param number   必填  float
     * @param price    必填  float
     * @param type     必填  int
     * @return array
     */
    public function addEntrustSheet(array $parms)
    {
        $parms['tradePwd'] = $this->tradePwd;
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Trade/addEntrustSheet';
        return $this->httpRequest($url,$sendData);
    }


    /**
     * 撤销单个委托单
     * @param entrustSheetId  必填  string 787945820
     * @return array
     */
    public function cancelEntrustSheet(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Trade/cancelEntrustSheet';
        return $this->httpRequest($url,$sendData);
    }


    /**
     * 批量撤销委托单
     * @param ids  必填  string '787945739,787945820'
     * @return array
     */
    public function cancelAllEntrustSheet(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Trade/cancelAllEntrustSheet';
        return $this->httpRequest($url,$sendData);
    }


    /**
     * 获取委托单详情
     * @param entrustSheetId 必填  string 787945820
     * @return array
     */
    public function getEntrustSheetInfo(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Trade/getEntrustSheetInfo';
        return $this->httpRequest($url,$sendData);
    }



    /**
     * 获取当前委托单详情
     * @param pageSize   选填  int
     * @param page       选填  int
     * @param coinForm   必填  eth
     * @param coinTo     必填  btc
     * @param startTime  选填  timestamp
     * @param endTime    选填  timestamp
     * @return array
     */
    public function getUserNowEntrustSheet(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Trade/getUserNowEntrustSheet';
        return $this->httpRequest($url,$sendData);
    }


    /**
     * 获取历史委托单详情
     * @param pageSize   选填  int
     * @param page       选填  int
     * @param coinForm   必填  eth
     * @param coinTo     必填  btc
     * @param startTime  选填  timestamp
     * @param endTime    选填  timestamp
     * @return array
     */
    public function getUserHistoryEntrustSheet(array $parms){
        $sendData  = $this->getData($parms);
        $url = $this->url.'/Trade/getUserHistoryEntrustSheet';
        return $this->httpRequest($url,$sendData);
    }


    protected function getData($data = null){
        $baseArr = array(
            'timeStamp'   =>  time(),
            'nonce'		  =>  $this->getRandomString(6),
            'apiKey'      =>  $this->apiKey,
        );
        if(isset($data)){
            $sendData = array_merge($baseArr,$data);
        }else{
            $sendData = $baseArr;
        }
        $sendData['sign'] = $this->getSign($sendData);
        return $sendData;
    }

    protected function getSign($data)
    {
        ksort($data);
        $dataStr = '';
        foreach ($data as $k => $v)
        {
            $dataStr .= $k.'='.$v."&";
        }

        return md5(trim($dataStr,"&").$this->secretKey);
    }

    protected function getRandomString($len, $chars=null)
    {
        if (is_null($chars)){
            $chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        }

        for ($i = 0, $str = '', $lc = strlen($chars)-1; $i < $len; $i++){
            $str .= $chars[mt_rand(0, $lc)];
        }
        return $str;
    }

    protected function httpRequest($url,$data = null){
        $curl = curl_init();
        curl_setopt($curl, CURLOPT_URL, $url);
        curl_setopt($curl, CURLOPT_SSL_VERIFYPEER, FALSE);
        curl_setopt($curl, CURLOPT_SSL_VERIFYHOST, FALSE);
        if(!empty($data)){
            curl_setopt($curl,CURLOPT_POST,1);
            curl_setopt($curl,CURLOPT_POSTFIELDS,$data);
        }
        curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);
        $output = curl_exec($curl);
        curl_close($curl);
        return $output;
    }
}


//example

$api = new api();

$parms = array('symbol' => 'eos_btc');

print_r($api->ticker($parms));



