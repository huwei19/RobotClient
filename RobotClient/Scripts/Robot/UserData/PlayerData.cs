using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Games.GlobeDefine;

public class PlayerData {

    public ulong Guid { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public long CreateTime { get; set; }
    public int Exp { get; set; }
    public long Diamond { get; set; }
    public long GoldCoin { get; set; }
    public int Stamina { get; set; }
    public int Confidence { get; set; }

    public int CardId { get; set; }
    public string Signature { get; set; }
    public int GoldBuyTimes { get; set; }
    public int StaminaBuyTimes { get; set; }
    public bool isNonage { get; set; }
    public string guideId { get; set; }
    public string GoldCoionStr { get { return GoldCoin.ToString("#,##0"); } }
    public string DiamondStr { get { return Diamond.ToString("#,##0"); } }

    public long OpenNumeralTime { get; set; }
    public bool IsFirstLogin { get; set; }

    public int ServerID;
    public float xPos;
    public float yPos;
    public int roleBaseID;
    public int force;
    public bool isDie;
    public float moveSpeed;

    public int SceneClass;
    public int profession;
    public int pkMode;
    public int mountID;
    public int reliveTime;
    public string titleName;
    public bool isInMainPlayerPKList;


    public int hp;
    public int maxHp;
    public int mp;
    public int maxMp;
    public int xp;
    public int maxXp;
    public int level;
    public bool isPvPAudience;

    public int exp;
    public int money;
    public int yuanbao;
    public int bindyuanbao;
    public bool isInCombat;
    public IList<int> playerTypeList = new List<int>();
    public IList<UInt64> playerGuidList = new List<UInt64>();
    public UInt64 playerGuid_ = GlobeVar.INVALID_GUID;
    public int rapidvalidatecode = GlobeVar.INVALID_ID;
    public int lastRapidCode = GlobeVar.INVALID_ID;

    //排队
    public int queuingIndex = -1;

    public global::ProtobufPacket._DBCards CardBag = new global::ProtobufPacket._DBCards(); // 背包

}
