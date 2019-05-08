# NODE DEMO 

## 安装依赖

```
	npm install 

	node test.js help

```

## 使用方法

```
	const _API = require('./api');
	/**
	 * @param apiServer     必须
	 * @param apiKey        必须
	 * @param secretKey     必须
	 * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
	 */
	var apiServer   = '';
	var apiKey 		= '';
	var secretKey 	= '';
	var tradePwd 	= '';
	_API.setConfig( apiServer, apiKey, secretKey, tradePwd );

	// 获取资产
	_API.getUserAssets().then(function(data){
		console.log(data);
	}).catch(function(err){
		console.log(err);
	});

	// 获取所有牌价数据
	_API.tickerall().then(function(data){
		console.log(data);
	}).catch(function(err){
		console.log(err);
	});

```

