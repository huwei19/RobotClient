using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace GCGame.Table
{
    public class StrDictionary
    {
        //\w ：与任何单词字符匹配，包括下划线。等价于 "[A-Za-z0-9_] "
        //static Regex m_Regex = new Regex("#{[0-9]+}");      //匹配#{0~9}，其中0~9为任意数字  

        //static string getDigitStr(string str)
        //{
        //    string result = "";
        //    if (string.IsNullOrEmpty(str))
        //    {
        //        return result;
        //    }

        //    for (int i = 0; i < str.Length; ++i)
        //    {
        //        if (str[i] >= '0' && str[i] <= '9') result += str[i];
        //    }

        //    return result;
        //}
        
        /// <summary>
        /// 返回翻译完的字典内容，只能用于客户端本地字典的解析
        /// 使用例子：
        /// string dicStr = StrDictionary.GetClientDictionaryString("#{2344}", element1, element2, element3 ... );   //其中element1等是字符串或者整数
        /// 或者
        /// string dicStr2 = StrDictionary.GetClientDictionaryString("#{2344}");  //直接在客户端写字典号
        /// </summary>
        /// <param name="ClientDictionaryStr"></param>
        /// ClientDictionaryStr为客户端字典号，例如#{5676}
        /// <param name="args">
        /// 变参内容，要依据字典中填写的{x}来确定有多少个内容，如果不对应，会报错（解析出的也是乱的）；
        /// </param>
        /// <returns>返回翻译完的字典内容，可以直接显示</returns>
        static public string GetClientDictionaryString(string ClientDictionaryStr, params object[] args)
        {
            /*
            if (ClientDictionaryStr.Length < 3)
            {
                return ClientDictionaryStr+"DictionaryERROR1";
            }
            string dicIdStr = ClientDictionaryStr.Substring(2, ClientDictionaryStr.Length - 3);
            Tab_StrDictionary pDictionary = TableManager.GetStrDictionaryByID(dicIdStr, 0);
            if (pDictionary != null)
            {
                 return string.Format(pDictionary.StrDictionary, args);
            }
           
            return ClientDictionaryStr+"DictionaryERROR2";
             * *
             */
            return "";
        }

        /// <summary>
        /// 解析由服务器函数DictionaryFormat::FormatDictionary()返回的包含字典的字符串。
        /// 返回翻译完的字典内容，只能用于从服务器发过来字典的解析
        /// 使用例子：
        /// string serverSendedStr = "#{12345}*hello*newWorld";  //Server发过来的字符串，由Server端的DictionaryFormat::FormatDictionary()生成的。
        /// 或者
        /// string serverSendedStr2 = "#{12345}";  //Server发过来的字符串，就是一个字典号
        /// string dicStr = StrDictionary.GetServerDictionaryFormatString(serverSendedStr); 
        /// string dicStr2 = StrDictionary.GetServerDictionaryFormatString(serverSendedStr2); 
        /// </summary>
        /// <param name="ServerSendedDictionaryStr">
        /// ServerSendedDictionaryStr为服务器发过来的包含字典号的字符串
        /// 格式举例如下：
        /// #{12345}*hello*newWorld
        /// 其中字典#{12345}的内容为：{0}{1}
        /// 上面的两个变量字符串分别为hello,newWorld
        /// 解析完整个字典串返回值为：hello newWorld
        /// </param>
        /// <returns>返回翻译完的字典内容，可以直接显示</returns>
        static public string GetServerDictionaryFormatString(string ServerSendedDictionaryStr)       //#{12345}*hello*newWorld
        {
            /*
            char firstChar = ServerSendedDictionaryStr[0];
            if (firstChar != '#')
            {
                return ServerSendedDictionaryStr+"DictionaryFormatERROR1";
            }

            int dicEndPos = ServerSendedDictionaryStr.IndexOf('*');
            if (dicEndPos > 0) //#{12345}*hello*newWorld         这种格式
            {
                string dictionaryStr = ServerSendedDictionaryStr.Substring(0, dicEndPos);
                string elementStr = ServerSendedDictionaryStr.Substring(dicEndPos + 1, ServerSendedDictionaryStr.Length - dicEndPos - 1);

                string[] allElements = elementStr.Split('*');

                return GetClientDictionaryString(dictionaryStr, allElements);
            }
            else // #{12345} 这种格式
            {
                if (ServerSendedDictionaryStr.Length < 3)
                {
                    return ServerSendedDictionaryStr+"DictionaryERROR";
                }
                string dicIdStr = ServerSendedDictionaryStr.Substring(2, ServerSendedDictionaryStr.Length - 3);
                Tab_StrDictionary pDictionary = TableManager.GetStrDictionaryByID(dicIdStr, 0);
                if (pDictionary != null)
                {
                    return pDictionary.StrDictionary;
                }
            }

            return ServerSendedDictionaryStr+"DictionaryFormatERROR2";
            */
            return "";
        }

        

        ////正则表达式,匹配包含字典的字符串
        ///// <summary>
        ///// 返回*字典1*字典2*字典3*     
        ///// 即替换字符串中的#{0~9}为字典号
        ///// </summary>
        ///// <param name="srcStr">
        ///// srcStr的格式为: *#{0~9}*#{0~9}*#{0~9}*  
        ///// 其中*匹配任何字符串，0~9代表任意数字
        ///// </param>
        ///// <returns></returns>
        //public static string GetDictionary(string srcStr)
        //{
        //    string result = srcStr;
        //    MatchCollection matchCol = m_Regex.Matches(srcStr);
        //    foreach (Match myMatch in matchCol)
        //    {
        //        string str = getDigitStr(myMatch.ToString());
        //        Tab_StrDictionary pdictionary = TableManager.GetStrDictionaryByID(str, 0);
        //        if (pdictionary != null)
        //        {
        //            result = result.Replace(myMatch.ToString(), pdictionary.StrDictionary);
        //        }
        //    }
        //    return result;
        //}

        
    }
}
