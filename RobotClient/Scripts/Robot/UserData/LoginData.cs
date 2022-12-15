/********************************************************************
	purpose:	存放登陆相关玩家数据
*********************************************************************/

using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoginData
{
    public class PlayerRoleData
    {
        public PlayerRoleData()
        {
            guid = 0xFFFFFFFFFFFFFFFFul; 
            type = 0;
            name = "";
            level = 0;
            lastRapidCode = -1;
        }
        public PlayerRoleData(ulong _guid, int _type, string _name, int _level, int _lastRapidCode)
        {
            guid = _guid;
            type = _type;
            name = _name;
            level= _level;
            lastRapidCode = _lastRapidCode;
        }
        public ulong guid;
        public int type;
        public string name;
        public int level;
        public int lastRapidCode;
    }

    public List<PlayerRoleData> loginRoleList = new List<PlayerRoleData>();
}
