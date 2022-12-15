using System;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;
using GCGame.Table;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

public static class Utils
{

    /// <summary>
    /// 按照规则严格进行分割
    /// </summary>
    /// <param name="str">原始字符</param>
    /// <param name="nTypeList">字符串类型</param>
    /// <param name="regix">规则词，只有一个</param>
    /// <returns>返回分割的词</returns>
    public static string[] MySplit(string str, string[] nTypeList, string regix)
    {

        if (string.IsNullOrEmpty(str))
        {
            return null;
        }
        String[] content = new String[nTypeList.Length];
        int nIndex = 0;
        int nstartPos = 0;
        while (nstartPos <= str.Length)
        {
            int nsPos = str.IndexOf(regix, nstartPos);
            if (nsPos < 0)
            {
                String lastdataString = str.Substring(nstartPos);
                if (string.IsNullOrEmpty(lastdataString) && nTypeList[nIndex].ToLower() != "string")
                {
                    content[nIndex++] = "--";
                }
                else
                {
                    content[nIndex++] = lastdataString;
                }
                break;
            }
            else
            {
                if (nstartPos == nsPos)
                {
                    if (nTypeList[nIndex].ToLower() != "string")
                    {
                        content[nIndex++] = "--";
                    }
                    else
                    {
                        content[nIndex++] = "";
                    }
                }
                else
                {
                    content[nIndex++] = str.Substring(nstartPos, nsPos - nstartPos);
                }
                nstartPos = nsPos + 1;
            }
        }

        return content;

    }

    /// <summary>
    /// 过滤字
    /// </summary>
    /// <param name="str">原始字符</param>
    /// <param name="nFilterType">过滤类型参考STRFILTER_TYPE</param>
    /// <returns>返回空未没有找到，找到后返回相应字符</returns>
    public static string GetStrFilter(string str, int nFilterType)
    {
        /*
        if (nFilterType < (int)GameDefine_Globe.STRFILTER_TYPE.STRFILTER_CHAT || nFilterType > (int)GameDefine_Globe.STRFILTER_TYPE.STRFILTER_MAIL)
        {
            return null;
        }
        if (str == null)
        {
            return null;
        }
        foreach (string key in TableManager.GetStrFilter().Keys)
        {
            Tab_StrFilter tableList = TableManager.GetStrFilterByID(key, 0);
            if (tableList != null)
            {
                //找到了
                if (str.IndexOf(key) != -1 && tableList.GetTypebyIndex(nFilterType) == true)
                {
                    return key;
                }
            }
        }
         */
        return null;
    }

    //从文件读取一个字符串
    public static bool ReadFileString(string path, ref string retString)
    {
        try
        {
            if (!File.Exists(path))
            {
                return false;
            }
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fs);
            retString = sr.ReadToEnd();
            sr.Close();
            fs.Close();

            return true;
        }
        catch (Exception ex)
        {
            LogModule.ErrorLog(ex.ToString());
            return false;
        }
    }

    public static string GetStringMD5(string srcString)
    {
        MD5CryptoServiceProvider oMD5Hasher = new MD5CryptoServiceProvider();
        MemoryStream msm = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(srcString));
        byte[] arrbytHashValue = oMD5Hasher.ComputeHash(msm);
        string strHashData = System.BitConverter.ToString(arrbytHashValue);
        return strHashData.Replace("-", "");
    }


    #region ini文件

    public static string ReadIniFile(string fileName)
    {
        string tableFilePath = Application.persistentDataPath + "/Update/ResData/" + fileName + ".txt";

        byte[] datas = null;
        string tableData = null;
        if (File.Exists(tableFilePath))
        {
            datas = File.ReadAllBytes(tableFilePath);
        }
        else
        {
            TextAsset testAsset;
            testAsset = Resources.Load("Bundle/" + fileName, typeof(TextAsset)) as TextAsset;
            if (null != testAsset)
            {
                datas = testAsset.bytes;
            }
        }

        if (datas != null)
        {
#if DATA_ENCRYPT
                XorCrypto.XorDecrypt(datas, 0, datas.Length - 1, Games.GlobeDefine.GlobeVar.dataKeys);
#endif
            tableData = Encoding.UTF8.GetString(datas);
        }

        return tableData;
    }

    #endregion

    /// <summary>
    /// 重复执行 函数方法，单位毫秒
    /// </summary>
    /// <param name="action"></param>
    /// <param name="millisecondsTimeout"></param>
    public static void Repeat(this Action action, int millisecondsTimeout)
    {
        new Thread(new ThreadStart(() =>
        {
            while (true)
            {
                Thread.Sleep(millisecondsTimeout);
                action();
            }
        })).Start();
    }

    /// <summary>
    /// 获取时间戳 单位毫秒
    /// </summary>
    /// <returns></returns>
    public static double GetTimeStamp()
    {
        TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        return ts.TotalMilliseconds;
    }

    public static int GetTimeDiffSecnds(DateTime date1, DateTime date2)
    {
        TimeSpan span = new TimeSpan(date1.Ticks - date2.Ticks);
        return span.Seconds;
    }
}