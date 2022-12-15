using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Games.Table
{
    public class TabReader
    {
        public static bool ReaderPList<T>(string xmlFile, SerializableTable<T> _fun, Dictionary<int, List<T>> _hash)
        {
            if (string.IsNullOrEmpty(xmlFile))
            {
                GameLog.Log("error:" + xmlFile);
                return false;
            }

            //例：Table/StoryChapter.txt or Stories/Level_1007.txt
            string[] list = xmlFile.Split('.');
            string[] relTablePaths = list[0].Split('/');
            List<string> alldataRow = new List<string>();
            int readIndex = 0;
            while (true)
            {
                string subName = "";
                if (readIndex > 0)
                {
                    subName = "-" + readIndex.ToString();
                }
                string[] readData = null;
                string tableFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "/Resources/Bundle/"+ list[0] + subName + ".txt";
                if (File.Exists(tableFilePath)) {
                    StreamReader sr = null;
                    sr = File.OpenText(tableFilePath);
                    string tableData = sr.ReadToEnd();
                    sr.Close();
                    readData = tableData.Split('\n');
                }
                if (null == readData)
                {
                    break;
                }
                else
                {
                    alldataRow.AddRange(readData);
                }
                readIndex++;
            }

            if (alldataRow.Count < 4)
            {
                throw TableException.ErrorReader("Load File{0} Fail,Header less 4.", xmlFile);
            }

            string typeLine = alldataRow[1];

            string[] typeList = typeLine.Split('\t');
            bool[] isStrSet = new bool[typeList.Length];
            for (int __i = 0; __i < typeList.Length; __i++) typeList[__i] = typeList[__i].ToLower();
            for (int __i = 0; __i < typeList.Length; __i++) isStrSet[__i] = typeList[__i] == "string";

            string[] lastValues = new string[typeList.Length];

            int count = alldataRow.Count;
            for (int i=4; i< count; i++)
            {
                string line = alldataRow[i];

                if (string.IsNullOrEmpty(line)) continue;
                if (line[0] == '#') continue;

                string szlinetemp = line.TrimEnd('\r');
                //if (szlinetemp.Length >= 1)
                //{
                //    if (szlinetemp[szlinetemp.Length - 1] == '\r')
                //    {
                //        szlinetemp = szlinetemp.TrimEnd('\r');
                //    }
                //}

                //MySplit(szlinetemp, intTypeLint, valuesList, m_Value);
                //Array.Copy(valuesList, m_Value, typeList.Length);

                string[] valuesList = szlinetemp.Split('\t');
                for (int j = 0; j < valuesList.Length; j++)
                {
                    string t = valuesList[j];
                    if (string.IsNullOrEmpty(t))
                    {
                        valuesList[j] = isStrSet[j] ? string.Empty : lastValues[j];
                    }
                }
                lastValues = valuesList;

                string skey = valuesList[0];
                int nKey;
                if (!int.TryParse(skey, out nKey))
                {
                    GameLog.LogWarning("j x error:" + xmlFile);
                    return false;
                }

                var _values = _fun(valuesList, nKey);
                List<T> tList;
                if (_hash.TryGetValue(nKey, out tList))
                {
                    tList.Add(_values);
                }
                else
                {
                    tList = new List<T>(1);
                    tList.Add(_values);
                    _hash.Add(nKey, tList);
                }
            }
            return true;
        }
        public static bool ReaderPListLong<T>(string xmlFile, SerializableTableLong<T> _fun, Dictionary<long, List<T>> _hash)
        {
            //UnityEngine.Debug.LogError(xmlFile);

            if (string.IsNullOrEmpty(xmlFile))
            {
                GameLog.Log("error:" + xmlFile);
                return false;
            }


            string[] list = xmlFile.Split('.');
            string relTablePath = list[0].Substring(6);
            List<string> alldataRow = new List<string>();
            int readIndex = 0;
            while (true)
            {
                string subName = "";
                if (readIndex > 0)
                {
                    subName = "-" + readIndex.ToString();
                }
                string[] readData = null;

                string tableFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "/Resources/Bundle/Table/" + relTablePath + subName + ".txt";
                string tableData = ReaderFile(tableFilePath, list[0] + subName);
                if (tableData != null)
                {
                    readData = tableData.Split('\n');
                }

                if (null == readData)
                {
                    break;
                }
                else
                {
                    alldataRow.AddRange(readData);
                }
                readIndex++;
            }

            if (alldataRow.Count < 4)
            {
                throw TableException.ErrorReader("Load File{0} Fail,Header less 4.", xmlFile);
            }

            string typeLine = alldataRow[1];

            string[] typeList = typeLine.Split('\t');
            bool[] isStrSet = new bool[typeList.Length];
            for (int __i = 0; __i < typeList.Length; __i++) typeList[__i] = typeList[__i].ToLower();
            for (int __i = 0; __i < typeList.Length; __i++) isStrSet[__i] = typeList[__i] == "string";

            string[] lastValues = new string[typeList.Length];

            int count = alldataRow.Count;
            for (int i = 4; i < count; i++)
            {
                string line = alldataRow[i];

                if (string.IsNullOrEmpty(line)) continue;
                if (line[0] == '#') continue;

                string szlinetemp = line.TrimEnd('\r');
                //if (szlinetemp.Length >= 1)
                //{
                //    if (szlinetemp[szlinetemp.Length - 1] == '\r')
                //    {
                //        szlinetemp = szlinetemp.TrimEnd('\r');
                //    }
                //}

                //MySplit(szlinetemp, intTypeLint, valuesList, m_Value);
                //Array.Copy(valuesList, m_Value, typeList.Length);

                string[] valuesList = szlinetemp.Split('\t');
                for (int j = 0; j < valuesList.Length; j++)
                {
                    string t = valuesList[j];
                    if (string.IsNullOrEmpty(t))
                    {
                        valuesList[j] = isStrSet[j] ? string.Empty : lastValues[j];
                    }
                }
                lastValues = valuesList;

                string skey = valuesList[0];
                long nKey;
                if (!long.TryParse(skey, out nKey))
                {
                    GameLog.Log("error:" + "j x error:" + xmlFile);
                    return false;
                }

                var _values = _fun(valuesList, nKey);
                List<T> tList;
                if (_hash.TryGetValue(nKey, out tList))
                {
                    tList.Add(_values);
                }
                else
                {
                    tList = new List<T>(1);
                    tList.Add(_values);
                    _hash.Add(nKey, tList);
                }
            }
            return true;
        }
        private static string ReaderFile(string tableFilePath, string subName)
        {
            byte[] datas = null;
            string tableData = null;
            if (File.Exists(tableFilePath))
            {
                datas = File.ReadAllBytes(tableFilePath);
            }
            if (datas != null)
            {

                if (!tableFilePath.EndsWith("BundleConfig.txt"))
                {
#if DATA_ENCRYPT
                XorCrypto.XorDecrypt(datas, 0, datas.Length - 1, Games.GlobeDefine.GlobeVar.dataKeys);   
#endif
                }
                tableData = Encoding.UTF8.GetString(datas);
            }
            return tableData;
        }
        public static bool ReaderList<T>(string data, Dictionary<int, List<T>> _hash)
        {
            if (string.IsNullOrEmpty(data))
                return false;

            List<string> alldataRow = new List<string>();
            string[] readData = null;
            readData = data.Split('\n');
            alldataRow.AddRange(readData);
            if (alldataRow.Count < 4)
            {
                throw TableException.ErrorReader("Load data Fail,Header less 4.");
            }


            try
            {
                string typeLine = alldataRow[1];

                string[] typeList = typeLine.Split('\t');
                bool[] isStrSet = new bool[typeList.Length];
                for (int __i = 0; __i < typeList.Length; __i++) typeList[__i] = typeList[__i].ToLower();
                for (int __i = 0; __i < typeList.Length; __i++) isStrSet[__i] = typeList[__i] == "string";
                string[] lastValues = new string[typeList.Length];

                int count = alldataRow.Count;

                for (int i = 4; i < count; i++)
                {
                    string line = alldataRow[i];

                    if (string.IsNullOrEmpty(line)) continue;
                    if (line[0] == '#') continue;

                    string szlinetemp = line.TrimEnd('\r');
                    string[] valuesList = szlinetemp.Split('\t');
                    for (int j = 0; j < valuesList.Length; j++)
                    {
                        string t = valuesList[j];
                        if (string.IsNullOrEmpty(t))
                        {
                            valuesList[j] = isStrSet[j] ? string.Empty : lastValues[j];
                        }
                    }
                    lastValues = valuesList;

                    string skey = valuesList[0];
                    int nKey;
                    if (!int.TryParse(skey, out nKey))
                    {
                        return false;
                    }
                    Type type = typeof(T);

                    object obj = type.InvokeMember("SerializableTable",
                        System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.Static
                                                                    | System.Reflection.BindingFlags.Public, null, null,
                        new object[] { valuesList, nKey });  //最后一个是参数:0
                    var _values = (T)obj;
                    List<T> tList;
                    if (_hash.TryGetValue(nKey, out tList))
                    {
                        tList.Add(_values);
                    }
                    else
                    {
                        tList = new List<T>(1);
                        tList.Add(_values);
                        _hash.Add(nKey, tList);
                    }
                }
            }
            catch (Exception e)
            {
                throw TableException.ErrorReader(e.Message);
            }
            return true;
        }
    }
}

