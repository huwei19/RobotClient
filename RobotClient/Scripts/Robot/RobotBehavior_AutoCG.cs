using LiteNet;
using ProtobufPacket;
using System;
using UnityEngine;
public partial class Robot {
	public bool SendRandomPacket(int packetID)
	{
		switch(packetID)
		{
			case ((int)MessageID.CG_LOGIN): 
			{
				CG_LOGIN packet = new CG_LOGIN();
				packet.logintype =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.gameversion =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.programversion =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.forceenter =UnityEngine.Random.Range(0, 1) == 0;
				packet.maxpacketid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.accountname =GetRandomString();
				packet.token =GetRandomString();
				packet.bios =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.bimac =GetRandomString();
				packet.rapidvalidatecode =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.autoselectroleguid =(ulong)UnityEngine.Random.Range(0, ulong.MaxValue - 1);
				packet.onepushid =GetRandomString();
				packet.accountactivation =GetRandomString();
				packet.mediaid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.phonemodel =GetRandomString();
				packet.resversion =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.selectworldid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.runninglevelid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.uuid =GetRandomString();
				packet.MemorySize =(long)UnityEngine.Random.Range(0, long.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GMCMDSTR): 
			{
				CG_GMCMDSTR packet = new CG_GMCMDSTR();
				packet.cmdstr =GetRandomString();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CREATE_USER): 
			{
				CG_CREATE_USER packet = new CG_CREATE_USER();
				packet.name =GetRandomString();
				packet.sex =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.dyeColorItem.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				packet.skin =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ITEM_USE): 
			{
				CG_ITEM_USE packet = new CG_ITEM_USE();
				packet.itemguid =(ulong)UnityEngine.Random.Range(0, ulong.MaxValue - 1);
				packet.itemNum =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.itemSele.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MAIL_OPERATION): 
			{
				CG_MAIL_OPERATION packet = new CG_MAIL_OPERATION();
				packet.OperationType =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.MailGuid =(ulong)UnityEngine.Random.Range(0, ulong.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ITEM_SELL): 
			{
				CG_ITEM_SELL packet = new CG_ITEM_SELL();
				packet.packtype =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.itemguid =(ulong)UnityEngine.Random.Range(0, ulong.MaxValue - 1);
				packet.itemNum =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_REQ_CHANGENAME): 
			{
				CG_REQ_CHANGENAME packet = new CG_REQ_CHANGENAME();
				packet.name =GetRandomString();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_FATELINE_ACTIVE): 
			{
				CG_FATELINE_ACTIVE packet = new CG_FATELINE_ACTIVE();
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_FATELINE_SELECT): 
			{
				CG_FATELINE_SELECT packet = new CG_FATELINE_SELECT();
				packet.CharacterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_FATELINE_AWARD): 
			{
				CG_FATELINE_AWARD packet = new CG_FATELINE_AWARD();
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Level =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_PERSONALITY_LEVELUP): 
			{
				CG_PERSONALITY_LEVELUP packet = new CG_PERSONALITY_LEVELUP();
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.PersonalityId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_PERSONALITY_ADD): 
			{
				CG_PERSONALITY_ADD packet = new CG_PERSONALITY_ADD();
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.PersonalityId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.ItemNum =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DRESSUP): 
			{
				CG_DRESSUP packet = new CG_DRESSUP();
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.DressInfo =new _DressInfo();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SKIN_UNLOCK): 
			{
				CG_SKIN_UNLOCK packet = new CG_SKIN_UNLOCK();
				packet.SkinId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DRESS_UNLOCK): 
			{
				CG_DRESS_UNLOCK packet = new CG_DRESS_UNLOCK();
				packet.DressId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_QUESTION_ANSWER): 
			{
				CG_QUESTION_ANSWER packet = new CG_QUESTION_ANSWER();
				packet.rpcid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.QuestionId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.OptionId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.TypeId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.PId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MONOLOGUE_UNLOCK): 
			{
				CG_MONOLOGUE_UNLOCK packet = new CG_MONOLOGUE_UNLOCK();
				packet.FateLineId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.MonologueId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORY_LEVEL_START): 
			{
				CG_STORY_LEVEL_START packet = new CG_STORY_LEVEL_START();
				packet.rpcid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.CardIds.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				packet.SavePointId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORY_LEVEL_FINISH): 
			{
				CG_STORY_LEVEL_FINISH packet = new CG_STORY_LEVEL_FINISH();
				packet.rpcid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.LevelResult =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.ConfidenceDelta =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.CustomRewardIds.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				packet.BehaviorHugeSuccCount =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.isSpec =UnityEngine.Random.Range(0, 1) == 0;
				packet.StoryData =new _STORY_INST();
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.switchRoleIds.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.AlbumIds.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				packet.SavePoints =new _LevelSavePoint();
				packet.PerceptUsedCount =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.PerceptUsedSceneEventIds.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				packet.LevelData =new _StoryLevel();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_UNLOCK_SCENEEVENT_HINT): 
			{
				CG_UNLOCK_SCENEEVENT_HINT packet = new CG_UNLOCK_SCENEEVENT_HINT();
				packet.LevelId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.SceneEventId =GetRandomString();
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.TagIds.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				packet.EventId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORY_CHAPTER_REWIND): 
			{
				CG_STORY_CHAPTER_REWIND packet = new CG_STORY_CHAPTER_REWIND();
				packet.rpcid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.ChapterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.RewindToLevelId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORY_CHAPTER_RESOLVE_ENDING): 
			{
				CG_STORY_CHAPTER_RESOLVE_ENDING packet = new CG_STORY_CHAPTER_RESOLVE_ENDING();
				packet.rpcid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.ChapterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.Objectives.Add(GetRandomString());
				}
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORY_CHAPTER_SELECT_ENDING): 
			{
				CG_STORY_CHAPTER_SELECT_ENDING packet = new CG_STORY_CHAPTER_SELECT_ENDING();
				packet.rpcid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.ChapterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Rank =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_LEVELUP): 
			{
				CG_CARD_LEVELUP packet = new CG_CARD_LEVELUP();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.ItemId.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.ItemCount.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				packet.IsDirect =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_MAKE): 
			{
				CG_CARD_MAKE packet = new CG_CARD_MAKE();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.MakeCount =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_RESOLVE): 
			{
				CG_CARD_RESOLVE packet = new CG_CARD_RESOLVE();
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.CardId.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.CardCount.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_VISUAL_CARD): 
			{
				CG_VISUAL_CARD packet = new CG_VISUAL_CARD();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SIGNATURE): 
			{
				CG_SIGNATURE packet = new CG_SIGNATURE();
				packet.Signature =GetRandomString();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_FILE_UNLOCK): 
			{
				CG_CARD_FILE_UNLOCK packet = new CG_CARD_FILE_UNLOCK();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.FileLevel =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_FILE_AWARD): 
			{
				CG_CARD_FILE_AWARD packet = new CG_CARD_FILE_AWARD();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.FileLevel =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_ENHANCE): 
			{
				CG_CARD_ENHANCE packet = new CG_CARD_ENHANCE();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_BUY_GOLD): 
			{
				CG_BUY_GOLD packet = new CG_BUY_GOLD();
				packet.BuyTimes =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_BUY_STAMINA): 
			{
				CG_BUY_STAMINA packet = new CG_BUY_STAMINA();
				packet.BuyTimes =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MISSION_ACCEPT): 
			{
				CG_MISSION_ACCEPT packet = new CG_MISSION_ACCEPT();
				packet.MisId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MISSION_COMMIT): 
			{
				CG_MISSION_COMMIT packet = new CG_MISSION_COMMIT();
				packet.MisId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MISSION_DO): 
			{
				CG_MISSION_DO packet = new CG_MISSION_DO();
				packet.MisId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Param =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CONTACTS_REMARK): 
			{
				CG_CONTACTS_REMARK packet = new CG_CONTACTS_REMARK();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Remark =GetRandomString();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RUMOR_REDUCE): 
			{
				CG_RUMOR_REDUCE packet = new CG_RUMOR_REDUCE();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.MultiNum =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RUMOR_REDUCE_AWARD): 
			{
				CG_RUMOR_REDUCE_AWARD packet = new CG_RUMOR_REDUCE_AWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RUMOR_BURST_AWARD): 
			{
				CG_RUMOR_BURST_AWARD packet = new CG_RUMOR_BURST_AWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RUMOR_RESET): 
			{
				CG_RUMOR_RESET packet = new CG_RUMOR_RESET();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_VCHAT_OPTION): 
			{
				CG_VCHAT_OPTION packet = new CG_VCHAT_OPTION();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Option =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RECHARGE_DIAMOND): 
			{
				CG_RECHARGE_DIAMOND packet = new CG_RECHARGE_DIAMOND();
				packet.shopId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_VCHAT_LASTMSG): 
			{
				CG_VCHAT_LASTMSG packet = new CG_VCHAT_LASTMSG();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.MsgId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.IsFinish =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_VCHAT_VOICE): 
			{
				CG_VCHAT_VOICE packet = new CG_VCHAT_VOICE();
				packet.VoiceId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CIRCLE_CREATE): 
			{
				CG_CIRCLE_CREATE packet = new CG_CIRCLE_CREATE();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.AtTargetId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CIRCLE_REPLY): 
			{
				CG_CIRCLE_REPLY packet = new CG_CIRCLE_REPLY();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.ReplyId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACCEPT_FRIEND): 
			{
				CG_ACCEPT_FRIEND packet = new CG_ACCEPT_FRIEND();
				packet.FriendId =(long)UnityEngine.Random.Range(0, long.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DEL_FRIEND): 
			{
				CG_DEL_FRIEND packet = new CG_DEL_FRIEND();
				packet.FriendId =(long)UnityEngine.Random.Range(0, long.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_REFUSE_FRIEND): 
			{
				CG_REFUSE_FRIEND packet = new CG_REFUSE_FRIEND();
				packet.FriendId =(long)UnityEngine.Random.Range(0, long.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RECMMEND_UPDATA_FRIEND): 
			{
				CG_RECMMEND_UPDATA_FRIEND packet = new CG_RECMMEND_UPDATA_FRIEND();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SEARCH_FRIEND): 
			{
				CG_SEARCH_FRIEND packet = new CG_SEARCH_FRIEND();
				packet.IsName =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.name =GetRandomString();
				packet.Guid =(ulong)UnityEngine.Random.Range(0, ulong.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_PARTICULARS_FRIEND): 
			{
				CG_PARTICULARS_FRIEND packet = new CG_PARTICULARS_FRIEND();
				packet.FriendId =(long)UnityEngine.Random.Range(0, long.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SEARCH_ADD_FRIEND): 
			{
				CG_SEARCH_ADD_FRIEND packet = new CG_SEARCH_ADD_FRIEND();
				packet.FriendId =(long)UnityEngine.Random.Range(0, long.MaxValue - 1);
				packet.FriendName =GetRandomString();
				packet.FriendLevel =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DRAW_CARD): 
			{
				CG_DRAW_CARD packet = new CG_DRAW_CARD();
				packet.DrawType =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.IsMulti =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DRAW_CARD_AWARD): 
			{
				CG_DRAW_CARD_AWARD packet = new CG_DRAW_CARD_AWARD();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SHOP_BUY): 
			{
				CG_SHOP_BUY packet = new CG_SHOP_BUY();
				packet.GoodsId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.BuyNum =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_LOG_REPORT): 
			{
				CG_LOG_REPORT packet = new CG_LOG_REPORT();
				packet.LogType =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Msg =GetRandomString();
				packet.StackTrace =GetRandomString();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DRAW_CARD_SWITCH): 
			{
				CG_DRAW_CARD_SWITCH packet = new CG_DRAW_CARD_SWITCH();
				packet.SwitchType =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SYNC_FRIEND): 
			{
				CG_SYNC_FRIEND packet = new CG_SYNC_FRIEND();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ALBUM_AWARD): 
			{
				CG_ALBUM_AWARD packet = new CG_ALBUM_AWARD();
				packet.AlbumId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_STAR_LEVELUP): 
			{
				CG_CARD_STAR_LEVELUP packet = new CG_CARD_STAR_LEVELUP();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CITYWORK_RECEIVE_TASK): 
			{
				CG_CITYWORK_RECEIVE_TASK packet = new CG_CITYWORK_RECEIVE_TASK();
				packet.cityId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.taskId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.cardid.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				packet.taskIdx =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.timeId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CITYWORK_GET_TASK): 
			{
				CG_CITYWORK_GET_TASK packet = new CG_CITYWORK_GET_TASK();
				packet.cityId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.taskId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.taskIdx =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GET_TASK): 
			{
				CG_GET_TASK packet = new CG_GET_TASK();
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.taskId.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GET_EVERY_TASK): 
			{
				CG_GET_EVERY_TASK packet = new CG_GET_EVERY_TASK();
				packet.awardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_CHANGE_FACE): 
			{
				CG_CARD_CHANGE_FACE packet = new CG_CARD_CHANGE_FACE();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.IsAdvanceFace =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RUMOR_SUB_TIME): 
			{
				CG_RUMOR_SUB_TIME packet = new CG_RUMOR_SUB_TIME();
				packet.rumorid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.index =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_PLOT_FINISH): 
			{
				CG_PLOT_FINISH packet = new CG_PLOT_FINISH();
				packet.PlotId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORY_START_ACTION): 
			{
				CG_STORY_START_ACTION packet = new CG_STORY_START_ACTION();
				packet.StoryId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.SectionId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.ActionId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.ActionCode =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SIGN): 
			{
				CG_SIGN packet = new CG_SIGN();
				packet.isSign =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MAINCITY_INTERACTIVE): 
			{
				CG_MAINCITY_INTERACTIVE packet = new CG_MAINCITY_INTERACTIVE();
				packet.archId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CDKEY_AWARD): 
			{
				CG_CDKEY_AWARD packet = new CG_CDKEY_AWARD();
				packet.CDKey =GetRandomString();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACTIVE_FATE_AUTO): 
			{
				CG_ACTIVE_FATE_AUTO packet = new CG_ACTIVE_FATE_AUTO();
				packet.CharacterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DAILY_STAMINA): 
			{
				CG_DAILY_STAMINA packet = new CG_DAILY_STAMINA();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.IsBuy =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CITYWORK_CLICKBUBBLE): 
			{
				CG_CITYWORK_CLICKBUBBLE packet = new CG_CITYWORK_CLICKBUBBLE();
				packet.rumorid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CITYWORK_OPENRUMOR): 
			{
				CG_CITYWORK_OPENRUMOR packet = new CG_CITYWORK_OPENRUMOR();
				packet.rumorid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_NPC_GETGIFT): 
			{
				CG_NPC_GETGIFT packet = new CG_NPC_GETGIFT();
				packet.npcid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CHANGE_PUSH_STATE): 
			{
				CG_CHANGE_PUSH_STATE packet = new CG_CHANGE_PUSH_STATE();
				packet.IsPushStamina =UnityEngine.Random.Range(0, 1) == 0;
				packet.IsPushInlineShop =UnityEngine.Random.Range(0, 1) == 0;
				packet.IsPushRumorHottes =UnityEngine.Random.Range(0, 1) == 0;
				packet.IsPushGetStamina =UnityEngine.Random.Range(0, 1) == 0;
				packet.IsPushCityTask =UnityEngine.Random.Range(0, 1) == 0;
				packet.IsOpenNoDisturbing =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORY_CHAPTER_UNLOCK): 
			{
				CG_STORY_CHAPTER_UNLOCK packet = new CG_STORY_CHAPTER_UNLOCK();
				packet.ChapterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_PERSONAL_STORY_UNLOCK): 
			{
				CG_PERSONAL_STORY_UNLOCK packet = new CG_PERSONAL_STORY_UNLOCK();
				packet.ChracterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_PERSONAL_STORY_GET_AWARD): 
			{
				CG_PERSONAL_STORY_GET_AWARD packet = new CG_PERSONAL_STORY_GET_AWARD();
				packet.ChapterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.AwardIndex =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GUIDE_SAVE): 
			{
				CG_GUIDE_SAVE packet = new CG_GUIDE_SAVE();
				packet.guideId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ADD_SIGN_LIST): 
			{
				CG_ADD_SIGN_LIST packet = new CG_ADD_SIGN_LIST();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ADD_SIGN_GET_AWARD): 
			{
				CG_ADD_SIGN_GET_AWARD packet = new CG_ADD_SIGN_GET_AWARD();
				packet.actId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.awardIndex =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CHENGHAO_LIST): 
			{
				CG_CHENGHAO_LIST packet = new CG_CHENGHAO_LIST();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SELECT_CHENGHAO): 
			{
				CG_SELECT_CHENGHAO packet = new CG_SELECT_CHENGHAO();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CHENGHAO): 
			{
				CG_CHENGHAO packet = new CG_CHENGHAO();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SURVERY): 
			{
				CG_SURVERY packet = new CG_SURVERY();
				packet.surveryId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GIVE_FRIEND): 
			{
				CG_GIVE_FRIEND packet = new CG_GIVE_FRIEND();
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.friendId.Add((long)UnityEngine.Random.Range(0, long.MaxValue - 1));
				}
				packet.isOne =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORY_QUICK_START): 
			{
				CG_STORY_QUICK_START packet = new CG_STORY_QUICK_START();
				packet.LevelId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_HEART_BEAT): 
			{
				CG_HEART_BEAT packet = new CG_HEART_BEAT();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_HEART_BEAT_USE_COUNT): 
			{
				CG_HEART_BEAT_USE_COUNT packet = new CG_HEART_BEAT_USE_COUNT();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_HEART_BEAT_START): 
			{
				CG_HEART_BEAT_START packet = new CG_HEART_BEAT_START();
				packet.HeartBeatId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_HEART_BEAT_PROGRESS): 
			{
				CG_HEART_BEAT_PROGRESS packet = new CG_HEART_BEAT_PROGRESS();
				packet.HeartBeatId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.QuesstionOrder =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.QuesstionNum =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.QuesstionState =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_HEART_BEAT_FNISH): 
			{
				CG_HEART_BEAT_FNISH packet = new CG_HEART_BEAT_FNISH();
				packet.HeartBeatId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.QuestIdNum.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_INTERFLOW): 
			{
				CG_INTERFLOW packet = new CG_INTERFLOW();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_INTERFLOW_SELECT): 
			{
				CG_INTERFLOW_SELECT packet = new CG_INTERFLOW_SELECT();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ARTICLE_READ): 
			{
				CG_ARTICLE_READ packet = new CG_ARTICLE_READ();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ARTICLE_FORWARD): 
			{
				CG_ARTICLE_FORWARD packet = new CG_ARTICLE_FORWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.Idx =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SHARE_SUCC): 
			{
				CG_SHARE_SUCC packet = new CG_SHARE_SUCC();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SECRET_QTE): 
			{
				CG_SECRET_QTE packet = new CG_SECRET_QTE();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_APPOINTMENT_OPEN): 
			{
				CG_APPOINTMENT_OPEN packet = new CG_APPOINTMENT_OPEN();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_APPOINTMENT_FINISH): 
			{
				CG_APPOINTMENT_FINISH packet = new CG_APPOINTMENT_FINISH();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.SelectIndex =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SECRET_LINK): 
			{
				CG_SECRET_LINK packet = new CG_SECRET_LINK();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SECRET_GET_AWARD): 
			{
				CG_SECRET_GET_AWARD packet = new CG_SECRET_GET_AWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_APPOINTMENT_START): 
			{
				CG_APPOINTMENT_START packet = new CG_APPOINTMENT_START();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_OPENGIFT_START): 
			{
				CG_OPENGIFT_START packet = new CG_OPENGIFT_START();
				packet.FateId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.GiftId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_APPOINTMENT_PANEL): 
			{
				CG_APPOINTMENT_PANEL packet = new CG_APPOINTMENT_PANEL();
				packet.FateId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CITYWORK_REVOCATION_TASK): 
			{
				CG_CITYWORK_REVOCATION_TASK packet = new CG_CITYWORK_REVOCATION_TASK();
				packet.cityId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.taskId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.taskIdx =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_VCHAT_UNLOCK): 
			{
				CG_VCHAT_UNLOCK packet = new CG_VCHAT_UNLOCK();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_ABILITYUP): 
			{
				CG_CARD_ABILITYUP packet = new CG_CARD_ABILITYUP();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.abilityId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ALBUM_LEVELUP): 
			{
				CG_ALBUM_LEVELUP packet = new CG_ALBUM_LEVELUP();
				packet.Level =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ALBUM_ACTIVE): 
			{
				CG_ALBUM_ACTIVE packet = new CG_ALBUM_ACTIVE();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ALBUM_ACTIVE_CARD): 
			{
				CG_ALBUM_ACTIVE_CARD packet = new CG_ALBUM_ACTIVE_CARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACTIVITY): 
			{
				CG_ACTIVITY packet = new CG_ACTIVITY();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CITY_COPY_GET_COMMON_AWARD): 
			{
				CG_CITY_COPY_GET_COMMON_AWARD packet = new CG_CITY_COPY_GET_COMMON_AWARD();
				packet.CopyId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CITY_COPY_GET_FAST_AWARD): 
			{
				CG_CITY_COPY_GET_FAST_AWARD packet = new CG_CITY_COPY_GET_FAST_AWARD();
				packet.CopyId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_FLOOR_CLICK): 
			{
				CG_FLOOR_CLICK packet = new CG_FLOOR_CLICK();
				packet.FloorId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CITY_COPY_AWARD_PANEL): 
			{
				CG_CITY_COPY_AWARD_PANEL packet = new CG_CITY_COPY_AWARD_PANEL();
				packet.CopyId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.IsFast =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_REQUEST_PURCHASE_INFO): 
			{
				CG_REQUEST_PURCHASE_INFO packet = new CG_REQUEST_PURCHASE_INFO();
				packet.goodId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_INTERACTIVE_REWARD): 
			{
				CG_INTERACTIVE_REWARD packet = new CG_INTERACTIVE_REWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ADD_CHARACTER): 
			{
				CG_ADD_CHARACTER packet = new CG_ADD_CHARACTER();
				packet.CharacterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CARD_TRAINLEVEL): 
			{
				CG_CARD_TRAINLEVEL packet = new CG_CARD_TRAINLEVEL();
				packet.CardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GET_CARD_SHAREREWARD): 
			{
				CG_GET_CARD_SHAREREWARD packet = new CG_GET_CARD_SHAREREWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GET_ALBUM_SHAREREWARD): 
			{
				CG_GET_ALBUM_SHAREREWARD packet = new CG_GET_ALBUM_SHAREREWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MONTHCARD_RECEIVEREWARD): 
			{
				CG_MONTHCARD_RECEIVEREWARD packet = new CG_MONTHCARD_RECEIVEREWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_FUND_RECEIVELEVELREWARD): 
			{
				CG_FUND_RECEIVELEVELREWARD packet = new CG_FUND_RECEIVELEVELREWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MONTHCARD_CHOUKATIP): 
			{
				CG_MONTHCARD_CHOUKATIP packet = new CG_MONTHCARD_CHOUKATIP();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACTIVITY_RECHARGE_RECEIVEREWARD): 
			{
				CG_ACTIVITY_RECHARGE_RECEIVEREWARD packet = new CG_ACTIVITY_RECHARGE_RECEIVEREWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACTIVITY_RECHARGE): 
			{
				CG_ACTIVITY_RECHARGE packet = new CG_ACTIVITY_RECHARGE();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_FRISTGIFT_RECEIVEREWARD): 
			{
				CG_FRISTGIFT_RECEIVEREWARD packet = new CG_FRISTGIFT_RECEIVEREWARD();
				packet.Id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SYNC_AIBUMLOCK): 
			{
				CG_SYNC_AIBUMLOCK packet = new CG_SYNC_AIBUMLOCK();
				packet.IsLock =UnityEngine.Random.Range(0, 1) == 0;
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SAVEPOINT): 
			{
				CG_SAVEPOINT packet = new CG_SAVEPOINT();
				packet.SavePointInfo =new _SavePoint();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SAVEPOINT_GET): 
			{
				CG_SAVEPOINT_GET packet = new CG_SAVEPOINT_GET();
				packet.LevelId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.SavepointId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GUIDE_STEP_ID): 
			{
				CG_GUIDE_STEP_ID packet = new CG_GUIDE_STEP_ID();
				packet.guideId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RUMOR_MULTI_STOP): 
			{
				CG_RUMOR_MULTI_STOP packet = new CG_RUMOR_MULTI_STOP();
				packet.rumorId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CLICK_CARDFRAME): 
			{
				CG_CLICK_CARDFRAME packet = new CG_CLICK_CARDFRAME();
				packet.CardFrameId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SELECT_CARDFRAME): 
			{
				CG_SELECT_CARDFRAME packet = new CG_SELECT_CARDFRAME();
				packet.CardFrameId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_PHONE_BINDING): 
			{
				CG_PHONE_BINDING packet = new CG_PHONE_BINDING();
				packet.CardFrameId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CLICK_TITLE): 
			{
				CG_CLICK_TITLE packet = new CG_CLICK_TITLE();
				packet.TileId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DIVINATION_GET): 
			{
				CG_DIVINATION_GET packet = new CG_DIVINATION_GET();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_MUSICDIVINATION_GET): 
			{
				CG_MUSICDIVINATION_GET packet = new CG_MUSICDIVINATION_GET();
				packet.divinationMusic =GetRandomString();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DIVINATIONREWARD_GET): 
			{
				CG_DIVINATIONREWARD_GET packet = new CG_DIVINATIONREWARD_GET();
				packet.rewardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DIVINATIONACTIVATE_GET): 
			{
				CG_DIVINATIONACTIVATE_GET packet = new CG_DIVINATIONACTIVATE_GET();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SEE_CHAPTER): 
			{
				CG_SEE_CHAPTER packet = new CG_SEE_CHAPTER();
				packet.chapterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_BUG_FREEGIFT): 
			{
				CG_BUG_FREEGIFT packet = new CG_BUG_FREEGIFT();
				packet.giftId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SYNC_TASK): 
			{
				CG_SYNC_TASK packet = new CG_SYNC_TASK();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SYNC_LOTTERY): 
			{
				CG_SYNC_LOTTERY packet = new CG_SYNC_LOTTERY();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_CONVERT_LOTTERY): 
			{
				CG_CONVERT_LOTTERY packet = new CG_CONVERT_LOTTERY();
				packet.buyItemNum =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_DRAW_LOTTERY): 
			{
				CG_DRAW_LOTTERY packet = new CG_DRAW_LOTTERY();
				packet.num =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACTIVEATE_SIGNBOARD): 
			{
				CG_ACTIVEATE_SIGNBOARD packet = new CG_ACTIVEATE_SIGNBOARD();
				packet.SignboardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACTIVEATE_DECALS): 
			{
				CG_ACTIVEATE_DECALS packet = new CG_ACTIVEATE_DECALS();
				packet.DecalsId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SAVE_SIGNBOARDPALETTE): 
			{
				CG_SAVE_SIGNBOARDPALETTE packet = new CG_SAVE_SIGNBOARDPALETTE();
				packet.SignboardPaletteInfo =new _DBSignboardPalette();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SAVE_THEMEPALETTE): 
			{
				CG_SAVE_THEMEPALETTE packet = new CG_SAVE_THEMEPALETTE();
				packet.ThemePaletteInfo =new _DBThemePalette();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_GET_THEMEAWARD): 
			{
				CG_GET_THEMEAWARD packet = new CG_GET_THEMEAWARD();
				packet.themeId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SYNS_NPCTASK): 
			{
				CG_SYNS_NPCTASK packet = new CG_SYNS_NPCTASK();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_NPCTASK_COMPLETE): 
			{
				CG_NPCTASK_COMPLETE packet = new CG_NPCTASK_COMPLETE();
				packet.npctaskid =UnityEngine.Random.Range(0, int.MaxValue - 1);
				for(int i=0; i<UnityEngine.Random.Range(0, 100); i++) {
					packet.questioninfo.Add(UnityEngine.Random.Range(0, int.MaxValue - 1));
				}
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RECEIVE_TESTAWARD): 
			{
				CG_RECEIVE_TESTAWARD packet = new CG_RECEIVE_TESTAWARD();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_QUERY_TESTAWARD): 
			{
				CG_QUERY_TESTAWARD packet = new CG_QUERY_TESTAWARD();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACTIVITY_RIDDLECAGE): 
			{
				CG_ACTIVITY_RIDDLECAGE packet = new CG_ACTIVITY_RIDDLECAGE();
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_ACTIVITY_RIDDLECAGE_RECEIVEREWARD): 
			{
				CG_ACTIVITY_RIDDLECAGE_RECEIVEREWARD packet = new CG_ACTIVITY_RIDDLECAGE_RECEIVEREWARD();
				packet.id =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RECEIVE_BPTASKAWARD): 
			{
				CG_RECEIVE_BPTASKAWARD packet = new CG_RECEIVE_BPTASKAWARD();
				packet.taskId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.BPTaskType =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_RECEIVEALL_BPTASKAWARD): 
			{
				CG_RECEIVEALL_BPTASKAWARD packet = new CG_RECEIVEALL_BPTASKAWARD();
				packet.BattlePassId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_STORYCHAPTER_FRIENDHINT): 
			{
				CG_STORYCHAPTER_FRIENDHINT packet = new CG_STORYCHAPTER_FRIENDHINT();
				packet.rank =UnityEngine.Random.Range(0, int.MaxValue - 1);
				packet.storyChapterId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			case ((int)MessageID.CG_SELECT_OPTIONALUPCARD): 
			{
				CG_SELECT_OPTIONALUPCARD packet = new CG_SELECT_OPTIONALUPCARD();
				packet.cardId =UnityEngine.Random.Range(0, int.MaxValue - 1);
				NetManager.SendMsg(packet);

			}
			break;
			default:
				return false;
		}
		return true;
	}
	public string GetRandomString()
	{
		string retStr = "";
		for(int i=0; i< UnityEngine.Random.Range(0, 1000); i++)
		{
			retStr += (Char)UnityEngine.Random.Range(0, Char.MaxValue-1);
		}
		return retStr;
	}
	public byte[] GetRandomByte()
	{
		int randomValue = UnityEngine.Random.Range(0, 1000);
		if(randomValue == 0) {return null;}
		byte[] retByte = new byte[randomValue];
		for(int i=0; i<randomValue; i++)
		{
			retByte[i] = (byte)UnityEngine.Random.Range(0, byte.MaxValue - 1);
		}
		return retByte;
	}
}
