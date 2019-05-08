using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ExchangeRestApiDemo
{
    class iniOperate
    {
        #region API函数申明
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section,
        string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section,
        string key, string def, StringBuilder retval, int size, string filepath);
        #endregion
        #region 读INI文件
        public string ReadIniData(string Section, string Key, string NoText, string iniFIlePath)//注意不要用静态的方法。
        {
            if (File.Exists(iniFIlePath))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFIlePath);//NoText为当找不到关键字时作为代替数据
                return temp.ToString();
            }
            else
            {
                return String.Empty;
            }
        }
        #endregion
        #region 写INI文件
        public bool WriteIniData(string Section, string Key, string Value, string iniFilePath)//注意不要用静态的方法。
        {
            if (File.Exists(iniFilePath))
            {
                long opStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
                if (opStation == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
