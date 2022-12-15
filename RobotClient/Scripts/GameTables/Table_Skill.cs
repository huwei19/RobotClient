//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Skill
{ private const string TAB_FILE_DATA = "Table/Skill.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_ICON,
ID_DESC,
ID_SKILLTYPE,
ID_SKILLEFFECTTYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_SkillEffectType;
 public int SkillEffectType { get{ return m_SkillEffectType;}}

private int m_SkillType;
 public int SkillType { get{ return m_SkillType;}}

public static bool LoadTable(Dictionary<int, List<Tab_Skill> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Skill SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Skill _values = new Tab_Skill();
 _values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_SkillEffectType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SKILLEFFECTTYPE] as string);
_values.m_SkillType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SKILLTYPE] as string);

 return _values; }


}
}

