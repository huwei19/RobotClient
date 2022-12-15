/*****Generated by GameConfigTool!*****/ 
/*****Do Not Edit!*****/

using UnityEngine;
using System.Collections;

namespace Games.GlobeDefine
{
    [SLua.CustomLuaClass]
    public class GameStruct_AutoGameConfig
    {
        public int LocalTimeImplTimeZone = 0;
        public int DayOffset = 0;
        public bool OpenRechargeShopDiamond = false;
        public int QueuingTimeForEachPlayer = 0;
        public int QueuingTimeMax = 0;
        public bool OpenPlayerChangeName = false;
        public int PlayerChangeNameCD = 0;
        public int ChangeNameItemID = 0;
        public bool IsOpenMail = false;
        public int MailBoxSizeMax = 0;
        public bool IsOpenRechargeClient = false;
        public int RechargeAndroidDefChannel = 0;
        public int RechargeIosDefChannel = 0;
        public bool RechargeDoubleOpen = false;
        public int RefundDiamondRate = 0;
        public int RefundDebtPunishTimeLimit = 0;
        public bool IsCardOpen = false;
        public int UseItemCardLevelUpMax = 0;
        public bool IsCardStarOpen = false;
        public int CardResolveMax = 0;
        public bool IsCardAbilityOpen = false;
        public int WebRequestTimeout = 0;
        public bool IsOpenFate = false;
        public bool IsOpenStory = false;
        public bool IsOpenQuickStart = false;
        public bool IsOpenSpecialLevel = false;
        public bool IsOpenPersonalStory = false;
        public float BehaviorCalc_A1 = 0.0f;
        public int BehaviorCalc_A2 = 0;
        public float BehaviorCalc_A3 = 0.0f;
        public float BehaviorCalc_B1 = 0.0f;
        public float BehaviorCalc_B2 = 0.0f;
        public float BehaviorCalc_B3 = 0.0f;
        public float BehaviorCalc_C1 = 0.0f;
        public float BehaviorCalc_C2 = 0.0f;
        public float BehaviorCalc_D1 = 0.0f;
        public float BehaviorCalc_D2 = 0.0f;
        public bool AllowReuseCardInInvestigate = false;
        public float HugeSuccClueMultiplier = 0.0f;
        public int HugeSuccLimitNum = 0;
        public bool IsOpenSavePoint = false;
        public bool CanSavePointToServer = false;
        public bool IsOpenSceneEventSkip = false;
        public bool IsOpenStamina = false;
        public bool IsOpenStaminaBuy = false;
        public int StaminaRecoverInterval = 0;
        public int StaminaBuyValue = 0;
        public int StaminaBuyTimesPerday = 0;
        public int StaminaBuyRewardItemID = 0;
        public int StaminaBuyRewardItemNum = 0;
        public int StaminaRecoverLevelUp = 0;
        public bool IsOpenMission = false;
        public int ReputationPerSegLv = 0;
        public int MissionPushTime_0 = 0;
        public int MissionPushTime_1 = 0;
        public int MissionPushTime_2 = 0;
        public bool IsOpenRumor = false;
        public int RumorReduceTime = 0;
        public int RumorHotValue = 0;
        public int RumorHotterValue = 0;
        public int RumorBurstPreviewId = 0;
        public int RumorBurstDropId = 0;
        public float RumorReduceRate = 0.0f;
        public int RumorBurstAwardMax = 0;
        public int RumorSubTime = 0;
        public int RumorSubNum = 0;
        public int CityBubbleReduceRumorNum = 0;
        public int RumorMaxReduceNum = 0;
        public bool IsOpenVChat = false;
        public int VChatVoiceIDOffset = 0;
        public bool IsOpenCircle = false;
        public int CircleMax = 0;
        public bool IsOpenDrawCard = false;
        public int NomalDrawCountMax = 0;
        public int AdvanceDrawCountMax = 0;
        public int AdvancePerDrawCountDrop = 0;
        public int AdvancePerDrawCountDropId = 0;
        public int AdvancePerDrawCountDropPreviewId = 0;
        public int AdvanceDrawDropId = 0;
        public bool IsOpenPoolSwitch = false;
        public int PoolSwitchCostItemId = 0;
        public int PoolSwitchCostItemNum = 0;
        public int AdvanceDrawCountNewMax = 0;
        public bool IsOpenDrawCardActivity = false;
        public int ActivityDrawCountMax = 0;
        public int ActivityDrawDropId = 0;
        public int ActivityDrawSSRPool = 0;
        public int ActivityDrawSSRPoolNum = 0;
        public int ActivityDrawCardType = 0;
        public bool IsOpenDrawCardAdvanceUp = false;
        public int AdvanceUpDrawCountMax = 0;
        public int AdvanceUpDrawSSRPool = 0;
        public int AdvanceUpDrawSSRPoolNum = 0;
        public int AdvanceUpDrawCardType = 0;
        public bool IsOpenDrawCardOptionalUp = false;
        public int OptionalUpDrawCountMax = 0;
        public int OptionalDrawDropId = 0;
        public int OptionalUpDrawSSRPool = 0;
        public int OptionalUpDrawSSRPoolNum = 0;
        public int OptionalUpTimeLimit = 0;
        public int JumpShopTabId = 0;
        public int JumpShopSubId = 0;
        public bool IsOpenFriend = false;
        public bool IsOpenGiveFriend = false;
        public int RecmmendFriendLevel = 0;
        public int SearchFriendTime = 0;
        public int ParticularsFriendTime = 0;
        public int RecmmendFriendTime = 0;
        public int OpenFriendTime = 0;
        public int FriendGetNum = 0;
        public int FriendGiveNum = 0;
        public int FriendGiveDel = 0;
        public int FriendGiveDrop = 0;
        public bool IsOpenFriendsHint = false;
        public bool IsOpenShop = false;
        public int ShopBuyMax = 0;
        public bool IsOpenCLogReport = false;
        public int CLogReportTimeInterval = 0;
        public int CLogReportNumInterval = 0;
        public int InitMainPlotId = 0;
        public int CreateUserBeforePlotId = 0;
        public int CreateUserAfterPlotId = 0;
        public bool IsOpenNotice = false;
        public bool IsOpenNoticeCache = false;
        public int NoticeCacheMax = 0;
        public int NoticeCacheBuffSize = 0;
        public bool IsOpenCityWork = false;
        public bool IsOpenCityCopy = false;
        public bool IsOpenCityNpcTask = false;
        public int CityWorkTaskMaxNum = 0;
        public int CityWorkListNpcId = 0;
        public int CityWorkTime_0 = 0;
        public int CityWorkTime_1 = 0;
        public int CityWorkTime_2 = 0;
        public int CityCopyHookUpdateTime = 0;
        public int CityCopyFastConsumeId = 0;
        public int CityCopyFastCosumeNum = 0;
        public bool IsOpenGuide = false;
        public int GuidePlotId = 0;
        public float GuideTipTime = 0.0f;
        public int GuideFihfishId = 0;
        public bool IsOpenTask = false;
        public bool IsOpenMainCity = false;
        public int MainCityGoldArchitecture = 0;
        public int MainCityGoldTime = 0;
        public int MainCityGoldOut = 0;
        public int MainCityGoldMax = 0;
        public int MainFunArchitecture_1 = 0;
        public int MainFunArchitecture_2 = 0;
        public int MainFunArchitecture_3 = 0;
        public int MainFunArchitecture_4 = 0;
        public int MainFunArchitecture_5 = 0;
        public int MainFunArchitecture_6 = 0;
        public int MainFunArchitecture_7 = 0;
        public int MainFunArchitecture_8 = 0;
        public int InteractionDropId = 0;
        public bool IsOpenCDKey = false;
        public int CDKeyCD = 0;
        public bool IsOpenSign = false;
        public bool IsOpenStaminaDaily = false;
        public bool IsOpenSDKPush = false;
        public int LimitPushNight = 0;
        public int LimitPushMorn = 0;
        public int LogoutPushMax = 0;
        public bool InitOpenNoDisturbing = false;
        public bool InitOpenPushStamina = false;
        public bool InitOpenPushInlineShop = false;
        public bool InitOpenPushRumorHottes = false;
        public bool InitOpenPushGetStamina = false;
        public bool InitOpenPushCityTask = false;
        public float NextLogFadeTime = 0.0f;
        public float WaitNextLogTime = 0.0f;
        public bool IsOpenSurvery = false;
        public int CheckSurveryInterval = 0;
        public bool IsOpenAddSign = false;
        public bool IsOpenTitle = false;
        public int InitTitle = 0;
        public bool IsOpenHeartBeat = false;
        public int HeartBeatFreeCount = 0;
        public int HeartBeatVipCount = 0;
        public int HeartBeatUseItemCount = 0;
        public int HeartBeatUseItemId = 0;
        public int HeartBeatIntegral = 0;
        public float HeartBeatBeginTime = 0.0f;
        public float HeartBeatScale = 0.0f;
        public float HeartBeatTime = 0.0f;
        public float HeartBeatCVTime = 0.0f;
        public float HeartBeatProTime = 0.0f;
        public int HeartBeatPos = 0;
        public bool IsOpenInterflow = false;
        public bool IsOpenInterflowGift = false;
        public int InterflowId = 0;
        public int InterflowFunlockId = 0;
        public int InterflowGiftFunlockId = 0;
        public int InterflowGiftCount = 0;
        public bool IsOpenArticle = false;
        public bool IsOpenSecret = false;
        public bool IsStaminaPush = false;
        public bool IsStaminaGetPush = false;
        public bool IsCityWorkPush = false;
        public bool IsMissionPush = false;
        public bool IsRumorPush = false;
        public bool IsDisturbPush = false;
        public int DisturbTime_b = 0;
        public int DisturbTime_a = 0;
        public bool IsOpenAlbum = false;
        public int AlbumExpItem = 0;
        public bool IsOpenActivity = false;
        public bool IsOpenActFuli = false;
        public bool IsOpenActJC = false;
        public bool OpenGrabPass = false;
        public bool IsOpenCardTrain = false;
        public bool IsOpenShare = false;
        public bool IsOpenMonthCard = false;
        public int MonthCardShopId = 0;
        public int MonthCardId = 0;
        public bool IsOpenFuliFund = false;
        public int FuliFund_ShopId = 0;
        public bool IsOpenLongFuliRecharge = false;
        public bool IsOpenLimitFuliRecharge = false;
        public int LongFuliRechargeScoreVar = 0;
        public int LimitFuliRechargeScoreVar = 0;
        public int FuliRechargeScoreLimit = 0;
        public bool IsFirstGift = false;
        public float FirstGiftThreshold = 0.0f;
        public int FirstGiftCardId = 0;
        public int FirstGiftPlayActtionId = 0;
        public int FirstGiftJumpGotoId = 0;
        public bool IsOpenRechargeGift = false;
        public int ResetRechargeGiftIssue = 0;
        public bool IsOpenCardFrame = false;
        public int DefaultCardFrameId = 0;
        public bool IsOpenPhone = false;
        public int PhoneAwardItemId = 0;
        public int PhoneAwardItemNum = 0;
        public bool IsOpenDivination = false;
        public int TodayDivinationCount = 0;
        public int MusicDivinationCount = 0;
        public bool IsOpenCDTime = false;
        public bool IsOpenFuliLottery = false;
        public int FuliLotteryMaxDrawTimes = 0;
        public int FuliLotteryItemConvertDiamond = 0;
        public bool IsOpenContactsRemark = false;
        public bool IsOpenTongXunlu = false;
        public bool IsOpenSignboard = false;
        public int SignboardPaletteDecalsNum = 0;
        public int ThemePaletteDecalsMaxNum = 0;
        public bool IsOpenEmoji = false;
        public bool IsOpenThemePalette = false;
        public bool IsOpenGoldBuy = false;
        public bool IsExtraAudioDownload = false;
        public int OnlineOrderHistoryPageSize = 0;
        public bool IsOpenActivityAward = false;
        public string ActivityAwardList = "";
        public bool IsOpenFuliRiddleCage = false;
        public int FuliRiddleCageCardId = 0;
        public int FuliRiddleCageVersionNum = 0;
        public bool IsOpenBattlePass = false;
        public bool IsOpenMainBattlePass = false;
        public bool IsOpenDarkBattlePass = false;
        public bool IsOpenOppoEntra = false;

        public void Clone(GameStruct_AutoGameConfig obj)
        {

				this.LocalTimeImplTimeZone = obj.LocalTimeImplTimeZone;
				this.DayOffset = obj.DayOffset;
				this.QueuingTimeForEachPlayer = obj.QueuingTimeForEachPlayer;
				this.QueuingTimeMax = obj.QueuingTimeMax;
				this.PlayerChangeNameCD = obj.PlayerChangeNameCD;
				this.ChangeNameItemID = obj.ChangeNameItemID;
				this.MailBoxSizeMax = obj.MailBoxSizeMax;
				this.RechargeAndroidDefChannel = obj.RechargeAndroidDefChannel;
				this.RechargeIosDefChannel = obj.RechargeIosDefChannel;
				this.RefundDiamondRate = obj.RefundDiamondRate;
				this.RefundDebtPunishTimeLimit = obj.RefundDebtPunishTimeLimit;
				this.UseItemCardLevelUpMax = obj.UseItemCardLevelUpMax;
				this.CardResolveMax = obj.CardResolveMax;
				this.WebRequestTimeout = obj.WebRequestTimeout;
				this.BehaviorCalc_A2 = obj.BehaviorCalc_A2;
				this.HugeSuccLimitNum = obj.HugeSuccLimitNum;
				this.StaminaRecoverInterval = obj.StaminaRecoverInterval;
				this.StaminaBuyValue = obj.StaminaBuyValue;
				this.StaminaBuyTimesPerday = obj.StaminaBuyTimesPerday;
				this.StaminaBuyRewardItemID = obj.StaminaBuyRewardItemID;
				this.StaminaBuyRewardItemNum = obj.StaminaBuyRewardItemNum;
				this.StaminaRecoverLevelUp = obj.StaminaRecoverLevelUp;
				this.ReputationPerSegLv = obj.ReputationPerSegLv;
				this.MissionPushTime_0 = obj.MissionPushTime_0;
				this.MissionPushTime_1 = obj.MissionPushTime_1;
				this.MissionPushTime_2 = obj.MissionPushTime_2;
				this.RumorReduceTime = obj.RumorReduceTime;
				this.RumorHotValue = obj.RumorHotValue;
				this.RumorHotterValue = obj.RumorHotterValue;
				this.RumorBurstPreviewId = obj.RumorBurstPreviewId;
				this.RumorBurstDropId = obj.RumorBurstDropId;
				this.RumorBurstAwardMax = obj.RumorBurstAwardMax;
				this.RumorSubTime = obj.RumorSubTime;
				this.RumorSubNum = obj.RumorSubNum;
				this.CityBubbleReduceRumorNum = obj.CityBubbleReduceRumorNum;
				this.RumorMaxReduceNum = obj.RumorMaxReduceNum;
				this.VChatVoiceIDOffset = obj.VChatVoiceIDOffset;
				this.CircleMax = obj.CircleMax;
				this.NomalDrawCountMax = obj.NomalDrawCountMax;
				this.AdvanceDrawCountMax = obj.AdvanceDrawCountMax;
				this.AdvancePerDrawCountDrop = obj.AdvancePerDrawCountDrop;
				this.AdvancePerDrawCountDropId = obj.AdvancePerDrawCountDropId;
				this.AdvancePerDrawCountDropPreviewId = obj.AdvancePerDrawCountDropPreviewId;
				this.AdvanceDrawDropId = obj.AdvanceDrawDropId;
				this.PoolSwitchCostItemId = obj.PoolSwitchCostItemId;
				this.PoolSwitchCostItemNum = obj.PoolSwitchCostItemNum;
				this.AdvanceDrawCountNewMax = obj.AdvanceDrawCountNewMax;
				this.ActivityDrawCountMax = obj.ActivityDrawCountMax;
				this.ActivityDrawDropId = obj.ActivityDrawDropId;
				this.ActivityDrawSSRPool = obj.ActivityDrawSSRPool;
				this.ActivityDrawSSRPoolNum = obj.ActivityDrawSSRPoolNum;
				this.ActivityDrawCardType = obj.ActivityDrawCardType;
				this.AdvanceUpDrawCountMax = obj.AdvanceUpDrawCountMax;
				this.AdvanceUpDrawSSRPool = obj.AdvanceUpDrawSSRPool;
				this.AdvanceUpDrawSSRPoolNum = obj.AdvanceUpDrawSSRPoolNum;
				this.AdvanceUpDrawCardType = obj.AdvanceUpDrawCardType;
				this.OptionalUpDrawCountMax = obj.OptionalUpDrawCountMax;
				this.OptionalDrawDropId = obj.OptionalDrawDropId;
				this.OptionalUpDrawSSRPool = obj.OptionalUpDrawSSRPool;
				this.OptionalUpDrawSSRPoolNum = obj.OptionalUpDrawSSRPoolNum;
				this.OptionalUpTimeLimit = obj.OptionalUpTimeLimit;
				this.JumpShopTabId = obj.JumpShopTabId;
				this.JumpShopSubId = obj.JumpShopSubId;
				this.RecmmendFriendLevel = obj.RecmmendFriendLevel;
				this.SearchFriendTime = obj.SearchFriendTime;
				this.ParticularsFriendTime = obj.ParticularsFriendTime;
				this.RecmmendFriendTime = obj.RecmmendFriendTime;
				this.OpenFriendTime = obj.OpenFriendTime;
				this.FriendGetNum = obj.FriendGetNum;
				this.FriendGiveNum = obj.FriendGiveNum;
				this.FriendGiveDel = obj.FriendGiveDel;
				this.FriendGiveDrop = obj.FriendGiveDrop;
				this.ShopBuyMax = obj.ShopBuyMax;
				this.CLogReportTimeInterval = obj.CLogReportTimeInterval;
				this.CLogReportNumInterval = obj.CLogReportNumInterval;
				this.InitMainPlotId = obj.InitMainPlotId;
				this.CreateUserBeforePlotId = obj.CreateUserBeforePlotId;
				this.CreateUserAfterPlotId = obj.CreateUserAfterPlotId;
				this.NoticeCacheMax = obj.NoticeCacheMax;
				this.NoticeCacheBuffSize = obj.NoticeCacheBuffSize;
				this.CityWorkTaskMaxNum = obj.CityWorkTaskMaxNum;
				this.CityWorkListNpcId = obj.CityWorkListNpcId;
				this.CityWorkTime_0 = obj.CityWorkTime_0;
				this.CityWorkTime_1 = obj.CityWorkTime_1;
				this.CityWorkTime_2 = obj.CityWorkTime_2;
				this.CityCopyHookUpdateTime = obj.CityCopyHookUpdateTime;
				this.CityCopyFastConsumeId = obj.CityCopyFastConsumeId;
				this.CityCopyFastCosumeNum = obj.CityCopyFastCosumeNum;
				this.GuidePlotId = obj.GuidePlotId;
				this.GuideFihfishId = obj.GuideFihfishId;
				this.MainCityGoldArchitecture = obj.MainCityGoldArchitecture;
				this.MainCityGoldTime = obj.MainCityGoldTime;
				this.MainCityGoldOut = obj.MainCityGoldOut;
				this.MainCityGoldMax = obj.MainCityGoldMax;
				this.MainFunArchitecture_1 = obj.MainFunArchitecture_1;
				this.MainFunArchitecture_2 = obj.MainFunArchitecture_2;
				this.MainFunArchitecture_3 = obj.MainFunArchitecture_3;
				this.MainFunArchitecture_4 = obj.MainFunArchitecture_4;
				this.MainFunArchitecture_5 = obj.MainFunArchitecture_5;
				this.MainFunArchitecture_6 = obj.MainFunArchitecture_6;
				this.MainFunArchitecture_7 = obj.MainFunArchitecture_7;
				this.MainFunArchitecture_8 = obj.MainFunArchitecture_8;
				this.InteractionDropId = obj.InteractionDropId;
				this.CDKeyCD = obj.CDKeyCD;
				this.LimitPushNight = obj.LimitPushNight;
				this.LimitPushMorn = obj.LimitPushMorn;
				this.LogoutPushMax = obj.LogoutPushMax;
				this.CheckSurveryInterval = obj.CheckSurveryInterval;
				this.InitTitle = obj.InitTitle;
				this.HeartBeatFreeCount = obj.HeartBeatFreeCount;
				this.HeartBeatVipCount = obj.HeartBeatVipCount;
				this.HeartBeatUseItemCount = obj.HeartBeatUseItemCount;
				this.HeartBeatUseItemId = obj.HeartBeatUseItemId;
				this.HeartBeatIntegral = obj.HeartBeatIntegral;
				this.HeartBeatPos = obj.HeartBeatPos;
				this.InterflowId = obj.InterflowId;
				this.InterflowFunlockId = obj.InterflowFunlockId;
				this.InterflowGiftFunlockId = obj.InterflowGiftFunlockId;
				this.InterflowGiftCount = obj.InterflowGiftCount;
				this.DisturbTime_b = obj.DisturbTime_b;
				this.DisturbTime_a = obj.DisturbTime_a;
				this.AlbumExpItem = obj.AlbumExpItem;
				this.MonthCardShopId = obj.MonthCardShopId;
				this.MonthCardId = obj.MonthCardId;
				this.FuliFund_ShopId = obj.FuliFund_ShopId;
				this.LongFuliRechargeScoreVar = obj.LongFuliRechargeScoreVar;
				this.LimitFuliRechargeScoreVar = obj.LimitFuliRechargeScoreVar;
				this.FuliRechargeScoreLimit = obj.FuliRechargeScoreLimit;
				this.FirstGiftCardId = obj.FirstGiftCardId;
				this.FirstGiftPlayActtionId = obj.FirstGiftPlayActtionId;
				this.FirstGiftJumpGotoId = obj.FirstGiftJumpGotoId;
				this.ResetRechargeGiftIssue = obj.ResetRechargeGiftIssue;
				this.DefaultCardFrameId = obj.DefaultCardFrameId;
				this.PhoneAwardItemId = obj.PhoneAwardItemId;
				this.PhoneAwardItemNum = obj.PhoneAwardItemNum;
				this.TodayDivinationCount = obj.TodayDivinationCount;
				this.MusicDivinationCount = obj.MusicDivinationCount;
				this.FuliLotteryMaxDrawTimes = obj.FuliLotteryMaxDrawTimes;
				this.FuliLotteryItemConvertDiamond = obj.FuliLotteryItemConvertDiamond;
				this.SignboardPaletteDecalsNum = obj.SignboardPaletteDecalsNum;
				this.ThemePaletteDecalsMaxNum = obj.ThemePaletteDecalsMaxNum;
				this.OnlineOrderHistoryPageSize = obj.OnlineOrderHistoryPageSize;
				this.FuliRiddleCageCardId = obj.FuliRiddleCageCardId;
				this.FuliRiddleCageVersionNum = obj.FuliRiddleCageVersionNum;



				this.OpenRechargeShopDiamond = obj.OpenRechargeShopDiamond;
				this.OpenPlayerChangeName = obj.OpenPlayerChangeName;
				this.IsOpenMail = obj.IsOpenMail;
				this.IsOpenRechargeClient = obj.IsOpenRechargeClient;
				this.RechargeDoubleOpen = obj.RechargeDoubleOpen;
				this.IsCardOpen = obj.IsCardOpen;
				this.IsCardStarOpen = obj.IsCardStarOpen;
				this.IsCardAbilityOpen = obj.IsCardAbilityOpen;
				this.IsOpenFate = obj.IsOpenFate;
				this.IsOpenStory = obj.IsOpenStory;
				this.IsOpenQuickStart = obj.IsOpenQuickStart;
				this.IsOpenSpecialLevel = obj.IsOpenSpecialLevel;
				this.IsOpenPersonalStory = obj.IsOpenPersonalStory;
				this.AllowReuseCardInInvestigate = obj.AllowReuseCardInInvestigate;
				this.IsOpenSavePoint = obj.IsOpenSavePoint;
				this.CanSavePointToServer = obj.CanSavePointToServer;
				this.IsOpenSceneEventSkip = obj.IsOpenSceneEventSkip;
				this.IsOpenStamina = obj.IsOpenStamina;
				this.IsOpenStaminaBuy = obj.IsOpenStaminaBuy;
				this.IsOpenMission = obj.IsOpenMission;
				this.IsOpenRumor = obj.IsOpenRumor;
				this.IsOpenVChat = obj.IsOpenVChat;
				this.IsOpenCircle = obj.IsOpenCircle;
				this.IsOpenDrawCard = obj.IsOpenDrawCard;
				this.IsOpenPoolSwitch = obj.IsOpenPoolSwitch;
				this.IsOpenDrawCardActivity = obj.IsOpenDrawCardActivity;
				this.IsOpenDrawCardAdvanceUp = obj.IsOpenDrawCardAdvanceUp;
				this.IsOpenDrawCardOptionalUp = obj.IsOpenDrawCardOptionalUp;
				this.IsOpenFriend = obj.IsOpenFriend;
				this.IsOpenGiveFriend = obj.IsOpenGiveFriend;
				this.IsOpenFriendsHint = obj.IsOpenFriendsHint;
				this.IsOpenShop = obj.IsOpenShop;
				this.IsOpenCLogReport = obj.IsOpenCLogReport;
				this.IsOpenNotice = obj.IsOpenNotice;
				this.IsOpenNoticeCache = obj.IsOpenNoticeCache;
				this.IsOpenCityWork = obj.IsOpenCityWork;
				this.IsOpenCityCopy = obj.IsOpenCityCopy;
				this.IsOpenCityNpcTask = obj.IsOpenCityNpcTask;
				this.IsOpenGuide = obj.IsOpenGuide;
				this.IsOpenTask = obj.IsOpenTask;
				this.IsOpenMainCity = obj.IsOpenMainCity;
				this.IsOpenCDKey = obj.IsOpenCDKey;
				this.IsOpenSign = obj.IsOpenSign;
				this.IsOpenStaminaDaily = obj.IsOpenStaminaDaily;
				this.IsOpenSDKPush = obj.IsOpenSDKPush;
				this.InitOpenNoDisturbing = obj.InitOpenNoDisturbing;
				this.InitOpenPushStamina = obj.InitOpenPushStamina;
				this.InitOpenPushInlineShop = obj.InitOpenPushInlineShop;
				this.InitOpenPushRumorHottes = obj.InitOpenPushRumorHottes;
				this.InitOpenPushGetStamina = obj.InitOpenPushGetStamina;
				this.InitOpenPushCityTask = obj.InitOpenPushCityTask;
				this.IsOpenSurvery = obj.IsOpenSurvery;
				this.IsOpenAddSign = obj.IsOpenAddSign;
				this.IsOpenTitle = obj.IsOpenTitle;
				this.IsOpenHeartBeat = obj.IsOpenHeartBeat;
				this.IsOpenInterflow = obj.IsOpenInterflow;
				this.IsOpenInterflowGift = obj.IsOpenInterflowGift;
				this.IsOpenArticle = obj.IsOpenArticle;
				this.IsOpenSecret = obj.IsOpenSecret;
				this.IsStaminaPush = obj.IsStaminaPush;
				this.IsStaminaGetPush = obj.IsStaminaGetPush;
				this.IsCityWorkPush = obj.IsCityWorkPush;
				this.IsMissionPush = obj.IsMissionPush;
				this.IsRumorPush = obj.IsRumorPush;
				this.IsDisturbPush = obj.IsDisturbPush;
				this.IsOpenAlbum = obj.IsOpenAlbum;
				this.IsOpenActivity = obj.IsOpenActivity;
				this.IsOpenActFuli = obj.IsOpenActFuli;
				this.IsOpenActJC = obj.IsOpenActJC;
				this.OpenGrabPass = obj.OpenGrabPass;
				this.IsOpenCardTrain = obj.IsOpenCardTrain;
				this.IsOpenShare = obj.IsOpenShare;
				this.IsOpenMonthCard = obj.IsOpenMonthCard;
				this.IsOpenFuliFund = obj.IsOpenFuliFund;
				this.IsOpenLongFuliRecharge = obj.IsOpenLongFuliRecharge;
				this.IsOpenLimitFuliRecharge = obj.IsOpenLimitFuliRecharge;
				this.IsFirstGift = obj.IsFirstGift;
				this.IsOpenRechargeGift = obj.IsOpenRechargeGift;
				this.IsOpenCardFrame = obj.IsOpenCardFrame;
				this.IsOpenPhone = obj.IsOpenPhone;
				this.IsOpenDivination = obj.IsOpenDivination;
				this.IsOpenCDTime = obj.IsOpenCDTime;
				this.IsOpenFuliLottery = obj.IsOpenFuliLottery;
				this.IsOpenContactsRemark = obj.IsOpenContactsRemark;
				this.IsOpenTongXunlu = obj.IsOpenTongXunlu;
				this.IsOpenSignboard = obj.IsOpenSignboard;
				this.IsOpenEmoji = obj.IsOpenEmoji;
				this.IsOpenThemePalette = obj.IsOpenThemePalette;
				this.IsOpenGoldBuy = obj.IsOpenGoldBuy;
				this.IsExtraAudioDownload = obj.IsExtraAudioDownload;
				this.IsOpenActivityAward = obj.IsOpenActivityAward;
				this.IsOpenFuliRiddleCage = obj.IsOpenFuliRiddleCage;
				this.IsOpenBattlePass = obj.IsOpenBattlePass;
				this.IsOpenMainBattlePass = obj.IsOpenMainBattlePass;
				this.IsOpenDarkBattlePass = obj.IsOpenDarkBattlePass;
				this.IsOpenOppoEntra = obj.IsOpenOppoEntra;

				this.BehaviorCalc_A1 = obj.BehaviorCalc_A1;
				this.BehaviorCalc_A3 = obj.BehaviorCalc_A3;
				this.BehaviorCalc_B1 = obj.BehaviorCalc_B1;
				this.BehaviorCalc_B2 = obj.BehaviorCalc_B2;
				this.BehaviorCalc_B3 = obj.BehaviorCalc_B3;
				this.BehaviorCalc_C1 = obj.BehaviorCalc_C1;
				this.BehaviorCalc_C2 = obj.BehaviorCalc_C2;
				this.BehaviorCalc_D1 = obj.BehaviorCalc_D1;
				this.BehaviorCalc_D2 = obj.BehaviorCalc_D2;
				this.HugeSuccClueMultiplier = obj.HugeSuccClueMultiplier;
				this.RumorReduceRate = obj.RumorReduceRate;
				this.GuideTipTime = obj.GuideTipTime;
				this.NextLogFadeTime = obj.NextLogFadeTime;
				this.WaitNextLogTime = obj.WaitNextLogTime;
				this.HeartBeatBeginTime = obj.HeartBeatBeginTime;
				this.HeartBeatScale = obj.HeartBeatScale;
				this.HeartBeatTime = obj.HeartBeatTime;
				this.HeartBeatCVTime = obj.HeartBeatCVTime;
				this.HeartBeatProTime = obj.HeartBeatProTime;
				this.FirstGiftThreshold = obj.FirstGiftThreshold;

				this.ActivityAwardList = obj.ActivityAwardList;

        }
    }
}
