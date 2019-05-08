using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ExchangeRestApiDemo.utils
{
    class SignUtil
    {
        // 把数组所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串
        // 把拼接后的字符串再与安全校验码直接连接起来
        public static String buildSign(Dictionary<String, String> sArray,  String secretKey)
        {
            String mysign = "";
            try
            {
                String prestr = createLinkString(sArray); 
                prestr = prestr + secretKey; 
                mysign = getMD5String(prestr);
            }
            catch (Exception e)
            {
                throw e;
            }
            return mysign;
        }
        // 拼接时，不包括最后一个&字符
        public static String createLinkString(Dictionary<String, String> paras)
        {
            List<string> keys = new List<string>(paras.Keys);

            var paraSort = from objDic in paras orderby objDic.Key ascending select objDic;
            String prestr = "";
            int i = 0;
            foreach (KeyValuePair<String, String> kvp in paraSort)
            {
                if (i == keys.Count() - 1)
                {
                    prestr = prestr + kvp.Key + "=" + kvp.Value;
                }
                else
                {
                    prestr = prestr + kvp.Key + "=" + kvp.Value + "&";
                }
                i++;
                if (i == keys.Count())
                {
                    break;
                }
            }
            return prestr;
        }

         private static char[] HEX_DIGITS = new char[]{'0', '1', '2', '3', '4', '5','6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
        public static String getMD5String(String str)
        {
            if (str == null || str.Trim().Length == 0)
            {
                return "";
            }
            byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
            MD5CryptoServiceProvider md = new MD5CryptoServiceProvider();
            bytes = md.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(HEX_DIGITS[(bytes[i] & 0xf0) >> 4] + ""
                        + HEX_DIGITS[bytes[i] & 0xf]);
            }
            return sb.ToString();
        }
    }
}
