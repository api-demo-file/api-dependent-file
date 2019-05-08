### Python 代码详解
* 此代码仅用来对请求参数签名使用，需要签名的接口，把参数存为字典格式，使用signature库内的api_signature方法进行签名进行签名，api_signature方法会直接生成可用来请求的参数体。

* api_signature 方法内已经存在 apiKey，secret，timeStamp，nonce，如获取用户接口就不需要传参，直接调用api_signature方法，获取请求参数即可直接请求。

* 如下单接口，需要自主构建字典参数调用api_signature方法进行签名

```python
from signature import api_signature

data = {"type":"1",
"price":"2",
"number":"3",
"symbol":"eth_btc",
"tradePwd":"qwe1234"}

# 获取的parameter 可直接用于发送请求
parameter = api_signature(data)

```
* 使用该方法前需要在 user.ini方法内存入自己的apiKey和secret
* 下载第三方库 configparser

下载方法
```
pip install configparser
```

