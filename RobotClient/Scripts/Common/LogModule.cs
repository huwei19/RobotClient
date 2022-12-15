/********************************************************************************
 *	文件名：	LogModule.cs
 *	全路径：	\Script\GlobalSystem\Log\LogModule.cs
 *	创建人：	李嘉
 *	创建时间：2015-10-15
 *
 *	功能说明：日志模块
 *	修改记录：
*********************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class LogModule
{
    public static void ErrorLog(object log)
    {
        Debug.LogError(log);
    }

    public static void ExceptionLog(Exception e)
    {
        Debug.LogException(e);
    }

    public static void WarningLog(object log)
    {
        Debug.LogWarning(log);
    }

    public static void DebugLog(object log)
    {
        Debug.Log(log);
    }

  
    public static string ByteToString(byte[] byteData, int nStartIndex, int nCount)
    {

        string strResult = "";
        if (nStartIndex < 0 || nStartIndex >= byteData.Length)
        {
            return strResult;
        }

        for (int i = nStartIndex; i < nCount && i < byteData.Length; i++)
        {
            strResult += Convert.ToString(byteData[i]);
        }
        return strResult;
    }

}
