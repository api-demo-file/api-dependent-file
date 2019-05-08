package com.exchange.utils;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Map;

public class SignUtil {
	/**
	 * 生成签名
	 * 首先，将待签名字符串要求按照参数名进行排序
	 * 首先比较所有参数名的第一个字母，按abcd顺序排列，若遇到相同首字母，则看第二个字母，以此类推
	 * @param 	sArray
	 * @param  	secretKey
	 * @return 签名结果字符串
	 */
	public static String buildSign(Map<String, String> sArray, String secretKey) {
		String mysign = "";
		try {
			String prestr = createLinkString(sArray);
			// 拼接secretKey
			prestr = prestr + secretKey;
			// 获得32位md5
			mysign = getMD5String(prestr);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return mysign;
	}

	/**
	 * 拼接时，不包括最后一个&字符
	 * @param params
	 * @return 拼接后字符串
	 */
	public static String createLinkString(Map<String, String> params) {

		String prestr = "";
		if( params == null) return "";
		List<String> keys = new ArrayList<String>(params.keySet());
		if(keys.size()>0){
			Collections.sort(keys);
			for (int i = 0; i < keys.size(); i++) {
				String key = keys.get(i);
				String value = params.get(key);
				if (i == keys.size() - 1) {//
					prestr = prestr + key + "=" + value;
				} else {
					prestr = prestr + key + "=" + value + "&";
				}
			}
		}
		return prestr;
	}

	/**
	 * 生成32位MD5值
	 */
	private static final char HEX_DIGITS[] = { '0', '1', '2', '3', '4', '5','6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
	public static String getMD5String(String str) {
		try {
			if (str == null || str.trim().length() == 0) {
				return "";
			}
			byte[] bytes = str.getBytes();
			MessageDigest messageDigest = MessageDigest.getInstance("MD5");
			messageDigest.update(bytes);
			bytes = messageDigest.digest();
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < bytes.length; i++) {
				sb.append(HEX_DIGITS[(bytes[i] & 0xf0) >> 4] + ""
						+ HEX_DIGITS[bytes[i] & 0xf]);
			}
			return sb.toString();
		} catch (NoSuchAlgorithmException e) {
			e.printStackTrace();
		}
		return "";
	}
}
