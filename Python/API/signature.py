# _*_ coding: utf-8 _*_
# @Time : 2018-12-18 18:24
# @Author : Ray
# @Site : 
# @File : signature.py
# @SOftware: PyCharm


import configparser
import hashlib
import time
import random

conf = configparser.ConfigParser()
conf.read("infor.ini", encoding="utf-8-sig")

def signature(params, secret):

    """
    Args:
        params: 需要进行签名的字典型参数
        secret_or_appkey: secret 是API的值    appkey是登录需要的值

    Returns: 数字指纹

    """

    iniSign = ''

    # 对字典参数进行排序
    for key in sorted(params.keys()):
        # 如果 value 为空不参与加密
        if params[key] != "":
            iniSign += key + '=' + str(params[key]) + '&'
    signs = iniSign[:-1]

    data = "%s%s" % (signs, str(secret))
    # 进行MD5加密
    digital = hashlib.md5(data.encode("utf8")).hexdigest().lower()

    return digital

def api_signature(request_params=None):
    """
    API 接口签名
    Args:
    	request_params: 请求参数

    Returns:
    	签名完成的请求参数
    """

    params={}
    params['apiKey'] =conf.get("key","ApiKey")
    params['secret'] = conf.get("key","Secret")
    params['timeStamp'] = str(int(time.time()))
    params['nonce'] = str(random.randint(100000, 999999))
    if request_params != None:
        params.update(request_params)

    secret = params['secret']
    # 字典中去除 secret 不参与排序
    params.pop("secret")

    # 对字典参数进行签名
    params['sign'] = signature(params=params, secret=secret)

    return params
