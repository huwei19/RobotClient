using System;
using System.Collections.Generic;

namespace Games.GlobeDefine
{
    public partial class GlobeVar
    {
        //场景文件
        public const int FriendMax = 50;
        public const int FriendApplyMax = 20;

        public const int Del_Friend = 1;
        public const int Add_Friend = 2;
        public const int Acc_Friend = 3;
        public const int Ref_Friend = 4;
        public const int Par_Friend = 5;

        public const int FriendGetNum = 15;
    }

    public enum EFriendOpType
    {
        Del_Friend = 1,
        Add_Friend,
        Acc_Friend,
        Ref_Friend,
        Par_Friend,
    }
}
