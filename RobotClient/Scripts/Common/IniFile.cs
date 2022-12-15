using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IniFile
{
    class DataInfo
    {
        public string section = "";
        public string name = "";
        public string type = "";
        public string val = "";
    }

    private Dictionary<string, DataInfo> m_data = new Dictionary<string, DataInfo>();

    public IniFile(string content)
    {
        string curSection = "";
        string[] lines = content.Split('\n');
        for (int idx = 0; idx < lines.Length; idx++)
        {
            string line = lines[idx].Trim();
            if (string.IsNullOrEmpty(line) || line.StartsWith("//"))
            {
                continue;
            }

            if (line.StartsWith("[") && line.EndsWith("]") && line.Length > 2)
            {
                curSection = line.Substring(1, line.Length - 2);
            }
            else if (string.IsNullOrEmpty(curSection))
            {
                GameLog.LogError("ini format error, not start with section");
                break;
            }
            else
            {
                string[] lineitems = line.Split(new char[] { '=', ';'});
                if (lineitems.Length >= 3)
                {
                    DataInfo info = new DataInfo();
                    info.section = curSection;
                    info.name = lineitems[0].Trim();
                    info.val = lineitems[1].Trim();
                    info.type = lineitems[2].Trim();
                    string key = format_key(info.section, info.name);
                    if (!m_data.ContainsKey(key))
                    {
                        m_data.Add(key, info);
                    }
                    else
                    {
                        GameLog.LogError("ini value duplicate, key:" + key);
                        break;
                    }
                }
                else
                {
                    GameLog.LogError("ini format error, line:" + idx);
                    break;
                }
            }
        }
    }

    public bool read_bool(string section, string name, bool dval)
    {
        DataInfo info = get_info(section, name);
        if (info != null)
        {
            if (info.type == "b")
            {
                return info.val.ToLower() == "true" || info.val.ToLower() == "1";
            }
            else
            {
                GameLog.LogError("ini data type error, name:" + name);
            }
        }
        return dval;
    }

    public int read_int(string section, string name, int dval)
    {
        DataInfo info = get_info(section, name);
        if (info != null)
        {
            if (info.type == "i")
            {
                return (int)Convert.ChangeType(info.val, TypeCode.Int32);
            }
            else
            {
                GameLog.LogError("ini data type error, name:" + name);
            }
        }
        return dval;
    }

    public float read_float(string section, string name, float dval)
    {
        DataInfo info = get_info(section, name);
        if (info != null)
        {
            if (info.type == "f")
            {
                return (float)Convert.ChangeType(info.val, TypeCode.Single);
            }
            else
            {
                GameLog.LogError("ini data type error, name:" + name);
            }
        }
        return dval;
    }

    public long read_long(string section, string name, long dval)
    {
        DataInfo info = get_info(section, name);
        if (info != null)
        {
            if (info.type == "l")
            {
                return (long)Convert.ChangeType(info.val, TypeCode.Int64);
            }
            else
            {
                GameLog.LogError("ini data type error, name:" + name);
            }
        }
        return dval;
    }

    public double read_double(string section, string name, double dval)
    {
        DataInfo info = get_info(section, name);
        if (info != null)
        {
            if (info.type == "d")
            {
                return (double)Convert.ChangeType(info.val, TypeCode.Double);
            }
            else
            {
                GameLog.LogError("ini data type error, name:" + name);
            }
        }
        return dval;
    }

    public string read_string(string section, string name, string dval)
    {
        DataInfo info = get_info(section, name);
        if (info != null)
        {
            if (info.type == "s")
            {
                return info.val;
            }
            else
            {
                GameLog.LogError("ini data type error, name:" + name);
            }
        }
        return dval;
    }

    private string format_key(string section, string name)
    {
        return section + "_" + name;
    }

    private DataInfo get_info(string section, string name)
    {
        string key = format_key(section, name);
        if (m_data.ContainsKey(key))
        {
            return m_data[key];
        }
        return null;
    }
}
