using System.Collections;
using System.Collections.Generic;
using Games.Table;
using UnityEngine;
//国际化
public class LocalizationManager 
{
    private static LocalizationManager _instance = null;

    public static LocalizationManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new LocalizationManager();
        }
        return _instance;
    }

    private string uiPackageName = "";

    public bool isHandle = false;
    
    private string tranlateDictionaryName = "" ;

    public string GetUIPackageName()
    {
        return uiPackageName;
    }

    public string GetTabFileDataByTranlateDictionary()
    {
        return "Table/" + tranlateDictionaryName + ".txt";
    }
    private LocalizationManager()
    {
        SwitchLanguage(101);
    }

    public void SwitchLanguage(int id)
    {
        Tab_LocalizationData data = TableManager.GetLocalizationDataByID(id);
        if (null != data)
        {
            if (id == 101)
            {
                isHandle = false;
            }
            else
            {
                isHandle = true;
            }
            // SwitchXML(data);
            // SwitchUIPackage(data);
            SwitchCondif(data);
        }
    }
   
/// <summary>
/// 切换UI美术字
/// </summary>
    private void SwitchUIPackage(Tab_LocalizationData data)
{
    uiPackageName = data.UIPackageName;
}
/// <summary>
/// 切换音效
/// </summary>
    private void SwitchAudio()
    {
        
    }
/// <summary>
/// 切换txt配置文件
/// </summary>
    private void SwitchCondif(Tab_LocalizationData data)
{
    tranlateDictionaryName = data.TranlateDictionaryName;
}

}
