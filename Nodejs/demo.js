
const _API = require('./exchange_api');

/**
 * ------------------------------------------------------------------
 * @param apiServer     必须
 * @param apiKey        必须
 * @param secretKey     必须
 * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
 * ------------------------------------------------------------------
 */
var apiServer   = 'https://';
var apiKey 		= '02ef8ea69846ef4e83e5f1525d9e8f28';
var secretKey 	= 'SxvCd2J6fM6UeGAx6ueOeKDXayCbgGAPvb4f8pmZULtek1dEsR6aaB3HYoQekizm';
var tradePwd 	= '';
_API.setConfig( apiServer, apiKey, secretKey, tradePwd );



// ------------------------------------------------

var demo_cmd = `
	// 行情接口
	# node demo.js tickerall
	# node demo.js ticker \\\'bz_usdt\\\'
	# node demo.js orders \\\'bz_usdt\\\'
	# node demo.js depth \\\'bz_usdt\\\'
	# node demo.js kline \\\'bz_usdt\\\',\\\'5min\\\',20
	# node demo.js symbolList
	
	// 资产
	#	node demo.js getUserAssets
	// 卖单
	#	node demo.js addEntrustSheet \\\'bz_usdt\\\',1,5,\'2\'
	// 买单
	#	node demo.js addEntrustSheet \\\'bz_usdt\\\',1,5,\'1\'
	// 订单详细
	#	node demo.js getEntrustSheetInfo \\\'orderid\\\'
	// 取消订单
	#	node demo.js cancelEntrustSheet \\\'orderid\\\'
	// 批量撤销订单
	#   node demo.js cancelAllEntrustSheet \\\'654997428,654928641\\\'	
	//
	# node demo.js getUserHistoryEntrustSheet \\\'bz\\\',\\\'usdt\\\',\\\'2\\\',1,5
	# node demo.js getUserNowEntrustSheet \\\'bz\\\',\\\'usdt\\\',\\\'2\\\',1,5
`;

function commandParser(){

	var argv = process.argv.splice(2);
	var func = argv[0];
	var params = argv.splice(1);
	var str_params = '';
	if( typeof(_API[func]) == 'function' ){
		if(params.length>0){
			str_params = params[0];
		}
		//	
		var script = `
			_API.${func}(${str_params})
			.then(
				function(d){
					log('-------------Response-----------');
					var data = JSON.parse(d);
					log(data);
					log(data.data);
				}
			)
			.catch(
				function(err){
					log('-------------Error-----------');
					log(err)
				}
			);`;
		log("----start-----"+func);
		log(script);
		eval(script);
	}else if(func == 'help'){
		log(demo_cmd);
	}
}
function log(msg){
	console.log(msg);
	console.log(" ");
}

commandParser();