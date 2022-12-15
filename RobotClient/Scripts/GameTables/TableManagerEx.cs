using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Games.Table
{
    //扩展tablemanager, 可以指定读取指定的表格
    public class TableManagerEx
    {
        //读取过的表保存 不反复加载
        private static Dictionary<string, Dictionary<int, List<Tab_Node>>> g_Nodes = new Dictionary<string, Dictionary<int, List<Tab_Node>>>();

        public static Dictionary<int, List<Tab_Node>> GetNode(string file)
        {
            if (string.IsNullOrEmpty(file))
                return null;

            if (g_Nodes.ContainsKey(file))
                return g_Nodes[file];

            var tNode = new Dictionary<int, List<Tab_Node>>();
            TableManager.ReaderPList(file, Tab_Node.SerializableTable, tNode);
            g_Nodes[file] = tNode;
            return tNode;
        }

        public static Tab_Node GetNodeByID(string file, int ID)
        {
            if (string.IsNullOrEmpty(file))
                return null;

            var tNode = GetNode(file);
            if (tNode == null)
                return null;
            if (tNode.ContainsKey(ID) && tNode[ID].Count >0)
                return tNode[ID][0];

            return null;
        }
    }
}