//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using UnityEngine;
 using System.IO;

namespace Games.Table{
public delegate T SerializableTable<T>(string[] valuesList, int skey);
 public delegate T SerializableTableLong<T>(string[] valuesList, long skey);
 [Serializable]
 public class TableManager
 {
 [SLua.DoNotToLua]
 public static bool ReaderPList<T>(string xmlFile, SerializableTable<T> _fun, Dictionary<int, List<T> > _hash)
 {
 return TabReader.ReaderPList(xmlFile,_fun,_hash); }
 public static bool ReaderPListLong<T>(string xmlFile, SerializableTableLong<T> _fun, Dictionary<long, List<T> > _hash)
 {
 return TabReader.ReaderPListLong(xmlFile,_fun,_hash); }
 [SLua.DoNotToLua]
 public static int ConvertToInt32(string value)
 {
 int v = -1;
 #if UNITY_EDITOR
 if (!int.TryParse(value, out v)) {
 Debug.LogError("Parse Table Value Failed.");
 } 
 #else
 int.TryParse(value, out v); 
 #endif
 return v;
 }
 [SLua.DoNotToLua]
 public static long ConvertToInt64(string value)
 {
 long v = -1;
 #if UNITY_EDITOR
 if (!long.TryParse(value, out v)) {
 Debug.LogError("Parse Table Value Failed.");
 } 
 #else
 long.TryParse(value, out v); 
 #endif
 return v;
 }
 [SLua.DoNotToLua]
 public static float ConvertToSingle(string value)
 {
 float v = -1;
 #if UNITY_EDITOR
 if (!float.TryParse(value, out v)) {
 Debug.LogError("Parse Table Value Failed.");
 } 
 #else
 float.TryParse(value, out v); 
 #endif
 return v;
 }

private static Dictionary<int, List<Tab_AbilityClue> > g_AbilityClue = new Dictionary<int, List<Tab_AbilityClue> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AbilityClue()
 {
 g_AbilityClue.Clear();
 if (!Tab_AbilityClue.LoadTable(g_AbilityClue)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AbilityData> > g_AbilityData = new Dictionary<int, List<Tab_AbilityData> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AbilityData()
 {
 g_AbilityData.Clear();
 if (!Tab_AbilityData.LoadTable(g_AbilityData)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AbilityDataEx> > g_AbilityDataEx = new Dictionary<int, List<Tab_AbilityDataEx> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AbilityDataEx()
 {
 g_AbilityDataEx.Clear();
 if (!Tab_AbilityDataEx.LoadTable(g_AbilityDataEx)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Action> > g_Action = new Dictionary<int, List<Tab_Action> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Action()
 {
 g_Action.Clear();
 if (!Tab_Action.LoadTable(g_Action)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ActionAvatarEvent> > g_ActionAvatarEvent = new Dictionary<int, List<Tab_ActionAvatarEvent> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ActionAvatarEvent()
 {
 g_ActionAvatarEvent.Clear();
 if (!Tab_ActionAvatarEvent.LoadTable(g_ActionAvatarEvent)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ActionReview> > g_ActionReview = new Dictionary<int, List<Tab_ActionReview> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ActionReview()
 {
 g_ActionReview.Clear();
 if (!Tab_ActionReview.LoadTable(g_ActionReview)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ActionSkip> > g_ActionSkip = new Dictionary<int, List<Tab_ActionSkip> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ActionSkip()
 {
 g_ActionSkip.Clear();
 if (!Tab_ActionSkip.LoadTable(g_ActionSkip)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AlbumCard> > g_AlbumCard = new Dictionary<int, List<Tab_AlbumCard> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AlbumCard()
 {
 g_AlbumCard.Clear();
 if (!Tab_AlbumCard.LoadTable(g_AlbumCard)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AlbumLevel> > g_AlbumLevel = new Dictionary<int, List<Tab_AlbumLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AlbumLevel()
 {
 g_AlbumLevel.Clear();
 if (!Tab_AlbumLevel.LoadTable(g_AlbumLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AlbumStory> > g_AlbumStory = new Dictionary<int, List<Tab_AlbumStory> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AlbumStory()
 {
 g_AlbumStory.Clear();
 if (!Tab_AlbumStory.LoadTable(g_AlbumStory)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AlbumStorySub> > g_AlbumStorySub = new Dictionary<int, List<Tab_AlbumStorySub> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AlbumStorySub()
 {
 g_AlbumStorySub.Clear();
 if (!Tab_AlbumStorySub.LoadTable(g_AlbumStorySub)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Appointment> > g_Appointment = new Dictionary<int, List<Tab_Appointment> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Appointment()
 {
 g_Appointment.Clear();
 if (!Tab_Appointment.LoadTable(g_Appointment)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Article> > g_Article = new Dictionary<int, List<Tab_Article> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Article()
 {
 g_Article.Clear();
 if (!Tab_Article.LoadTable(g_Article)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ArticleDetail> > g_ArticleDetail = new Dictionary<int, List<Tab_ArticleDetail> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ArticleDetail()
 {
 g_ArticleDetail.Clear();
 if (!Tab_ArticleDetail.LoadTable(g_ArticleDetail)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ArticleOfficialAccount> > g_ArticleOfficialAccount = new Dictionary<int, List<Tab_ArticleOfficialAccount> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ArticleOfficialAccount()
 {
 g_ArticleOfficialAccount.Clear();
 if (!Tab_ArticleOfficialAccount.LoadTable(g_ArticleOfficialAccount)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ArticleReply> > g_ArticleReply = new Dictionary<int, List<Tab_ArticleReply> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ArticleReply()
 {
 g_ArticleReply.Clear();
 if (!Tab_ArticleReply.LoadTable(g_ArticleReply)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AssetGroup> > g_AssetGroup = new Dictionary<int, List<Tab_AssetGroup> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AssetGroup()
 {
 g_AssetGroup.Clear();
 if (!Tab_AssetGroup.LoadTable(g_AssetGroup)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AssetList> > g_AssetList = new Dictionary<int, List<Tab_AssetList> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AssetList()
 {
 g_AssetList.Clear();
 if (!Tab_AssetList.LoadTable(g_AssetList)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AttrData> > g_AttrData = new Dictionary<int, List<Tab_AttrData> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AttrData()
 {
 g_AttrData.Clear();
 if (!Tab_AttrData.LoadTable(g_AttrData)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Audio> > g_Audio = new Dictionary<int, List<Tab_Audio> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Audio()
 {
 g_Audio.Clear();
 if (!Tab_Audio.LoadTable(g_Audio)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_AudioAcb> > g_AudioAcb = new Dictionary<int, List<Tab_AudioAcb> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_AudioAcb()
 {
 g_AudioAcb.Clear();
 if (!Tab_AudioAcb.LoadTable(g_AudioAcb)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Avatar> > g_Avatar = new Dictionary<int, List<Tab_Avatar> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Avatar()
 {
 g_Avatar.Clear();
 if (!Tab_Avatar.LoadTable(g_Avatar)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_BattlePass> > g_BattlePass = new Dictionary<int, List<Tab_BattlePass> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_BattlePass()
 {
 g_BattlePass.Clear();
 if (!Tab_BattlePass.LoadTable(g_BattlePass)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_BattlePassTask> > g_BattlePassTask = new Dictionary<int, List<Tab_BattlePassTask> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_BattlePassTask()
 {
 g_BattlePassTask.Clear();
 if (!Tab_BattlePassTask.LoadTable(g_BattlePassTask)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_BattleScript> > g_BattleScript = new Dictionary<int, List<Tab_BattleScript> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_BattleScript()
 {
 g_BattleScript.Clear();
 if (!Tab_BattleScript.LoadTable(g_BattleScript)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_BehaviorCalcNum> > g_BehaviorCalcNum = new Dictionary<int, List<Tab_BehaviorCalcNum> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_BehaviorCalcNum()
 {
 g_BehaviorCalcNum.Clear();
 if (!Tab_BehaviorCalcNum.LoadTable(g_BehaviorCalcNum)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_BundleConfig> > g_BundleConfig = new Dictionary<int, List<Tab_BundleConfig> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_BundleConfig()
 {
 g_BundleConfig.Clear();
 if (!Tab_BundleConfig.LoadTable(g_BundleConfig)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_BuyGold> > g_BuyGold = new Dictionary<int, List<Tab_BuyGold> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_BuyGold()
 {
 g_BuyGold.Clear();
 if (!Tab_BuyGold.LoadTable(g_BuyGold)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_BuyStamina> > g_BuyStamina = new Dictionary<int, List<Tab_BuyStamina> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_BuyStamina()
 {
 g_BuyStamina.Clear();
 if (!Tab_BuyStamina.LoadTable(g_BuyStamina)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CV> > g_CV = new Dictionary<int, List<Tab_CV> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CV()
 {
 g_CV.Clear();
 if (!Tab_CV.LoadTable(g_CV)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Camera> > g_Camera = new Dictionary<int, List<Tab_Camera> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Camera()
 {
 g_Camera.Clear();
 if (!Tab_Camera.LoadTable(g_Camera)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CameraShake> > g_CameraShake = new Dictionary<int, List<Tab_CameraShake> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CameraShake()
 {
 g_CameraShake.Clear();
 if (!Tab_CameraShake.LoadTable(g_CameraShake)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Card> > g_Card = new Dictionary<int, List<Tab_Card> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Card()
 {
 g_Card.Clear();
 if (!Tab_Card.LoadTable(g_Card)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardAsset> > g_CardAsset = new Dictionary<int, List<Tab_CardAsset> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardAsset()
 {
 g_CardAsset.Clear();
 if (!Tab_CardAsset.LoadTable(g_CardAsset)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardAttrGrow> > g_CardAttrGrow = new Dictionary<int, List<Tab_CardAttrGrow> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardAttrGrow()
 {
 g_CardAttrGrow.Clear();
 if (!Tab_CardAttrGrow.LoadTable(g_CardAttrGrow)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardAudio> > g_CardAudio = new Dictionary<int, List<Tab_CardAudio> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardAudio()
 {
 g_CardAudio.Clear();
 if (!Tab_CardAudio.LoadTable(g_CardAudio)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardEnhanceLevel> > g_CardEnhanceLevel = new Dictionary<int, List<Tab_CardEnhanceLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardEnhanceLevel()
 {
 g_CardEnhanceLevel.Clear();
 if (!Tab_CardEnhanceLevel.LoadTable(g_CardEnhanceLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardEx> > g_CardEx = new Dictionary<int, List<Tab_CardEx> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardEx()
 {
 g_CardEx.Clear();
 if (!Tab_CardEx.LoadTable(g_CardEx)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardExpItem> > g_CardExpItem = new Dictionary<int, List<Tab_CardExpItem> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardExpItem()
 {
 g_CardExpItem.Clear();
 if (!Tab_CardExpItem.LoadTable(g_CardExpItem)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardFile> > g_CardFile = new Dictionary<int, List<Tab_CardFile> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardFile()
 {
 g_CardFile.Clear();
 if (!Tab_CardFile.LoadTable(g_CardFile)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardFileLevel> > g_CardFileLevel = new Dictionary<int, List<Tab_CardFileLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardFileLevel()
 {
 g_CardFileLevel.Clear();
 if (!Tab_CardFileLevel.LoadTable(g_CardFileLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardFrame> > g_CardFrame = new Dictionary<int, List<Tab_CardFrame> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardFrame()
 {
 g_CardFrame.Clear();
 if (!Tab_CardFrame.LoadTable(g_CardFrame)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardLevel> > g_CardLevel = new Dictionary<int, List<Tab_CardLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardLevel()
 {
 g_CardLevel.Clear();
 if (!Tab_CardLevel.LoadTable(g_CardLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardPiece> > g_CardPiece = new Dictionary<int, List<Tab_CardPiece> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardPiece()
 {
 g_CardPiece.Clear();
 if (!Tab_CardPiece.LoadTable(g_CardPiece)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardPoolType> > g_CardPoolType = new Dictionary<int, List<Tab_CardPoolType> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardPoolType()
 {
 g_CardPoolType.Clear();
 if (!Tab_CardPoolType.LoadTable(g_CardPoolType)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardResolve> > g_CardResolve = new Dictionary<int, List<Tab_CardResolve> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardResolve()
 {
 g_CardResolve.Clear();
 if (!Tab_CardResolve.LoadTable(g_CardResolve)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardStar> > g_CardStar = new Dictionary<int, List<Tab_CardStar> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardStar()
 {
 g_CardStar.Clear();
 if (!Tab_CardStar.LoadTable(g_CardStar)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardStarItem> > g_CardStarItem = new Dictionary<int, List<Tab_CardStarItem> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardStarItem()
 {
 g_CardStarItem.Clear();
 if (!Tab_CardStarItem.LoadTable(g_CardStarItem)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CardTrain> > g_CardTrain = new Dictionary<int, List<Tab_CardTrain> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CardTrain()
 {
 g_CardTrain.Clear();
 if (!Tab_CardTrain.LoadTable(g_CardTrain)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Channel> > g_Channel = new Dictionary<int, List<Tab_Channel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Channel()
 {
 g_Channel.Clear();
 if (!Tab_Channel.LoadTable(g_Channel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Character> > g_Character = new Dictionary<int, List<Tab_Character> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Character()
 {
 g_Character.Clear();
 if (!Tab_Character.LoadTable(g_Character)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CharacterAsset> > g_CharacterAsset = new Dictionary<int, List<Tab_CharacterAsset> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CharacterAsset()
 {
 g_CharacterAsset.Clear();
 if (!Tab_CharacterAsset.LoadTable(g_CharacterAsset)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CharacterContacts> > g_CharacterContacts = new Dictionary<int, List<Tab_CharacterContacts> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CharacterContacts()
 {
 g_CharacterContacts.Clear();
 if (!Tab_CharacterContacts.LoadTable(g_CharacterContacts)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CharacterIntimacyDialog> > g_CharacterIntimacyDialog = new Dictionary<int, List<Tab_CharacterIntimacyDialog> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CharacterIntimacyDialog()
 {
 g_CharacterIntimacyDialog.Clear();
 if (!Tab_CharacterIntimacyDialog.LoadTable(g_CharacterIntimacyDialog)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Circle> > g_Circle = new Dictionary<int, List<Tab_Circle> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Circle()
 {
 g_Circle.Clear();
 if (!Tab_Circle.LoadTable(g_Circle)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CircleReply> > g_CircleReply = new Dictionary<int, List<Tab_CircleReply> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CircleReply()
 {
 g_CircleReply.Clear();
 if (!Tab_CircleReply.LoadTable(g_CircleReply)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CityCopy> > g_CityCopy = new Dictionary<int, List<Tab_CityCopy> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CityCopy()
 {
 g_CityCopy.Clear();
 if (!Tab_CityCopy.LoadTable(g_CityCopy)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CityCopyFloor> > g_CityCopyFloor = new Dictionary<int, List<Tab_CityCopyFloor> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CityCopyFloor()
 {
 g_CityCopyFloor.Clear();
 if (!Tab_CityCopyFloor.LoadTable(g_CityCopyFloor)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CityCopyFloorDesc> > g_CityCopyFloorDesc = new Dictionary<int, List<Tab_CityCopyFloorDesc> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CityCopyFloorDesc()
 {
 g_CityCopyFloorDesc.Clear();
 if (!Tab_CityCopyFloorDesc.LoadTable(g_CityCopyFloorDesc)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CityWork> > g_CityWork = new Dictionary<int, List<Tab_CityWork> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CityWork()
 {
 g_CityWork.Clear();
 if (!Tab_CityWork.LoadTable(g_CityWork)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CityWorkTask> > g_CityWorkTask = new Dictionary<int, List<Tab_CityWorkTask> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CityWorkTask()
 {
 g_CityWorkTask.Clear();
 if (!Tab_CityWorkTask.LoadTable(g_CityWorkTask)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CityWorkTaskDrop> > g_CityWorkTaskDrop = new Dictionary<int, List<Tab_CityWorkTaskDrop> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CityWorkTaskDrop()
 {
 g_CityWorkTaskDrop.Clear();
 if (!Tab_CityWorkTaskDrop.LoadTable(g_CityWorkTaskDrop)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CommonAward> > g_CommonAward = new Dictionary<int, List<Tab_CommonAward> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CommonAward()
 {
 g_CommonAward.Clear();
 if (!Tab_CommonAward.LoadTable(g_CommonAward)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Condition> > g_Condition = new Dictionary<int, List<Tab_Condition> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Condition()
 {
 g_Condition.Clear();
 if (!Tab_Condition.LoadTable(g_Condition)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CoolDown> > g_CoolDown = new Dictionary<int, List<Tab_CoolDown> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CoolDown()
 {
 g_CoolDown.Clear();
 if (!Tab_CoolDown.LoadTable(g_CoolDown)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_CoolDownTimeInfo> > g_CoolDownTimeInfo = new Dictionary<int, List<Tab_CoolDownTimeInfo> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_CoolDownTimeInfo()
 {
 g_CoolDownTimeInfo.Clear();
 if (!Tab_CoolDownTimeInfo.LoadTable(g_CoolDownTimeInfo)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Device> > g_Device = new Dictionary<int, List<Tab_Device> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Device()
 {
 g_Device.Clear();
 if (!Tab_Device.LoadTable(g_Device)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_DeviceAdapter> > g_DeviceAdapter = new Dictionary<int, List<Tab_DeviceAdapter> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_DeviceAdapter()
 {
 g_DeviceAdapter.Clear();
 if (!Tab_DeviceAdapter.LoadTable(g_DeviceAdapter)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Dialog> > g_Dialog = new Dictionary<int, List<Tab_Dialog> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Dialog()
 {
 g_Dialog.Clear();
 if (!Tab_Dialog.LoadTable(g_Dialog)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_DialogAvatar> > g_DialogAvatar = new Dictionary<int, List<Tab_DialogAvatar> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_DialogAvatar()
 {
 g_DialogAvatar.Clear();
 if (!Tab_DialogAvatar.LoadTable(g_DialogAvatar)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Divination> > g_Divination = new Dictionary<int, List<Tab_Divination> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Divination()
 {
 g_Divination.Clear();
 if (!Tab_Divination.LoadTable(g_Divination)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_DivinationProgress> > g_DivinationProgress = new Dictionary<int, List<Tab_DivinationProgress> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_DivinationProgress()
 {
 g_DivinationProgress.Clear();
 if (!Tab_DivinationProgress.LoadTable(g_DivinationProgress)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_DivinationReward> > g_DivinationReward = new Dictionary<int, List<Tab_DivinationReward> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_DivinationReward()
 {
 g_DivinationReward.Clear();
 if (!Tab_DivinationReward.LoadTable(g_DivinationReward)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_DrawCardAdvanceCard> > g_DrawCardAdvanceCard = new Dictionary<int, List<Tab_DrawCardAdvanceCard> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_DrawCardAdvanceCard()
 {
 g_DrawCardAdvanceCard.Clear();
 if (!Tab_DrawCardAdvanceCard.LoadTable(g_DrawCardAdvanceCard)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_DrawCardNormalCard> > g_DrawCardNormalCard = new Dictionary<int, List<Tab_DrawCardNormalCard> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_DrawCardNormalCard()
 {
 g_DrawCardNormalCard.Clear();
 if (!Tab_DrawCardNormalCard.LoadTable(g_DrawCardNormalCard)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_DrawCardPreview> > g_DrawCardPreview = new Dictionary<int, List<Tab_DrawCardPreview> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_DrawCardPreview()
 {
 g_DrawCardPreview.Clear();
 if (!Tab_DrawCardPreview.LoadTable(g_DrawCardPreview)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Dressup> > g_Dressup = new Dictionary<int, List<Tab_Dressup> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Dressup()
 {
 g_Dressup.Clear();
 if (!Tab_Dressup.LoadTable(g_Dressup)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_DropPreview> > g_DropPreview = new Dictionary<int, List<Tab_DropPreview> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_DropPreview()
 {
 g_DropPreview.Clear();
 if (!Tab_DropPreview.LoadTable(g_DropPreview)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_EffectAsset> > g_EffectAsset = new Dictionary<int, List<Tab_EffectAsset> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_EffectAsset()
 {
 g_EffectAsset.Clear();
 if (!Tab_EffectAsset.LoadTable(g_EffectAsset)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Emoji> > g_Emoji = new Dictionary<int, List<Tab_Emoji> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Emoji()
 {
 g_Emoji.Clear();
 if (!Tab_Emoji.LoadTable(g_Emoji)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Enviroment> > g_Enviroment = new Dictionary<int, List<Tab_Enviroment> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Enviroment()
 {
 g_Enviroment.Clear();
 if (!Tab_Enviroment.LoadTable(g_Enviroment)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_EverydaySign> > g_EverydaySign = new Dictionary<int, List<Tab_EverydaySign> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_EverydaySign()
 {
 g_EverydaySign.Clear();
 if (!Tab_EverydaySign.LoadTable(g_EverydaySign)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Example> > g_Example = new Dictionary<int, List<Tab_Example> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Example()
 {
 g_Example.Clear();
 if (!Tab_Example.LoadTable(g_Example)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ExtraConfig> > g_ExtraConfig = new Dictionary<int, List<Tab_ExtraConfig> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ExtraConfig()
 {
 g_ExtraConfig.Clear();
 if (!Tab_ExtraConfig.LoadTable(g_ExtraConfig)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FateDialog> > g_FateDialog = new Dictionary<int, List<Tab_FateDialog> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FateDialog()
 {
 g_FateDialog.Clear();
 if (!Tab_FateDialog.LoadTable(g_FateDialog)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FateLine> > g_FateLine = new Dictionary<int, List<Tab_FateLine> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FateLine()
 {
 g_FateLine.Clear();
 if (!Tab_FateLine.LoadTable(g_FateLine)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FateLineAvatar> > g_FateLineAvatar = new Dictionary<int, List<Tab_FateLineAvatar> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FateLineAvatar()
 {
 g_FateLineAvatar.Clear();
 if (!Tab_FateLineAvatar.LoadTable(g_FateLineAvatar)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FateLineLevel> > g_FateLineLevel = new Dictionary<int, List<Tab_FateLineLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FateLineLevel()
 {
 g_FateLineLevel.Clear();
 if (!Tab_FateLineLevel.LoadTable(g_FateLineLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FirstGift> > g_FirstGift = new Dictionary<int, List<Tab_FirstGift> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FirstGift()
 {
 g_FirstGift.Clear();
 if (!Tab_FirstGift.LoadTable(g_FirstGift)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliAddSign> > g_FuliAddSign = new Dictionary<int, List<Tab_FuliAddSign> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliAddSign()
 {
 g_FuliAddSign.Clear();
 if (!Tab_FuliAddSign.LoadTable(g_FuliAddSign)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliAddSignAward> > g_FuliAddSignAward = new Dictionary<int, List<Tab_FuliAddSignAward> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliAddSignAward()
 {
 g_FuliAddSignAward.Clear();
 if (!Tab_FuliAddSignAward.LoadTable(g_FuliAddSignAward)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliDailyStamina> > g_FuliDailyStamina = new Dictionary<int, List<Tab_FuliDailyStamina> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliDailyStamina()
 {
 g_FuliDailyStamina.Clear();
 if (!Tab_FuliDailyStamina.LoadTable(g_FuliDailyStamina)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliDailyStaminaDialog> > g_FuliDailyStaminaDialog = new Dictionary<int, List<Tab_FuliDailyStaminaDialog> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliDailyStaminaDialog()
 {
 g_FuliDailyStaminaDialog.Clear();
 if (!Tab_FuliDailyStaminaDialog.LoadTable(g_FuliDailyStaminaDialog)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliFund> > g_FuliFund = new Dictionary<int, List<Tab_FuliFund> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliFund()
 {
 g_FuliFund.Clear();
 if (!Tab_FuliFund.LoadTable(g_FuliFund)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliLottery> > g_FuliLottery = new Dictionary<int, List<Tab_FuliLottery> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliLottery()
 {
 g_FuliLottery.Clear();
 if (!Tab_FuliLottery.LoadTable(g_FuliLottery)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliNormal> > g_FuliNormal = new Dictionary<int, List<Tab_FuliNormal> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliNormal()
 {
 g_FuliNormal.Clear();
 if (!Tab_FuliNormal.LoadTable(g_FuliNormal)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliRecharge> > g_FuliRecharge = new Dictionary<int, List<Tab_FuliRecharge> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliRecharge()
 {
 g_FuliRecharge.Clear();
 if (!Tab_FuliRecharge.LoadTable(g_FuliRecharge)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FuliRiddleCage> > g_FuliRiddleCage = new Dictionary<int, List<Tab_FuliRiddleCage> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FuliRiddleCage()
 {
 g_FuliRiddleCage.Clear();
 if (!Tab_FuliRiddleCage.LoadTable(g_FuliRiddleCage)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_FunctionUnlock> > g_FunctionUnlock = new Dictionary<int, List<Tab_FunctionUnlock> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_FunctionUnlock()
 {
 g_FunctionUnlock.Clear();
 if (!Tab_FunctionUnlock.LoadTable(g_FunctionUnlock)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Gift> > g_Gift = new Dictionary<int, List<Tab_Gift> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Gift()
 {
 g_Gift.Clear();
 if (!Tab_Gift.LoadTable(g_Gift)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Goto> > g_Goto = new Dictionary<int, List<Tab_Goto> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Goto()
 {
 g_Goto.Clear();
 if (!Tab_Goto.LoadTable(g_Goto)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Guide> > g_Guide = new Dictionary<int, List<Tab_Guide> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Guide()
 {
 g_Guide.Clear();
 if (!Tab_Guide.LoadTable(g_Guide)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_GuideEx> > g_GuideEx = new Dictionary<int, List<Tab_GuideEx> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_GuideEx()
 {
 g_GuideEx.Clear();
 if (!Tab_GuideEx.LoadTable(g_GuideEx)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Hardware> > g_Hardware = new Dictionary<int, List<Tab_Hardware> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Hardware()
 {
 g_Hardware.Clear();
 if (!Tab_Hardware.LoadTable(g_Hardware)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_HeartBeat> > g_HeartBeat = new Dictionary<int, List<Tab_HeartBeat> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_HeartBeat()
 {
 g_HeartBeat.Clear();
 if (!Tab_HeartBeat.LoadTable(g_HeartBeat)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_HeartBeatAction> > g_HeartBeatAction = new Dictionary<int, List<Tab_HeartBeatAction> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_HeartBeatAction()
 {
 g_HeartBeatAction.Clear();
 if (!Tab_HeartBeatAction.LoadTable(g_HeartBeatAction)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_HeartBeatDialog> > g_HeartBeatDialog = new Dictionary<int, List<Tab_HeartBeatDialog> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_HeartBeatDialog()
 {
 g_HeartBeatDialog.Clear();
 if (!Tab_HeartBeatDialog.LoadTable(g_HeartBeatDialog)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_HeartBeatQuestion> > g_HeartBeatQuestion = new Dictionary<int, List<Tab_HeartBeatQuestion> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_HeartBeatQuestion()
 {
 g_HeartBeatQuestion.Clear();
 if (!Tab_HeartBeatQuestion.LoadTable(g_HeartBeatQuestion)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_HelpTips> > g_HelpTips = new Dictionary<int, List<Tab_HelpTips> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_HelpTips()
 {
 g_HelpTips.Clear();
 if (!Tab_HelpTips.LoadTable(g_HelpTips)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Hexagram> > g_Hexagram = new Dictionary<int, List<Tab_Hexagram> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Hexagram()
 {
 g_Hexagram.Clear();
 if (!Tab_Hexagram.LoadTable(g_Hexagram)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_InteractGamePlay> > g_InteractGamePlay = new Dictionary<int, List<Tab_InteractGamePlay> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_InteractGamePlay()
 {
 g_InteractGamePlay.Clear();
 if (!Tab_InteractGamePlay.LoadTable(g_InteractGamePlay)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_InteractSpecialSound> > g_InteractSpecialSound = new Dictionary<int, List<Tab_InteractSpecialSound> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_InteractSpecialSound()
 {
 g_InteractSpecialSound.Clear();
 if (!Tab_InteractSpecialSound.LoadTable(g_InteractSpecialSound)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Interflow> > g_Interflow = new Dictionary<int, List<Tab_Interflow> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Interflow()
 {
 g_Interflow.Clear();
 if (!Tab_Interflow.LoadTable(g_Interflow)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_IntimacyLevel> > g_IntimacyLevel = new Dictionary<int, List<Tab_IntimacyLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_IntimacyLevel()
 {
 g_IntimacyLevel.Clear();
 if (!Tab_IntimacyLevel.LoadTable(g_IntimacyLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Item> > g_Item = new Dictionary<int, List<Tab_Item> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Item()
 {
 g_Item.Clear();
 if (!Tab_Item.LoadTable(g_Item)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ItemPageType> > g_ItemPageType = new Dictionary<int, List<Tab_ItemPageType> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ItemPageType()
 {
 g_ItemPageType.Clear();
 if (!Tab_ItemPageType.LoadTable(g_ItemPageType)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_LevelPlotDesc> > g_LevelPlotDesc = new Dictionary<int, List<Tab_LevelPlotDesc> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_LevelPlotDesc()
 {
 g_LevelPlotDesc.Clear();
 if (!Tab_LevelPlotDesc.LoadTable(g_LevelPlotDesc)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Loading> > g_Loading = new Dictionary<int, List<Tab_Loading> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Loading()
 {
 g_Loading.Clear();
 if (!Tab_Loading.LoadTable(g_Loading)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_LoadingScene> > g_LoadingScene = new Dictionary<int, List<Tab_LoadingScene> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_LoadingScene()
 {
 g_LoadingScene.Clear();
 if (!Tab_LoadingScene.LoadTable(g_LoadingScene)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_LoadingText> > g_LoadingText = new Dictionary<int, List<Tab_LoadingText> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_LoadingText()
 {
 g_LoadingText.Clear();
 if (!Tab_LoadingText.LoadTable(g_LoadingText)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_LoadingTexture> > g_LoadingTexture = new Dictionary<int, List<Tab_LoadingTexture> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_LoadingTexture()
 {
 g_LoadingTexture.Clear();
 if (!Tab_LoadingTexture.LoadTable(g_LoadingTexture)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_LocalizationData> > g_LocalizationData = new Dictionary<int, List<Tab_LocalizationData> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_LocalizationData()
 {
 g_LocalizationData.Clear();
 if (!Tab_LocalizationData.LoadTable(g_LocalizationData)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_MainSceneCarouselMap> > g_MainSceneCarouselMap = new Dictionary<int, List<Tab_MainSceneCarouselMap> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_MainSceneCarouselMap()
 {
 g_MainSceneCarouselMap.Clear();
 if (!Tab_MainSceneCarouselMap.LoadTable(g_MainSceneCarouselMap)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_MainSceneTimeSceneEnv> > g_MainSceneTimeSceneEnv = new Dictionary<int, List<Tab_MainSceneTimeSceneEnv> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_MainSceneTimeSceneEnv()
 {
 g_MainSceneTimeSceneEnv.Clear();
 if (!Tab_MainSceneTimeSceneEnv.LoadTable(g_MainSceneTimeSceneEnv)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_MisReputationLevel> > g_MisReputationLevel = new Dictionary<int, List<Tab_MisReputationLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_MisReputationLevel()
 {
 g_MisReputationLevel.Clear();
 if (!Tab_MisReputationLevel.LoadTable(g_MisReputationLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Mission> > g_Mission = new Dictionary<int, List<Tab_Mission> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Mission()
 {
 g_Mission.Clear();
 if (!Tab_Mission.LoadTable(g_Mission)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_MissionItem> > g_MissionItem = new Dictionary<int, List<Tab_MissionItem> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_MissionItem()
 {
 g_MissionItem.Clear();
 if (!Tab_MissionItem.LoadTable(g_MissionItem)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_MissionMail> > g_MissionMail = new Dictionary<int, List<Tab_MissionMail> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_MissionMail()
 {
 g_MissionMail.Clear();
 if (!Tab_MissionMail.LoadTable(g_MissionMail)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_MonthCard> > g_MonthCard = new Dictionary<int, List<Tab_MonthCard> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_MonthCard()
 {
 g_MonthCard.Clear();
 if (!Tab_MonthCard.LoadTable(g_MonthCard)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Node> > g_Node = new Dictionary<int, List<Tab_Node> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Node()
 {
 g_Node.Clear();
 if (!Tab_Node.LoadTable(g_Node)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Notice> > g_Notice = new Dictionary<int, List<Tab_Notice> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Notice()
 {
 g_Notice.Clear();
 if (!Tab_Notice.LoadTable(g_Notice)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_NoticeType> > g_NoticeType = new Dictionary<int, List<Tab_NoticeType> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_NoticeType()
 {
 g_NoticeType.Clear();
 if (!Tab_NoticeType.LoadTable(g_NoticeType)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_NoviceGuide> > g_NoviceGuide = new Dictionary<int, List<Tab_NoviceGuide> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_NoviceGuide()
 {
 g_NoviceGuide.Clear();
 if (!Tab_NoviceGuide.LoadTable(g_NoviceGuide)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Npc> > g_Npc = new Dictionary<int, List<Tab_Npc> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Npc()
 {
 g_Npc.Clear();
 if (!Tab_Npc.LoadTable(g_Npc)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_NpcLevel> > g_NpcLevel = new Dictionary<int, List<Tab_NpcLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_NpcLevel()
 {
 g_NpcLevel.Clear();
 if (!Tab_NpcLevel.LoadTable(g_NpcLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_NpcQuestion> > g_NpcQuestion = new Dictionary<int, List<Tab_NpcQuestion> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_NpcQuestion()
 {
 g_NpcQuestion.Clear();
 if (!Tab_NpcQuestion.LoadTable(g_NpcQuestion)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_NpcState> > g_NpcState = new Dictionary<int, List<Tab_NpcState> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_NpcState()
 {
 g_NpcState.Clear();
 if (!Tab_NpcState.LoadTable(g_NpcState)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_NpcTask> > g_NpcTask = new Dictionary<int, List<Tab_NpcTask> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_NpcTask()
 {
 g_NpcTask.Clear();
 if (!Tab_NpcTask.LoadTable(g_NpcTask)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Npclike> > g_Npclike = new Dictionary<int, List<Tab_Npclike> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Npclike()
 {
 g_Npclike.Clear();
 if (!Tab_Npclike.LoadTable(g_Npclike)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_OptItem> > g_OptItem = new Dictionary<int, List<Tab_OptItem> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_OptItem()
 {
 g_OptItem.Clear();
 if (!Tab_OptItem.LoadTable(g_OptItem)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PersonalChapterAward> > g_PersonalChapterAward = new Dictionary<int, List<Tab_PersonalChapterAward> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PersonalChapterAward()
 {
 g_PersonalChapterAward.Clear();
 if (!Tab_PersonalChapterAward.LoadTable(g_PersonalChapterAward)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PersonalStory> > g_PersonalStory = new Dictionary<int, List<Tab_PersonalStory> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PersonalStory()
 {
 g_PersonalStory.Clear();
 if (!Tab_PersonalStory.LoadTable(g_PersonalStory)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Personality> > g_Personality = new Dictionary<int, List<Tab_Personality> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Personality()
 {
 g_Personality.Clear();
 if (!Tab_Personality.LoadTable(g_Personality)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PersonalityData> > g_PersonalityData = new Dictionary<int, List<Tab_PersonalityData> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PersonalityData()
 {
 g_PersonalityData.Clear();
 if (!Tab_PersonalityData.LoadTable(g_PersonalityData)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PersonalityLevel> > g_PersonalityLevel = new Dictionary<int, List<Tab_PersonalityLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PersonalityLevel()
 {
 g_PersonalityLevel.Clear();
 if (!Tab_PersonalityLevel.LoadTable(g_PersonalityLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PersonalityMonologue> > g_PersonalityMonologue = new Dictionary<int, List<Tab_PersonalityMonologue> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PersonalityMonologue()
 {
 g_PersonalityMonologue.Clear();
 if (!Tab_PersonalityMonologue.LoadTable(g_PersonalityMonologue)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PersonalityProcess> > g_PersonalityProcess = new Dictionary<int, List<Tab_PersonalityProcess> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PersonalityProcess()
 {
 g_PersonalityProcess.Clear();
 if (!Tab_PersonalityProcess.LoadTable(g_PersonalityProcess)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PersonalityQuestion> > g_PersonalityQuestion = new Dictionary<int, List<Tab_PersonalityQuestion> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PersonalityQuestion()
 {
 g_PersonalityQuestion.Clear();
 if (!Tab_PersonalityQuestion.LoadTable(g_PersonalityQuestion)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PlayerLevel> > g_PlayerLevel = new Dictionary<int, List<Tab_PlayerLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PlayerLevel()
 {
 g_PlayerLevel.Clear();
 if (!Tab_PlayerLevel.LoadTable(g_PlayerLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Plot> > g_Plot = new Dictionary<int, List<Tab_Plot> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Plot()
 {
 g_Plot.Clear();
 if (!Tab_Plot.LoadTable(g_Plot)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PlotInteraction> > g_PlotInteraction = new Dictionary<int, List<Tab_PlotInteraction> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PlotInteraction()
 {
 g_PlotInteraction.Clear();
 if (!Tab_PlotInteraction.LoadTable(g_PlotInteraction)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Preloader> > g_Preloader = new Dictionary<int, List<Tab_Preloader> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Preloader()
 {
 g_Preloader.Clear();
 if (!Tab_Preloader.LoadTable(g_Preloader)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ProductIDMap> > g_ProductIDMap = new Dictionary<int, List<Tab_ProductIDMap> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ProductIDMap()
 {
 g_ProductIDMap.Clear();
 if (!Tab_ProductIDMap.LoadTable(g_ProductIDMap)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PushNotification> > g_PushNotification = new Dictionary<int, List<Tab_PushNotification> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PushNotification()
 {
 g_PushNotification.Clear();
 if (!Tab_PushNotification.LoadTable(g_PushNotification)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PuzzleLevelData> > g_PuzzleLevelData = new Dictionary<int, List<Tab_PuzzleLevelData> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PuzzleLevelData()
 {
 g_PuzzleLevelData.Clear();
 if (!Tab_PuzzleLevelData.LoadTable(g_PuzzleLevelData)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PuzzleThought> > g_PuzzleThought = new Dictionary<int, List<Tab_PuzzleThought> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PuzzleThought()
 {
 g_PuzzleThought.Clear();
 if (!Tab_PuzzleThought.LoadTable(g_PuzzleThought)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_PuzzleThoughtSet> > g_PuzzleThoughtSet = new Dictionary<int, List<Tab_PuzzleThoughtSet> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_PuzzleThoughtSet()
 {
 g_PuzzleThoughtSet.Clear();
 if (!Tab_PuzzleThoughtSet.LoadTable(g_PuzzleThoughtSet)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Question> > g_Question = new Dictionary<int, List<Tab_Question> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Question()
 {
 g_Question.Clear();
 if (!Tab_Question.LoadTable(g_Question)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_RechargeGift> > g_RechargeGift = new Dictionary<int, List<Tab_RechargeGift> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_RechargeGift()
 {
 g_RechargeGift.Clear();
 if (!Tab_RechargeGift.LoadTable(g_RechargeGift)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_RechargeRule> > g_RechargeRule = new Dictionary<int, List<Tab_RechargeRule> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_RechargeRule()
 {
 g_RechargeRule.Clear();
 if (!Tab_RechargeRule.LoadTable(g_RechargeRule)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Retrieval> > g_Retrieval = new Dictionary<int, List<Tab_Retrieval> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Retrieval()
 {
 g_Retrieval.Clear();
 if (!Tab_Retrieval.LoadTable(g_Retrieval)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_RewardPreview> > g_RewardPreview = new Dictionary<int, List<Tab_RewardPreview> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_RewardPreview()
 {
 g_RewardPreview.Clear();
 if (!Tab_RewardPreview.LoadTable(g_RewardPreview)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Role> > g_Role = new Dictionary<int, List<Tab_Role> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Role()
 {
 g_Role.Clear();
 if (!Tab_Role.LoadTable(g_Role)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Rumor> > g_Rumor = new Dictionary<int, List<Tab_Rumor> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Rumor()
 {
 g_Rumor.Clear();
 if (!Tab_Rumor.LoadTable(g_Rumor)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_RumorRewardRule> > g_RumorRewardRule = new Dictionary<int, List<Tab_RumorRewardRule> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_RumorRewardRule()
 {
 g_RumorRewardRule.Clear();
 if (!Tab_RumorRewardRule.LoadTable(g_RumorRewardRule)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_RumorSub> > g_RumorSub = new Dictionary<int, List<Tab_RumorSub> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_RumorSub()
 {
 g_RumorSub.Clear();
 if (!Tab_RumorSub.LoadTable(g_RumorSub)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_RumorSubSet> > g_RumorSubSet = new Dictionary<int, List<Tab_RumorSubSet> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_RumorSubSet()
 {
 g_RumorSubSet.Clear();
 if (!Tab_RumorSubSet.LoadTable(g_RumorSubSet)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SavePoint> > g_SavePoint = new Dictionary<int, List<Tab_SavePoint> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SavePoint()
 {
 g_SavePoint.Clear();
 if (!Tab_SavePoint.LoadTable(g_SavePoint)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneClass> > g_SceneClass = new Dictionary<int, List<Tab_SceneClass> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneClass()
 {
 g_SceneClass.Clear();
 if (!Tab_SceneClass.LoadTable(g_SceneClass)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneClassRandomEntry> > g_SceneClassRandomEntry = new Dictionary<int, List<Tab_SceneClassRandomEntry> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneClassRandomEntry()
 {
 g_SceneClassRandomEntry.Clear();
 if (!Tab_SceneClassRandomEntry.LoadTable(g_SceneClassRandomEntry)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneEventCategory> > g_SceneEventCategory = new Dictionary<int, List<Tab_SceneEventCategory> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneEventCategory()
 {
 g_SceneEventCategory.Clear();
 if (!Tab_SceneEventCategory.LoadTable(g_SceneEventCategory)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneEventDesc> > g_SceneEventDesc = new Dictionary<int, List<Tab_SceneEventDesc> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneEventDesc()
 {
 g_SceneEventDesc.Clear();
 if (!Tab_SceneEventDesc.LoadTable(g_SceneEventDesc)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneNode> > g_SceneNode = new Dictionary<int, List<Tab_SceneNode> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneNode()
 {
 g_SceneNode.Clear();
 if (!Tab_SceneNode.LoadTable(g_SceneNode)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneNpc> > g_SceneNpc = new Dictionary<int, List<Tab_SceneNpc> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneNpc()
 {
 g_SceneNpc.Clear();
 if (!Tab_SceneNpc.LoadTable(g_SceneNpc)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneNpcCreateRule> > g_SceneNpcCreateRule = new Dictionary<int, List<Tab_SceneNpcCreateRule> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneNpcCreateRule()
 {
 g_SceneNpcCreateRule.Clear();
 if (!Tab_SceneNpcCreateRule.LoadTable(g_SceneNpcCreateRule)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneNpcReplace> > g_SceneNpcReplace = new Dictionary<int, List<Tab_SceneNpcReplace> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneNpcReplace()
 {
 g_SceneNpcReplace.Clear();
 if (!Tab_SceneNpcReplace.LoadTable(g_SceneNpcReplace)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneObject> > g_SceneObject = new Dictionary<int, List<Tab_SceneObject> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneObject()
 {
 g_SceneObject.Clear();
 if (!Tab_SceneObject.LoadTable(g_SceneObject)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SceneTimeChange> > g_SceneTimeChange = new Dictionary<int, List<Tab_SceneTimeChange> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SceneTimeChange()
 {
 g_SceneTimeChange.Clear();
 if (!Tab_SceneTimeChange.LoadTable(g_SceneTimeChange)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ScreenFade> > g_ScreenFade = new Dictionary<int, List<Tab_ScreenFade> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ScreenFade()
 {
 g_ScreenFade.Clear();
 if (!Tab_ScreenFade.LoadTable(g_ScreenFade)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Secret> > g_Secret = new Dictionary<int, List<Tab_Secret> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Secret()
 {
 g_Secret.Clear();
 if (!Tab_Secret.LoadTable(g_Secret)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SecretDesc> > g_SecretDesc = new Dictionary<int, List<Tab_SecretDesc> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SecretDesc()
 {
 g_SecretDesc.Clear();
 if (!Tab_SecretDesc.LoadTable(g_SecretDesc)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SecretKeyword> > g_SecretKeyword = new Dictionary<int, List<Tab_SecretKeyword> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SecretKeyword()
 {
 g_SecretKeyword.Clear();
 if (!Tab_SecretKeyword.LoadTable(g_SecretKeyword)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Selection> > g_Selection = new Dictionary<int, List<Tab_Selection> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Selection()
 {
 g_Selection.Clear();
 if (!Tab_Selection.LoadTable(g_Selection)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ServerList> > g_ServerList = new Dictionary<int, List<Tab_ServerList> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ServerList()
 {
 g_ServerList.Clear();
 if (!Tab_ServerList.LoadTable(g_ServerList)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ShopCommon> > g_ShopCommon = new Dictionary<int, List<Tab_ShopCommon> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ShopCommon()
 {
 g_ShopCommon.Clear();
 if (!Tab_ShopCommon.LoadTable(g_ShopCommon)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ShopDiamond> > g_ShopDiamond = new Dictionary<int, List<Tab_ShopDiamond> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ShopDiamond()
 {
 g_ShopDiamond.Clear();
 if (!Tab_ShopDiamond.LoadTable(g_ShopDiamond)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ShopGiftItem> > g_ShopGiftItem = new Dictionary<int, List<Tab_ShopGiftItem> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ShopGiftItem()
 {
 g_ShopGiftItem.Clear();
 if (!Tab_ShopGiftItem.LoadTable(g_ShopGiftItem)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ShopType> > g_ShopType = new Dictionary<int, List<Tab_ShopType> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ShopType()
 {
 g_ShopType.Clear();
 if (!Tab_ShopType.LoadTable(g_ShopType)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_ShopTypeDialog> > g_ShopTypeDialog = new Dictionary<int, List<Tab_ShopTypeDialog> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_ShopTypeDialog()
 {
 g_ShopTypeDialog.Clear();
 if (!Tab_ShopTypeDialog.LoadTable(g_ShopTypeDialog)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Signboard> > g_Signboard = new Dictionary<int, List<Tab_Signboard> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Signboard()
 {
 g_Signboard.Clear();
 if (!Tab_Signboard.LoadTable(g_Signboard)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SignboardDecals> > g_SignboardDecals = new Dictionary<int, List<Tab_SignboardDecals> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SignboardDecals()
 {
 g_SignboardDecals.Clear();
 if (!Tab_SignboardDecals.LoadTable(g_SignboardDecals)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SignboardTheme> > g_SignboardTheme = new Dictionary<int, List<Tab_SignboardTheme> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SignboardTheme()
 {
 g_SignboardTheme.Clear();
 if (!Tab_SignboardTheme.LoadTable(g_SignboardTheme)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Skill> > g_Skill = new Dictionary<int, List<Tab_Skill> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Skill()
 {
 g_Skill.Clear();
 if (!Tab_Skill.LoadTable(g_Skill)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SkillEx> > g_SkillEx = new Dictionary<int, List<Tab_SkillEx> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SkillEx()
 {
 g_SkillEx.Clear();
 if (!Tab_SkillEx.LoadTable(g_SkillEx)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SkinData> > g_SkinData = new Dictionary<int, List<Tab_SkinData> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SkinData()
 {
 g_SkinData.Clear();
 if (!Tab_SkinData.LoadTable(g_SkinData)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SpecialClue> > g_SpecialClue = new Dictionary<int, List<Tab_SpecialClue> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SpecialClue()
 {
 g_SpecialClue.Clear();
 if (!Tab_SpecialClue.LoadTable(g_SpecialClue)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SpecialLevelGamePlay> > g_SpecialLevelGamePlay = new Dictionary<int, List<Tab_SpecialLevelGamePlay> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SpecialLevelGamePlay()
 {
 g_SpecialLevelGamePlay.Clear();
 if (!Tab_SpecialLevelGamePlay.LoadTable(g_SpecialLevelGamePlay)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapter> > g_StoryChapter = new Dictionary<int, List<Tab_StoryChapter> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapter()
 {
 g_StoryChapter.Clear();
 if (!Tab_StoryChapter.LoadTable(g_StoryChapter)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterCheckpoint> > g_StoryChapterCheckpoint = new Dictionary<int, List<Tab_StoryChapterCheckpoint> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterCheckpoint()
 {
 g_StoryChapterCheckpoint.Clear();
 if (!Tab_StoryChapterCheckpoint.LoadTable(g_StoryChapterCheckpoint)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterEnding> > g_StoryChapterEnding = new Dictionary<int, List<Tab_StoryChapterEnding> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterEnding()
 {
 g_StoryChapterEnding.Clear();
 if (!Tab_StoryChapterEnding.LoadTable(g_StoryChapterEnding)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterEndingDesc> > g_StoryChapterEndingDesc = new Dictionary<int, List<Tab_StoryChapterEndingDesc> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterEndingDesc()
 {
 g_StoryChapterEndingDesc.Clear();
 if (!Tab_StoryChapterEndingDesc.LoadTable(g_StoryChapterEndingDesc)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterEndingRule> > g_StoryChapterEndingRule = new Dictionary<int, List<Tab_StoryChapterEndingRule> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterEndingRule()
 {
 g_StoryChapterEndingRule.Clear();
 if (!Tab_StoryChapterEndingRule.LoadTable(g_StoryChapterEndingRule)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterLevel> > g_StoryChapterLevel = new Dictionary<int, List<Tab_StoryChapterLevel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterLevel()
 {
 g_StoryChapterLevel.Clear();
 if (!Tab_StoryChapterLevel.LoadTable(g_StoryChapterLevel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterLevelReq> > g_StoryChapterLevelReq = new Dictionary<int, List<Tab_StoryChapterLevelReq> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterLevelReq()
 {
 g_StoryChapterLevelReq.Clear();
 if (!Tab_StoryChapterLevelReq.LoadTable(g_StoryChapterLevelReq)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterLevelReward> > g_StoryChapterLevelReward = new Dictionary<int, List<Tab_StoryChapterLevelReward> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterLevelReward()
 {
 g_StoryChapterLevelReward.Clear();
 if (!Tab_StoryChapterLevelReward.LoadTable(g_StoryChapterLevelReward)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterLevelRule> > g_StoryChapterLevelRule = new Dictionary<int, List<Tab_StoryChapterLevelRule> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterLevelRule()
 {
 g_StoryChapterLevelRule.Clear();
 if (!Tab_StoryChapterLevelRule.LoadTable(g_StoryChapterLevelRule)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterLevelSceneEvent> > g_StoryChapterLevelSceneEvent = new Dictionary<int, List<Tab_StoryChapterLevelSceneEvent> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterLevelSceneEvent()
 {
 g_StoryChapterLevelSceneEvent.Clear();
 if (!Tab_StoryChapterLevelSceneEvent.LoadTable(g_StoryChapterLevelSceneEvent)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryChapterRule> > g_StoryChapterRule = new Dictionary<int, List<Tab_StoryChapterRule> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryChapterRule()
 {
 g_StoryChapterRule.Clear();
 if (!Tab_StoryChapterRule.LoadTable(g_StoryChapterRule)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StoryLine> > g_StoryLine = new Dictionary<int, List<Tab_StoryLine> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StoryLine()
 {
 g_StoryLine.Clear();
 if (!Tab_StoryLine.LoadTable(g_StoryLine)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StrDictionary> > g_StrDictionary = new Dictionary<int, List<Tab_StrDictionary> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StrDictionary()
 {
 g_StrDictionary.Clear();
 if (!Tab_StrDictionary.LoadTable(g_StrDictionary)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_StrFilter> > g_StrFilter = new Dictionary<int, List<Tab_StrFilter> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_StrFilter()
 {
 g_StrFilter.Clear();
 if (!Tab_StrFilter.LoadTable(g_StrFilter)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_SystemMail> > g_SystemMail = new Dictionary<int, List<Tab_SystemMail> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_SystemMail()
 {
 g_SystemMail.Clear();
 if (!Tab_SystemMail.LoadTable(g_SystemMail)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_TagData> > g_TagData = new Dictionary<int, List<Tab_TagData> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_TagData()
 {
 g_TagData.Clear();
 if (!Tab_TagData.LoadTable(g_TagData)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Task> > g_Task = new Dictionary<int, List<Tab_Task> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Task()
 {
 g_Task.Clear();
 if (!Tab_Task.LoadTable(g_Task)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_TaskAward> > g_TaskAward = new Dictionary<int, List<Tab_TaskAward> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_TaskAward()
 {
 g_TaskAward.Clear();
 if (!Tab_TaskAward.LoadTable(g_TaskAward)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_TaskGroup> > g_TaskGroup = new Dictionary<int, List<Tab_TaskGroup> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_TaskGroup()
 {
 g_TaskGroup.Clear();
 if (!Tab_TaskGroup.LoadTable(g_TaskGroup)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_TaskTab> > g_TaskTab = new Dictionary<int, List<Tab_TaskTab> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_TaskTab()
 {
 g_TaskTab.Clear();
 if (!Tab_TaskTab.LoadTable(g_TaskTab)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_TeleportPoint> > g_TeleportPoint = new Dictionary<int, List<Tab_TeleportPoint> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_TeleportPoint()
 {
 g_TeleportPoint.Clear();
 if (!Tab_TeleportPoint.LoadTable(g_TeleportPoint)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_Title> > g_Title = new Dictionary<int, List<Tab_Title> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_Title()
 {
 g_Title.Clear();
 if (!Tab_Title.LoadTable(g_Title)) return false;
 return true;
 }
private static Dictionary<long, List<Tab_TranlateDictionary> > g_TranlateDictionary = new Dictionary<long, List<Tab_TranlateDictionary> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_TranlateDictionary()
 {
 g_TranlateDictionary.Clear();
 if (!Tab_TranlateDictionary.LoadTable(g_TranlateDictionary)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_TranlateDictionaryEn> > g_TranlateDictionaryEn = new Dictionary<int, List<Tab_TranlateDictionaryEn> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_TranlateDictionaryEn()
 {
 g_TranlateDictionaryEn.Clear();
 if (!Tab_TranlateDictionaryEn.LoadTable(g_TranlateDictionaryEn)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_UIDictionary> > g_UIDictionary = new Dictionary<int, List<Tab_UIDictionary> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_UIDictionary()
 {
 g_UIDictionary.Clear();
 if (!Tab_UIDictionary.LoadTable(g_UIDictionary)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_UIItemExtension> > g_UIItemExtension = new Dictionary<int, List<Tab_UIItemExtension> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_UIItemExtension()
 {
 g_UIItemExtension.Clear();
 if (!Tab_UIItemExtension.LoadTable(g_UIItemExtension)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_UIPackage> > g_UIPackage = new Dictionary<int, List<Tab_UIPackage> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_UIPackage()
 {
 g_UIPackage.Clear();
 if (!Tab_UIPackage.LoadTable(g_UIPackage)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_UIPanel> > g_UIPanel = new Dictionary<int, List<Tab_UIPanel> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_UIPanel()
 {
 g_UIPanel.Clear();
 if (!Tab_UIPanel.LoadTable(g_UIPanel)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_UIRedDot> > g_UIRedDot = new Dictionary<int, List<Tab_UIRedDot> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_UIRedDot()
 {
 g_UIRedDot.Clear();
 if (!Tab_UIRedDot.LoadTable(g_UIRedDot)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_VChat> > g_VChat = new Dictionary<int, List<Tab_VChat> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_VChat()
 {
 g_VChat.Clear();
 if (!Tab_VChat.LoadTable(g_VChat)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_VChatEmoji> > g_VChatEmoji = new Dictionary<int, List<Tab_VChatEmoji> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_VChatEmoji()
 {
 g_VChatEmoji.Clear();
 if (!Tab_VChatEmoji.LoadTable(g_VChatEmoji)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_VChatGroup> > g_VChatGroup = new Dictionary<int, List<Tab_VChatGroup> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_VChatGroup()
 {
 g_VChatGroup.Clear();
 if (!Tab_VChatGroup.LoadTable(g_VChatGroup)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_VChatMsg> > g_VChatMsg = new Dictionary<int, List<Tab_VChatMsg> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_VChatMsg()
 {
 g_VChatMsg.Clear();
 if (!Tab_VChatMsg.LoadTable(g_VChatMsg)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_VChatOption> > g_VChatOption = new Dictionary<int, List<Tab_VChatOption> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_VChatOption()
 {
 g_VChatOption.Clear();
 if (!Tab_VChatOption.LoadTable(g_VChatOption)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_VoiceData> > g_VoiceData = new Dictionary<int, List<Tab_VoiceData> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_VoiceData()
 {
 g_VoiceData.Clear();
 if (!Tab_VoiceData.LoadTable(g_VoiceData)) return false;
 return true;
 }
private static Dictionary<int, List<Tab_VoiceExtraConfig> > g_VoiceExtraConfig = new Dictionary<int, List<Tab_VoiceExtraConfig> >(); 
[SLua.DoNotToLua]
 
 public static bool InitTable_VoiceExtraConfig()
 {
 g_VoiceExtraConfig.Clear();
 if (!Tab_VoiceExtraConfig.LoadTable(g_VoiceExtraConfig)) return false;
 return true;
 }
[SLua.DoNotToLua]
 public bool InitTable()
 {
 if (false == InitTable_AbilityClue())
 {
 return false;
 }

if (false == InitTable_AbilityData())
 {
 return false;
 }

if (false == InitTable_AbilityDataEx())
 {
 return false;
 }

if (false == InitTable_Action())
 {
 return false;
 }

if (false == InitTable_ActionAvatarEvent())
 {
 return false;
 }

if (false == InitTable_ActionReview())
 {
 return false;
 }

if (false == InitTable_ActionSkip())
 {
 return false;
 }

if (false == InitTable_AlbumCard())
 {
 return false;
 }

if (false == InitTable_AlbumLevel())
 {
 return false;
 }

if (false == InitTable_AlbumStory())
 {
 return false;
 }

if (false == InitTable_AlbumStorySub())
 {
 return false;
 }

if (false == InitTable_Appointment())
 {
 return false;
 }

if (false == InitTable_Article())
 {
 return false;
 }

if (false == InitTable_ArticleDetail())
 {
 return false;
 }

if (false == InitTable_ArticleOfficialAccount())
 {
 return false;
 }

if (false == InitTable_ArticleReply())
 {
 return false;
 }

if (false == InitTable_AssetGroup())
 {
 return false;
 }

if (false == InitTable_AssetList())
 {
 return false;
 }

if (false == InitTable_AttrData())
 {
 return false;
 }

if (false == InitTable_Audio())
 {
 return false;
 }

if (false == InitTable_AudioAcb())
 {
 return false;
 }

if (false == InitTable_Avatar())
 {
 return false;
 }

if (false == InitTable_BattlePass())
 {
 return false;
 }

if (false == InitTable_BattlePassTask())
 {
 return false;
 }

if (false == InitTable_BattleScript())
 {
 return false;
 }

if (false == InitTable_BehaviorCalcNum())
 {
 return false;
 }

if (false == InitTable_BundleConfig())
 {
 return false;
 }

if (false == InitTable_BuyGold())
 {
 return false;
 }

if (false == InitTable_BuyStamina())
 {
 return false;
 }

if (false == InitTable_CV())
 {
 return false;
 }

if (false == InitTable_Camera())
 {
 return false;
 }

if (false == InitTable_CameraShake())
 {
 return false;
 }

if (false == InitTable_Card())
 {
 return false;
 }

if (false == InitTable_CardAsset())
 {
 return false;
 }

if (false == InitTable_CardAttrGrow())
 {
 return false;
 }

if (false == InitTable_CardAudio())
 {
 return false;
 }

if (false == InitTable_CardEnhanceLevel())
 {
 return false;
 }

if (false == InitTable_CardEx())
 {
 return false;
 }

if (false == InitTable_CardExpItem())
 {
 return false;
 }

if (false == InitTable_CardFile())
 {
 return false;
 }

if (false == InitTable_CardFileLevel())
 {
 return false;
 }

if (false == InitTable_CardFrame())
 {
 return false;
 }

if (false == InitTable_CardLevel())
 {
 return false;
 }

if (false == InitTable_CardPiece())
 {
 return false;
 }

if (false == InitTable_CardPoolType())
 {
 return false;
 }

if (false == InitTable_CardResolve())
 {
 return false;
 }

if (false == InitTable_CardStar())
 {
 return false;
 }

if (false == InitTable_CardStarItem())
 {
 return false;
 }

if (false == InitTable_CardTrain())
 {
 return false;
 }

if (false == InitTable_Channel())
 {
 return false;
 }

if (false == InitTable_Character())
 {
 return false;
 }

if (false == InitTable_CharacterAsset())
 {
 return false;
 }

if (false == InitTable_CharacterContacts())
 {
 return false;
 }

if (false == InitTable_CharacterIntimacyDialog())
 {
 return false;
 }

if (false == InitTable_Circle())
 {
 return false;
 }

if (false == InitTable_CircleReply())
 {
 return false;
 }

if (false == InitTable_CityCopy())
 {
 return false;
 }

if (false == InitTable_CityCopyFloor())
 {
 return false;
 }

if (false == InitTable_CityCopyFloorDesc())
 {
 return false;
 }

if (false == InitTable_CityWork())
 {
 return false;
 }

if (false == InitTable_CityWorkTask())
 {
 return false;
 }

if (false == InitTable_CityWorkTaskDrop())
 {
 return false;
 }

if (false == InitTable_CommonAward())
 {
 return false;
 }

if (false == InitTable_Condition())
 {
 return false;
 }

if (false == InitTable_CoolDown())
 {
 return false;
 }

if (false == InitTable_CoolDownTimeInfo())
 {
 return false;
 }

if (false == InitTable_Device())
 {
 return false;
 }

if (false == InitTable_DeviceAdapter())
 {
 return false;
 }

if (false == InitTable_Dialog())
 {
 return false;
 }

if (false == InitTable_DialogAvatar())
 {
 return false;
 }

if (false == InitTable_Divination())
 {
 return false;
 }

if (false == InitTable_DivinationProgress())
 {
 return false;
 }

if (false == InitTable_DivinationReward())
 {
 return false;
 }

if (false == InitTable_DrawCardAdvanceCard())
 {
 return false;
 }

if (false == InitTable_DrawCardNormalCard())
 {
 return false;
 }

if (false == InitTable_DrawCardPreview())
 {
 return false;
 }

if (false == InitTable_Dressup())
 {
 return false;
 }

if (false == InitTable_DropPreview())
 {
 return false;
 }

if (false == InitTable_EffectAsset())
 {
 return false;
 }

if (false == InitTable_Emoji())
 {
 return false;
 }

if (false == InitTable_Enviroment())
 {
 return false;
 }

if (false == InitTable_EverydaySign())
 {
 return false;
 }

if (false == InitTable_Example())
 {
 return false;
 }

if (false == InitTable_ExtraConfig())
 {
 return false;
 }

if (false == InitTable_FateDialog())
 {
 return false;
 }

if (false == InitTable_FateLine())
 {
 return false;
 }

if (false == InitTable_FateLineAvatar())
 {
 return false;
 }

if (false == InitTable_FateLineLevel())
 {
 return false;
 }

if (false == InitTable_FirstGift())
 {
 return false;
 }

if (false == InitTable_FuliAddSign())
 {
 return false;
 }

if (false == InitTable_FuliAddSignAward())
 {
 return false;
 }

if (false == InitTable_FuliDailyStamina())
 {
 return false;
 }

if (false == InitTable_FuliDailyStaminaDialog())
 {
 return false;
 }

if (false == InitTable_FuliFund())
 {
 return false;
 }

if (false == InitTable_FuliLottery())
 {
 return false;
 }

if (false == InitTable_FuliNormal())
 {
 return false;
 }

if (false == InitTable_FuliRecharge())
 {
 return false;
 }

if (false == InitTable_FuliRiddleCage())
 {
 return false;
 }

if (false == InitTable_FunctionUnlock())
 {
 return false;
 }

if (false == InitTable_Gift())
 {
 return false;
 }

if (false == InitTable_Goto())
 {
 return false;
 }

if (false == InitTable_Guide())
 {
 return false;
 }

if (false == InitTable_GuideEx())
 {
 return false;
 }

if (false == InitTable_Hardware())
 {
 return false;
 }

if (false == InitTable_HeartBeat())
 {
 return false;
 }

if (false == InitTable_HeartBeatAction())
 {
 return false;
 }

if (false == InitTable_HeartBeatDialog())
 {
 return false;
 }

if (false == InitTable_HeartBeatQuestion())
 {
 return false;
 }

if (false == InitTable_HelpTips())
 {
 return false;
 }

if (false == InitTable_Hexagram())
 {
 return false;
 }

if (false == InitTable_InteractGamePlay())
 {
 return false;
 }

if (false == InitTable_InteractSpecialSound())
 {
 return false;
 }

if (false == InitTable_Interflow())
 {
 return false;
 }

if (false == InitTable_IntimacyLevel())
 {
 return false;
 }

if (false == InitTable_Item())
 {
 return false;
 }

if (false == InitTable_ItemPageType())
 {
 return false;
 }

if (false == InitTable_LevelPlotDesc())
 {
 return false;
 }

if (false == InitTable_Loading())
 {
 return false;
 }

if (false == InitTable_LoadingScene())
 {
 return false;
 }

if (false == InitTable_LoadingText())
 {
 return false;
 }

if (false == InitTable_LoadingTexture())
 {
 return false;
 }

if (false == InitTable_LocalizationData())
 {
 return false;
 }

if (false == InitTable_MainSceneCarouselMap())
 {
 return false;
 }

if (false == InitTable_MainSceneTimeSceneEnv())
 {
 return false;
 }

if (false == InitTable_MisReputationLevel())
 {
 return false;
 }

if (false == InitTable_Mission())
 {
 return false;
 }

if (false == InitTable_MissionItem())
 {
 return false;
 }

if (false == InitTable_MissionMail())
 {
 return false;
 }

if (false == InitTable_MonthCard())
 {
 return false;
 }

if (false == InitTable_Node())
 {
 return false;
 }

if (false == InitTable_Notice())
 {
 return false;
 }

if (false == InitTable_NoticeType())
 {
 return false;
 }

if (false == InitTable_NoviceGuide())
 {
 return false;
 }

if (false == InitTable_Npc())
 {
 return false;
 }

if (false == InitTable_NpcLevel())
 {
 return false;
 }

if (false == InitTable_NpcQuestion())
 {
 return false;
 }

if (false == InitTable_NpcState())
 {
 return false;
 }

if (false == InitTable_NpcTask())
 {
 return false;
 }

if (false == InitTable_Npclike())
 {
 return false;
 }

if (false == InitTable_OptItem())
 {
 return false;
 }

if (false == InitTable_PersonalChapterAward())
 {
 return false;
 }

if (false == InitTable_PersonalStory())
 {
 return false;
 }

if (false == InitTable_Personality())
 {
 return false;
 }

if (false == InitTable_PersonalityData())
 {
 return false;
 }

if (false == InitTable_PersonalityLevel())
 {
 return false;
 }

if (false == InitTable_PersonalityMonologue())
 {
 return false;
 }

if (false == InitTable_PersonalityProcess())
 {
 return false;
 }

if (false == InitTable_PersonalityQuestion())
 {
 return false;
 }

if (false == InitTable_PlayerLevel())
 {
 return false;
 }

if (false == InitTable_Plot())
 {
 return false;
 }

if (false == InitTable_PlotInteraction())
 {
 return false;
 }

if (false == InitTable_Preloader())
 {
 return false;
 }

if (false == InitTable_ProductIDMap())
 {
 return false;
 }

if (false == InitTable_PushNotification())
 {
 return false;
 }

if (false == InitTable_PuzzleLevelData())
 {
 return false;
 }

if (false == InitTable_PuzzleThought())
 {
 return false;
 }

if (false == InitTable_PuzzleThoughtSet())
 {
 return false;
 }

if (false == InitTable_Question())
 {
 return false;
 }

if (false == InitTable_RechargeGift())
 {
 return false;
 }

if (false == InitTable_RechargeRule())
 {
 return false;
 }

if (false == InitTable_Retrieval())
 {
 return false;
 }

if (false == InitTable_RewardPreview())
 {
 return false;
 }

if (false == InitTable_Role())
 {
 return false;
 }

if (false == InitTable_Rumor())
 {
 return false;
 }

if (false == InitTable_RumorRewardRule())
 {
 return false;
 }

if (false == InitTable_RumorSub())
 {
 return false;
 }

if (false == InitTable_RumorSubSet())
 {
 return false;
 }

if (false == InitTable_SavePoint())
 {
 return false;
 }

if (false == InitTable_SceneClass())
 {
 return false;
 }

if (false == InitTable_SceneClassRandomEntry())
 {
 return false;
 }

if (false == InitTable_SceneEventCategory())
 {
 return false;
 }

if (false == InitTable_SceneEventDesc())
 {
 return false;
 }

if (false == InitTable_SceneNode())
 {
 return false;
 }

if (false == InitTable_SceneNpc())
 {
 return false;
 }

if (false == InitTable_SceneNpcCreateRule())
 {
 return false;
 }

if (false == InitTable_SceneNpcReplace())
 {
 return false;
 }

if (false == InitTable_SceneObject())
 {
 return false;
 }

if (false == InitTable_SceneTimeChange())
 {
 return false;
 }

if (false == InitTable_ScreenFade())
 {
 return false;
 }

if (false == InitTable_Secret())
 {
 return false;
 }

if (false == InitTable_SecretDesc())
 {
 return false;
 }

if (false == InitTable_SecretKeyword())
 {
 return false;
 }

if (false == InitTable_Selection())
 {
 return false;
 }

if (false == InitTable_ServerList())
 {
 return false;
 }

if (false == InitTable_ShopCommon())
 {
 return false;
 }

if (false == InitTable_ShopDiamond())
 {
 return false;
 }

if (false == InitTable_ShopGiftItem())
 {
 return false;
 }

if (false == InitTable_ShopType())
 {
 return false;
 }

if (false == InitTable_ShopTypeDialog())
 {
 return false;
 }

if (false == InitTable_Signboard())
 {
 return false;
 }

if (false == InitTable_SignboardDecals())
 {
 return false;
 }

if (false == InitTable_SignboardTheme())
 {
 return false;
 }

if (false == InitTable_Skill())
 {
 return false;
 }

if (false == InitTable_SkillEx())
 {
 return false;
 }

if (false == InitTable_SkinData())
 {
 return false;
 }

if (false == InitTable_SpecialClue())
 {
 return false;
 }

if (false == InitTable_SpecialLevelGamePlay())
 {
 return false;
 }

if (false == InitTable_StoryChapter())
 {
 return false;
 }

if (false == InitTable_StoryChapterCheckpoint())
 {
 return false;
 }

if (false == InitTable_StoryChapterEnding())
 {
 return false;
 }

if (false == InitTable_StoryChapterEndingDesc())
 {
 return false;
 }

if (false == InitTable_StoryChapterEndingRule())
 {
 return false;
 }

if (false == InitTable_StoryChapterLevel())
 {
 return false;
 }

if (false == InitTable_StoryChapterLevelReq())
 {
 return false;
 }

if (false == InitTable_StoryChapterLevelReward())
 {
 return false;
 }

if (false == InitTable_StoryChapterLevelRule())
 {
 return false;
 }

if (false == InitTable_StoryChapterLevelSceneEvent())
 {
 return false;
 }

if (false == InitTable_StoryChapterRule())
 {
 return false;
 }

if (false == InitTable_StoryLine())
 {
 return false;
 }

if (false == InitTable_StrDictionary())
 {
 return false;
 }

if (false == InitTable_StrFilter())
 {
 return false;
 }

if (false == InitTable_SystemMail())
 {
 return false;
 }

if (false == InitTable_TagData())
 {
 return false;
 }

if (false == InitTable_Task())
 {
 return false;
 }

if (false == InitTable_TaskAward())
 {
 return false;
 }

if (false == InitTable_TaskGroup())
 {
 return false;
 }

if (false == InitTable_TaskTab())
 {
 return false;
 }

if (false == InitTable_TeleportPoint())
 {
 return false;
 }

if (false == InitTable_Title())
 {
 return false;
 }

if (false == InitTable_TranlateDictionary())
 {
 return false;
 }

if (false == InitTable_TranlateDictionaryEn())
 {
 return false;
 }

if (false == InitTable_UIDictionary())
 {
 return false;
 }

if (false == InitTable_UIItemExtension())
 {
 return false;
 }

if (false == InitTable_UIPackage())
 {
 return false;
 }

if (false == InitTable_UIPanel())
 {
 return false;
 }

if (false == InitTable_UIRedDot())
 {
 return false;
 }

if (false == InitTable_VChat())
 {
 return false;
 }

if (false == InitTable_VChatEmoji())
 {
 return false;
 }

if (false == InitTable_VChatGroup())
 {
 return false;
 }

if (false == InitTable_VChatMsg())
 {
 return false;
 }

if (false == InitTable_VChatOption())
 {
 return false;
 }

if (false == InitTable_VoiceData())
 {
 return false;
 }

if (false == InitTable_VoiceExtraConfig())
 {
 return false;
 }


 return true;
 }

public static List<Tab_AbilityClue> GetAbilityClueLine(int nKey)
 {
 if(g_AbilityClue.Count==0)
 {
 InitTable_AbilityClue();
 }
 if( g_AbilityClue.ContainsKey(nKey))
 {
 return g_AbilityClue[nKey];
 }
 return null;
 }
 public static Tab_AbilityClue GetAbilityClueByID(int nKey)
 {
 return GetAbilityClueByID(nKey, 0);
 }
 public static Tab_AbilityClue GetAbilityClueByID(int nKey, int nIndex)
 {
 if(g_AbilityClue.Count==0)
 {
 InitTable_AbilityClue();
 }
 if( g_AbilityClue.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AbilityClue[nKey].Count)
 return g_AbilityClue[nKey][nIndex];
 }
 return null;
 }
 public static int GetAbilityClueCount()
 {
 if(g_AbilityClue.Count==0)
 {
 InitTable_AbilityClue();
 }
 
 return g_AbilityClue.Count;
 }
 public static Dictionary<int, List<Tab_AbilityClue> > GetAbilityClue()
 {
 if(g_AbilityClue.Count==0)
 {
 InitTable_AbilityClue();
 }
 return g_AbilityClue;
 }

public static List<Tab_AbilityData> GetAbilityDataLine(int nKey)
 {
 if(g_AbilityData.Count==0)
 {
 InitTable_AbilityData();
 }
 if( g_AbilityData.ContainsKey(nKey))
 {
 return g_AbilityData[nKey];
 }
 return null;
 }
 public static Tab_AbilityData GetAbilityDataByID(int nKey)
 {
 return GetAbilityDataByID(nKey, 0);
 }
 public static Tab_AbilityData GetAbilityDataByID(int nKey, int nIndex)
 {
 if(g_AbilityData.Count==0)
 {
 InitTable_AbilityData();
 }
 if( g_AbilityData.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AbilityData[nKey].Count)
 return g_AbilityData[nKey][nIndex];
 }
 return null;
 }
 public static int GetAbilityDataCount()
 {
 if(g_AbilityData.Count==0)
 {
 InitTable_AbilityData();
 }
 
 return g_AbilityData.Count;
 }
 public static Dictionary<int, List<Tab_AbilityData> > GetAbilityData()
 {
 if(g_AbilityData.Count==0)
 {
 InitTable_AbilityData();
 }
 return g_AbilityData;
 }

public static List<Tab_AbilityDataEx> GetAbilityDataExLine(int nKey)
 {
 if(g_AbilityDataEx.Count==0)
 {
 InitTable_AbilityDataEx();
 }
 if( g_AbilityDataEx.ContainsKey(nKey))
 {
 return g_AbilityDataEx[nKey];
 }
 return null;
 }
 public static Tab_AbilityDataEx GetAbilityDataExByID(int nKey)
 {
 return GetAbilityDataExByID(nKey, 0);
 }
 public static Tab_AbilityDataEx GetAbilityDataExByID(int nKey, int nIndex)
 {
 if(g_AbilityDataEx.Count==0)
 {
 InitTable_AbilityDataEx();
 }
 if( g_AbilityDataEx.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AbilityDataEx[nKey].Count)
 return g_AbilityDataEx[nKey][nIndex];
 }
 return null;
 }
 public static int GetAbilityDataExCount()
 {
 if(g_AbilityDataEx.Count==0)
 {
 InitTable_AbilityDataEx();
 }
 
 return g_AbilityDataEx.Count;
 }
 public static Dictionary<int, List<Tab_AbilityDataEx> > GetAbilityDataEx()
 {
 if(g_AbilityDataEx.Count==0)
 {
 InitTable_AbilityDataEx();
 }
 return g_AbilityDataEx;
 }

public static List<Tab_Action> GetActionLine(int nKey)
 {
 if(g_Action.Count==0)
 {
 InitTable_Action();
 }
 if( g_Action.ContainsKey(nKey))
 {
 return g_Action[nKey];
 }
 return null;
 }
 public static Tab_Action GetActionByID(int nKey)
 {
 return GetActionByID(nKey, 0);
 }
 public static Tab_Action GetActionByID(int nKey, int nIndex)
 {
 if(g_Action.Count==0)
 {
 InitTable_Action();
 }
 if( g_Action.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Action[nKey].Count)
 return g_Action[nKey][nIndex];
 }
 return null;
 }
 public static int GetActionCount()
 {
 if(g_Action.Count==0)
 {
 InitTable_Action();
 }
 
 return g_Action.Count;
 }
 public static Dictionary<int, List<Tab_Action> > GetAction()
 {
 if(g_Action.Count==0)
 {
 InitTable_Action();
 }
 return g_Action;
 }

public static List<Tab_ActionAvatarEvent> GetActionAvatarEventLine(int nKey)
 {
 if(g_ActionAvatarEvent.Count==0)
 {
 InitTable_ActionAvatarEvent();
 }
 if( g_ActionAvatarEvent.ContainsKey(nKey))
 {
 return g_ActionAvatarEvent[nKey];
 }
 return null;
 }
 public static Tab_ActionAvatarEvent GetActionAvatarEventByID(int nKey)
 {
 return GetActionAvatarEventByID(nKey, 0);
 }
 public static Tab_ActionAvatarEvent GetActionAvatarEventByID(int nKey, int nIndex)
 {
 if(g_ActionAvatarEvent.Count==0)
 {
 InitTable_ActionAvatarEvent();
 }
 if( g_ActionAvatarEvent.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ActionAvatarEvent[nKey].Count)
 return g_ActionAvatarEvent[nKey][nIndex];
 }
 return null;
 }
 public static int GetActionAvatarEventCount()
 {
 if(g_ActionAvatarEvent.Count==0)
 {
 InitTable_ActionAvatarEvent();
 }
 
 return g_ActionAvatarEvent.Count;
 }
 public static Dictionary<int, List<Tab_ActionAvatarEvent> > GetActionAvatarEvent()
 {
 if(g_ActionAvatarEvent.Count==0)
 {
 InitTable_ActionAvatarEvent();
 }
 return g_ActionAvatarEvent;
 }

public static List<Tab_ActionReview> GetActionReviewLine(int nKey)
 {
 if(g_ActionReview.Count==0)
 {
 InitTable_ActionReview();
 }
 if( g_ActionReview.ContainsKey(nKey))
 {
 return g_ActionReview[nKey];
 }
 return null;
 }
 public static Tab_ActionReview GetActionReviewByID(int nKey)
 {
 return GetActionReviewByID(nKey, 0);
 }
 public static Tab_ActionReview GetActionReviewByID(int nKey, int nIndex)
 {
 if(g_ActionReview.Count==0)
 {
 InitTable_ActionReview();
 }
 if( g_ActionReview.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ActionReview[nKey].Count)
 return g_ActionReview[nKey][nIndex];
 }
 return null;
 }
 public static int GetActionReviewCount()
 {
 if(g_ActionReview.Count==0)
 {
 InitTable_ActionReview();
 }
 
 return g_ActionReview.Count;
 }
 public static Dictionary<int, List<Tab_ActionReview> > GetActionReview()
 {
 if(g_ActionReview.Count==0)
 {
 InitTable_ActionReview();
 }
 return g_ActionReview;
 }

public static List<Tab_ActionSkip> GetActionSkipLine(int nKey)
 {
 if(g_ActionSkip.Count==0)
 {
 InitTable_ActionSkip();
 }
 if( g_ActionSkip.ContainsKey(nKey))
 {
 return g_ActionSkip[nKey];
 }
 return null;
 }
 public static Tab_ActionSkip GetActionSkipByID(int nKey)
 {
 return GetActionSkipByID(nKey, 0);
 }
 public static Tab_ActionSkip GetActionSkipByID(int nKey, int nIndex)
 {
 if(g_ActionSkip.Count==0)
 {
 InitTable_ActionSkip();
 }
 if( g_ActionSkip.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ActionSkip[nKey].Count)
 return g_ActionSkip[nKey][nIndex];
 }
 return null;
 }
 public static int GetActionSkipCount()
 {
 if(g_ActionSkip.Count==0)
 {
 InitTable_ActionSkip();
 }
 
 return g_ActionSkip.Count;
 }
 public static Dictionary<int, List<Tab_ActionSkip> > GetActionSkip()
 {
 if(g_ActionSkip.Count==0)
 {
 InitTable_ActionSkip();
 }
 return g_ActionSkip;
 }

public static List<Tab_AlbumCard> GetAlbumCardLine(int nKey)
 {
 if(g_AlbumCard.Count==0)
 {
 InitTable_AlbumCard();
 }
 if( g_AlbumCard.ContainsKey(nKey))
 {
 return g_AlbumCard[nKey];
 }
 return null;
 }
 public static Tab_AlbumCard GetAlbumCardByID(int nKey)
 {
 return GetAlbumCardByID(nKey, 0);
 }
 public static Tab_AlbumCard GetAlbumCardByID(int nKey, int nIndex)
 {
 if(g_AlbumCard.Count==0)
 {
 InitTable_AlbumCard();
 }
 if( g_AlbumCard.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AlbumCard[nKey].Count)
 return g_AlbumCard[nKey][nIndex];
 }
 return null;
 }
 public static int GetAlbumCardCount()
 {
 if(g_AlbumCard.Count==0)
 {
 InitTable_AlbumCard();
 }
 
 return g_AlbumCard.Count;
 }
 public static Dictionary<int, List<Tab_AlbumCard> > GetAlbumCard()
 {
 if(g_AlbumCard.Count==0)
 {
 InitTable_AlbumCard();
 }
 return g_AlbumCard;
 }

public static List<Tab_AlbumLevel> GetAlbumLevelLine(int nKey)
 {
 if(g_AlbumLevel.Count==0)
 {
 InitTable_AlbumLevel();
 }
 if( g_AlbumLevel.ContainsKey(nKey))
 {
 return g_AlbumLevel[nKey];
 }
 return null;
 }
 public static Tab_AlbumLevel GetAlbumLevelByID(int nKey)
 {
 return GetAlbumLevelByID(nKey, 0);
 }
 public static Tab_AlbumLevel GetAlbumLevelByID(int nKey, int nIndex)
 {
 if(g_AlbumLevel.Count==0)
 {
 InitTable_AlbumLevel();
 }
 if( g_AlbumLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AlbumLevel[nKey].Count)
 return g_AlbumLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetAlbumLevelCount()
 {
 if(g_AlbumLevel.Count==0)
 {
 InitTable_AlbumLevel();
 }
 
 return g_AlbumLevel.Count;
 }
 public static Dictionary<int, List<Tab_AlbumLevel> > GetAlbumLevel()
 {
 if(g_AlbumLevel.Count==0)
 {
 InitTable_AlbumLevel();
 }
 return g_AlbumLevel;
 }

public static List<Tab_AlbumStory> GetAlbumStoryLine(int nKey)
 {
 if(g_AlbumStory.Count==0)
 {
 InitTable_AlbumStory();
 }
 if( g_AlbumStory.ContainsKey(nKey))
 {
 return g_AlbumStory[nKey];
 }
 return null;
 }
 public static Tab_AlbumStory GetAlbumStoryByID(int nKey)
 {
 return GetAlbumStoryByID(nKey, 0);
 }
 public static Tab_AlbumStory GetAlbumStoryByID(int nKey, int nIndex)
 {
 if(g_AlbumStory.Count==0)
 {
 InitTable_AlbumStory();
 }
 if( g_AlbumStory.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AlbumStory[nKey].Count)
 return g_AlbumStory[nKey][nIndex];
 }
 return null;
 }
 public static int GetAlbumStoryCount()
 {
 if(g_AlbumStory.Count==0)
 {
 InitTable_AlbumStory();
 }
 
 return g_AlbumStory.Count;
 }
 public static Dictionary<int, List<Tab_AlbumStory> > GetAlbumStory()
 {
 if(g_AlbumStory.Count==0)
 {
 InitTable_AlbumStory();
 }
 return g_AlbumStory;
 }

public static List<Tab_AlbumStorySub> GetAlbumStorySubLine(int nKey)
 {
 if(g_AlbumStorySub.Count==0)
 {
 InitTable_AlbumStorySub();
 }
 if( g_AlbumStorySub.ContainsKey(nKey))
 {
 return g_AlbumStorySub[nKey];
 }
 return null;
 }
 public static Tab_AlbumStorySub GetAlbumStorySubByID(int nKey)
 {
 return GetAlbumStorySubByID(nKey, 0);
 }
 public static Tab_AlbumStorySub GetAlbumStorySubByID(int nKey, int nIndex)
 {
 if(g_AlbumStorySub.Count==0)
 {
 InitTable_AlbumStorySub();
 }
 if( g_AlbumStorySub.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AlbumStorySub[nKey].Count)
 return g_AlbumStorySub[nKey][nIndex];
 }
 return null;
 }
 public static int GetAlbumStorySubCount()
 {
 if(g_AlbumStorySub.Count==0)
 {
 InitTable_AlbumStorySub();
 }
 
 return g_AlbumStorySub.Count;
 }
 public static Dictionary<int, List<Tab_AlbumStorySub> > GetAlbumStorySub()
 {
 if(g_AlbumStorySub.Count==0)
 {
 InitTable_AlbumStorySub();
 }
 return g_AlbumStorySub;
 }

public static List<Tab_Appointment> GetAppointmentLine(int nKey)
 {
 if(g_Appointment.Count==0)
 {
 InitTable_Appointment();
 }
 if( g_Appointment.ContainsKey(nKey))
 {
 return g_Appointment[nKey];
 }
 return null;
 }
 public static Tab_Appointment GetAppointmentByID(int nKey)
 {
 return GetAppointmentByID(nKey, 0);
 }
 public static Tab_Appointment GetAppointmentByID(int nKey, int nIndex)
 {
 if(g_Appointment.Count==0)
 {
 InitTable_Appointment();
 }
 if( g_Appointment.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Appointment[nKey].Count)
 return g_Appointment[nKey][nIndex];
 }
 return null;
 }
 public static int GetAppointmentCount()
 {
 if(g_Appointment.Count==0)
 {
 InitTable_Appointment();
 }
 
 return g_Appointment.Count;
 }
 public static Dictionary<int, List<Tab_Appointment> > GetAppointment()
 {
 if(g_Appointment.Count==0)
 {
 InitTable_Appointment();
 }
 return g_Appointment;
 }

public static List<Tab_Article> GetArticleLine(int nKey)
 {
 if(g_Article.Count==0)
 {
 InitTable_Article();
 }
 if( g_Article.ContainsKey(nKey))
 {
 return g_Article[nKey];
 }
 return null;
 }
 public static Tab_Article GetArticleByID(int nKey)
 {
 return GetArticleByID(nKey, 0);
 }
 public static Tab_Article GetArticleByID(int nKey, int nIndex)
 {
 if(g_Article.Count==0)
 {
 InitTable_Article();
 }
 if( g_Article.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Article[nKey].Count)
 return g_Article[nKey][nIndex];
 }
 return null;
 }
 public static int GetArticleCount()
 {
 if(g_Article.Count==0)
 {
 InitTable_Article();
 }
 
 return g_Article.Count;
 }
 public static Dictionary<int, List<Tab_Article> > GetArticle()
 {
 if(g_Article.Count==0)
 {
 InitTable_Article();
 }
 return g_Article;
 }

public static List<Tab_ArticleDetail> GetArticleDetailLine(int nKey)
 {
 if(g_ArticleDetail.Count==0)
 {
 InitTable_ArticleDetail();
 }
 if( g_ArticleDetail.ContainsKey(nKey))
 {
 return g_ArticleDetail[nKey];
 }
 return null;
 }
 public static Tab_ArticleDetail GetArticleDetailByID(int nKey)
 {
 return GetArticleDetailByID(nKey, 0);
 }
 public static Tab_ArticleDetail GetArticleDetailByID(int nKey, int nIndex)
 {
 if(g_ArticleDetail.Count==0)
 {
 InitTable_ArticleDetail();
 }
 if( g_ArticleDetail.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ArticleDetail[nKey].Count)
 return g_ArticleDetail[nKey][nIndex];
 }
 return null;
 }
 public static int GetArticleDetailCount()
 {
 if(g_ArticleDetail.Count==0)
 {
 InitTable_ArticleDetail();
 }
 
 return g_ArticleDetail.Count;
 }
 public static Dictionary<int, List<Tab_ArticleDetail> > GetArticleDetail()
 {
 if(g_ArticleDetail.Count==0)
 {
 InitTable_ArticleDetail();
 }
 return g_ArticleDetail;
 }

public static List<Tab_ArticleOfficialAccount> GetArticleOfficialAccountLine(int nKey)
 {
 if(g_ArticleOfficialAccount.Count==0)
 {
 InitTable_ArticleOfficialAccount();
 }
 if( g_ArticleOfficialAccount.ContainsKey(nKey))
 {
 return g_ArticleOfficialAccount[nKey];
 }
 return null;
 }
 public static Tab_ArticleOfficialAccount GetArticleOfficialAccountByID(int nKey)
 {
 return GetArticleOfficialAccountByID(nKey, 0);
 }
 public static Tab_ArticleOfficialAccount GetArticleOfficialAccountByID(int nKey, int nIndex)
 {
 if(g_ArticleOfficialAccount.Count==0)
 {
 InitTable_ArticleOfficialAccount();
 }
 if( g_ArticleOfficialAccount.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ArticleOfficialAccount[nKey].Count)
 return g_ArticleOfficialAccount[nKey][nIndex];
 }
 return null;
 }
 public static int GetArticleOfficialAccountCount()
 {
 if(g_ArticleOfficialAccount.Count==0)
 {
 InitTable_ArticleOfficialAccount();
 }
 
 return g_ArticleOfficialAccount.Count;
 }
 public static Dictionary<int, List<Tab_ArticleOfficialAccount> > GetArticleOfficialAccount()
 {
 if(g_ArticleOfficialAccount.Count==0)
 {
 InitTable_ArticleOfficialAccount();
 }
 return g_ArticleOfficialAccount;
 }

public static List<Tab_ArticleReply> GetArticleReplyLine(int nKey)
 {
 if(g_ArticleReply.Count==0)
 {
 InitTable_ArticleReply();
 }
 if( g_ArticleReply.ContainsKey(nKey))
 {
 return g_ArticleReply[nKey];
 }
 return null;
 }
 public static Tab_ArticleReply GetArticleReplyByID(int nKey)
 {
 return GetArticleReplyByID(nKey, 0);
 }
 public static Tab_ArticleReply GetArticleReplyByID(int nKey, int nIndex)
 {
 if(g_ArticleReply.Count==0)
 {
 InitTable_ArticleReply();
 }
 if( g_ArticleReply.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ArticleReply[nKey].Count)
 return g_ArticleReply[nKey][nIndex];
 }
 return null;
 }
 public static int GetArticleReplyCount()
 {
 if(g_ArticleReply.Count==0)
 {
 InitTable_ArticleReply();
 }
 
 return g_ArticleReply.Count;
 }
 public static Dictionary<int, List<Tab_ArticleReply> > GetArticleReply()
 {
 if(g_ArticleReply.Count==0)
 {
 InitTable_ArticleReply();
 }
 return g_ArticleReply;
 }

public static List<Tab_AssetGroup> GetAssetGroupLine(int nKey)
 {
 if(g_AssetGroup.Count==0)
 {
 InitTable_AssetGroup();
 }
 if( g_AssetGroup.ContainsKey(nKey))
 {
 return g_AssetGroup[nKey];
 }
 return null;
 }
 public static Tab_AssetGroup GetAssetGroupByID(int nKey)
 {
 return GetAssetGroupByID(nKey, 0);
 }
 public static Tab_AssetGroup GetAssetGroupByID(int nKey, int nIndex)
 {
 if(g_AssetGroup.Count==0)
 {
 InitTable_AssetGroup();
 }
 if( g_AssetGroup.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AssetGroup[nKey].Count)
 return g_AssetGroup[nKey][nIndex];
 }
 return null;
 }
 public static int GetAssetGroupCount()
 {
 if(g_AssetGroup.Count==0)
 {
 InitTable_AssetGroup();
 }
 
 return g_AssetGroup.Count;
 }
 public static Dictionary<int, List<Tab_AssetGroup> > GetAssetGroup()
 {
 if(g_AssetGroup.Count==0)
 {
 InitTable_AssetGroup();
 }
 return g_AssetGroup;
 }

public static List<Tab_AssetList> GetAssetListLine(int nKey)
 {
 if(g_AssetList.Count==0)
 {
 InitTable_AssetList();
 }
 if( g_AssetList.ContainsKey(nKey))
 {
 return g_AssetList[nKey];
 }
 return null;
 }
 public static Tab_AssetList GetAssetListByID(int nKey)
 {
 return GetAssetListByID(nKey, 0);
 }
 public static Tab_AssetList GetAssetListByID(int nKey, int nIndex)
 {
 if(g_AssetList.Count==0)
 {
 InitTable_AssetList();
 }
 if( g_AssetList.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AssetList[nKey].Count)
 return g_AssetList[nKey][nIndex];
 }
 return null;
 }
 public static int GetAssetListCount()
 {
 if(g_AssetList.Count==0)
 {
 InitTable_AssetList();
 }
 
 return g_AssetList.Count;
 }
 public static Dictionary<int, List<Tab_AssetList> > GetAssetList()
 {
 if(g_AssetList.Count==0)
 {
 InitTable_AssetList();
 }
 return g_AssetList;
 }

public static List<Tab_AttrData> GetAttrDataLine(int nKey)
 {
 if(g_AttrData.Count==0)
 {
 InitTable_AttrData();
 }
 if( g_AttrData.ContainsKey(nKey))
 {
 return g_AttrData[nKey];
 }
 return null;
 }
 public static Tab_AttrData GetAttrDataByID(int nKey)
 {
 return GetAttrDataByID(nKey, 0);
 }
 public static Tab_AttrData GetAttrDataByID(int nKey, int nIndex)
 {
 if(g_AttrData.Count==0)
 {
 InitTable_AttrData();
 }
 if( g_AttrData.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AttrData[nKey].Count)
 return g_AttrData[nKey][nIndex];
 }
 return null;
 }
 public static int GetAttrDataCount()
 {
 if(g_AttrData.Count==0)
 {
 InitTable_AttrData();
 }
 
 return g_AttrData.Count;
 }
 public static Dictionary<int, List<Tab_AttrData> > GetAttrData()
 {
 if(g_AttrData.Count==0)
 {
 InitTable_AttrData();
 }
 return g_AttrData;
 }

public static List<Tab_Audio> GetAudioLine(int nKey)
 {
 if(g_Audio.Count==0)
 {
 InitTable_Audio();
 }
 if( g_Audio.ContainsKey(nKey))
 {
 return g_Audio[nKey];
 }
 return null;
 }
 public static Tab_Audio GetAudioByID(int nKey)
 {
 return GetAudioByID(nKey, 0);
 }
 public static Tab_Audio GetAudioByID(int nKey, int nIndex)
 {
 if(g_Audio.Count==0)
 {
 InitTable_Audio();
 }
 if( g_Audio.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Audio[nKey].Count)
 return g_Audio[nKey][nIndex];
 }
 return null;
 }
 public static int GetAudioCount()
 {
 if(g_Audio.Count==0)
 {
 InitTable_Audio();
 }
 
 return g_Audio.Count;
 }
 public static Dictionary<int, List<Tab_Audio> > GetAudio()
 {
 if(g_Audio.Count==0)
 {
 InitTable_Audio();
 }
 return g_Audio;
 }

public static List<Tab_AudioAcb> GetAudioAcbLine(int nKey)
 {
 if(g_AudioAcb.Count==0)
 {
 InitTable_AudioAcb();
 }
 if( g_AudioAcb.ContainsKey(nKey))
 {
 return g_AudioAcb[nKey];
 }
 return null;
 }
 public static Tab_AudioAcb GetAudioAcbByID(int nKey)
 {
 return GetAudioAcbByID(nKey, 0);
 }
 public static Tab_AudioAcb GetAudioAcbByID(int nKey, int nIndex)
 {
 if(g_AudioAcb.Count==0)
 {
 InitTable_AudioAcb();
 }
 if( g_AudioAcb.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_AudioAcb[nKey].Count)
 return g_AudioAcb[nKey][nIndex];
 }
 return null;
 }
 public static int GetAudioAcbCount()
 {
 if(g_AudioAcb.Count==0)
 {
 InitTable_AudioAcb();
 }
 
 return g_AudioAcb.Count;
 }
 public static Dictionary<int, List<Tab_AudioAcb> > GetAudioAcb()
 {
 if(g_AudioAcb.Count==0)
 {
 InitTable_AudioAcb();
 }
 return g_AudioAcb;
 }

public static List<Tab_Avatar> GetAvatarLine(int nKey)
 {
 if(g_Avatar.Count==0)
 {
 InitTable_Avatar();
 }
 if( g_Avatar.ContainsKey(nKey))
 {
 return g_Avatar[nKey];
 }
 return null;
 }
 public static Tab_Avatar GetAvatarByID(int nKey)
 {
 return GetAvatarByID(nKey, 0);
 }
 public static Tab_Avatar GetAvatarByID(int nKey, int nIndex)
 {
 if(g_Avatar.Count==0)
 {
 InitTable_Avatar();
 }
 if( g_Avatar.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Avatar[nKey].Count)
 return g_Avatar[nKey][nIndex];
 }
 return null;
 }
 public static int GetAvatarCount()
 {
 if(g_Avatar.Count==0)
 {
 InitTable_Avatar();
 }
 
 return g_Avatar.Count;
 }
 public static Dictionary<int, List<Tab_Avatar> > GetAvatar()
 {
 if(g_Avatar.Count==0)
 {
 InitTable_Avatar();
 }
 return g_Avatar;
 }

public static List<Tab_BattlePass> GetBattlePassLine(int nKey)
 {
 if(g_BattlePass.Count==0)
 {
 InitTable_BattlePass();
 }
 if( g_BattlePass.ContainsKey(nKey))
 {
 return g_BattlePass[nKey];
 }
 return null;
 }
 public static Tab_BattlePass GetBattlePassByID(int nKey)
 {
 return GetBattlePassByID(nKey, 0);
 }
 public static Tab_BattlePass GetBattlePassByID(int nKey, int nIndex)
 {
 if(g_BattlePass.Count==0)
 {
 InitTable_BattlePass();
 }
 if( g_BattlePass.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_BattlePass[nKey].Count)
 return g_BattlePass[nKey][nIndex];
 }
 return null;
 }
 public static int GetBattlePassCount()
 {
 if(g_BattlePass.Count==0)
 {
 InitTable_BattlePass();
 }
 
 return g_BattlePass.Count;
 }
 public static Dictionary<int, List<Tab_BattlePass> > GetBattlePass()
 {
 if(g_BattlePass.Count==0)
 {
 InitTable_BattlePass();
 }
 return g_BattlePass;
 }

public static List<Tab_BattlePassTask> GetBattlePassTaskLine(int nKey)
 {
 if(g_BattlePassTask.Count==0)
 {
 InitTable_BattlePassTask();
 }
 if( g_BattlePassTask.ContainsKey(nKey))
 {
 return g_BattlePassTask[nKey];
 }
 return null;
 }
 public static Tab_BattlePassTask GetBattlePassTaskByID(int nKey)
 {
 return GetBattlePassTaskByID(nKey, 0);
 }
 public static Tab_BattlePassTask GetBattlePassTaskByID(int nKey, int nIndex)
 {
 if(g_BattlePassTask.Count==0)
 {
 InitTable_BattlePassTask();
 }
 if( g_BattlePassTask.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_BattlePassTask[nKey].Count)
 return g_BattlePassTask[nKey][nIndex];
 }
 return null;
 }
 public static int GetBattlePassTaskCount()
 {
 if(g_BattlePassTask.Count==0)
 {
 InitTable_BattlePassTask();
 }
 
 return g_BattlePassTask.Count;
 }
 public static Dictionary<int, List<Tab_BattlePassTask> > GetBattlePassTask()
 {
 if(g_BattlePassTask.Count==0)
 {
 InitTable_BattlePassTask();
 }
 return g_BattlePassTask;
 }

public static List<Tab_BattleScript> GetBattleScriptLine(int nKey)
 {
 if(g_BattleScript.Count==0)
 {
 InitTable_BattleScript();
 }
 if( g_BattleScript.ContainsKey(nKey))
 {
 return g_BattleScript[nKey];
 }
 return null;
 }
 public static Tab_BattleScript GetBattleScriptByID(int nKey)
 {
 return GetBattleScriptByID(nKey, 0);
 }
 public static Tab_BattleScript GetBattleScriptByID(int nKey, int nIndex)
 {
 if(g_BattleScript.Count==0)
 {
 InitTable_BattleScript();
 }
 if( g_BattleScript.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_BattleScript[nKey].Count)
 return g_BattleScript[nKey][nIndex];
 }
 return null;
 }
 public static int GetBattleScriptCount()
 {
 if(g_BattleScript.Count==0)
 {
 InitTable_BattleScript();
 }
 
 return g_BattleScript.Count;
 }
 public static Dictionary<int, List<Tab_BattleScript> > GetBattleScript()
 {
 if(g_BattleScript.Count==0)
 {
 InitTable_BattleScript();
 }
 return g_BattleScript;
 }

public static List<Tab_BehaviorCalcNum> GetBehaviorCalcNumLine(int nKey)
 {
 if(g_BehaviorCalcNum.Count==0)
 {
 InitTable_BehaviorCalcNum();
 }
 if( g_BehaviorCalcNum.ContainsKey(nKey))
 {
 return g_BehaviorCalcNum[nKey];
 }
 return null;
 }
 public static Tab_BehaviorCalcNum GetBehaviorCalcNumByID(int nKey)
 {
 return GetBehaviorCalcNumByID(nKey, 0);
 }
 public static Tab_BehaviorCalcNum GetBehaviorCalcNumByID(int nKey, int nIndex)
 {
 if(g_BehaviorCalcNum.Count==0)
 {
 InitTable_BehaviorCalcNum();
 }
 if( g_BehaviorCalcNum.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_BehaviorCalcNum[nKey].Count)
 return g_BehaviorCalcNum[nKey][nIndex];
 }
 return null;
 }
 public static int GetBehaviorCalcNumCount()
 {
 if(g_BehaviorCalcNum.Count==0)
 {
 InitTable_BehaviorCalcNum();
 }
 
 return g_BehaviorCalcNum.Count;
 }
 public static Dictionary<int, List<Tab_BehaviorCalcNum> > GetBehaviorCalcNum()
 {
 if(g_BehaviorCalcNum.Count==0)
 {
 InitTable_BehaviorCalcNum();
 }
 return g_BehaviorCalcNum;
 }

public static List<Tab_BundleConfig> GetBundleConfigLine(int nKey)
 {
 if(g_BundleConfig.Count==0)
 {
 InitTable_BundleConfig();
 }
 if( g_BundleConfig.ContainsKey(nKey))
 {
 return g_BundleConfig[nKey];
 }
 return null;
 }
 public static Tab_BundleConfig GetBundleConfigByID(int nKey)
 {
 return GetBundleConfigByID(nKey, 0);
 }
 public static Tab_BundleConfig GetBundleConfigByID(int nKey, int nIndex)
 {
 if(g_BundleConfig.Count==0)
 {
 InitTable_BundleConfig();
 }
 if( g_BundleConfig.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_BundleConfig[nKey].Count)
 return g_BundleConfig[nKey][nIndex];
 }
 return null;
 }
 public static int GetBundleConfigCount()
 {
 if(g_BundleConfig.Count==0)
 {
 InitTable_BundleConfig();
 }
 
 return g_BundleConfig.Count;
 }
 public static Dictionary<int, List<Tab_BundleConfig> > GetBundleConfig()
 {
 if(g_BundleConfig.Count==0)
 {
 InitTable_BundleConfig();
 }
 return g_BundleConfig;
 }

public static List<Tab_BuyGold> GetBuyGoldLine(int nKey)
 {
 if(g_BuyGold.Count==0)
 {
 InitTable_BuyGold();
 }
 if( g_BuyGold.ContainsKey(nKey))
 {
 return g_BuyGold[nKey];
 }
 return null;
 }
 public static Tab_BuyGold GetBuyGoldByID(int nKey)
 {
 return GetBuyGoldByID(nKey, 0);
 }
 public static Tab_BuyGold GetBuyGoldByID(int nKey, int nIndex)
 {
 if(g_BuyGold.Count==0)
 {
 InitTable_BuyGold();
 }
 if( g_BuyGold.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_BuyGold[nKey].Count)
 return g_BuyGold[nKey][nIndex];
 }
 return null;
 }
 public static int GetBuyGoldCount()
 {
 if(g_BuyGold.Count==0)
 {
 InitTable_BuyGold();
 }
 
 return g_BuyGold.Count;
 }
 public static Dictionary<int, List<Tab_BuyGold> > GetBuyGold()
 {
 if(g_BuyGold.Count==0)
 {
 InitTable_BuyGold();
 }
 return g_BuyGold;
 }

public static List<Tab_BuyStamina> GetBuyStaminaLine(int nKey)
 {
 if(g_BuyStamina.Count==0)
 {
 InitTable_BuyStamina();
 }
 if( g_BuyStamina.ContainsKey(nKey))
 {
 return g_BuyStamina[nKey];
 }
 return null;
 }
 public static Tab_BuyStamina GetBuyStaminaByID(int nKey)
 {
 return GetBuyStaminaByID(nKey, 0);
 }
 public static Tab_BuyStamina GetBuyStaminaByID(int nKey, int nIndex)
 {
 if(g_BuyStamina.Count==0)
 {
 InitTable_BuyStamina();
 }
 if( g_BuyStamina.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_BuyStamina[nKey].Count)
 return g_BuyStamina[nKey][nIndex];
 }
 return null;
 }
 public static int GetBuyStaminaCount()
 {
 if(g_BuyStamina.Count==0)
 {
 InitTable_BuyStamina();
 }
 
 return g_BuyStamina.Count;
 }
 public static Dictionary<int, List<Tab_BuyStamina> > GetBuyStamina()
 {
 if(g_BuyStamina.Count==0)
 {
 InitTable_BuyStamina();
 }
 return g_BuyStamina;
 }

public static List<Tab_CV> GetCVLine(int nKey)
 {
 if(g_CV.Count==0)
 {
 InitTable_CV();
 }
 if( g_CV.ContainsKey(nKey))
 {
 return g_CV[nKey];
 }
 return null;
 }
 public static Tab_CV GetCVByID(int nKey)
 {
 return GetCVByID(nKey, 0);
 }
 public static Tab_CV GetCVByID(int nKey, int nIndex)
 {
 if(g_CV.Count==0)
 {
 InitTable_CV();
 }
 if( g_CV.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CV[nKey].Count)
 return g_CV[nKey][nIndex];
 }
 return null;
 }
 public static int GetCVCount()
 {
 if(g_CV.Count==0)
 {
 InitTable_CV();
 }
 
 return g_CV.Count;
 }
 public static Dictionary<int, List<Tab_CV> > GetCV()
 {
 if(g_CV.Count==0)
 {
 InitTable_CV();
 }
 return g_CV;
 }

public static List<Tab_Camera> GetCameraLine(int nKey)
 {
 if(g_Camera.Count==0)
 {
 InitTable_Camera();
 }
 if( g_Camera.ContainsKey(nKey))
 {
 return g_Camera[nKey];
 }
 return null;
 }
 public static Tab_Camera GetCameraByID(int nKey)
 {
 return GetCameraByID(nKey, 0);
 }
 public static Tab_Camera GetCameraByID(int nKey, int nIndex)
 {
 if(g_Camera.Count==0)
 {
 InitTable_Camera();
 }
 if( g_Camera.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Camera[nKey].Count)
 return g_Camera[nKey][nIndex];
 }
 return null;
 }
 public static int GetCameraCount()
 {
 if(g_Camera.Count==0)
 {
 InitTable_Camera();
 }
 
 return g_Camera.Count;
 }
 public static Dictionary<int, List<Tab_Camera> > GetCamera()
 {
 if(g_Camera.Count==0)
 {
 InitTable_Camera();
 }
 return g_Camera;
 }

public static List<Tab_CameraShake> GetCameraShakeLine(int nKey)
 {
 if(g_CameraShake.Count==0)
 {
 InitTable_CameraShake();
 }
 if( g_CameraShake.ContainsKey(nKey))
 {
 return g_CameraShake[nKey];
 }
 return null;
 }
 public static Tab_CameraShake GetCameraShakeByID(int nKey)
 {
 return GetCameraShakeByID(nKey, 0);
 }
 public static Tab_CameraShake GetCameraShakeByID(int nKey, int nIndex)
 {
 if(g_CameraShake.Count==0)
 {
 InitTable_CameraShake();
 }
 if( g_CameraShake.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CameraShake[nKey].Count)
 return g_CameraShake[nKey][nIndex];
 }
 return null;
 }
 public static int GetCameraShakeCount()
 {
 if(g_CameraShake.Count==0)
 {
 InitTable_CameraShake();
 }
 
 return g_CameraShake.Count;
 }
 public static Dictionary<int, List<Tab_CameraShake> > GetCameraShake()
 {
 if(g_CameraShake.Count==0)
 {
 InitTable_CameraShake();
 }
 return g_CameraShake;
 }

public static List<Tab_Card> GetCardLine(int nKey)
 {
 if(g_Card.Count==0)
 {
 InitTable_Card();
 }
 if( g_Card.ContainsKey(nKey))
 {
 return g_Card[nKey];
 }
 return null;
 }
 public static Tab_Card GetCardByID(int nKey)
 {
 return GetCardByID(nKey, 0);
 }
 public static Tab_Card GetCardByID(int nKey, int nIndex)
 {
 if(g_Card.Count==0)
 {
 InitTable_Card();
 }
 if( g_Card.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Card[nKey].Count)
 return g_Card[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardCount()
 {
 if(g_Card.Count==0)
 {
 InitTable_Card();
 }
 
 return g_Card.Count;
 }
 public static Dictionary<int, List<Tab_Card> > GetCard()
 {
 if(g_Card.Count==0)
 {
 InitTable_Card();
 }
 return g_Card;
 }

public static List<Tab_CardAsset> GetCardAssetLine(int nKey)
 {
 if(g_CardAsset.Count==0)
 {
 InitTable_CardAsset();
 }
 if( g_CardAsset.ContainsKey(nKey))
 {
 return g_CardAsset[nKey];
 }
 return null;
 }
 public static Tab_CardAsset GetCardAssetByID(int nKey)
 {
 return GetCardAssetByID(nKey, 0);
 }
 public static Tab_CardAsset GetCardAssetByID(int nKey, int nIndex)
 {
 if(g_CardAsset.Count==0)
 {
 InitTable_CardAsset();
 }
 if( g_CardAsset.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardAsset[nKey].Count)
 return g_CardAsset[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardAssetCount()
 {
 if(g_CardAsset.Count==0)
 {
 InitTable_CardAsset();
 }
 
 return g_CardAsset.Count;
 }
 public static Dictionary<int, List<Tab_CardAsset> > GetCardAsset()
 {
 if(g_CardAsset.Count==0)
 {
 InitTable_CardAsset();
 }
 return g_CardAsset;
 }

public static List<Tab_CardAttrGrow> GetCardAttrGrowLine(int nKey)
 {
 if(g_CardAttrGrow.Count==0)
 {
 InitTable_CardAttrGrow();
 }
 if( g_CardAttrGrow.ContainsKey(nKey))
 {
 return g_CardAttrGrow[nKey];
 }
 return null;
 }
 public static Tab_CardAttrGrow GetCardAttrGrowByID(int nKey)
 {
 return GetCardAttrGrowByID(nKey, 0);
 }
 public static Tab_CardAttrGrow GetCardAttrGrowByID(int nKey, int nIndex)
 {
 if(g_CardAttrGrow.Count==0)
 {
 InitTable_CardAttrGrow();
 }
 if( g_CardAttrGrow.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardAttrGrow[nKey].Count)
 return g_CardAttrGrow[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardAttrGrowCount()
 {
 if(g_CardAttrGrow.Count==0)
 {
 InitTable_CardAttrGrow();
 }
 
 return g_CardAttrGrow.Count;
 }
 public static Dictionary<int, List<Tab_CardAttrGrow> > GetCardAttrGrow()
 {
 if(g_CardAttrGrow.Count==0)
 {
 InitTable_CardAttrGrow();
 }
 return g_CardAttrGrow;
 }

public static List<Tab_CardAudio> GetCardAudioLine(int nKey)
 {
 if(g_CardAudio.Count==0)
 {
 InitTable_CardAudio();
 }
 if( g_CardAudio.ContainsKey(nKey))
 {
 return g_CardAudio[nKey];
 }
 return null;
 }
 public static Tab_CardAudio GetCardAudioByID(int nKey)
 {
 return GetCardAudioByID(nKey, 0);
 }
 public static Tab_CardAudio GetCardAudioByID(int nKey, int nIndex)
 {
 if(g_CardAudio.Count==0)
 {
 InitTable_CardAudio();
 }
 if( g_CardAudio.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardAudio[nKey].Count)
 return g_CardAudio[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardAudioCount()
 {
 if(g_CardAudio.Count==0)
 {
 InitTable_CardAudio();
 }
 
 return g_CardAudio.Count;
 }
 public static Dictionary<int, List<Tab_CardAudio> > GetCardAudio()
 {
 if(g_CardAudio.Count==0)
 {
 InitTable_CardAudio();
 }
 return g_CardAudio;
 }

public static List<Tab_CardEnhanceLevel> GetCardEnhanceLevelLine(int nKey)
 {
 if(g_CardEnhanceLevel.Count==0)
 {
 InitTable_CardEnhanceLevel();
 }
 if( g_CardEnhanceLevel.ContainsKey(nKey))
 {
 return g_CardEnhanceLevel[nKey];
 }
 return null;
 }
 public static Tab_CardEnhanceLevel GetCardEnhanceLevelByID(int nKey)
 {
 return GetCardEnhanceLevelByID(nKey, 0);
 }
 public static Tab_CardEnhanceLevel GetCardEnhanceLevelByID(int nKey, int nIndex)
 {
 if(g_CardEnhanceLevel.Count==0)
 {
 InitTable_CardEnhanceLevel();
 }
 if( g_CardEnhanceLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardEnhanceLevel[nKey].Count)
 return g_CardEnhanceLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardEnhanceLevelCount()
 {
 if(g_CardEnhanceLevel.Count==0)
 {
 InitTable_CardEnhanceLevel();
 }
 
 return g_CardEnhanceLevel.Count;
 }
 public static Dictionary<int, List<Tab_CardEnhanceLevel> > GetCardEnhanceLevel()
 {
 if(g_CardEnhanceLevel.Count==0)
 {
 InitTable_CardEnhanceLevel();
 }
 return g_CardEnhanceLevel;
 }

public static List<Tab_CardEx> GetCardExLine(int nKey)
 {
 if(g_CardEx.Count==0)
 {
 InitTable_CardEx();
 }
 if( g_CardEx.ContainsKey(nKey))
 {
 return g_CardEx[nKey];
 }
 return null;
 }
 public static Tab_CardEx GetCardExByID(int nKey)
 {
 return GetCardExByID(nKey, 0);
 }
 public static Tab_CardEx GetCardExByID(int nKey, int nIndex)
 {
 if(g_CardEx.Count==0)
 {
 InitTable_CardEx();
 }
 if( g_CardEx.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardEx[nKey].Count)
 return g_CardEx[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardExCount()
 {
 if(g_CardEx.Count==0)
 {
 InitTable_CardEx();
 }
 
 return g_CardEx.Count;
 }
 public static Dictionary<int, List<Tab_CardEx> > GetCardEx()
 {
 if(g_CardEx.Count==0)
 {
 InitTable_CardEx();
 }
 return g_CardEx;
 }

public static List<Tab_CardExpItem> GetCardExpItemLine(int nKey)
 {
 if(g_CardExpItem.Count==0)
 {
 InitTable_CardExpItem();
 }
 if( g_CardExpItem.ContainsKey(nKey))
 {
 return g_CardExpItem[nKey];
 }
 return null;
 }
 public static Tab_CardExpItem GetCardExpItemByID(int nKey)
 {
 return GetCardExpItemByID(nKey, 0);
 }
 public static Tab_CardExpItem GetCardExpItemByID(int nKey, int nIndex)
 {
 if(g_CardExpItem.Count==0)
 {
 InitTable_CardExpItem();
 }
 if( g_CardExpItem.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardExpItem[nKey].Count)
 return g_CardExpItem[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardExpItemCount()
 {
 if(g_CardExpItem.Count==0)
 {
 InitTable_CardExpItem();
 }
 
 return g_CardExpItem.Count;
 }
 public static Dictionary<int, List<Tab_CardExpItem> > GetCardExpItem()
 {
 if(g_CardExpItem.Count==0)
 {
 InitTable_CardExpItem();
 }
 return g_CardExpItem;
 }

public static List<Tab_CardFile> GetCardFileLine(int nKey)
 {
 if(g_CardFile.Count==0)
 {
 InitTable_CardFile();
 }
 if( g_CardFile.ContainsKey(nKey))
 {
 return g_CardFile[nKey];
 }
 return null;
 }
 public static Tab_CardFile GetCardFileByID(int nKey)
 {
 return GetCardFileByID(nKey, 0);
 }
 public static Tab_CardFile GetCardFileByID(int nKey, int nIndex)
 {
 if(g_CardFile.Count==0)
 {
 InitTable_CardFile();
 }
 if( g_CardFile.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardFile[nKey].Count)
 return g_CardFile[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardFileCount()
 {
 if(g_CardFile.Count==0)
 {
 InitTable_CardFile();
 }
 
 return g_CardFile.Count;
 }
 public static Dictionary<int, List<Tab_CardFile> > GetCardFile()
 {
 if(g_CardFile.Count==0)
 {
 InitTable_CardFile();
 }
 return g_CardFile;
 }

public static List<Tab_CardFileLevel> GetCardFileLevelLine(int nKey)
 {
 if(g_CardFileLevel.Count==0)
 {
 InitTable_CardFileLevel();
 }
 if( g_CardFileLevel.ContainsKey(nKey))
 {
 return g_CardFileLevel[nKey];
 }
 return null;
 }
 public static Tab_CardFileLevel GetCardFileLevelByID(int nKey)
 {
 return GetCardFileLevelByID(nKey, 0);
 }
 public static Tab_CardFileLevel GetCardFileLevelByID(int nKey, int nIndex)
 {
 if(g_CardFileLevel.Count==0)
 {
 InitTable_CardFileLevel();
 }
 if( g_CardFileLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardFileLevel[nKey].Count)
 return g_CardFileLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardFileLevelCount()
 {
 if(g_CardFileLevel.Count==0)
 {
 InitTable_CardFileLevel();
 }
 
 return g_CardFileLevel.Count;
 }
 public static Dictionary<int, List<Tab_CardFileLevel> > GetCardFileLevel()
 {
 if(g_CardFileLevel.Count==0)
 {
 InitTable_CardFileLevel();
 }
 return g_CardFileLevel;
 }

public static List<Tab_CardFrame> GetCardFrameLine(int nKey)
 {
 if(g_CardFrame.Count==0)
 {
 InitTable_CardFrame();
 }
 if( g_CardFrame.ContainsKey(nKey))
 {
 return g_CardFrame[nKey];
 }
 return null;
 }
 public static Tab_CardFrame GetCardFrameByID(int nKey)
 {
 return GetCardFrameByID(nKey, 0);
 }
 public static Tab_CardFrame GetCardFrameByID(int nKey, int nIndex)
 {
 if(g_CardFrame.Count==0)
 {
 InitTable_CardFrame();
 }
 if( g_CardFrame.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardFrame[nKey].Count)
 return g_CardFrame[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardFrameCount()
 {
 if(g_CardFrame.Count==0)
 {
 InitTable_CardFrame();
 }
 
 return g_CardFrame.Count;
 }
 public static Dictionary<int, List<Tab_CardFrame> > GetCardFrame()
 {
 if(g_CardFrame.Count==0)
 {
 InitTable_CardFrame();
 }
 return g_CardFrame;
 }

public static List<Tab_CardLevel> GetCardLevelLine(int nKey)
 {
 if(g_CardLevel.Count==0)
 {
 InitTable_CardLevel();
 }
 if( g_CardLevel.ContainsKey(nKey))
 {
 return g_CardLevel[nKey];
 }
 return null;
 }
 public static Tab_CardLevel GetCardLevelByID(int nKey)
 {
 return GetCardLevelByID(nKey, 0);
 }
 public static Tab_CardLevel GetCardLevelByID(int nKey, int nIndex)
 {
 if(g_CardLevel.Count==0)
 {
 InitTable_CardLevel();
 }
 if( g_CardLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardLevel[nKey].Count)
 return g_CardLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardLevelCount()
 {
 if(g_CardLevel.Count==0)
 {
 InitTable_CardLevel();
 }
 
 return g_CardLevel.Count;
 }
 public static Dictionary<int, List<Tab_CardLevel> > GetCardLevel()
 {
 if(g_CardLevel.Count==0)
 {
 InitTable_CardLevel();
 }
 return g_CardLevel;
 }

public static List<Tab_CardPiece> GetCardPieceLine(int nKey)
 {
 if(g_CardPiece.Count==0)
 {
 InitTable_CardPiece();
 }
 if( g_CardPiece.ContainsKey(nKey))
 {
 return g_CardPiece[nKey];
 }
 return null;
 }
 public static Tab_CardPiece GetCardPieceByID(int nKey)
 {
 return GetCardPieceByID(nKey, 0);
 }
 public static Tab_CardPiece GetCardPieceByID(int nKey, int nIndex)
 {
 if(g_CardPiece.Count==0)
 {
 InitTable_CardPiece();
 }
 if( g_CardPiece.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardPiece[nKey].Count)
 return g_CardPiece[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardPieceCount()
 {
 if(g_CardPiece.Count==0)
 {
 InitTable_CardPiece();
 }
 
 return g_CardPiece.Count;
 }
 public static Dictionary<int, List<Tab_CardPiece> > GetCardPiece()
 {
 if(g_CardPiece.Count==0)
 {
 InitTable_CardPiece();
 }
 return g_CardPiece;
 }

public static List<Tab_CardPoolType> GetCardPoolTypeLine(int nKey)
 {
 if(g_CardPoolType.Count==0)
 {
 InitTable_CardPoolType();
 }
 if( g_CardPoolType.ContainsKey(nKey))
 {
 return g_CardPoolType[nKey];
 }
 return null;
 }
 public static Tab_CardPoolType GetCardPoolTypeByID(int nKey)
 {
 return GetCardPoolTypeByID(nKey, 0);
 }
 public static Tab_CardPoolType GetCardPoolTypeByID(int nKey, int nIndex)
 {
 if(g_CardPoolType.Count==0)
 {
 InitTable_CardPoolType();
 }
 if( g_CardPoolType.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardPoolType[nKey].Count)
 return g_CardPoolType[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardPoolTypeCount()
 {
 if(g_CardPoolType.Count==0)
 {
 InitTable_CardPoolType();
 }
 
 return g_CardPoolType.Count;
 }
 public static Dictionary<int, List<Tab_CardPoolType> > GetCardPoolType()
 {
 if(g_CardPoolType.Count==0)
 {
 InitTable_CardPoolType();
 }
 return g_CardPoolType;
 }

public static List<Tab_CardResolve> GetCardResolveLine(int nKey)
 {
 if(g_CardResolve.Count==0)
 {
 InitTable_CardResolve();
 }
 if( g_CardResolve.ContainsKey(nKey))
 {
 return g_CardResolve[nKey];
 }
 return null;
 }
 public static Tab_CardResolve GetCardResolveByID(int nKey)
 {
 return GetCardResolveByID(nKey, 0);
 }
 public static Tab_CardResolve GetCardResolveByID(int nKey, int nIndex)
 {
 if(g_CardResolve.Count==0)
 {
 InitTable_CardResolve();
 }
 if( g_CardResolve.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardResolve[nKey].Count)
 return g_CardResolve[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardResolveCount()
 {
 if(g_CardResolve.Count==0)
 {
 InitTable_CardResolve();
 }
 
 return g_CardResolve.Count;
 }
 public static Dictionary<int, List<Tab_CardResolve> > GetCardResolve()
 {
 if(g_CardResolve.Count==0)
 {
 InitTable_CardResolve();
 }
 return g_CardResolve;
 }

public static List<Tab_CardStar> GetCardStarLine(int nKey)
 {
 if(g_CardStar.Count==0)
 {
 InitTable_CardStar();
 }
 if( g_CardStar.ContainsKey(nKey))
 {
 return g_CardStar[nKey];
 }
 return null;
 }
 public static Tab_CardStar GetCardStarByID(int nKey)
 {
 return GetCardStarByID(nKey, 0);
 }
 public static Tab_CardStar GetCardStarByID(int nKey, int nIndex)
 {
 if(g_CardStar.Count==0)
 {
 InitTable_CardStar();
 }
 if( g_CardStar.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardStar[nKey].Count)
 return g_CardStar[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardStarCount()
 {
 if(g_CardStar.Count==0)
 {
 InitTable_CardStar();
 }
 
 return g_CardStar.Count;
 }
 public static Dictionary<int, List<Tab_CardStar> > GetCardStar()
 {
 if(g_CardStar.Count==0)
 {
 InitTable_CardStar();
 }
 return g_CardStar;
 }

public static List<Tab_CardStarItem> GetCardStarItemLine(int nKey)
 {
 if(g_CardStarItem.Count==0)
 {
 InitTable_CardStarItem();
 }
 if( g_CardStarItem.ContainsKey(nKey))
 {
 return g_CardStarItem[nKey];
 }
 return null;
 }
 public static Tab_CardStarItem GetCardStarItemByID(int nKey)
 {
 return GetCardStarItemByID(nKey, 0);
 }
 public static Tab_CardStarItem GetCardStarItemByID(int nKey, int nIndex)
 {
 if(g_CardStarItem.Count==0)
 {
 InitTable_CardStarItem();
 }
 if( g_CardStarItem.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardStarItem[nKey].Count)
 return g_CardStarItem[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardStarItemCount()
 {
 if(g_CardStarItem.Count==0)
 {
 InitTable_CardStarItem();
 }
 
 return g_CardStarItem.Count;
 }
 public static Dictionary<int, List<Tab_CardStarItem> > GetCardStarItem()
 {
 if(g_CardStarItem.Count==0)
 {
 InitTable_CardStarItem();
 }
 return g_CardStarItem;
 }

public static List<Tab_CardTrain> GetCardTrainLine(int nKey)
 {
 if(g_CardTrain.Count==0)
 {
 InitTable_CardTrain();
 }
 if( g_CardTrain.ContainsKey(nKey))
 {
 return g_CardTrain[nKey];
 }
 return null;
 }
 public static Tab_CardTrain GetCardTrainByID(int nKey)
 {
 return GetCardTrainByID(nKey, 0);
 }
 public static Tab_CardTrain GetCardTrainByID(int nKey, int nIndex)
 {
 if(g_CardTrain.Count==0)
 {
 InitTable_CardTrain();
 }
 if( g_CardTrain.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CardTrain[nKey].Count)
 return g_CardTrain[nKey][nIndex];
 }
 return null;
 }
 public static int GetCardTrainCount()
 {
 if(g_CardTrain.Count==0)
 {
 InitTable_CardTrain();
 }
 
 return g_CardTrain.Count;
 }
 public static Dictionary<int, List<Tab_CardTrain> > GetCardTrain()
 {
 if(g_CardTrain.Count==0)
 {
 InitTable_CardTrain();
 }
 return g_CardTrain;
 }

public static List<Tab_Channel> GetChannelLine(int nKey)
 {
 if(g_Channel.Count==0)
 {
 InitTable_Channel();
 }
 if( g_Channel.ContainsKey(nKey))
 {
 return g_Channel[nKey];
 }
 return null;
 }
 public static Tab_Channel GetChannelByID(int nKey)
 {
 return GetChannelByID(nKey, 0);
 }
 public static Tab_Channel GetChannelByID(int nKey, int nIndex)
 {
 if(g_Channel.Count==0)
 {
 InitTable_Channel();
 }
 if( g_Channel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Channel[nKey].Count)
 return g_Channel[nKey][nIndex];
 }
 return null;
 }
 public static int GetChannelCount()
 {
 if(g_Channel.Count==0)
 {
 InitTable_Channel();
 }
 
 return g_Channel.Count;
 }
 public static Dictionary<int, List<Tab_Channel> > GetChannel()
 {
 if(g_Channel.Count==0)
 {
 InitTable_Channel();
 }
 return g_Channel;
 }

public static List<Tab_Character> GetCharacterLine(int nKey)
 {
 if(g_Character.Count==0)
 {
 InitTable_Character();
 }
 if( g_Character.ContainsKey(nKey))
 {
 return g_Character[nKey];
 }
 return null;
 }
 public static Tab_Character GetCharacterByID(int nKey)
 {
 return GetCharacterByID(nKey, 0);
 }
 public static Tab_Character GetCharacterByID(int nKey, int nIndex)
 {
 if(g_Character.Count==0)
 {
 InitTable_Character();
 }
 if( g_Character.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Character[nKey].Count)
 return g_Character[nKey][nIndex];
 }
 return null;
 }
 public static int GetCharacterCount()
 {
 if(g_Character.Count==0)
 {
 InitTable_Character();
 }
 
 return g_Character.Count;
 }
 public static Dictionary<int, List<Tab_Character> > GetCharacter()
 {
 if(g_Character.Count==0)
 {
 InitTable_Character();
 }
 return g_Character;
 }

public static List<Tab_CharacterAsset> GetCharacterAssetLine(int nKey)
 {
 if(g_CharacterAsset.Count==0)
 {
 InitTable_CharacterAsset();
 }
 if( g_CharacterAsset.ContainsKey(nKey))
 {
 return g_CharacterAsset[nKey];
 }
 return null;
 }
 public static Tab_CharacterAsset GetCharacterAssetByID(int nKey)
 {
 return GetCharacterAssetByID(nKey, 0);
 }
 public static Tab_CharacterAsset GetCharacterAssetByID(int nKey, int nIndex)
 {
 if(g_CharacterAsset.Count==0)
 {
 InitTable_CharacterAsset();
 }
 if( g_CharacterAsset.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CharacterAsset[nKey].Count)
 return g_CharacterAsset[nKey][nIndex];
 }
 return null;
 }
 public static int GetCharacterAssetCount()
 {
 if(g_CharacterAsset.Count==0)
 {
 InitTable_CharacterAsset();
 }
 
 return g_CharacterAsset.Count;
 }
 public static Dictionary<int, List<Tab_CharacterAsset> > GetCharacterAsset()
 {
 if(g_CharacterAsset.Count==0)
 {
 InitTable_CharacterAsset();
 }
 return g_CharacterAsset;
 }

public static List<Tab_CharacterContacts> GetCharacterContactsLine(int nKey)
 {
 if(g_CharacterContacts.Count==0)
 {
 InitTable_CharacterContacts();
 }
 if( g_CharacterContacts.ContainsKey(nKey))
 {
 return g_CharacterContacts[nKey];
 }
 return null;
 }
 public static Tab_CharacterContacts GetCharacterContactsByID(int nKey)
 {
 return GetCharacterContactsByID(nKey, 0);
 }
 public static Tab_CharacterContacts GetCharacterContactsByID(int nKey, int nIndex)
 {
 if(g_CharacterContacts.Count==0)
 {
 InitTable_CharacterContacts();
 }
 if( g_CharacterContacts.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CharacterContacts[nKey].Count)
 return g_CharacterContacts[nKey][nIndex];
 }
 return null;
 }
 public static int GetCharacterContactsCount()
 {
 if(g_CharacterContacts.Count==0)
 {
 InitTable_CharacterContacts();
 }
 
 return g_CharacterContacts.Count;
 }
 public static Dictionary<int, List<Tab_CharacterContacts> > GetCharacterContacts()
 {
 if(g_CharacterContacts.Count==0)
 {
 InitTable_CharacterContacts();
 }
 return g_CharacterContacts;
 }

public static List<Tab_CharacterIntimacyDialog> GetCharacterIntimacyDialogLine(int nKey)
 {
 if(g_CharacterIntimacyDialog.Count==0)
 {
 InitTable_CharacterIntimacyDialog();
 }
 if( g_CharacterIntimacyDialog.ContainsKey(nKey))
 {
 return g_CharacterIntimacyDialog[nKey];
 }
 return null;
 }
 public static Tab_CharacterIntimacyDialog GetCharacterIntimacyDialogByID(int nKey)
 {
 return GetCharacterIntimacyDialogByID(nKey, 0);
 }
 public static Tab_CharacterIntimacyDialog GetCharacterIntimacyDialogByID(int nKey, int nIndex)
 {
 if(g_CharacterIntimacyDialog.Count==0)
 {
 InitTable_CharacterIntimacyDialog();
 }
 if( g_CharacterIntimacyDialog.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CharacterIntimacyDialog[nKey].Count)
 return g_CharacterIntimacyDialog[nKey][nIndex];
 }
 return null;
 }
 public static int GetCharacterIntimacyDialogCount()
 {
 if(g_CharacterIntimacyDialog.Count==0)
 {
 InitTable_CharacterIntimacyDialog();
 }
 
 return g_CharacterIntimacyDialog.Count;
 }
 public static Dictionary<int, List<Tab_CharacterIntimacyDialog> > GetCharacterIntimacyDialog()
 {
 if(g_CharacterIntimacyDialog.Count==0)
 {
 InitTable_CharacterIntimacyDialog();
 }
 return g_CharacterIntimacyDialog;
 }

public static List<Tab_Circle> GetCircleLine(int nKey)
 {
 if(g_Circle.Count==0)
 {
 InitTable_Circle();
 }
 if( g_Circle.ContainsKey(nKey))
 {
 return g_Circle[nKey];
 }
 return null;
 }
 public static Tab_Circle GetCircleByID(int nKey)
 {
 return GetCircleByID(nKey, 0);
 }
 public static Tab_Circle GetCircleByID(int nKey, int nIndex)
 {
 if(g_Circle.Count==0)
 {
 InitTable_Circle();
 }
 if( g_Circle.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Circle[nKey].Count)
 return g_Circle[nKey][nIndex];
 }
 return null;
 }
 public static int GetCircleCount()
 {
 if(g_Circle.Count==0)
 {
 InitTable_Circle();
 }
 
 return g_Circle.Count;
 }
 public static Dictionary<int, List<Tab_Circle> > GetCircle()
 {
 if(g_Circle.Count==0)
 {
 InitTable_Circle();
 }
 return g_Circle;
 }

public static List<Tab_CircleReply> GetCircleReplyLine(int nKey)
 {
 if(g_CircleReply.Count==0)
 {
 InitTable_CircleReply();
 }
 if( g_CircleReply.ContainsKey(nKey))
 {
 return g_CircleReply[nKey];
 }
 return null;
 }
 public static Tab_CircleReply GetCircleReplyByID(int nKey)
 {
 return GetCircleReplyByID(nKey, 0);
 }
 public static Tab_CircleReply GetCircleReplyByID(int nKey, int nIndex)
 {
 if(g_CircleReply.Count==0)
 {
 InitTable_CircleReply();
 }
 if( g_CircleReply.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CircleReply[nKey].Count)
 return g_CircleReply[nKey][nIndex];
 }
 return null;
 }
 public static int GetCircleReplyCount()
 {
 if(g_CircleReply.Count==0)
 {
 InitTable_CircleReply();
 }
 
 return g_CircleReply.Count;
 }
 public static Dictionary<int, List<Tab_CircleReply> > GetCircleReply()
 {
 if(g_CircleReply.Count==0)
 {
 InitTable_CircleReply();
 }
 return g_CircleReply;
 }

public static List<Tab_CityCopy> GetCityCopyLine(int nKey)
 {
 if(g_CityCopy.Count==0)
 {
 InitTable_CityCopy();
 }
 if( g_CityCopy.ContainsKey(nKey))
 {
 return g_CityCopy[nKey];
 }
 return null;
 }
 public static Tab_CityCopy GetCityCopyByID(int nKey)
 {
 return GetCityCopyByID(nKey, 0);
 }
 public static Tab_CityCopy GetCityCopyByID(int nKey, int nIndex)
 {
 if(g_CityCopy.Count==0)
 {
 InitTable_CityCopy();
 }
 if( g_CityCopy.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CityCopy[nKey].Count)
 return g_CityCopy[nKey][nIndex];
 }
 return null;
 }
 public static int GetCityCopyCount()
 {
 if(g_CityCopy.Count==0)
 {
 InitTable_CityCopy();
 }
 
 return g_CityCopy.Count;
 }
 public static Dictionary<int, List<Tab_CityCopy> > GetCityCopy()
 {
 if(g_CityCopy.Count==0)
 {
 InitTable_CityCopy();
 }
 return g_CityCopy;
 }

public static List<Tab_CityCopyFloor> GetCityCopyFloorLine(int nKey)
 {
 if(g_CityCopyFloor.Count==0)
 {
 InitTable_CityCopyFloor();
 }
 if( g_CityCopyFloor.ContainsKey(nKey))
 {
 return g_CityCopyFloor[nKey];
 }
 return null;
 }
 public static Tab_CityCopyFloor GetCityCopyFloorByID(int nKey)
 {
 return GetCityCopyFloorByID(nKey, 0);
 }
 public static Tab_CityCopyFloor GetCityCopyFloorByID(int nKey, int nIndex)
 {
 if(g_CityCopyFloor.Count==0)
 {
 InitTable_CityCopyFloor();
 }
 if( g_CityCopyFloor.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CityCopyFloor[nKey].Count)
 return g_CityCopyFloor[nKey][nIndex];
 }
 return null;
 }
 public static int GetCityCopyFloorCount()
 {
 if(g_CityCopyFloor.Count==0)
 {
 InitTable_CityCopyFloor();
 }
 
 return g_CityCopyFloor.Count;
 }
 public static Dictionary<int, List<Tab_CityCopyFloor> > GetCityCopyFloor()
 {
 if(g_CityCopyFloor.Count==0)
 {
 InitTable_CityCopyFloor();
 }
 return g_CityCopyFloor;
 }

public static List<Tab_CityCopyFloorDesc> GetCityCopyFloorDescLine(int nKey)
 {
 if(g_CityCopyFloorDesc.Count==0)
 {
 InitTable_CityCopyFloorDesc();
 }
 if( g_CityCopyFloorDesc.ContainsKey(nKey))
 {
 return g_CityCopyFloorDesc[nKey];
 }
 return null;
 }
 public static Tab_CityCopyFloorDesc GetCityCopyFloorDescByID(int nKey)
 {
 return GetCityCopyFloorDescByID(nKey, 0);
 }
 public static Tab_CityCopyFloorDesc GetCityCopyFloorDescByID(int nKey, int nIndex)
 {
 if(g_CityCopyFloorDesc.Count==0)
 {
 InitTable_CityCopyFloorDesc();
 }
 if( g_CityCopyFloorDesc.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CityCopyFloorDesc[nKey].Count)
 return g_CityCopyFloorDesc[nKey][nIndex];
 }
 return null;
 }
 public static int GetCityCopyFloorDescCount()
 {
 if(g_CityCopyFloorDesc.Count==0)
 {
 InitTable_CityCopyFloorDesc();
 }
 
 return g_CityCopyFloorDesc.Count;
 }
 public static Dictionary<int, List<Tab_CityCopyFloorDesc> > GetCityCopyFloorDesc()
 {
 if(g_CityCopyFloorDesc.Count==0)
 {
 InitTable_CityCopyFloorDesc();
 }
 return g_CityCopyFloorDesc;
 }

public static List<Tab_CityWork> GetCityWorkLine(int nKey)
 {
 if(g_CityWork.Count==0)
 {
 InitTable_CityWork();
 }
 if( g_CityWork.ContainsKey(nKey))
 {
 return g_CityWork[nKey];
 }
 return null;
 }
 public static Tab_CityWork GetCityWorkByID(int nKey)
 {
 return GetCityWorkByID(nKey, 0);
 }
 public static Tab_CityWork GetCityWorkByID(int nKey, int nIndex)
 {
 if(g_CityWork.Count==0)
 {
 InitTable_CityWork();
 }
 if( g_CityWork.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CityWork[nKey].Count)
 return g_CityWork[nKey][nIndex];
 }
 return null;
 }
 public static int GetCityWorkCount()
 {
 if(g_CityWork.Count==0)
 {
 InitTable_CityWork();
 }
 
 return g_CityWork.Count;
 }
 public static Dictionary<int, List<Tab_CityWork> > GetCityWork()
 {
 if(g_CityWork.Count==0)
 {
 InitTable_CityWork();
 }
 return g_CityWork;
 }

public static List<Tab_CityWorkTask> GetCityWorkTaskLine(int nKey)
 {
 if(g_CityWorkTask.Count==0)
 {
 InitTable_CityWorkTask();
 }
 if( g_CityWorkTask.ContainsKey(nKey))
 {
 return g_CityWorkTask[nKey];
 }
 return null;
 }
 public static Tab_CityWorkTask GetCityWorkTaskByID(int nKey)
 {
 return GetCityWorkTaskByID(nKey, 0);
 }
 public static Tab_CityWorkTask GetCityWorkTaskByID(int nKey, int nIndex)
 {
 if(g_CityWorkTask.Count==0)
 {
 InitTable_CityWorkTask();
 }
 if( g_CityWorkTask.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CityWorkTask[nKey].Count)
 return g_CityWorkTask[nKey][nIndex];
 }
 return null;
 }
 public static int GetCityWorkTaskCount()
 {
 if(g_CityWorkTask.Count==0)
 {
 InitTable_CityWorkTask();
 }
 
 return g_CityWorkTask.Count;
 }
 public static Dictionary<int, List<Tab_CityWorkTask> > GetCityWorkTask()
 {
 if(g_CityWorkTask.Count==0)
 {
 InitTable_CityWorkTask();
 }
 return g_CityWorkTask;
 }

public static List<Tab_CityWorkTaskDrop> GetCityWorkTaskDropLine(int nKey)
 {
 if(g_CityWorkTaskDrop.Count==0)
 {
 InitTable_CityWorkTaskDrop();
 }
 if( g_CityWorkTaskDrop.ContainsKey(nKey))
 {
 return g_CityWorkTaskDrop[nKey];
 }
 return null;
 }
 public static Tab_CityWorkTaskDrop GetCityWorkTaskDropByID(int nKey)
 {
 return GetCityWorkTaskDropByID(nKey, 0);
 }
 public static Tab_CityWorkTaskDrop GetCityWorkTaskDropByID(int nKey, int nIndex)
 {
 if(g_CityWorkTaskDrop.Count==0)
 {
 InitTable_CityWorkTaskDrop();
 }
 if( g_CityWorkTaskDrop.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CityWorkTaskDrop[nKey].Count)
 return g_CityWorkTaskDrop[nKey][nIndex];
 }
 return null;
 }
 public static int GetCityWorkTaskDropCount()
 {
 if(g_CityWorkTaskDrop.Count==0)
 {
 InitTable_CityWorkTaskDrop();
 }
 
 return g_CityWorkTaskDrop.Count;
 }
 public static Dictionary<int, List<Tab_CityWorkTaskDrop> > GetCityWorkTaskDrop()
 {
 if(g_CityWorkTaskDrop.Count==0)
 {
 InitTable_CityWorkTaskDrop();
 }
 return g_CityWorkTaskDrop;
 }

public static List<Tab_CommonAward> GetCommonAwardLine(int nKey)
 {
 if(g_CommonAward.Count==0)
 {
 InitTable_CommonAward();
 }
 if( g_CommonAward.ContainsKey(nKey))
 {
 return g_CommonAward[nKey];
 }
 return null;
 }
 public static Tab_CommonAward GetCommonAwardByID(int nKey)
 {
 return GetCommonAwardByID(nKey, 0);
 }
 public static Tab_CommonAward GetCommonAwardByID(int nKey, int nIndex)
 {
 if(g_CommonAward.Count==0)
 {
 InitTable_CommonAward();
 }
 if( g_CommonAward.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CommonAward[nKey].Count)
 return g_CommonAward[nKey][nIndex];
 }
 return null;
 }
 public static int GetCommonAwardCount()
 {
 if(g_CommonAward.Count==0)
 {
 InitTable_CommonAward();
 }
 
 return g_CommonAward.Count;
 }
 public static Dictionary<int, List<Tab_CommonAward> > GetCommonAward()
 {
 if(g_CommonAward.Count==0)
 {
 InitTable_CommonAward();
 }
 return g_CommonAward;
 }

public static List<Tab_Condition> GetConditionLine(int nKey)
 {
 if(g_Condition.Count==0)
 {
 InitTable_Condition();
 }
 if( g_Condition.ContainsKey(nKey))
 {
 return g_Condition[nKey];
 }
 return null;
 }
 public static Tab_Condition GetConditionByID(int nKey)
 {
 return GetConditionByID(nKey, 0);
 }
 public static Tab_Condition GetConditionByID(int nKey, int nIndex)
 {
 if(g_Condition.Count==0)
 {
 InitTable_Condition();
 }
 if( g_Condition.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Condition[nKey].Count)
 return g_Condition[nKey][nIndex];
 }
 return null;
 }
 public static int GetConditionCount()
 {
 if(g_Condition.Count==0)
 {
 InitTable_Condition();
 }
 
 return g_Condition.Count;
 }
 public static Dictionary<int, List<Tab_Condition> > GetCondition()
 {
 if(g_Condition.Count==0)
 {
 InitTable_Condition();
 }
 return g_Condition;
 }

public static List<Tab_CoolDown> GetCoolDownLine(int nKey)
 {
 if(g_CoolDown.Count==0)
 {
 InitTable_CoolDown();
 }
 if( g_CoolDown.ContainsKey(nKey))
 {
 return g_CoolDown[nKey];
 }
 return null;
 }
 public static Tab_CoolDown GetCoolDownByID(int nKey)
 {
 return GetCoolDownByID(nKey, 0);
 }
 public static Tab_CoolDown GetCoolDownByID(int nKey, int nIndex)
 {
 if(g_CoolDown.Count==0)
 {
 InitTable_CoolDown();
 }
 if( g_CoolDown.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CoolDown[nKey].Count)
 return g_CoolDown[nKey][nIndex];
 }
 return null;
 }
 public static int GetCoolDownCount()
 {
 if(g_CoolDown.Count==0)
 {
 InitTable_CoolDown();
 }
 
 return g_CoolDown.Count;
 }
 public static Dictionary<int, List<Tab_CoolDown> > GetCoolDown()
 {
 if(g_CoolDown.Count==0)
 {
 InitTable_CoolDown();
 }
 return g_CoolDown;
 }

public static List<Tab_CoolDownTimeInfo> GetCoolDownTimeInfoLine(int nKey)
 {
 if(g_CoolDownTimeInfo.Count==0)
 {
 InitTable_CoolDownTimeInfo();
 }
 if( g_CoolDownTimeInfo.ContainsKey(nKey))
 {
 return g_CoolDownTimeInfo[nKey];
 }
 return null;
 }
 public static Tab_CoolDownTimeInfo GetCoolDownTimeInfoByID(int nKey)
 {
 return GetCoolDownTimeInfoByID(nKey, 0);
 }
 public static Tab_CoolDownTimeInfo GetCoolDownTimeInfoByID(int nKey, int nIndex)
 {
 if(g_CoolDownTimeInfo.Count==0)
 {
 InitTable_CoolDownTimeInfo();
 }
 if( g_CoolDownTimeInfo.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_CoolDownTimeInfo[nKey].Count)
 return g_CoolDownTimeInfo[nKey][nIndex];
 }
 return null;
 }
 public static int GetCoolDownTimeInfoCount()
 {
 if(g_CoolDownTimeInfo.Count==0)
 {
 InitTable_CoolDownTimeInfo();
 }
 
 return g_CoolDownTimeInfo.Count;
 }
 public static Dictionary<int, List<Tab_CoolDownTimeInfo> > GetCoolDownTimeInfo()
 {
 if(g_CoolDownTimeInfo.Count==0)
 {
 InitTable_CoolDownTimeInfo();
 }
 return g_CoolDownTimeInfo;
 }

public static List<Tab_Device> GetDeviceLine(int nKey)
 {
 if(g_Device.Count==0)
 {
 InitTable_Device();
 }
 if( g_Device.ContainsKey(nKey))
 {
 return g_Device[nKey];
 }
 return null;
 }
 public static Tab_Device GetDeviceByID(int nKey)
 {
 return GetDeviceByID(nKey, 0);
 }
 public static Tab_Device GetDeviceByID(int nKey, int nIndex)
 {
 if(g_Device.Count==0)
 {
 InitTable_Device();
 }
 if( g_Device.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Device[nKey].Count)
 return g_Device[nKey][nIndex];
 }
 return null;
 }
 public static int GetDeviceCount()
 {
 if(g_Device.Count==0)
 {
 InitTable_Device();
 }
 
 return g_Device.Count;
 }
 public static Dictionary<int, List<Tab_Device> > GetDevice()
 {
 if(g_Device.Count==0)
 {
 InitTable_Device();
 }
 return g_Device;
 }

public static List<Tab_DeviceAdapter> GetDeviceAdapterLine(int nKey)
 {
 if(g_DeviceAdapter.Count==0)
 {
 InitTable_DeviceAdapter();
 }
 if( g_DeviceAdapter.ContainsKey(nKey))
 {
 return g_DeviceAdapter[nKey];
 }
 return null;
 }
 public static Tab_DeviceAdapter GetDeviceAdapterByID(int nKey)
 {
 return GetDeviceAdapterByID(nKey, 0);
 }
 public static Tab_DeviceAdapter GetDeviceAdapterByID(int nKey, int nIndex)
 {
 if(g_DeviceAdapter.Count==0)
 {
 InitTable_DeviceAdapter();
 }
 if( g_DeviceAdapter.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_DeviceAdapter[nKey].Count)
 return g_DeviceAdapter[nKey][nIndex];
 }
 return null;
 }
 public static int GetDeviceAdapterCount()
 {
 if(g_DeviceAdapter.Count==0)
 {
 InitTable_DeviceAdapter();
 }
 
 return g_DeviceAdapter.Count;
 }
 public static Dictionary<int, List<Tab_DeviceAdapter> > GetDeviceAdapter()
 {
 if(g_DeviceAdapter.Count==0)
 {
 InitTable_DeviceAdapter();
 }
 return g_DeviceAdapter;
 }

public static List<Tab_Dialog> GetDialogLine(int nKey)
 {
 if(g_Dialog.Count==0)
 {
 InitTable_Dialog();
 }
 if( g_Dialog.ContainsKey(nKey))
 {
 return g_Dialog[nKey];
 }
 return null;
 }
 public static Tab_Dialog GetDialogByID(int nKey)
 {
 return GetDialogByID(nKey, 0);
 }
 public static Tab_Dialog GetDialogByID(int nKey, int nIndex)
 {
 if(g_Dialog.Count==0)
 {
 InitTable_Dialog();
 }
 if( g_Dialog.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Dialog[nKey].Count)
 return g_Dialog[nKey][nIndex];
 }
 return null;
 }
 public static int GetDialogCount()
 {
 if(g_Dialog.Count==0)
 {
 InitTable_Dialog();
 }
 
 return g_Dialog.Count;
 }
 public static Dictionary<int, List<Tab_Dialog> > GetDialog()
 {
 if(g_Dialog.Count==0)
 {
 InitTable_Dialog();
 }
 return g_Dialog;
 }

public static List<Tab_DialogAvatar> GetDialogAvatarLine(int nKey)
 {
 if(g_DialogAvatar.Count==0)
 {
 InitTable_DialogAvatar();
 }
 if( g_DialogAvatar.ContainsKey(nKey))
 {
 return g_DialogAvatar[nKey];
 }
 return null;
 }
 public static Tab_DialogAvatar GetDialogAvatarByID(int nKey)
 {
 return GetDialogAvatarByID(nKey, 0);
 }
 public static Tab_DialogAvatar GetDialogAvatarByID(int nKey, int nIndex)
 {
 if(g_DialogAvatar.Count==0)
 {
 InitTable_DialogAvatar();
 }
 if( g_DialogAvatar.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_DialogAvatar[nKey].Count)
 return g_DialogAvatar[nKey][nIndex];
 }
 return null;
 }
 public static int GetDialogAvatarCount()
 {
 if(g_DialogAvatar.Count==0)
 {
 InitTable_DialogAvatar();
 }
 
 return g_DialogAvatar.Count;
 }
 public static Dictionary<int, List<Tab_DialogAvatar> > GetDialogAvatar()
 {
 if(g_DialogAvatar.Count==0)
 {
 InitTable_DialogAvatar();
 }
 return g_DialogAvatar;
 }

public static List<Tab_Divination> GetDivinationLine(int nKey)
 {
 if(g_Divination.Count==0)
 {
 InitTable_Divination();
 }
 if( g_Divination.ContainsKey(nKey))
 {
 return g_Divination[nKey];
 }
 return null;
 }
 public static Tab_Divination GetDivinationByID(int nKey)
 {
 return GetDivinationByID(nKey, 0);
 }
 public static Tab_Divination GetDivinationByID(int nKey, int nIndex)
 {
 if(g_Divination.Count==0)
 {
 InitTable_Divination();
 }
 if( g_Divination.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Divination[nKey].Count)
 return g_Divination[nKey][nIndex];
 }
 return null;
 }
 public static int GetDivinationCount()
 {
 if(g_Divination.Count==0)
 {
 InitTable_Divination();
 }
 
 return g_Divination.Count;
 }
 public static Dictionary<int, List<Tab_Divination> > GetDivination()
 {
 if(g_Divination.Count==0)
 {
 InitTable_Divination();
 }
 return g_Divination;
 }

public static List<Tab_DivinationProgress> GetDivinationProgressLine(int nKey)
 {
 if(g_DivinationProgress.Count==0)
 {
 InitTable_DivinationProgress();
 }
 if( g_DivinationProgress.ContainsKey(nKey))
 {
 return g_DivinationProgress[nKey];
 }
 return null;
 }
 public static Tab_DivinationProgress GetDivinationProgressByID(int nKey)
 {
 return GetDivinationProgressByID(nKey, 0);
 }
 public static Tab_DivinationProgress GetDivinationProgressByID(int nKey, int nIndex)
 {
 if(g_DivinationProgress.Count==0)
 {
 InitTable_DivinationProgress();
 }
 if( g_DivinationProgress.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_DivinationProgress[nKey].Count)
 return g_DivinationProgress[nKey][nIndex];
 }
 return null;
 }
 public static int GetDivinationProgressCount()
 {
 if(g_DivinationProgress.Count==0)
 {
 InitTable_DivinationProgress();
 }
 
 return g_DivinationProgress.Count;
 }
 public static Dictionary<int, List<Tab_DivinationProgress> > GetDivinationProgress()
 {
 if(g_DivinationProgress.Count==0)
 {
 InitTable_DivinationProgress();
 }
 return g_DivinationProgress;
 }

public static List<Tab_DivinationReward> GetDivinationRewardLine(int nKey)
 {
 if(g_DivinationReward.Count==0)
 {
 InitTable_DivinationReward();
 }
 if( g_DivinationReward.ContainsKey(nKey))
 {
 return g_DivinationReward[nKey];
 }
 return null;
 }
 public static Tab_DivinationReward GetDivinationRewardByID(int nKey)
 {
 return GetDivinationRewardByID(nKey, 0);
 }
 public static Tab_DivinationReward GetDivinationRewardByID(int nKey, int nIndex)
 {
 if(g_DivinationReward.Count==0)
 {
 InitTable_DivinationReward();
 }
 if( g_DivinationReward.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_DivinationReward[nKey].Count)
 return g_DivinationReward[nKey][nIndex];
 }
 return null;
 }
 public static int GetDivinationRewardCount()
 {
 if(g_DivinationReward.Count==0)
 {
 InitTable_DivinationReward();
 }
 
 return g_DivinationReward.Count;
 }
 public static Dictionary<int, List<Tab_DivinationReward> > GetDivinationReward()
 {
 if(g_DivinationReward.Count==0)
 {
 InitTable_DivinationReward();
 }
 return g_DivinationReward;
 }

public static List<Tab_DrawCardAdvanceCard> GetDrawCardAdvanceCardLine(int nKey)
 {
 if(g_DrawCardAdvanceCard.Count==0)
 {
 InitTable_DrawCardAdvanceCard();
 }
 if( g_DrawCardAdvanceCard.ContainsKey(nKey))
 {
 return g_DrawCardAdvanceCard[nKey];
 }
 return null;
 }
 public static Tab_DrawCardAdvanceCard GetDrawCardAdvanceCardByID(int nKey)
 {
 return GetDrawCardAdvanceCardByID(nKey, 0);
 }
 public static Tab_DrawCardAdvanceCard GetDrawCardAdvanceCardByID(int nKey, int nIndex)
 {
 if(g_DrawCardAdvanceCard.Count==0)
 {
 InitTable_DrawCardAdvanceCard();
 }
 if( g_DrawCardAdvanceCard.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_DrawCardAdvanceCard[nKey].Count)
 return g_DrawCardAdvanceCard[nKey][nIndex];
 }
 return null;
 }
 public static int GetDrawCardAdvanceCardCount()
 {
 if(g_DrawCardAdvanceCard.Count==0)
 {
 InitTable_DrawCardAdvanceCard();
 }
 
 return g_DrawCardAdvanceCard.Count;
 }
 public static Dictionary<int, List<Tab_DrawCardAdvanceCard> > GetDrawCardAdvanceCard()
 {
 if(g_DrawCardAdvanceCard.Count==0)
 {
 InitTable_DrawCardAdvanceCard();
 }
 return g_DrawCardAdvanceCard;
 }

public static List<Tab_DrawCardNormalCard> GetDrawCardNormalCardLine(int nKey)
 {
 if(g_DrawCardNormalCard.Count==0)
 {
 InitTable_DrawCardNormalCard();
 }
 if( g_DrawCardNormalCard.ContainsKey(nKey))
 {
 return g_DrawCardNormalCard[nKey];
 }
 return null;
 }
 public static Tab_DrawCardNormalCard GetDrawCardNormalCardByID(int nKey)
 {
 return GetDrawCardNormalCardByID(nKey, 0);
 }
 public static Tab_DrawCardNormalCard GetDrawCardNormalCardByID(int nKey, int nIndex)
 {
 if(g_DrawCardNormalCard.Count==0)
 {
 InitTable_DrawCardNormalCard();
 }
 if( g_DrawCardNormalCard.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_DrawCardNormalCard[nKey].Count)
 return g_DrawCardNormalCard[nKey][nIndex];
 }
 return null;
 }
 public static int GetDrawCardNormalCardCount()
 {
 if(g_DrawCardNormalCard.Count==0)
 {
 InitTable_DrawCardNormalCard();
 }
 
 return g_DrawCardNormalCard.Count;
 }
 public static Dictionary<int, List<Tab_DrawCardNormalCard> > GetDrawCardNormalCard()
 {
 if(g_DrawCardNormalCard.Count==0)
 {
 InitTable_DrawCardNormalCard();
 }
 return g_DrawCardNormalCard;
 }

public static List<Tab_DrawCardPreview> GetDrawCardPreviewLine(int nKey)
 {
 if(g_DrawCardPreview.Count==0)
 {
 InitTable_DrawCardPreview();
 }
 if( g_DrawCardPreview.ContainsKey(nKey))
 {
 return g_DrawCardPreview[nKey];
 }
 return null;
 }
 public static Tab_DrawCardPreview GetDrawCardPreviewByID(int nKey)
 {
 return GetDrawCardPreviewByID(nKey, 0);
 }
 public static Tab_DrawCardPreview GetDrawCardPreviewByID(int nKey, int nIndex)
 {
 if(g_DrawCardPreview.Count==0)
 {
 InitTable_DrawCardPreview();
 }
 if( g_DrawCardPreview.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_DrawCardPreview[nKey].Count)
 return g_DrawCardPreview[nKey][nIndex];
 }
 return null;
 }
 public static int GetDrawCardPreviewCount()
 {
 if(g_DrawCardPreview.Count==0)
 {
 InitTable_DrawCardPreview();
 }
 
 return g_DrawCardPreview.Count;
 }
 public static Dictionary<int, List<Tab_DrawCardPreview> > GetDrawCardPreview()
 {
 if(g_DrawCardPreview.Count==0)
 {
 InitTable_DrawCardPreview();
 }
 return g_DrawCardPreview;
 }

public static List<Tab_Dressup> GetDressupLine(int nKey)
 {
 if(g_Dressup.Count==0)
 {
 InitTable_Dressup();
 }
 if( g_Dressup.ContainsKey(nKey))
 {
 return g_Dressup[nKey];
 }
 return null;
 }
 public static Tab_Dressup GetDressupByID(int nKey)
 {
 return GetDressupByID(nKey, 0);
 }
 public static Tab_Dressup GetDressupByID(int nKey, int nIndex)
 {
 if(g_Dressup.Count==0)
 {
 InitTable_Dressup();
 }
 if( g_Dressup.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Dressup[nKey].Count)
 return g_Dressup[nKey][nIndex];
 }
 return null;
 }
 public static int GetDressupCount()
 {
 if(g_Dressup.Count==0)
 {
 InitTable_Dressup();
 }
 
 return g_Dressup.Count;
 }
 public static Dictionary<int, List<Tab_Dressup> > GetDressup()
 {
 if(g_Dressup.Count==0)
 {
 InitTable_Dressup();
 }
 return g_Dressup;
 }

public static List<Tab_DropPreview> GetDropPreviewLine(int nKey)
 {
 if(g_DropPreview.Count==0)
 {
 InitTable_DropPreview();
 }
 if( g_DropPreview.ContainsKey(nKey))
 {
 return g_DropPreview[nKey];
 }
 return null;
 }
 public static Tab_DropPreview GetDropPreviewByID(int nKey)
 {
 return GetDropPreviewByID(nKey, 0);
 }
 public static Tab_DropPreview GetDropPreviewByID(int nKey, int nIndex)
 {
 if(g_DropPreview.Count==0)
 {
 InitTable_DropPreview();
 }
 if( g_DropPreview.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_DropPreview[nKey].Count)
 return g_DropPreview[nKey][nIndex];
 }
 return null;
 }
 public static int GetDropPreviewCount()
 {
 if(g_DropPreview.Count==0)
 {
 InitTable_DropPreview();
 }
 
 return g_DropPreview.Count;
 }
 public static Dictionary<int, List<Tab_DropPreview> > GetDropPreview()
 {
 if(g_DropPreview.Count==0)
 {
 InitTable_DropPreview();
 }
 return g_DropPreview;
 }

public static List<Tab_EffectAsset> GetEffectAssetLine(int nKey)
 {
 if(g_EffectAsset.Count==0)
 {
 InitTable_EffectAsset();
 }
 if( g_EffectAsset.ContainsKey(nKey))
 {
 return g_EffectAsset[nKey];
 }
 return null;
 }
 public static Tab_EffectAsset GetEffectAssetByID(int nKey)
 {
 return GetEffectAssetByID(nKey, 0);
 }
 public static Tab_EffectAsset GetEffectAssetByID(int nKey, int nIndex)
 {
 if(g_EffectAsset.Count==0)
 {
 InitTable_EffectAsset();
 }
 if( g_EffectAsset.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_EffectAsset[nKey].Count)
 return g_EffectAsset[nKey][nIndex];
 }
 return null;
 }
 public static int GetEffectAssetCount()
 {
 if(g_EffectAsset.Count==0)
 {
 InitTable_EffectAsset();
 }
 
 return g_EffectAsset.Count;
 }
 public static Dictionary<int, List<Tab_EffectAsset> > GetEffectAsset()
 {
 if(g_EffectAsset.Count==0)
 {
 InitTable_EffectAsset();
 }
 return g_EffectAsset;
 }

public static List<Tab_Emoji> GetEmojiLine(int nKey)
 {
 if(g_Emoji.Count==0)
 {
 InitTable_Emoji();
 }
 if( g_Emoji.ContainsKey(nKey))
 {
 return g_Emoji[nKey];
 }
 return null;
 }
 public static Tab_Emoji GetEmojiByID(int nKey)
 {
 return GetEmojiByID(nKey, 0);
 }
 public static Tab_Emoji GetEmojiByID(int nKey, int nIndex)
 {
 if(g_Emoji.Count==0)
 {
 InitTable_Emoji();
 }
 if( g_Emoji.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Emoji[nKey].Count)
 return g_Emoji[nKey][nIndex];
 }
 return null;
 }
 public static int GetEmojiCount()
 {
 if(g_Emoji.Count==0)
 {
 InitTable_Emoji();
 }
 
 return g_Emoji.Count;
 }
 public static Dictionary<int, List<Tab_Emoji> > GetEmoji()
 {
 if(g_Emoji.Count==0)
 {
 InitTable_Emoji();
 }
 return g_Emoji;
 }

public static List<Tab_Enviroment> GetEnviromentLine(int nKey)
 {
 if(g_Enviroment.Count==0)
 {
 InitTable_Enviroment();
 }
 if( g_Enviroment.ContainsKey(nKey))
 {
 return g_Enviroment[nKey];
 }
 return null;
 }
 public static Tab_Enviroment GetEnviromentByID(int nKey)
 {
 return GetEnviromentByID(nKey, 0);
 }
 public static Tab_Enviroment GetEnviromentByID(int nKey, int nIndex)
 {
 if(g_Enviroment.Count==0)
 {
 InitTable_Enviroment();
 }
 if( g_Enviroment.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Enviroment[nKey].Count)
 return g_Enviroment[nKey][nIndex];
 }
 return null;
 }
 public static int GetEnviromentCount()
 {
 if(g_Enviroment.Count==0)
 {
 InitTable_Enviroment();
 }
 
 return g_Enviroment.Count;
 }
 public static Dictionary<int, List<Tab_Enviroment> > GetEnviroment()
 {
 if(g_Enviroment.Count==0)
 {
 InitTable_Enviroment();
 }
 return g_Enviroment;
 }

public static List<Tab_EverydaySign> GetEverydaySignLine(int nKey)
 {
 if(g_EverydaySign.Count==0)
 {
 InitTable_EverydaySign();
 }
 if( g_EverydaySign.ContainsKey(nKey))
 {
 return g_EverydaySign[nKey];
 }
 return null;
 }
 public static Tab_EverydaySign GetEverydaySignByID(int nKey)
 {
 return GetEverydaySignByID(nKey, 0);
 }
 public static Tab_EverydaySign GetEverydaySignByID(int nKey, int nIndex)
 {
 if(g_EverydaySign.Count==0)
 {
 InitTable_EverydaySign();
 }
 if( g_EverydaySign.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_EverydaySign[nKey].Count)
 return g_EverydaySign[nKey][nIndex];
 }
 return null;
 }
 public static int GetEverydaySignCount()
 {
 if(g_EverydaySign.Count==0)
 {
 InitTable_EverydaySign();
 }
 
 return g_EverydaySign.Count;
 }
 public static Dictionary<int, List<Tab_EverydaySign> > GetEverydaySign()
 {
 if(g_EverydaySign.Count==0)
 {
 InitTable_EverydaySign();
 }
 return g_EverydaySign;
 }

public static List<Tab_Example> GetExampleLine(int nKey)
 {
 if(g_Example.Count==0)
 {
 InitTable_Example();
 }
 if( g_Example.ContainsKey(nKey))
 {
 return g_Example[nKey];
 }
 return null;
 }
 public static Tab_Example GetExampleByID(int nKey)
 {
 return GetExampleByID(nKey, 0);
 }
 public static Tab_Example GetExampleByID(int nKey, int nIndex)
 {
 if(g_Example.Count==0)
 {
 InitTable_Example();
 }
 if( g_Example.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Example[nKey].Count)
 return g_Example[nKey][nIndex];
 }
 return null;
 }
 public static int GetExampleCount()
 {
 if(g_Example.Count==0)
 {
 InitTable_Example();
 }
 
 return g_Example.Count;
 }
 public static Dictionary<int, List<Tab_Example> > GetExample()
 {
 if(g_Example.Count==0)
 {
 InitTable_Example();
 }
 return g_Example;
 }

public static List<Tab_ExtraConfig> GetExtraConfigLine(int nKey)
 {
 if(g_ExtraConfig.Count==0)
 {
 InitTable_ExtraConfig();
 }
 if( g_ExtraConfig.ContainsKey(nKey))
 {
 return g_ExtraConfig[nKey];
 }
 return null;
 }
 public static Tab_ExtraConfig GetExtraConfigByID(int nKey)
 {
 return GetExtraConfigByID(nKey, 0);
 }
 public static Tab_ExtraConfig GetExtraConfigByID(int nKey, int nIndex)
 {
 if(g_ExtraConfig.Count==0)
 {
 InitTable_ExtraConfig();
 }
 if( g_ExtraConfig.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ExtraConfig[nKey].Count)
 return g_ExtraConfig[nKey][nIndex];
 }
 return null;
 }
 public static int GetExtraConfigCount()
 {
 if(g_ExtraConfig.Count==0)
 {
 InitTable_ExtraConfig();
 }
 
 return g_ExtraConfig.Count;
 }
 public static Dictionary<int, List<Tab_ExtraConfig> > GetExtraConfig()
 {
 if(g_ExtraConfig.Count==0)
 {
 InitTable_ExtraConfig();
 }
 return g_ExtraConfig;
 }

public static List<Tab_FateDialog> GetFateDialogLine(int nKey)
 {
 if(g_FateDialog.Count==0)
 {
 InitTable_FateDialog();
 }
 if( g_FateDialog.ContainsKey(nKey))
 {
 return g_FateDialog[nKey];
 }
 return null;
 }
 public static Tab_FateDialog GetFateDialogByID(int nKey)
 {
 return GetFateDialogByID(nKey, 0);
 }
 public static Tab_FateDialog GetFateDialogByID(int nKey, int nIndex)
 {
 if(g_FateDialog.Count==0)
 {
 InitTable_FateDialog();
 }
 if( g_FateDialog.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FateDialog[nKey].Count)
 return g_FateDialog[nKey][nIndex];
 }
 return null;
 }
 public static int GetFateDialogCount()
 {
 if(g_FateDialog.Count==0)
 {
 InitTable_FateDialog();
 }
 
 return g_FateDialog.Count;
 }
 public static Dictionary<int, List<Tab_FateDialog> > GetFateDialog()
 {
 if(g_FateDialog.Count==0)
 {
 InitTable_FateDialog();
 }
 return g_FateDialog;
 }

public static List<Tab_FateLine> GetFateLineLine(int nKey)
 {
 if(g_FateLine.Count==0)
 {
 InitTable_FateLine();
 }
 if( g_FateLine.ContainsKey(nKey))
 {
 return g_FateLine[nKey];
 }
 return null;
 }
 public static Tab_FateLine GetFateLineByID(int nKey)
 {
 return GetFateLineByID(nKey, 0);
 }
 public static Tab_FateLine GetFateLineByID(int nKey, int nIndex)
 {
 if(g_FateLine.Count==0)
 {
 InitTable_FateLine();
 }
 if( g_FateLine.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FateLine[nKey].Count)
 return g_FateLine[nKey][nIndex];
 }
 return null;
 }
 public static int GetFateLineCount()
 {
 if(g_FateLine.Count==0)
 {
 InitTable_FateLine();
 }
 
 return g_FateLine.Count;
 }
 public static Dictionary<int, List<Tab_FateLine> > GetFateLine()
 {
 if(g_FateLine.Count==0)
 {
 InitTable_FateLine();
 }
 return g_FateLine;
 }

public static List<Tab_FateLineAvatar> GetFateLineAvatarLine(int nKey)
 {
 if(g_FateLineAvatar.Count==0)
 {
 InitTable_FateLineAvatar();
 }
 if( g_FateLineAvatar.ContainsKey(nKey))
 {
 return g_FateLineAvatar[nKey];
 }
 return null;
 }
 public static Tab_FateLineAvatar GetFateLineAvatarByID(int nKey)
 {
 return GetFateLineAvatarByID(nKey, 0);
 }
 public static Tab_FateLineAvatar GetFateLineAvatarByID(int nKey, int nIndex)
 {
 if(g_FateLineAvatar.Count==0)
 {
 InitTable_FateLineAvatar();
 }
 if( g_FateLineAvatar.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FateLineAvatar[nKey].Count)
 return g_FateLineAvatar[nKey][nIndex];
 }
 return null;
 }
 public static int GetFateLineAvatarCount()
 {
 if(g_FateLineAvatar.Count==0)
 {
 InitTable_FateLineAvatar();
 }
 
 return g_FateLineAvatar.Count;
 }
 public static Dictionary<int, List<Tab_FateLineAvatar> > GetFateLineAvatar()
 {
 if(g_FateLineAvatar.Count==0)
 {
 InitTable_FateLineAvatar();
 }
 return g_FateLineAvatar;
 }

public static List<Tab_FateLineLevel> GetFateLineLevelLine(int nKey)
 {
 if(g_FateLineLevel.Count==0)
 {
 InitTable_FateLineLevel();
 }
 if( g_FateLineLevel.ContainsKey(nKey))
 {
 return g_FateLineLevel[nKey];
 }
 return null;
 }
 public static Tab_FateLineLevel GetFateLineLevelByID(int nKey)
 {
 return GetFateLineLevelByID(nKey, 0);
 }
 public static Tab_FateLineLevel GetFateLineLevelByID(int nKey, int nIndex)
 {
 if(g_FateLineLevel.Count==0)
 {
 InitTable_FateLineLevel();
 }
 if( g_FateLineLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FateLineLevel[nKey].Count)
 return g_FateLineLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetFateLineLevelCount()
 {
 if(g_FateLineLevel.Count==0)
 {
 InitTable_FateLineLevel();
 }
 
 return g_FateLineLevel.Count;
 }
 public static Dictionary<int, List<Tab_FateLineLevel> > GetFateLineLevel()
 {
 if(g_FateLineLevel.Count==0)
 {
 InitTable_FateLineLevel();
 }
 return g_FateLineLevel;
 }

public static List<Tab_FirstGift> GetFirstGiftLine(int nKey)
 {
 if(g_FirstGift.Count==0)
 {
 InitTable_FirstGift();
 }
 if( g_FirstGift.ContainsKey(nKey))
 {
 return g_FirstGift[nKey];
 }
 return null;
 }
 public static Tab_FirstGift GetFirstGiftByID(int nKey)
 {
 return GetFirstGiftByID(nKey, 0);
 }
 public static Tab_FirstGift GetFirstGiftByID(int nKey, int nIndex)
 {
 if(g_FirstGift.Count==0)
 {
 InitTable_FirstGift();
 }
 if( g_FirstGift.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FirstGift[nKey].Count)
 return g_FirstGift[nKey][nIndex];
 }
 return null;
 }
 public static int GetFirstGiftCount()
 {
 if(g_FirstGift.Count==0)
 {
 InitTable_FirstGift();
 }
 
 return g_FirstGift.Count;
 }
 public static Dictionary<int, List<Tab_FirstGift> > GetFirstGift()
 {
 if(g_FirstGift.Count==0)
 {
 InitTable_FirstGift();
 }
 return g_FirstGift;
 }

public static List<Tab_FuliAddSign> GetFuliAddSignLine(int nKey)
 {
 if(g_FuliAddSign.Count==0)
 {
 InitTable_FuliAddSign();
 }
 if( g_FuliAddSign.ContainsKey(nKey))
 {
 return g_FuliAddSign[nKey];
 }
 return null;
 }
 public static Tab_FuliAddSign GetFuliAddSignByID(int nKey)
 {
 return GetFuliAddSignByID(nKey, 0);
 }
 public static Tab_FuliAddSign GetFuliAddSignByID(int nKey, int nIndex)
 {
 if(g_FuliAddSign.Count==0)
 {
 InitTable_FuliAddSign();
 }
 if( g_FuliAddSign.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliAddSign[nKey].Count)
 return g_FuliAddSign[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliAddSignCount()
 {
 if(g_FuliAddSign.Count==0)
 {
 InitTable_FuliAddSign();
 }
 
 return g_FuliAddSign.Count;
 }
 public static Dictionary<int, List<Tab_FuliAddSign> > GetFuliAddSign()
 {
 if(g_FuliAddSign.Count==0)
 {
 InitTable_FuliAddSign();
 }
 return g_FuliAddSign;
 }

public static List<Tab_FuliAddSignAward> GetFuliAddSignAwardLine(int nKey)
 {
 if(g_FuliAddSignAward.Count==0)
 {
 InitTable_FuliAddSignAward();
 }
 if( g_FuliAddSignAward.ContainsKey(nKey))
 {
 return g_FuliAddSignAward[nKey];
 }
 return null;
 }
 public static Tab_FuliAddSignAward GetFuliAddSignAwardByID(int nKey)
 {
 return GetFuliAddSignAwardByID(nKey, 0);
 }
 public static Tab_FuliAddSignAward GetFuliAddSignAwardByID(int nKey, int nIndex)
 {
 if(g_FuliAddSignAward.Count==0)
 {
 InitTable_FuliAddSignAward();
 }
 if( g_FuliAddSignAward.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliAddSignAward[nKey].Count)
 return g_FuliAddSignAward[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliAddSignAwardCount()
 {
 if(g_FuliAddSignAward.Count==0)
 {
 InitTable_FuliAddSignAward();
 }
 
 return g_FuliAddSignAward.Count;
 }
 public static Dictionary<int, List<Tab_FuliAddSignAward> > GetFuliAddSignAward()
 {
 if(g_FuliAddSignAward.Count==0)
 {
 InitTable_FuliAddSignAward();
 }
 return g_FuliAddSignAward;
 }

public static List<Tab_FuliDailyStamina> GetFuliDailyStaminaLine(int nKey)
 {
 if(g_FuliDailyStamina.Count==0)
 {
 InitTable_FuliDailyStamina();
 }
 if( g_FuliDailyStamina.ContainsKey(nKey))
 {
 return g_FuliDailyStamina[nKey];
 }
 return null;
 }
 public static Tab_FuliDailyStamina GetFuliDailyStaminaByID(int nKey)
 {
 return GetFuliDailyStaminaByID(nKey, 0);
 }
 public static Tab_FuliDailyStamina GetFuliDailyStaminaByID(int nKey, int nIndex)
 {
 if(g_FuliDailyStamina.Count==0)
 {
 InitTable_FuliDailyStamina();
 }
 if( g_FuliDailyStamina.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliDailyStamina[nKey].Count)
 return g_FuliDailyStamina[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliDailyStaminaCount()
 {
 if(g_FuliDailyStamina.Count==0)
 {
 InitTable_FuliDailyStamina();
 }
 
 return g_FuliDailyStamina.Count;
 }
 public static Dictionary<int, List<Tab_FuliDailyStamina> > GetFuliDailyStamina()
 {
 if(g_FuliDailyStamina.Count==0)
 {
 InitTable_FuliDailyStamina();
 }
 return g_FuliDailyStamina;
 }

public static List<Tab_FuliDailyStaminaDialog> GetFuliDailyStaminaDialogLine(int nKey)
 {
 if(g_FuliDailyStaminaDialog.Count==0)
 {
 InitTable_FuliDailyStaminaDialog();
 }
 if( g_FuliDailyStaminaDialog.ContainsKey(nKey))
 {
 return g_FuliDailyStaminaDialog[nKey];
 }
 return null;
 }
 public static Tab_FuliDailyStaminaDialog GetFuliDailyStaminaDialogByID(int nKey)
 {
 return GetFuliDailyStaminaDialogByID(nKey, 0);
 }
 public static Tab_FuliDailyStaminaDialog GetFuliDailyStaminaDialogByID(int nKey, int nIndex)
 {
 if(g_FuliDailyStaminaDialog.Count==0)
 {
 InitTable_FuliDailyStaminaDialog();
 }
 if( g_FuliDailyStaminaDialog.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliDailyStaminaDialog[nKey].Count)
 return g_FuliDailyStaminaDialog[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliDailyStaminaDialogCount()
 {
 if(g_FuliDailyStaminaDialog.Count==0)
 {
 InitTable_FuliDailyStaminaDialog();
 }
 
 return g_FuliDailyStaminaDialog.Count;
 }
 public static Dictionary<int, List<Tab_FuliDailyStaminaDialog> > GetFuliDailyStaminaDialog()
 {
 if(g_FuliDailyStaminaDialog.Count==0)
 {
 InitTable_FuliDailyStaminaDialog();
 }
 return g_FuliDailyStaminaDialog;
 }

public static List<Tab_FuliFund> GetFuliFundLine(int nKey)
 {
 if(g_FuliFund.Count==0)
 {
 InitTable_FuliFund();
 }
 if( g_FuliFund.ContainsKey(nKey))
 {
 return g_FuliFund[nKey];
 }
 return null;
 }
 public static Tab_FuliFund GetFuliFundByID(int nKey)
 {
 return GetFuliFundByID(nKey, 0);
 }
 public static Tab_FuliFund GetFuliFundByID(int nKey, int nIndex)
 {
 if(g_FuliFund.Count==0)
 {
 InitTable_FuliFund();
 }
 if( g_FuliFund.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliFund[nKey].Count)
 return g_FuliFund[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliFundCount()
 {
 if(g_FuliFund.Count==0)
 {
 InitTable_FuliFund();
 }
 
 return g_FuliFund.Count;
 }
 public static Dictionary<int, List<Tab_FuliFund> > GetFuliFund()
 {
 if(g_FuliFund.Count==0)
 {
 InitTable_FuliFund();
 }
 return g_FuliFund;
 }

public static List<Tab_FuliLottery> GetFuliLotteryLine(int nKey)
 {
 if(g_FuliLottery.Count==0)
 {
 InitTable_FuliLottery();
 }
 if( g_FuliLottery.ContainsKey(nKey))
 {
 return g_FuliLottery[nKey];
 }
 return null;
 }
 public static Tab_FuliLottery GetFuliLotteryByID(int nKey)
 {
 return GetFuliLotteryByID(nKey, 0);
 }
 public static Tab_FuliLottery GetFuliLotteryByID(int nKey, int nIndex)
 {
 if(g_FuliLottery.Count==0)
 {
 InitTable_FuliLottery();
 }
 if( g_FuliLottery.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliLottery[nKey].Count)
 return g_FuliLottery[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliLotteryCount()
 {
 if(g_FuliLottery.Count==0)
 {
 InitTable_FuliLottery();
 }
 
 return g_FuliLottery.Count;
 }
 public static Dictionary<int, List<Tab_FuliLottery> > GetFuliLottery()
 {
 if(g_FuliLottery.Count==0)
 {
 InitTable_FuliLottery();
 }
 return g_FuliLottery;
 }

public static List<Tab_FuliNormal> GetFuliNormalLine(int nKey)
 {
 if(g_FuliNormal.Count==0)
 {
 InitTable_FuliNormal();
 }
 if( g_FuliNormal.ContainsKey(nKey))
 {
 return g_FuliNormal[nKey];
 }
 return null;
 }
 public static Tab_FuliNormal GetFuliNormalByID(int nKey)
 {
 return GetFuliNormalByID(nKey, 0);
 }
 public static Tab_FuliNormal GetFuliNormalByID(int nKey, int nIndex)
 {
 if(g_FuliNormal.Count==0)
 {
 InitTable_FuliNormal();
 }
 if( g_FuliNormal.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliNormal[nKey].Count)
 return g_FuliNormal[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliNormalCount()
 {
 if(g_FuliNormal.Count==0)
 {
 InitTable_FuliNormal();
 }
 
 return g_FuliNormal.Count;
 }
 public static Dictionary<int, List<Tab_FuliNormal> > GetFuliNormal()
 {
 if(g_FuliNormal.Count==0)
 {
 InitTable_FuliNormal();
 }
 return g_FuliNormal;
 }

public static List<Tab_FuliRecharge> GetFuliRechargeLine(int nKey)
 {
 if(g_FuliRecharge.Count==0)
 {
 InitTable_FuliRecharge();
 }
 if( g_FuliRecharge.ContainsKey(nKey))
 {
 return g_FuliRecharge[nKey];
 }
 return null;
 }
 public static Tab_FuliRecharge GetFuliRechargeByID(int nKey)
 {
 return GetFuliRechargeByID(nKey, 0);
 }
 public static Tab_FuliRecharge GetFuliRechargeByID(int nKey, int nIndex)
 {
 if(g_FuliRecharge.Count==0)
 {
 InitTable_FuliRecharge();
 }
 if( g_FuliRecharge.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliRecharge[nKey].Count)
 return g_FuliRecharge[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliRechargeCount()
 {
 if(g_FuliRecharge.Count==0)
 {
 InitTable_FuliRecharge();
 }
 
 return g_FuliRecharge.Count;
 }
 public static Dictionary<int, List<Tab_FuliRecharge> > GetFuliRecharge()
 {
 if(g_FuliRecharge.Count==0)
 {
 InitTable_FuliRecharge();
 }
 return g_FuliRecharge;
 }

public static List<Tab_FuliRiddleCage> GetFuliRiddleCageLine(int nKey)
 {
 if(g_FuliRiddleCage.Count==0)
 {
 InitTable_FuliRiddleCage();
 }
 if( g_FuliRiddleCage.ContainsKey(nKey))
 {
 return g_FuliRiddleCage[nKey];
 }
 return null;
 }
 public static Tab_FuliRiddleCage GetFuliRiddleCageByID(int nKey)
 {
 return GetFuliRiddleCageByID(nKey, 0);
 }
 public static Tab_FuliRiddleCage GetFuliRiddleCageByID(int nKey, int nIndex)
 {
 if(g_FuliRiddleCage.Count==0)
 {
 InitTable_FuliRiddleCage();
 }
 if( g_FuliRiddleCage.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FuliRiddleCage[nKey].Count)
 return g_FuliRiddleCage[nKey][nIndex];
 }
 return null;
 }
 public static int GetFuliRiddleCageCount()
 {
 if(g_FuliRiddleCage.Count==0)
 {
 InitTable_FuliRiddleCage();
 }
 
 return g_FuliRiddleCage.Count;
 }
 public static Dictionary<int, List<Tab_FuliRiddleCage> > GetFuliRiddleCage()
 {
 if(g_FuliRiddleCage.Count==0)
 {
 InitTable_FuliRiddleCage();
 }
 return g_FuliRiddleCage;
 }

public static List<Tab_FunctionUnlock> GetFunctionUnlockLine(int nKey)
 {
 if(g_FunctionUnlock.Count==0)
 {
 InitTable_FunctionUnlock();
 }
 if( g_FunctionUnlock.ContainsKey(nKey))
 {
 return g_FunctionUnlock[nKey];
 }
 return null;
 }
 public static Tab_FunctionUnlock GetFunctionUnlockByID(int nKey)
 {
 return GetFunctionUnlockByID(nKey, 0);
 }
 public static Tab_FunctionUnlock GetFunctionUnlockByID(int nKey, int nIndex)
 {
 if(g_FunctionUnlock.Count==0)
 {
 InitTable_FunctionUnlock();
 }
 if( g_FunctionUnlock.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_FunctionUnlock[nKey].Count)
 return g_FunctionUnlock[nKey][nIndex];
 }
 return null;
 }
 public static int GetFunctionUnlockCount()
 {
 if(g_FunctionUnlock.Count==0)
 {
 InitTable_FunctionUnlock();
 }
 
 return g_FunctionUnlock.Count;
 }
 public static Dictionary<int, List<Tab_FunctionUnlock> > GetFunctionUnlock()
 {
 if(g_FunctionUnlock.Count==0)
 {
 InitTable_FunctionUnlock();
 }
 return g_FunctionUnlock;
 }

public static List<Tab_Gift> GetGiftLine(int nKey)
 {
 if(g_Gift.Count==0)
 {
 InitTable_Gift();
 }
 if( g_Gift.ContainsKey(nKey))
 {
 return g_Gift[nKey];
 }
 return null;
 }
 public static Tab_Gift GetGiftByID(int nKey)
 {
 return GetGiftByID(nKey, 0);
 }
 public static Tab_Gift GetGiftByID(int nKey, int nIndex)
 {
 if(g_Gift.Count==0)
 {
 InitTable_Gift();
 }
 if( g_Gift.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Gift[nKey].Count)
 return g_Gift[nKey][nIndex];
 }
 return null;
 }
 public static int GetGiftCount()
 {
 if(g_Gift.Count==0)
 {
 InitTable_Gift();
 }
 
 return g_Gift.Count;
 }
 public static Dictionary<int, List<Tab_Gift> > GetGift()
 {
 if(g_Gift.Count==0)
 {
 InitTable_Gift();
 }
 return g_Gift;
 }

public static List<Tab_Goto> GetGotoLine(int nKey)
 {
 if(g_Goto.Count==0)
 {
 InitTable_Goto();
 }
 if( g_Goto.ContainsKey(nKey))
 {
 return g_Goto[nKey];
 }
 return null;
 }
 public static Tab_Goto GetGotoByID(int nKey)
 {
 return GetGotoByID(nKey, 0);
 }
 public static Tab_Goto GetGotoByID(int nKey, int nIndex)
 {
 if(g_Goto.Count==0)
 {
 InitTable_Goto();
 }
 if( g_Goto.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Goto[nKey].Count)
 return g_Goto[nKey][nIndex];
 }
 return null;
 }
 public static int GetGotoCount()
 {
 if(g_Goto.Count==0)
 {
 InitTable_Goto();
 }
 
 return g_Goto.Count;
 }
 public static Dictionary<int, List<Tab_Goto> > GetGoto()
 {
 if(g_Goto.Count==0)
 {
 InitTable_Goto();
 }
 return g_Goto;
 }

public static List<Tab_Guide> GetGuideLine(int nKey)
 {
 if(g_Guide.Count==0)
 {
 InitTable_Guide();
 }
 if( g_Guide.ContainsKey(nKey))
 {
 return g_Guide[nKey];
 }
 return null;
 }
 public static Tab_Guide GetGuideByID(int nKey)
 {
 return GetGuideByID(nKey, 0);
 }
 public static Tab_Guide GetGuideByID(int nKey, int nIndex)
 {
 if(g_Guide.Count==0)
 {
 InitTable_Guide();
 }
 if( g_Guide.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Guide[nKey].Count)
 return g_Guide[nKey][nIndex];
 }
 return null;
 }
 public static int GetGuideCount()
 {
 if(g_Guide.Count==0)
 {
 InitTable_Guide();
 }
 
 return g_Guide.Count;
 }
 public static Dictionary<int, List<Tab_Guide> > GetGuide()
 {
 if(g_Guide.Count==0)
 {
 InitTable_Guide();
 }
 return g_Guide;
 }

public static List<Tab_GuideEx> GetGuideExLine(int nKey)
 {
 if(g_GuideEx.Count==0)
 {
 InitTable_GuideEx();
 }
 if( g_GuideEx.ContainsKey(nKey))
 {
 return g_GuideEx[nKey];
 }
 return null;
 }
 public static Tab_GuideEx GetGuideExByID(int nKey)
 {
 return GetGuideExByID(nKey, 0);
 }
 public static Tab_GuideEx GetGuideExByID(int nKey, int nIndex)
 {
 if(g_GuideEx.Count==0)
 {
 InitTable_GuideEx();
 }
 if( g_GuideEx.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_GuideEx[nKey].Count)
 return g_GuideEx[nKey][nIndex];
 }
 return null;
 }
 public static int GetGuideExCount()
 {
 if(g_GuideEx.Count==0)
 {
 InitTable_GuideEx();
 }
 
 return g_GuideEx.Count;
 }
 public static Dictionary<int, List<Tab_GuideEx> > GetGuideEx()
 {
 if(g_GuideEx.Count==0)
 {
 InitTable_GuideEx();
 }
 return g_GuideEx;
 }

public static List<Tab_Hardware> GetHardwareLine(int nKey)
 {
 if(g_Hardware.Count==0)
 {
 InitTable_Hardware();
 }
 if( g_Hardware.ContainsKey(nKey))
 {
 return g_Hardware[nKey];
 }
 return null;
 }
 public static Tab_Hardware GetHardwareByID(int nKey)
 {
 return GetHardwareByID(nKey, 0);
 }
 public static Tab_Hardware GetHardwareByID(int nKey, int nIndex)
 {
 if(g_Hardware.Count==0)
 {
 InitTable_Hardware();
 }
 if( g_Hardware.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Hardware[nKey].Count)
 return g_Hardware[nKey][nIndex];
 }
 return null;
 }
 public static int GetHardwareCount()
 {
 if(g_Hardware.Count==0)
 {
 InitTable_Hardware();
 }
 
 return g_Hardware.Count;
 }
 public static Dictionary<int, List<Tab_Hardware> > GetHardware()
 {
 if(g_Hardware.Count==0)
 {
 InitTable_Hardware();
 }
 return g_Hardware;
 }

public static List<Tab_HeartBeat> GetHeartBeatLine(int nKey)
 {
 if(g_HeartBeat.Count==0)
 {
 InitTable_HeartBeat();
 }
 if( g_HeartBeat.ContainsKey(nKey))
 {
 return g_HeartBeat[nKey];
 }
 return null;
 }
 public static Tab_HeartBeat GetHeartBeatByID(int nKey)
 {
 return GetHeartBeatByID(nKey, 0);
 }
 public static Tab_HeartBeat GetHeartBeatByID(int nKey, int nIndex)
 {
 if(g_HeartBeat.Count==0)
 {
 InitTable_HeartBeat();
 }
 if( g_HeartBeat.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_HeartBeat[nKey].Count)
 return g_HeartBeat[nKey][nIndex];
 }
 return null;
 }
 public static int GetHeartBeatCount()
 {
 if(g_HeartBeat.Count==0)
 {
 InitTable_HeartBeat();
 }
 
 return g_HeartBeat.Count;
 }
 public static Dictionary<int, List<Tab_HeartBeat> > GetHeartBeat()
 {
 if(g_HeartBeat.Count==0)
 {
 InitTable_HeartBeat();
 }
 return g_HeartBeat;
 }

public static List<Tab_HeartBeatAction> GetHeartBeatActionLine(int nKey)
 {
 if(g_HeartBeatAction.Count==0)
 {
 InitTable_HeartBeatAction();
 }
 if( g_HeartBeatAction.ContainsKey(nKey))
 {
 return g_HeartBeatAction[nKey];
 }
 return null;
 }
 public static Tab_HeartBeatAction GetHeartBeatActionByID(int nKey)
 {
 return GetHeartBeatActionByID(nKey, 0);
 }
 public static Tab_HeartBeatAction GetHeartBeatActionByID(int nKey, int nIndex)
 {
 if(g_HeartBeatAction.Count==0)
 {
 InitTable_HeartBeatAction();
 }
 if( g_HeartBeatAction.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_HeartBeatAction[nKey].Count)
 return g_HeartBeatAction[nKey][nIndex];
 }
 return null;
 }
 public static int GetHeartBeatActionCount()
 {
 if(g_HeartBeatAction.Count==0)
 {
 InitTable_HeartBeatAction();
 }
 
 return g_HeartBeatAction.Count;
 }
 public static Dictionary<int, List<Tab_HeartBeatAction> > GetHeartBeatAction()
 {
 if(g_HeartBeatAction.Count==0)
 {
 InitTable_HeartBeatAction();
 }
 return g_HeartBeatAction;
 }

public static List<Tab_HeartBeatDialog> GetHeartBeatDialogLine(int nKey)
 {
 if(g_HeartBeatDialog.Count==0)
 {
 InitTable_HeartBeatDialog();
 }
 if( g_HeartBeatDialog.ContainsKey(nKey))
 {
 return g_HeartBeatDialog[nKey];
 }
 return null;
 }
 public static Tab_HeartBeatDialog GetHeartBeatDialogByID(int nKey)
 {
 return GetHeartBeatDialogByID(nKey, 0);
 }
 public static Tab_HeartBeatDialog GetHeartBeatDialogByID(int nKey, int nIndex)
 {
 if(g_HeartBeatDialog.Count==0)
 {
 InitTable_HeartBeatDialog();
 }
 if( g_HeartBeatDialog.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_HeartBeatDialog[nKey].Count)
 return g_HeartBeatDialog[nKey][nIndex];
 }
 return null;
 }
 public static int GetHeartBeatDialogCount()
 {
 if(g_HeartBeatDialog.Count==0)
 {
 InitTable_HeartBeatDialog();
 }
 
 return g_HeartBeatDialog.Count;
 }
 public static Dictionary<int, List<Tab_HeartBeatDialog> > GetHeartBeatDialog()
 {
 if(g_HeartBeatDialog.Count==0)
 {
 InitTable_HeartBeatDialog();
 }
 return g_HeartBeatDialog;
 }

public static List<Tab_HeartBeatQuestion> GetHeartBeatQuestionLine(int nKey)
 {
 if(g_HeartBeatQuestion.Count==0)
 {
 InitTable_HeartBeatQuestion();
 }
 if( g_HeartBeatQuestion.ContainsKey(nKey))
 {
 return g_HeartBeatQuestion[nKey];
 }
 return null;
 }
 public static Tab_HeartBeatQuestion GetHeartBeatQuestionByID(int nKey)
 {
 return GetHeartBeatQuestionByID(nKey, 0);
 }
 public static Tab_HeartBeatQuestion GetHeartBeatQuestionByID(int nKey, int nIndex)
 {
 if(g_HeartBeatQuestion.Count==0)
 {
 InitTable_HeartBeatQuestion();
 }
 if( g_HeartBeatQuestion.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_HeartBeatQuestion[nKey].Count)
 return g_HeartBeatQuestion[nKey][nIndex];
 }
 return null;
 }
 public static int GetHeartBeatQuestionCount()
 {
 if(g_HeartBeatQuestion.Count==0)
 {
 InitTable_HeartBeatQuestion();
 }
 
 return g_HeartBeatQuestion.Count;
 }
 public static Dictionary<int, List<Tab_HeartBeatQuestion> > GetHeartBeatQuestion()
 {
 if(g_HeartBeatQuestion.Count==0)
 {
 InitTable_HeartBeatQuestion();
 }
 return g_HeartBeatQuestion;
 }

public static List<Tab_HelpTips> GetHelpTipsLine(int nKey)
 {
 if(g_HelpTips.Count==0)
 {
 InitTable_HelpTips();
 }
 if( g_HelpTips.ContainsKey(nKey))
 {
 return g_HelpTips[nKey];
 }
 return null;
 }
 public static Tab_HelpTips GetHelpTipsByID(int nKey)
 {
 return GetHelpTipsByID(nKey, 0);
 }
 public static Tab_HelpTips GetHelpTipsByID(int nKey, int nIndex)
 {
 if(g_HelpTips.Count==0)
 {
 InitTable_HelpTips();
 }
 if( g_HelpTips.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_HelpTips[nKey].Count)
 return g_HelpTips[nKey][nIndex];
 }
 return null;
 }
 public static int GetHelpTipsCount()
 {
 if(g_HelpTips.Count==0)
 {
 InitTable_HelpTips();
 }
 
 return g_HelpTips.Count;
 }
 public static Dictionary<int, List<Tab_HelpTips> > GetHelpTips()
 {
 if(g_HelpTips.Count==0)
 {
 InitTable_HelpTips();
 }
 return g_HelpTips;
 }

public static List<Tab_Hexagram> GetHexagramLine(int nKey)
 {
 if(g_Hexagram.Count==0)
 {
 InitTable_Hexagram();
 }
 if( g_Hexagram.ContainsKey(nKey))
 {
 return g_Hexagram[nKey];
 }
 return null;
 }
 public static Tab_Hexagram GetHexagramByID(int nKey)
 {
 return GetHexagramByID(nKey, 0);
 }
 public static Tab_Hexagram GetHexagramByID(int nKey, int nIndex)
 {
 if(g_Hexagram.Count==0)
 {
 InitTable_Hexagram();
 }
 if( g_Hexagram.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Hexagram[nKey].Count)
 return g_Hexagram[nKey][nIndex];
 }
 return null;
 }
 public static int GetHexagramCount()
 {
 if(g_Hexagram.Count==0)
 {
 InitTable_Hexagram();
 }
 
 return g_Hexagram.Count;
 }
 public static Dictionary<int, List<Tab_Hexagram> > GetHexagram()
 {
 if(g_Hexagram.Count==0)
 {
 InitTable_Hexagram();
 }
 return g_Hexagram;
 }

public static List<Tab_InteractGamePlay> GetInteractGamePlayLine(int nKey)
 {
 if(g_InteractGamePlay.Count==0)
 {
 InitTable_InteractGamePlay();
 }
 if( g_InteractGamePlay.ContainsKey(nKey))
 {
 return g_InteractGamePlay[nKey];
 }
 return null;
 }
 public static Tab_InteractGamePlay GetInteractGamePlayByID(int nKey)
 {
 return GetInteractGamePlayByID(nKey, 0);
 }
 public static Tab_InteractGamePlay GetInteractGamePlayByID(int nKey, int nIndex)
 {
 if(g_InteractGamePlay.Count==0)
 {
 InitTable_InteractGamePlay();
 }
 if( g_InteractGamePlay.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_InteractGamePlay[nKey].Count)
 return g_InteractGamePlay[nKey][nIndex];
 }
 return null;
 }
 public static int GetInteractGamePlayCount()
 {
 if(g_InteractGamePlay.Count==0)
 {
 InitTable_InteractGamePlay();
 }
 
 return g_InteractGamePlay.Count;
 }
 public static Dictionary<int, List<Tab_InteractGamePlay> > GetInteractGamePlay()
 {
 if(g_InteractGamePlay.Count==0)
 {
 InitTable_InteractGamePlay();
 }
 return g_InteractGamePlay;
 }

public static List<Tab_InteractSpecialSound> GetInteractSpecialSoundLine(int nKey)
 {
 if(g_InteractSpecialSound.Count==0)
 {
 InitTable_InteractSpecialSound();
 }
 if( g_InteractSpecialSound.ContainsKey(nKey))
 {
 return g_InteractSpecialSound[nKey];
 }
 return null;
 }
 public static Tab_InteractSpecialSound GetInteractSpecialSoundByID(int nKey)
 {
 return GetInteractSpecialSoundByID(nKey, 0);
 }
 public static Tab_InteractSpecialSound GetInteractSpecialSoundByID(int nKey, int nIndex)
 {
 if(g_InteractSpecialSound.Count==0)
 {
 InitTable_InteractSpecialSound();
 }
 if( g_InteractSpecialSound.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_InteractSpecialSound[nKey].Count)
 return g_InteractSpecialSound[nKey][nIndex];
 }
 return null;
 }
 public static int GetInteractSpecialSoundCount()
 {
 if(g_InteractSpecialSound.Count==0)
 {
 InitTable_InteractSpecialSound();
 }
 
 return g_InteractSpecialSound.Count;
 }
 public static Dictionary<int, List<Tab_InteractSpecialSound> > GetInteractSpecialSound()
 {
 if(g_InteractSpecialSound.Count==0)
 {
 InitTable_InteractSpecialSound();
 }
 return g_InteractSpecialSound;
 }

public static List<Tab_Interflow> GetInterflowLine(int nKey)
 {
 if(g_Interflow.Count==0)
 {
 InitTable_Interflow();
 }
 if( g_Interflow.ContainsKey(nKey))
 {
 return g_Interflow[nKey];
 }
 return null;
 }
 public static Tab_Interflow GetInterflowByID(int nKey)
 {
 return GetInterflowByID(nKey, 0);
 }
 public static Tab_Interflow GetInterflowByID(int nKey, int nIndex)
 {
 if(g_Interflow.Count==0)
 {
 InitTable_Interflow();
 }
 if( g_Interflow.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Interflow[nKey].Count)
 return g_Interflow[nKey][nIndex];
 }
 return null;
 }
 public static int GetInterflowCount()
 {
 if(g_Interflow.Count==0)
 {
 InitTable_Interflow();
 }
 
 return g_Interflow.Count;
 }
 public static Dictionary<int, List<Tab_Interflow> > GetInterflow()
 {
 if(g_Interflow.Count==0)
 {
 InitTable_Interflow();
 }
 return g_Interflow;
 }

public static List<Tab_IntimacyLevel> GetIntimacyLevelLine(int nKey)
 {
 if(g_IntimacyLevel.Count==0)
 {
 InitTable_IntimacyLevel();
 }
 if( g_IntimacyLevel.ContainsKey(nKey))
 {
 return g_IntimacyLevel[nKey];
 }
 return null;
 }
 public static Tab_IntimacyLevel GetIntimacyLevelByID(int nKey)
 {
 return GetIntimacyLevelByID(nKey, 0);
 }
 public static Tab_IntimacyLevel GetIntimacyLevelByID(int nKey, int nIndex)
 {
 if(g_IntimacyLevel.Count==0)
 {
 InitTable_IntimacyLevel();
 }
 if( g_IntimacyLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_IntimacyLevel[nKey].Count)
 return g_IntimacyLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetIntimacyLevelCount()
 {
 if(g_IntimacyLevel.Count==0)
 {
 InitTable_IntimacyLevel();
 }
 
 return g_IntimacyLevel.Count;
 }
 public static Dictionary<int, List<Tab_IntimacyLevel> > GetIntimacyLevel()
 {
 if(g_IntimacyLevel.Count==0)
 {
 InitTable_IntimacyLevel();
 }
 return g_IntimacyLevel;
 }

public static List<Tab_Item> GetItemLine(int nKey)
 {
 if(g_Item.Count==0)
 {
 InitTable_Item();
 }
 if( g_Item.ContainsKey(nKey))
 {
 return g_Item[nKey];
 }
 return null;
 }
 public static Tab_Item GetItemByID(int nKey)
 {
 return GetItemByID(nKey, 0);
 }
 public static Tab_Item GetItemByID(int nKey, int nIndex)
 {
 if(g_Item.Count==0)
 {
 InitTable_Item();
 }
 if( g_Item.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Item[nKey].Count)
 return g_Item[nKey][nIndex];
 }
 return null;
 }
 public static int GetItemCount()
 {
 if(g_Item.Count==0)
 {
 InitTable_Item();
 }
 
 return g_Item.Count;
 }
 public static Dictionary<int, List<Tab_Item> > GetItem()
 {
 if(g_Item.Count==0)
 {
 InitTable_Item();
 }
 return g_Item;
 }

public static List<Tab_ItemPageType> GetItemPageTypeLine(int nKey)
 {
 if(g_ItemPageType.Count==0)
 {
 InitTable_ItemPageType();
 }
 if( g_ItemPageType.ContainsKey(nKey))
 {
 return g_ItemPageType[nKey];
 }
 return null;
 }
 public static Tab_ItemPageType GetItemPageTypeByID(int nKey)
 {
 return GetItemPageTypeByID(nKey, 0);
 }
 public static Tab_ItemPageType GetItemPageTypeByID(int nKey, int nIndex)
 {
 if(g_ItemPageType.Count==0)
 {
 InitTable_ItemPageType();
 }
 if( g_ItemPageType.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ItemPageType[nKey].Count)
 return g_ItemPageType[nKey][nIndex];
 }
 return null;
 }
 public static int GetItemPageTypeCount()
 {
 if(g_ItemPageType.Count==0)
 {
 InitTable_ItemPageType();
 }
 
 return g_ItemPageType.Count;
 }
 public static Dictionary<int, List<Tab_ItemPageType> > GetItemPageType()
 {
 if(g_ItemPageType.Count==0)
 {
 InitTable_ItemPageType();
 }
 return g_ItemPageType;
 }

public static List<Tab_LevelPlotDesc> GetLevelPlotDescLine(int nKey)
 {
 if(g_LevelPlotDesc.Count==0)
 {
 InitTable_LevelPlotDesc();
 }
 if( g_LevelPlotDesc.ContainsKey(nKey))
 {
 return g_LevelPlotDesc[nKey];
 }
 return null;
 }
 public static Tab_LevelPlotDesc GetLevelPlotDescByID(int nKey)
 {
 return GetLevelPlotDescByID(nKey, 0);
 }
 public static Tab_LevelPlotDesc GetLevelPlotDescByID(int nKey, int nIndex)
 {
 if(g_LevelPlotDesc.Count==0)
 {
 InitTable_LevelPlotDesc();
 }
 if( g_LevelPlotDesc.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_LevelPlotDesc[nKey].Count)
 return g_LevelPlotDesc[nKey][nIndex];
 }
 return null;
 }
 public static int GetLevelPlotDescCount()
 {
 if(g_LevelPlotDesc.Count==0)
 {
 InitTable_LevelPlotDesc();
 }
 
 return g_LevelPlotDesc.Count;
 }
 public static Dictionary<int, List<Tab_LevelPlotDesc> > GetLevelPlotDesc()
 {
 if(g_LevelPlotDesc.Count==0)
 {
 InitTable_LevelPlotDesc();
 }
 return g_LevelPlotDesc;
 }

public static List<Tab_Loading> GetLoadingLine(int nKey)
 {
 if(g_Loading.Count==0)
 {
 InitTable_Loading();
 }
 if( g_Loading.ContainsKey(nKey))
 {
 return g_Loading[nKey];
 }
 return null;
 }
 public static Tab_Loading GetLoadingByID(int nKey)
 {
 return GetLoadingByID(nKey, 0);
 }
 public static Tab_Loading GetLoadingByID(int nKey, int nIndex)
 {
 if(g_Loading.Count==0)
 {
 InitTable_Loading();
 }
 if( g_Loading.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Loading[nKey].Count)
 return g_Loading[nKey][nIndex];
 }
 return null;
 }
 public static int GetLoadingCount()
 {
 if(g_Loading.Count==0)
 {
 InitTable_Loading();
 }
 
 return g_Loading.Count;
 }
 public static Dictionary<int, List<Tab_Loading> > GetLoading()
 {
 if(g_Loading.Count==0)
 {
 InitTable_Loading();
 }
 return g_Loading;
 }

public static List<Tab_LoadingScene> GetLoadingSceneLine(int nKey)
 {
 if(g_LoadingScene.Count==0)
 {
 InitTable_LoadingScene();
 }
 if( g_LoadingScene.ContainsKey(nKey))
 {
 return g_LoadingScene[nKey];
 }
 return null;
 }
 public static Tab_LoadingScene GetLoadingSceneByID(int nKey)
 {
 return GetLoadingSceneByID(nKey, 0);
 }
 public static Tab_LoadingScene GetLoadingSceneByID(int nKey, int nIndex)
 {
 if(g_LoadingScene.Count==0)
 {
 InitTable_LoadingScene();
 }
 if( g_LoadingScene.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_LoadingScene[nKey].Count)
 return g_LoadingScene[nKey][nIndex];
 }
 return null;
 }
 public static int GetLoadingSceneCount()
 {
 if(g_LoadingScene.Count==0)
 {
 InitTable_LoadingScene();
 }
 
 return g_LoadingScene.Count;
 }
 public static Dictionary<int, List<Tab_LoadingScene> > GetLoadingScene()
 {
 if(g_LoadingScene.Count==0)
 {
 InitTable_LoadingScene();
 }
 return g_LoadingScene;
 }

public static List<Tab_LoadingText> GetLoadingTextLine(int nKey)
 {
 if(g_LoadingText.Count==0)
 {
 InitTable_LoadingText();
 }
 if( g_LoadingText.ContainsKey(nKey))
 {
 return g_LoadingText[nKey];
 }
 return null;
 }
 public static Tab_LoadingText GetLoadingTextByID(int nKey)
 {
 return GetLoadingTextByID(nKey, 0);
 }
 public static Tab_LoadingText GetLoadingTextByID(int nKey, int nIndex)
 {
 if(g_LoadingText.Count==0)
 {
 InitTable_LoadingText();
 }
 if( g_LoadingText.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_LoadingText[nKey].Count)
 return g_LoadingText[nKey][nIndex];
 }
 return null;
 }
 public static int GetLoadingTextCount()
 {
 if(g_LoadingText.Count==0)
 {
 InitTable_LoadingText();
 }
 
 return g_LoadingText.Count;
 }
 public static Dictionary<int, List<Tab_LoadingText> > GetLoadingText()
 {
 if(g_LoadingText.Count==0)
 {
 InitTable_LoadingText();
 }
 return g_LoadingText;
 }

public static List<Tab_LoadingTexture> GetLoadingTextureLine(int nKey)
 {
 if(g_LoadingTexture.Count==0)
 {
 InitTable_LoadingTexture();
 }
 if( g_LoadingTexture.ContainsKey(nKey))
 {
 return g_LoadingTexture[nKey];
 }
 return null;
 }
 public static Tab_LoadingTexture GetLoadingTextureByID(int nKey)
 {
 return GetLoadingTextureByID(nKey, 0);
 }
 public static Tab_LoadingTexture GetLoadingTextureByID(int nKey, int nIndex)
 {
 if(g_LoadingTexture.Count==0)
 {
 InitTable_LoadingTexture();
 }
 if( g_LoadingTexture.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_LoadingTexture[nKey].Count)
 return g_LoadingTexture[nKey][nIndex];
 }
 return null;
 }
 public static int GetLoadingTextureCount()
 {
 if(g_LoadingTexture.Count==0)
 {
 InitTable_LoadingTexture();
 }
 
 return g_LoadingTexture.Count;
 }
 public static Dictionary<int, List<Tab_LoadingTexture> > GetLoadingTexture()
 {
 if(g_LoadingTexture.Count==0)
 {
 InitTable_LoadingTexture();
 }
 return g_LoadingTexture;
 }

public static List<Tab_LocalizationData> GetLocalizationDataLine(int nKey)
 {
 if(g_LocalizationData.Count==0)
 {
 InitTable_LocalizationData();
 }
 if( g_LocalizationData.ContainsKey(nKey))
 {
 return g_LocalizationData[nKey];
 }
 return null;
 }
 public static Tab_LocalizationData GetLocalizationDataByID(int nKey)
 {
 return GetLocalizationDataByID(nKey, 0);
 }
 public static Tab_LocalizationData GetLocalizationDataByID(int nKey, int nIndex)
 {
 if(g_LocalizationData.Count==0)
 {
 InitTable_LocalizationData();
 }
 if( g_LocalizationData.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_LocalizationData[nKey].Count)
 return g_LocalizationData[nKey][nIndex];
 }
 return null;
 }
 public static int GetLocalizationDataCount()
 {
 if(g_LocalizationData.Count==0)
 {
 InitTable_LocalizationData();
 }
 
 return g_LocalizationData.Count;
 }
 public static Dictionary<int, List<Tab_LocalizationData> > GetLocalizationData()
 {
 if(g_LocalizationData.Count==0)
 {
 InitTable_LocalizationData();
 }
 return g_LocalizationData;
 }

public static List<Tab_MainSceneCarouselMap> GetMainSceneCarouselMapLine(int nKey)
 {
 if(g_MainSceneCarouselMap.Count==0)
 {
 InitTable_MainSceneCarouselMap();
 }
 if( g_MainSceneCarouselMap.ContainsKey(nKey))
 {
 return g_MainSceneCarouselMap[nKey];
 }
 return null;
 }
 public static Tab_MainSceneCarouselMap GetMainSceneCarouselMapByID(int nKey)
 {
 return GetMainSceneCarouselMapByID(nKey, 0);
 }
 public static Tab_MainSceneCarouselMap GetMainSceneCarouselMapByID(int nKey, int nIndex)
 {
 if(g_MainSceneCarouselMap.Count==0)
 {
 InitTable_MainSceneCarouselMap();
 }
 if( g_MainSceneCarouselMap.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_MainSceneCarouselMap[nKey].Count)
 return g_MainSceneCarouselMap[nKey][nIndex];
 }
 return null;
 }
 public static int GetMainSceneCarouselMapCount()
 {
 if(g_MainSceneCarouselMap.Count==0)
 {
 InitTable_MainSceneCarouselMap();
 }
 
 return g_MainSceneCarouselMap.Count;
 }
 public static Dictionary<int, List<Tab_MainSceneCarouselMap> > GetMainSceneCarouselMap()
 {
 if(g_MainSceneCarouselMap.Count==0)
 {
 InitTable_MainSceneCarouselMap();
 }
 return g_MainSceneCarouselMap;
 }

public static List<Tab_MainSceneTimeSceneEnv> GetMainSceneTimeSceneEnvLine(int nKey)
 {
 if(g_MainSceneTimeSceneEnv.Count==0)
 {
 InitTable_MainSceneTimeSceneEnv();
 }
 if( g_MainSceneTimeSceneEnv.ContainsKey(nKey))
 {
 return g_MainSceneTimeSceneEnv[nKey];
 }
 return null;
 }
 public static Tab_MainSceneTimeSceneEnv GetMainSceneTimeSceneEnvByID(int nKey)
 {
 return GetMainSceneTimeSceneEnvByID(nKey, 0);
 }
 public static Tab_MainSceneTimeSceneEnv GetMainSceneTimeSceneEnvByID(int nKey, int nIndex)
 {
 if(g_MainSceneTimeSceneEnv.Count==0)
 {
 InitTable_MainSceneTimeSceneEnv();
 }
 if( g_MainSceneTimeSceneEnv.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_MainSceneTimeSceneEnv[nKey].Count)
 return g_MainSceneTimeSceneEnv[nKey][nIndex];
 }
 return null;
 }
 public static int GetMainSceneTimeSceneEnvCount()
 {
 if(g_MainSceneTimeSceneEnv.Count==0)
 {
 InitTable_MainSceneTimeSceneEnv();
 }
 
 return g_MainSceneTimeSceneEnv.Count;
 }
 public static Dictionary<int, List<Tab_MainSceneTimeSceneEnv> > GetMainSceneTimeSceneEnv()
 {
 if(g_MainSceneTimeSceneEnv.Count==0)
 {
 InitTable_MainSceneTimeSceneEnv();
 }
 return g_MainSceneTimeSceneEnv;
 }

public static List<Tab_MisReputationLevel> GetMisReputationLevelLine(int nKey)
 {
 if(g_MisReputationLevel.Count==0)
 {
 InitTable_MisReputationLevel();
 }
 if( g_MisReputationLevel.ContainsKey(nKey))
 {
 return g_MisReputationLevel[nKey];
 }
 return null;
 }
 public static Tab_MisReputationLevel GetMisReputationLevelByID(int nKey)
 {
 return GetMisReputationLevelByID(nKey, 0);
 }
 public static Tab_MisReputationLevel GetMisReputationLevelByID(int nKey, int nIndex)
 {
 if(g_MisReputationLevel.Count==0)
 {
 InitTable_MisReputationLevel();
 }
 if( g_MisReputationLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_MisReputationLevel[nKey].Count)
 return g_MisReputationLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetMisReputationLevelCount()
 {
 if(g_MisReputationLevel.Count==0)
 {
 InitTable_MisReputationLevel();
 }
 
 return g_MisReputationLevel.Count;
 }
 public static Dictionary<int, List<Tab_MisReputationLevel> > GetMisReputationLevel()
 {
 if(g_MisReputationLevel.Count==0)
 {
 InitTable_MisReputationLevel();
 }
 return g_MisReputationLevel;
 }

public static List<Tab_Mission> GetMissionLine(int nKey)
 {
 if(g_Mission.Count==0)
 {
 InitTable_Mission();
 }
 if( g_Mission.ContainsKey(nKey))
 {
 return g_Mission[nKey];
 }
 return null;
 }
 public static Tab_Mission GetMissionByID(int nKey)
 {
 return GetMissionByID(nKey, 0);
 }
 public static Tab_Mission GetMissionByID(int nKey, int nIndex)
 {
 if(g_Mission.Count==0)
 {
 InitTable_Mission();
 }
 if( g_Mission.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Mission[nKey].Count)
 return g_Mission[nKey][nIndex];
 }
 return null;
 }
 public static int GetMissionCount()
 {
 if(g_Mission.Count==0)
 {
 InitTable_Mission();
 }
 
 return g_Mission.Count;
 }
 public static Dictionary<int, List<Tab_Mission> > GetMission()
 {
 if(g_Mission.Count==0)
 {
 InitTable_Mission();
 }
 return g_Mission;
 }

public static List<Tab_MissionItem> GetMissionItemLine(int nKey)
 {
 if(g_MissionItem.Count==0)
 {
 InitTable_MissionItem();
 }
 if( g_MissionItem.ContainsKey(nKey))
 {
 return g_MissionItem[nKey];
 }
 return null;
 }
 public static Tab_MissionItem GetMissionItemByID(int nKey)
 {
 return GetMissionItemByID(nKey, 0);
 }
 public static Tab_MissionItem GetMissionItemByID(int nKey, int nIndex)
 {
 if(g_MissionItem.Count==0)
 {
 InitTable_MissionItem();
 }
 if( g_MissionItem.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_MissionItem[nKey].Count)
 return g_MissionItem[nKey][nIndex];
 }
 return null;
 }
 public static int GetMissionItemCount()
 {
 if(g_MissionItem.Count==0)
 {
 InitTable_MissionItem();
 }
 
 return g_MissionItem.Count;
 }
 public static Dictionary<int, List<Tab_MissionItem> > GetMissionItem()
 {
 if(g_MissionItem.Count==0)
 {
 InitTable_MissionItem();
 }
 return g_MissionItem;
 }

public static List<Tab_MissionMail> GetMissionMailLine(int nKey)
 {
 if(g_MissionMail.Count==0)
 {
 InitTable_MissionMail();
 }
 if( g_MissionMail.ContainsKey(nKey))
 {
 return g_MissionMail[nKey];
 }
 return null;
 }
 public static Tab_MissionMail GetMissionMailByID(int nKey)
 {
 return GetMissionMailByID(nKey, 0);
 }
 public static Tab_MissionMail GetMissionMailByID(int nKey, int nIndex)
 {
 if(g_MissionMail.Count==0)
 {
 InitTable_MissionMail();
 }
 if( g_MissionMail.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_MissionMail[nKey].Count)
 return g_MissionMail[nKey][nIndex];
 }
 return null;
 }
 public static int GetMissionMailCount()
 {
 if(g_MissionMail.Count==0)
 {
 InitTable_MissionMail();
 }
 
 return g_MissionMail.Count;
 }
 public static Dictionary<int, List<Tab_MissionMail> > GetMissionMail()
 {
 if(g_MissionMail.Count==0)
 {
 InitTable_MissionMail();
 }
 return g_MissionMail;
 }

public static List<Tab_MonthCard> GetMonthCardLine(int nKey)
 {
 if(g_MonthCard.Count==0)
 {
 InitTable_MonthCard();
 }
 if( g_MonthCard.ContainsKey(nKey))
 {
 return g_MonthCard[nKey];
 }
 return null;
 }
 public static Tab_MonthCard GetMonthCardByID(int nKey)
 {
 return GetMonthCardByID(nKey, 0);
 }
 public static Tab_MonthCard GetMonthCardByID(int nKey, int nIndex)
 {
 if(g_MonthCard.Count==0)
 {
 InitTable_MonthCard();
 }
 if( g_MonthCard.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_MonthCard[nKey].Count)
 return g_MonthCard[nKey][nIndex];
 }
 return null;
 }
 public static int GetMonthCardCount()
 {
 if(g_MonthCard.Count==0)
 {
 InitTable_MonthCard();
 }
 
 return g_MonthCard.Count;
 }
 public static Dictionary<int, List<Tab_MonthCard> > GetMonthCard()
 {
 if(g_MonthCard.Count==0)
 {
 InitTable_MonthCard();
 }
 return g_MonthCard;
 }

public static List<Tab_Node> GetNodeLine(int nKey)
 {
 if(g_Node.Count==0)
 {
 InitTable_Node();
 }
 if( g_Node.ContainsKey(nKey))
 {
 return g_Node[nKey];
 }
 return null;
 }
 public static Tab_Node GetNodeByID(int nKey)
 {
 return GetNodeByID(nKey, 0);
 }
 public static Tab_Node GetNodeByID(int nKey, int nIndex)
 {
 if(g_Node.Count==0)
 {
 InitTable_Node();
 }
 if( g_Node.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Node[nKey].Count)
 return g_Node[nKey][nIndex];
 }
 return null;
 }
 public static int GetNodeCount()
 {
 if(g_Node.Count==0)
 {
 InitTable_Node();
 }
 
 return g_Node.Count;
 }
 public static Dictionary<int, List<Tab_Node> > GetNode()
 {
 if(g_Node.Count==0)
 {
 InitTable_Node();
 }
 return g_Node;
 }

public static List<Tab_Notice> GetNoticeLine(int nKey)
 {
 if(g_Notice.Count==0)
 {
 InitTable_Notice();
 }
 if( g_Notice.ContainsKey(nKey))
 {
 return g_Notice[nKey];
 }
 return null;
 }
 public static Tab_Notice GetNoticeByID(int nKey)
 {
 return GetNoticeByID(nKey, 0);
 }
 public static Tab_Notice GetNoticeByID(int nKey, int nIndex)
 {
 if(g_Notice.Count==0)
 {
 InitTable_Notice();
 }
 if( g_Notice.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Notice[nKey].Count)
 return g_Notice[nKey][nIndex];
 }
 return null;
 }
 public static int GetNoticeCount()
 {
 if(g_Notice.Count==0)
 {
 InitTable_Notice();
 }
 
 return g_Notice.Count;
 }
 public static Dictionary<int, List<Tab_Notice> > GetNotice()
 {
 if(g_Notice.Count==0)
 {
 InitTable_Notice();
 }
 return g_Notice;
 }

public static List<Tab_NoticeType> GetNoticeTypeLine(int nKey)
 {
 if(g_NoticeType.Count==0)
 {
 InitTable_NoticeType();
 }
 if( g_NoticeType.ContainsKey(nKey))
 {
 return g_NoticeType[nKey];
 }
 return null;
 }
 public static Tab_NoticeType GetNoticeTypeByID(int nKey)
 {
 return GetNoticeTypeByID(nKey, 0);
 }
 public static Tab_NoticeType GetNoticeTypeByID(int nKey, int nIndex)
 {
 if(g_NoticeType.Count==0)
 {
 InitTable_NoticeType();
 }
 if( g_NoticeType.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_NoticeType[nKey].Count)
 return g_NoticeType[nKey][nIndex];
 }
 return null;
 }
 public static int GetNoticeTypeCount()
 {
 if(g_NoticeType.Count==0)
 {
 InitTable_NoticeType();
 }
 
 return g_NoticeType.Count;
 }
 public static Dictionary<int, List<Tab_NoticeType> > GetNoticeType()
 {
 if(g_NoticeType.Count==0)
 {
 InitTable_NoticeType();
 }
 return g_NoticeType;
 }

public static List<Tab_NoviceGuide> GetNoviceGuideLine(int nKey)
 {
 if(g_NoviceGuide.Count==0)
 {
 InitTable_NoviceGuide();
 }
 if( g_NoviceGuide.ContainsKey(nKey))
 {
 return g_NoviceGuide[nKey];
 }
 return null;
 }
 public static Tab_NoviceGuide GetNoviceGuideByID(int nKey)
 {
 return GetNoviceGuideByID(nKey, 0);
 }
 public static Tab_NoviceGuide GetNoviceGuideByID(int nKey, int nIndex)
 {
 if(g_NoviceGuide.Count==0)
 {
 InitTable_NoviceGuide();
 }
 if( g_NoviceGuide.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_NoviceGuide[nKey].Count)
 return g_NoviceGuide[nKey][nIndex];
 }
 return null;
 }
 public static int GetNoviceGuideCount()
 {
 if(g_NoviceGuide.Count==0)
 {
 InitTable_NoviceGuide();
 }
 
 return g_NoviceGuide.Count;
 }
 public static Dictionary<int, List<Tab_NoviceGuide> > GetNoviceGuide()
 {
 if(g_NoviceGuide.Count==0)
 {
 InitTable_NoviceGuide();
 }
 return g_NoviceGuide;
 }

public static List<Tab_Npc> GetNpcLine(int nKey)
 {
 if(g_Npc.Count==0)
 {
 InitTable_Npc();
 }
 if( g_Npc.ContainsKey(nKey))
 {
 return g_Npc[nKey];
 }
 return null;
 }
 public static Tab_Npc GetNpcByID(int nKey)
 {
 return GetNpcByID(nKey, 0);
 }
 public static Tab_Npc GetNpcByID(int nKey, int nIndex)
 {
 if(g_Npc.Count==0)
 {
 InitTable_Npc();
 }
 if( g_Npc.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Npc[nKey].Count)
 return g_Npc[nKey][nIndex];
 }
 return null;
 }
 public static int GetNpcCount()
 {
 if(g_Npc.Count==0)
 {
 InitTable_Npc();
 }
 
 return g_Npc.Count;
 }
 public static Dictionary<int, List<Tab_Npc> > GetNpc()
 {
 if(g_Npc.Count==0)
 {
 InitTable_Npc();
 }
 return g_Npc;
 }

public static List<Tab_NpcLevel> GetNpcLevelLine(int nKey)
 {
 if(g_NpcLevel.Count==0)
 {
 InitTable_NpcLevel();
 }
 if( g_NpcLevel.ContainsKey(nKey))
 {
 return g_NpcLevel[nKey];
 }
 return null;
 }
 public static Tab_NpcLevel GetNpcLevelByID(int nKey)
 {
 return GetNpcLevelByID(nKey, 0);
 }
 public static Tab_NpcLevel GetNpcLevelByID(int nKey, int nIndex)
 {
 if(g_NpcLevel.Count==0)
 {
 InitTable_NpcLevel();
 }
 if( g_NpcLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_NpcLevel[nKey].Count)
 return g_NpcLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetNpcLevelCount()
 {
 if(g_NpcLevel.Count==0)
 {
 InitTable_NpcLevel();
 }
 
 return g_NpcLevel.Count;
 }
 public static Dictionary<int, List<Tab_NpcLevel> > GetNpcLevel()
 {
 if(g_NpcLevel.Count==0)
 {
 InitTable_NpcLevel();
 }
 return g_NpcLevel;
 }

public static List<Tab_NpcQuestion> GetNpcQuestionLine(int nKey)
 {
 if(g_NpcQuestion.Count==0)
 {
 InitTable_NpcQuestion();
 }
 if( g_NpcQuestion.ContainsKey(nKey))
 {
 return g_NpcQuestion[nKey];
 }
 return null;
 }
 public static Tab_NpcQuestion GetNpcQuestionByID(int nKey)
 {
 return GetNpcQuestionByID(nKey, 0);
 }
 public static Tab_NpcQuestion GetNpcQuestionByID(int nKey, int nIndex)
 {
 if(g_NpcQuestion.Count==0)
 {
 InitTable_NpcQuestion();
 }
 if( g_NpcQuestion.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_NpcQuestion[nKey].Count)
 return g_NpcQuestion[nKey][nIndex];
 }
 return null;
 }
 public static int GetNpcQuestionCount()
 {
 if(g_NpcQuestion.Count==0)
 {
 InitTable_NpcQuestion();
 }
 
 return g_NpcQuestion.Count;
 }
 public static Dictionary<int, List<Tab_NpcQuestion> > GetNpcQuestion()
 {
 if(g_NpcQuestion.Count==0)
 {
 InitTable_NpcQuestion();
 }
 return g_NpcQuestion;
 }

public static List<Tab_NpcState> GetNpcStateLine(int nKey)
 {
 if(g_NpcState.Count==0)
 {
 InitTable_NpcState();
 }
 if( g_NpcState.ContainsKey(nKey))
 {
 return g_NpcState[nKey];
 }
 return null;
 }
 public static Tab_NpcState GetNpcStateByID(int nKey)
 {
 return GetNpcStateByID(nKey, 0);
 }
 public static Tab_NpcState GetNpcStateByID(int nKey, int nIndex)
 {
 if(g_NpcState.Count==0)
 {
 InitTable_NpcState();
 }
 if( g_NpcState.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_NpcState[nKey].Count)
 return g_NpcState[nKey][nIndex];
 }
 return null;
 }
 public static int GetNpcStateCount()
 {
 if(g_NpcState.Count==0)
 {
 InitTable_NpcState();
 }
 
 return g_NpcState.Count;
 }
 public static Dictionary<int, List<Tab_NpcState> > GetNpcState()
 {
 if(g_NpcState.Count==0)
 {
 InitTable_NpcState();
 }
 return g_NpcState;
 }

public static List<Tab_NpcTask> GetNpcTaskLine(int nKey)
 {
 if(g_NpcTask.Count==0)
 {
 InitTable_NpcTask();
 }
 if( g_NpcTask.ContainsKey(nKey))
 {
 return g_NpcTask[nKey];
 }
 return null;
 }
 public static Tab_NpcTask GetNpcTaskByID(int nKey)
 {
 return GetNpcTaskByID(nKey, 0);
 }
 public static Tab_NpcTask GetNpcTaskByID(int nKey, int nIndex)
 {
 if(g_NpcTask.Count==0)
 {
 InitTable_NpcTask();
 }
 if( g_NpcTask.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_NpcTask[nKey].Count)
 return g_NpcTask[nKey][nIndex];
 }
 return null;
 }
 public static int GetNpcTaskCount()
 {
 if(g_NpcTask.Count==0)
 {
 InitTable_NpcTask();
 }
 
 return g_NpcTask.Count;
 }
 public static Dictionary<int, List<Tab_NpcTask> > GetNpcTask()
 {
 if(g_NpcTask.Count==0)
 {
 InitTable_NpcTask();
 }
 return g_NpcTask;
 }

public static List<Tab_Npclike> GetNpclikeLine(int nKey)
 {
 if(g_Npclike.Count==0)
 {
 InitTable_Npclike();
 }
 if( g_Npclike.ContainsKey(nKey))
 {
 return g_Npclike[nKey];
 }
 return null;
 }
 public static Tab_Npclike GetNpclikeByID(int nKey)
 {
 return GetNpclikeByID(nKey, 0);
 }
 public static Tab_Npclike GetNpclikeByID(int nKey, int nIndex)
 {
 if(g_Npclike.Count==0)
 {
 InitTable_Npclike();
 }
 if( g_Npclike.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Npclike[nKey].Count)
 return g_Npclike[nKey][nIndex];
 }
 return null;
 }
 public static int GetNpclikeCount()
 {
 if(g_Npclike.Count==0)
 {
 InitTable_Npclike();
 }
 
 return g_Npclike.Count;
 }
 public static Dictionary<int, List<Tab_Npclike> > GetNpclike()
 {
 if(g_Npclike.Count==0)
 {
 InitTable_Npclike();
 }
 return g_Npclike;
 }

public static List<Tab_OptItem> GetOptItemLine(int nKey)
 {
 if(g_OptItem.Count==0)
 {
 InitTable_OptItem();
 }
 if( g_OptItem.ContainsKey(nKey))
 {
 return g_OptItem[nKey];
 }
 return null;
 }
 public static Tab_OptItem GetOptItemByID(int nKey)
 {
 return GetOptItemByID(nKey, 0);
 }
 public static Tab_OptItem GetOptItemByID(int nKey, int nIndex)
 {
 if(g_OptItem.Count==0)
 {
 InitTable_OptItem();
 }
 if( g_OptItem.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_OptItem[nKey].Count)
 return g_OptItem[nKey][nIndex];
 }
 return null;
 }
 public static int GetOptItemCount()
 {
 if(g_OptItem.Count==0)
 {
 InitTable_OptItem();
 }
 
 return g_OptItem.Count;
 }
 public static Dictionary<int, List<Tab_OptItem> > GetOptItem()
 {
 if(g_OptItem.Count==0)
 {
 InitTable_OptItem();
 }
 return g_OptItem;
 }

public static List<Tab_PersonalChapterAward> GetPersonalChapterAwardLine(int nKey)
 {
 if(g_PersonalChapterAward.Count==0)
 {
 InitTable_PersonalChapterAward();
 }
 if( g_PersonalChapterAward.ContainsKey(nKey))
 {
 return g_PersonalChapterAward[nKey];
 }
 return null;
 }
 public static Tab_PersonalChapterAward GetPersonalChapterAwardByID(int nKey)
 {
 return GetPersonalChapterAwardByID(nKey, 0);
 }
 public static Tab_PersonalChapterAward GetPersonalChapterAwardByID(int nKey, int nIndex)
 {
 if(g_PersonalChapterAward.Count==0)
 {
 InitTable_PersonalChapterAward();
 }
 if( g_PersonalChapterAward.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PersonalChapterAward[nKey].Count)
 return g_PersonalChapterAward[nKey][nIndex];
 }
 return null;
 }
 public static int GetPersonalChapterAwardCount()
 {
 if(g_PersonalChapterAward.Count==0)
 {
 InitTable_PersonalChapterAward();
 }
 
 return g_PersonalChapterAward.Count;
 }
 public static Dictionary<int, List<Tab_PersonalChapterAward> > GetPersonalChapterAward()
 {
 if(g_PersonalChapterAward.Count==0)
 {
 InitTable_PersonalChapterAward();
 }
 return g_PersonalChapterAward;
 }

public static List<Tab_PersonalStory> GetPersonalStoryLine(int nKey)
 {
 if(g_PersonalStory.Count==0)
 {
 InitTable_PersonalStory();
 }
 if( g_PersonalStory.ContainsKey(nKey))
 {
 return g_PersonalStory[nKey];
 }
 return null;
 }
 public static Tab_PersonalStory GetPersonalStoryByID(int nKey)
 {
 return GetPersonalStoryByID(nKey, 0);
 }
 public static Tab_PersonalStory GetPersonalStoryByID(int nKey, int nIndex)
 {
 if(g_PersonalStory.Count==0)
 {
 InitTable_PersonalStory();
 }
 if( g_PersonalStory.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PersonalStory[nKey].Count)
 return g_PersonalStory[nKey][nIndex];
 }
 return null;
 }
 public static int GetPersonalStoryCount()
 {
 if(g_PersonalStory.Count==0)
 {
 InitTable_PersonalStory();
 }
 
 return g_PersonalStory.Count;
 }
 public static Dictionary<int, List<Tab_PersonalStory> > GetPersonalStory()
 {
 if(g_PersonalStory.Count==0)
 {
 InitTable_PersonalStory();
 }
 return g_PersonalStory;
 }

public static List<Tab_Personality> GetPersonalityLine(int nKey)
 {
 if(g_Personality.Count==0)
 {
 InitTable_Personality();
 }
 if( g_Personality.ContainsKey(nKey))
 {
 return g_Personality[nKey];
 }
 return null;
 }
 public static Tab_Personality GetPersonalityByID(int nKey)
 {
 return GetPersonalityByID(nKey, 0);
 }
 public static Tab_Personality GetPersonalityByID(int nKey, int nIndex)
 {
 if(g_Personality.Count==0)
 {
 InitTable_Personality();
 }
 if( g_Personality.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Personality[nKey].Count)
 return g_Personality[nKey][nIndex];
 }
 return null;
 }
 public static int GetPersonalityCount()
 {
 if(g_Personality.Count==0)
 {
 InitTable_Personality();
 }
 
 return g_Personality.Count;
 }
 public static Dictionary<int, List<Tab_Personality> > GetPersonality()
 {
 if(g_Personality.Count==0)
 {
 InitTable_Personality();
 }
 return g_Personality;
 }

public static List<Tab_PersonalityData> GetPersonalityDataLine(int nKey)
 {
 if(g_PersonalityData.Count==0)
 {
 InitTable_PersonalityData();
 }
 if( g_PersonalityData.ContainsKey(nKey))
 {
 return g_PersonalityData[nKey];
 }
 return null;
 }
 public static Tab_PersonalityData GetPersonalityDataByID(int nKey)
 {
 return GetPersonalityDataByID(nKey, 0);
 }
 public static Tab_PersonalityData GetPersonalityDataByID(int nKey, int nIndex)
 {
 if(g_PersonalityData.Count==0)
 {
 InitTable_PersonalityData();
 }
 if( g_PersonalityData.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PersonalityData[nKey].Count)
 return g_PersonalityData[nKey][nIndex];
 }
 return null;
 }
 public static int GetPersonalityDataCount()
 {
 if(g_PersonalityData.Count==0)
 {
 InitTable_PersonalityData();
 }
 
 return g_PersonalityData.Count;
 }
 public static Dictionary<int, List<Tab_PersonalityData> > GetPersonalityData()
 {
 if(g_PersonalityData.Count==0)
 {
 InitTable_PersonalityData();
 }
 return g_PersonalityData;
 }

public static List<Tab_PersonalityLevel> GetPersonalityLevelLine(int nKey)
 {
 if(g_PersonalityLevel.Count==0)
 {
 InitTable_PersonalityLevel();
 }
 if( g_PersonalityLevel.ContainsKey(nKey))
 {
 return g_PersonalityLevel[nKey];
 }
 return null;
 }
 public static Tab_PersonalityLevel GetPersonalityLevelByID(int nKey)
 {
 return GetPersonalityLevelByID(nKey, 0);
 }
 public static Tab_PersonalityLevel GetPersonalityLevelByID(int nKey, int nIndex)
 {
 if(g_PersonalityLevel.Count==0)
 {
 InitTable_PersonalityLevel();
 }
 if( g_PersonalityLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PersonalityLevel[nKey].Count)
 return g_PersonalityLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetPersonalityLevelCount()
 {
 if(g_PersonalityLevel.Count==0)
 {
 InitTable_PersonalityLevel();
 }
 
 return g_PersonalityLevel.Count;
 }
 public static Dictionary<int, List<Tab_PersonalityLevel> > GetPersonalityLevel()
 {
 if(g_PersonalityLevel.Count==0)
 {
 InitTable_PersonalityLevel();
 }
 return g_PersonalityLevel;
 }

public static List<Tab_PersonalityMonologue> GetPersonalityMonologueLine(int nKey)
 {
 if(g_PersonalityMonologue.Count==0)
 {
 InitTable_PersonalityMonologue();
 }
 if( g_PersonalityMonologue.ContainsKey(nKey))
 {
 return g_PersonalityMonologue[nKey];
 }
 return null;
 }
 public static Tab_PersonalityMonologue GetPersonalityMonologueByID(int nKey)
 {
 return GetPersonalityMonologueByID(nKey, 0);
 }
 public static Tab_PersonalityMonologue GetPersonalityMonologueByID(int nKey, int nIndex)
 {
 if(g_PersonalityMonologue.Count==0)
 {
 InitTable_PersonalityMonologue();
 }
 if( g_PersonalityMonologue.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PersonalityMonologue[nKey].Count)
 return g_PersonalityMonologue[nKey][nIndex];
 }
 return null;
 }
 public static int GetPersonalityMonologueCount()
 {
 if(g_PersonalityMonologue.Count==0)
 {
 InitTable_PersonalityMonologue();
 }
 
 return g_PersonalityMonologue.Count;
 }
 public static Dictionary<int, List<Tab_PersonalityMonologue> > GetPersonalityMonologue()
 {
 if(g_PersonalityMonologue.Count==0)
 {
 InitTable_PersonalityMonologue();
 }
 return g_PersonalityMonologue;
 }

public static List<Tab_PersonalityProcess> GetPersonalityProcessLine(int nKey)
 {
 if(g_PersonalityProcess.Count==0)
 {
 InitTable_PersonalityProcess();
 }
 if( g_PersonalityProcess.ContainsKey(nKey))
 {
 return g_PersonalityProcess[nKey];
 }
 return null;
 }
 public static Tab_PersonalityProcess GetPersonalityProcessByID(int nKey)
 {
 return GetPersonalityProcessByID(nKey, 0);
 }
 public static Tab_PersonalityProcess GetPersonalityProcessByID(int nKey, int nIndex)
 {
 if(g_PersonalityProcess.Count==0)
 {
 InitTable_PersonalityProcess();
 }
 if( g_PersonalityProcess.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PersonalityProcess[nKey].Count)
 return g_PersonalityProcess[nKey][nIndex];
 }
 return null;
 }
 public static int GetPersonalityProcessCount()
 {
 if(g_PersonalityProcess.Count==0)
 {
 InitTable_PersonalityProcess();
 }
 
 return g_PersonalityProcess.Count;
 }
 public static Dictionary<int, List<Tab_PersonalityProcess> > GetPersonalityProcess()
 {
 if(g_PersonalityProcess.Count==0)
 {
 InitTable_PersonalityProcess();
 }
 return g_PersonalityProcess;
 }

public static List<Tab_PersonalityQuestion> GetPersonalityQuestionLine(int nKey)
 {
 if(g_PersonalityQuestion.Count==0)
 {
 InitTable_PersonalityQuestion();
 }
 if( g_PersonalityQuestion.ContainsKey(nKey))
 {
 return g_PersonalityQuestion[nKey];
 }
 return null;
 }
 public static Tab_PersonalityQuestion GetPersonalityQuestionByID(int nKey)
 {
 return GetPersonalityQuestionByID(nKey, 0);
 }
 public static Tab_PersonalityQuestion GetPersonalityQuestionByID(int nKey, int nIndex)
 {
 if(g_PersonalityQuestion.Count==0)
 {
 InitTable_PersonalityQuestion();
 }
 if( g_PersonalityQuestion.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PersonalityQuestion[nKey].Count)
 return g_PersonalityQuestion[nKey][nIndex];
 }
 return null;
 }
 public static int GetPersonalityQuestionCount()
 {
 if(g_PersonalityQuestion.Count==0)
 {
 InitTable_PersonalityQuestion();
 }
 
 return g_PersonalityQuestion.Count;
 }
 public static Dictionary<int, List<Tab_PersonalityQuestion> > GetPersonalityQuestion()
 {
 if(g_PersonalityQuestion.Count==0)
 {
 InitTable_PersonalityQuestion();
 }
 return g_PersonalityQuestion;
 }

public static List<Tab_PlayerLevel> GetPlayerLevelLine(int nKey)
 {
 if(g_PlayerLevel.Count==0)
 {
 InitTable_PlayerLevel();
 }
 if( g_PlayerLevel.ContainsKey(nKey))
 {
 return g_PlayerLevel[nKey];
 }
 return null;
 }
 public static Tab_PlayerLevel GetPlayerLevelByID(int nKey)
 {
 return GetPlayerLevelByID(nKey, 0);
 }
 public static Tab_PlayerLevel GetPlayerLevelByID(int nKey, int nIndex)
 {
 if(g_PlayerLevel.Count==0)
 {
 InitTable_PlayerLevel();
 }
 if( g_PlayerLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PlayerLevel[nKey].Count)
 return g_PlayerLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetPlayerLevelCount()
 {
 if(g_PlayerLevel.Count==0)
 {
 InitTable_PlayerLevel();
 }
 
 return g_PlayerLevel.Count;
 }
 public static Dictionary<int, List<Tab_PlayerLevel> > GetPlayerLevel()
 {
 if(g_PlayerLevel.Count==0)
 {
 InitTable_PlayerLevel();
 }
 return g_PlayerLevel;
 }

public static List<Tab_Plot> GetPlotLine(int nKey)
 {
 if(g_Plot.Count==0)
 {
 InitTable_Plot();
 }
 if( g_Plot.ContainsKey(nKey))
 {
 return g_Plot[nKey];
 }
 return null;
 }
 public static Tab_Plot GetPlotByID(int nKey)
 {
 return GetPlotByID(nKey, 0);
 }
 public static Tab_Plot GetPlotByID(int nKey, int nIndex)
 {
 if(g_Plot.Count==0)
 {
 InitTable_Plot();
 }
 if( g_Plot.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Plot[nKey].Count)
 return g_Plot[nKey][nIndex];
 }
 return null;
 }
 public static int GetPlotCount()
 {
 if(g_Plot.Count==0)
 {
 InitTable_Plot();
 }
 
 return g_Plot.Count;
 }
 public static Dictionary<int, List<Tab_Plot> > GetPlot()
 {
 if(g_Plot.Count==0)
 {
 InitTable_Plot();
 }
 return g_Plot;
 }

public static List<Tab_PlotInteraction> GetPlotInteractionLine(int nKey)
 {
 if(g_PlotInteraction.Count==0)
 {
 InitTable_PlotInteraction();
 }
 if( g_PlotInteraction.ContainsKey(nKey))
 {
 return g_PlotInteraction[nKey];
 }
 return null;
 }
 public static Tab_PlotInteraction GetPlotInteractionByID(int nKey)
 {
 return GetPlotInteractionByID(nKey, 0);
 }
 public static Tab_PlotInteraction GetPlotInteractionByID(int nKey, int nIndex)
 {
 if(g_PlotInteraction.Count==0)
 {
 InitTable_PlotInteraction();
 }
 if( g_PlotInteraction.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PlotInteraction[nKey].Count)
 return g_PlotInteraction[nKey][nIndex];
 }
 return null;
 }
 public static int GetPlotInteractionCount()
 {
 if(g_PlotInteraction.Count==0)
 {
 InitTable_PlotInteraction();
 }
 
 return g_PlotInteraction.Count;
 }
 public static Dictionary<int, List<Tab_PlotInteraction> > GetPlotInteraction()
 {
 if(g_PlotInteraction.Count==0)
 {
 InitTable_PlotInteraction();
 }
 return g_PlotInteraction;
 }

public static List<Tab_Preloader> GetPreloaderLine(int nKey)
 {
 if(g_Preloader.Count==0)
 {
 InitTable_Preloader();
 }
 if( g_Preloader.ContainsKey(nKey))
 {
 return g_Preloader[nKey];
 }
 return null;
 }
 public static Tab_Preloader GetPreloaderByID(int nKey)
 {
 return GetPreloaderByID(nKey, 0);
 }
 public static Tab_Preloader GetPreloaderByID(int nKey, int nIndex)
 {
 if(g_Preloader.Count==0)
 {
 InitTable_Preloader();
 }
 if( g_Preloader.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Preloader[nKey].Count)
 return g_Preloader[nKey][nIndex];
 }
 return null;
 }
 public static int GetPreloaderCount()
 {
 if(g_Preloader.Count==0)
 {
 InitTable_Preloader();
 }
 
 return g_Preloader.Count;
 }
 public static Dictionary<int, List<Tab_Preloader> > GetPreloader()
 {
 if(g_Preloader.Count==0)
 {
 InitTable_Preloader();
 }
 return g_Preloader;
 }

public static List<Tab_ProductIDMap> GetProductIDMapLine(int nKey)
 {
 if(g_ProductIDMap.Count==0)
 {
 InitTable_ProductIDMap();
 }
 if( g_ProductIDMap.ContainsKey(nKey))
 {
 return g_ProductIDMap[nKey];
 }
 return null;
 }
 public static Tab_ProductIDMap GetProductIDMapByID(int nKey)
 {
 return GetProductIDMapByID(nKey, 0);
 }
 public static Tab_ProductIDMap GetProductIDMapByID(int nKey, int nIndex)
 {
 if(g_ProductIDMap.Count==0)
 {
 InitTable_ProductIDMap();
 }
 if( g_ProductIDMap.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ProductIDMap[nKey].Count)
 return g_ProductIDMap[nKey][nIndex];
 }
 return null;
 }
 public static int GetProductIDMapCount()
 {
 if(g_ProductIDMap.Count==0)
 {
 InitTable_ProductIDMap();
 }
 
 return g_ProductIDMap.Count;
 }
 public static Dictionary<int, List<Tab_ProductIDMap> > GetProductIDMap()
 {
 if(g_ProductIDMap.Count==0)
 {
 InitTable_ProductIDMap();
 }
 return g_ProductIDMap;
 }

public static List<Tab_PushNotification> GetPushNotificationLine(int nKey)
 {
 if(g_PushNotification.Count==0)
 {
 InitTable_PushNotification();
 }
 if( g_PushNotification.ContainsKey(nKey))
 {
 return g_PushNotification[nKey];
 }
 return null;
 }
 public static Tab_PushNotification GetPushNotificationByID(int nKey)
 {
 return GetPushNotificationByID(nKey, 0);
 }
 public static Tab_PushNotification GetPushNotificationByID(int nKey, int nIndex)
 {
 if(g_PushNotification.Count==0)
 {
 InitTable_PushNotification();
 }
 if( g_PushNotification.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PushNotification[nKey].Count)
 return g_PushNotification[nKey][nIndex];
 }
 return null;
 }
 public static int GetPushNotificationCount()
 {
 if(g_PushNotification.Count==0)
 {
 InitTable_PushNotification();
 }
 
 return g_PushNotification.Count;
 }
 public static Dictionary<int, List<Tab_PushNotification> > GetPushNotification()
 {
 if(g_PushNotification.Count==0)
 {
 InitTable_PushNotification();
 }
 return g_PushNotification;
 }

public static List<Tab_PuzzleLevelData> GetPuzzleLevelDataLine(int nKey)
 {
 if(g_PuzzleLevelData.Count==0)
 {
 InitTable_PuzzleLevelData();
 }
 if( g_PuzzleLevelData.ContainsKey(nKey))
 {
 return g_PuzzleLevelData[nKey];
 }
 return null;
 }
 public static Tab_PuzzleLevelData GetPuzzleLevelDataByID(int nKey)
 {
 return GetPuzzleLevelDataByID(nKey, 0);
 }
 public static Tab_PuzzleLevelData GetPuzzleLevelDataByID(int nKey, int nIndex)
 {
 if(g_PuzzleLevelData.Count==0)
 {
 InitTable_PuzzleLevelData();
 }
 if( g_PuzzleLevelData.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PuzzleLevelData[nKey].Count)
 return g_PuzzleLevelData[nKey][nIndex];
 }
 return null;
 }
 public static int GetPuzzleLevelDataCount()
 {
 if(g_PuzzleLevelData.Count==0)
 {
 InitTable_PuzzleLevelData();
 }
 
 return g_PuzzleLevelData.Count;
 }
 public static Dictionary<int, List<Tab_PuzzleLevelData> > GetPuzzleLevelData()
 {
 if(g_PuzzleLevelData.Count==0)
 {
 InitTable_PuzzleLevelData();
 }
 return g_PuzzleLevelData;
 }

public static List<Tab_PuzzleThought> GetPuzzleThoughtLine(int nKey)
 {
 if(g_PuzzleThought.Count==0)
 {
 InitTable_PuzzleThought();
 }
 if( g_PuzzleThought.ContainsKey(nKey))
 {
 return g_PuzzleThought[nKey];
 }
 return null;
 }
 public static Tab_PuzzleThought GetPuzzleThoughtByID(int nKey)
 {
 return GetPuzzleThoughtByID(nKey, 0);
 }
 public static Tab_PuzzleThought GetPuzzleThoughtByID(int nKey, int nIndex)
 {
 if(g_PuzzleThought.Count==0)
 {
 InitTable_PuzzleThought();
 }
 if( g_PuzzleThought.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PuzzleThought[nKey].Count)
 return g_PuzzleThought[nKey][nIndex];
 }
 return null;
 }
 public static int GetPuzzleThoughtCount()
 {
 if(g_PuzzleThought.Count==0)
 {
 InitTable_PuzzleThought();
 }
 
 return g_PuzzleThought.Count;
 }
 public static Dictionary<int, List<Tab_PuzzleThought> > GetPuzzleThought()
 {
 if(g_PuzzleThought.Count==0)
 {
 InitTable_PuzzleThought();
 }
 return g_PuzzleThought;
 }

public static List<Tab_PuzzleThoughtSet> GetPuzzleThoughtSetLine(int nKey)
 {
 if(g_PuzzleThoughtSet.Count==0)
 {
 InitTable_PuzzleThoughtSet();
 }
 if( g_PuzzleThoughtSet.ContainsKey(nKey))
 {
 return g_PuzzleThoughtSet[nKey];
 }
 return null;
 }
 public static Tab_PuzzleThoughtSet GetPuzzleThoughtSetByID(int nKey)
 {
 return GetPuzzleThoughtSetByID(nKey, 0);
 }
 public static Tab_PuzzleThoughtSet GetPuzzleThoughtSetByID(int nKey, int nIndex)
 {
 if(g_PuzzleThoughtSet.Count==0)
 {
 InitTable_PuzzleThoughtSet();
 }
 if( g_PuzzleThoughtSet.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_PuzzleThoughtSet[nKey].Count)
 return g_PuzzleThoughtSet[nKey][nIndex];
 }
 return null;
 }
 public static int GetPuzzleThoughtSetCount()
 {
 if(g_PuzzleThoughtSet.Count==0)
 {
 InitTable_PuzzleThoughtSet();
 }
 
 return g_PuzzleThoughtSet.Count;
 }
 public static Dictionary<int, List<Tab_PuzzleThoughtSet> > GetPuzzleThoughtSet()
 {
 if(g_PuzzleThoughtSet.Count==0)
 {
 InitTable_PuzzleThoughtSet();
 }
 return g_PuzzleThoughtSet;
 }

public static List<Tab_Question> GetQuestionLine(int nKey)
 {
 if(g_Question.Count==0)
 {
 InitTable_Question();
 }
 if( g_Question.ContainsKey(nKey))
 {
 return g_Question[nKey];
 }
 return null;
 }
 public static Tab_Question GetQuestionByID(int nKey)
 {
 return GetQuestionByID(nKey, 0);
 }
 public static Tab_Question GetQuestionByID(int nKey, int nIndex)
 {
 if(g_Question.Count==0)
 {
 InitTable_Question();
 }
 if( g_Question.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Question[nKey].Count)
 return g_Question[nKey][nIndex];
 }
 return null;
 }
 public static int GetQuestionCount()
 {
 if(g_Question.Count==0)
 {
 InitTable_Question();
 }
 
 return g_Question.Count;
 }
 public static Dictionary<int, List<Tab_Question> > GetQuestion()
 {
 if(g_Question.Count==0)
 {
 InitTable_Question();
 }
 return g_Question;
 }

public static List<Tab_RechargeGift> GetRechargeGiftLine(int nKey)
 {
 if(g_RechargeGift.Count==0)
 {
 InitTable_RechargeGift();
 }
 if( g_RechargeGift.ContainsKey(nKey))
 {
 return g_RechargeGift[nKey];
 }
 return null;
 }
 public static Tab_RechargeGift GetRechargeGiftByID(int nKey)
 {
 return GetRechargeGiftByID(nKey, 0);
 }
 public static Tab_RechargeGift GetRechargeGiftByID(int nKey, int nIndex)
 {
 if(g_RechargeGift.Count==0)
 {
 InitTable_RechargeGift();
 }
 if( g_RechargeGift.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_RechargeGift[nKey].Count)
 return g_RechargeGift[nKey][nIndex];
 }
 return null;
 }
 public static int GetRechargeGiftCount()
 {
 if(g_RechargeGift.Count==0)
 {
 InitTable_RechargeGift();
 }
 
 return g_RechargeGift.Count;
 }
 public static Dictionary<int, List<Tab_RechargeGift> > GetRechargeGift()
 {
 if(g_RechargeGift.Count==0)
 {
 InitTable_RechargeGift();
 }
 return g_RechargeGift;
 }

public static List<Tab_RechargeRule> GetRechargeRuleLine(int nKey)
 {
 if(g_RechargeRule.Count==0)
 {
 InitTable_RechargeRule();
 }
 if( g_RechargeRule.ContainsKey(nKey))
 {
 return g_RechargeRule[nKey];
 }
 return null;
 }
 public static Tab_RechargeRule GetRechargeRuleByID(int nKey)
 {
 return GetRechargeRuleByID(nKey, 0);
 }
 public static Tab_RechargeRule GetRechargeRuleByID(int nKey, int nIndex)
 {
 if(g_RechargeRule.Count==0)
 {
 InitTable_RechargeRule();
 }
 if( g_RechargeRule.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_RechargeRule[nKey].Count)
 return g_RechargeRule[nKey][nIndex];
 }
 return null;
 }
 public static int GetRechargeRuleCount()
 {
 if(g_RechargeRule.Count==0)
 {
 InitTable_RechargeRule();
 }
 
 return g_RechargeRule.Count;
 }
 public static Dictionary<int, List<Tab_RechargeRule> > GetRechargeRule()
 {
 if(g_RechargeRule.Count==0)
 {
 InitTable_RechargeRule();
 }
 return g_RechargeRule;
 }

public static List<Tab_Retrieval> GetRetrievalLine(int nKey)
 {
 if(g_Retrieval.Count==0)
 {
 InitTable_Retrieval();
 }
 if( g_Retrieval.ContainsKey(nKey))
 {
 return g_Retrieval[nKey];
 }
 return null;
 }
 public static Tab_Retrieval GetRetrievalByID(int nKey)
 {
 return GetRetrievalByID(nKey, 0);
 }
 public static Tab_Retrieval GetRetrievalByID(int nKey, int nIndex)
 {
 if(g_Retrieval.Count==0)
 {
 InitTable_Retrieval();
 }
 if( g_Retrieval.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Retrieval[nKey].Count)
 return g_Retrieval[nKey][nIndex];
 }
 return null;
 }
 public static int GetRetrievalCount()
 {
 if(g_Retrieval.Count==0)
 {
 InitTable_Retrieval();
 }
 
 return g_Retrieval.Count;
 }
 public static Dictionary<int, List<Tab_Retrieval> > GetRetrieval()
 {
 if(g_Retrieval.Count==0)
 {
 InitTable_Retrieval();
 }
 return g_Retrieval;
 }

public static List<Tab_RewardPreview> GetRewardPreviewLine(int nKey)
 {
 if(g_RewardPreview.Count==0)
 {
 InitTable_RewardPreview();
 }
 if( g_RewardPreview.ContainsKey(nKey))
 {
 return g_RewardPreview[nKey];
 }
 return null;
 }
 public static Tab_RewardPreview GetRewardPreviewByID(int nKey)
 {
 return GetRewardPreviewByID(nKey, 0);
 }
 public static Tab_RewardPreview GetRewardPreviewByID(int nKey, int nIndex)
 {
 if(g_RewardPreview.Count==0)
 {
 InitTable_RewardPreview();
 }
 if( g_RewardPreview.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_RewardPreview[nKey].Count)
 return g_RewardPreview[nKey][nIndex];
 }
 return null;
 }
 public static int GetRewardPreviewCount()
 {
 if(g_RewardPreview.Count==0)
 {
 InitTable_RewardPreview();
 }
 
 return g_RewardPreview.Count;
 }
 public static Dictionary<int, List<Tab_RewardPreview> > GetRewardPreview()
 {
 if(g_RewardPreview.Count==0)
 {
 InitTable_RewardPreview();
 }
 return g_RewardPreview;
 }

public static List<Tab_Role> GetRoleLine(int nKey)
 {
 if(g_Role.Count==0)
 {
 InitTable_Role();
 }
 if( g_Role.ContainsKey(nKey))
 {
 return g_Role[nKey];
 }
 return null;
 }
 public static Tab_Role GetRoleByID(int nKey)
 {
 return GetRoleByID(nKey, 0);
 }
 public static Tab_Role GetRoleByID(int nKey, int nIndex)
 {
 if(g_Role.Count==0)
 {
 InitTable_Role();
 }
 if( g_Role.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Role[nKey].Count)
 return g_Role[nKey][nIndex];
 }
 return null;
 }
 public static int GetRoleCount()
 {
 if(g_Role.Count==0)
 {
 InitTable_Role();
 }
 
 return g_Role.Count;
 }
 public static Dictionary<int, List<Tab_Role> > GetRole()
 {
 if(g_Role.Count==0)
 {
 InitTable_Role();
 }
 return g_Role;
 }

public static List<Tab_Rumor> GetRumorLine(int nKey)
 {
 if(g_Rumor.Count==0)
 {
 InitTable_Rumor();
 }
 if( g_Rumor.ContainsKey(nKey))
 {
 return g_Rumor[nKey];
 }
 return null;
 }
 public static Tab_Rumor GetRumorByID(int nKey)
 {
 return GetRumorByID(nKey, 0);
 }
 public static Tab_Rumor GetRumorByID(int nKey, int nIndex)
 {
 if(g_Rumor.Count==0)
 {
 InitTable_Rumor();
 }
 if( g_Rumor.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Rumor[nKey].Count)
 return g_Rumor[nKey][nIndex];
 }
 return null;
 }
 public static int GetRumorCount()
 {
 if(g_Rumor.Count==0)
 {
 InitTable_Rumor();
 }
 
 return g_Rumor.Count;
 }
 public static Dictionary<int, List<Tab_Rumor> > GetRumor()
 {
 if(g_Rumor.Count==0)
 {
 InitTable_Rumor();
 }
 return g_Rumor;
 }

public static List<Tab_RumorRewardRule> GetRumorRewardRuleLine(int nKey)
 {
 if(g_RumorRewardRule.Count==0)
 {
 InitTable_RumorRewardRule();
 }
 if( g_RumorRewardRule.ContainsKey(nKey))
 {
 return g_RumorRewardRule[nKey];
 }
 return null;
 }
 public static Tab_RumorRewardRule GetRumorRewardRuleByID(int nKey)
 {
 return GetRumorRewardRuleByID(nKey, 0);
 }
 public static Tab_RumorRewardRule GetRumorRewardRuleByID(int nKey, int nIndex)
 {
 if(g_RumorRewardRule.Count==0)
 {
 InitTable_RumorRewardRule();
 }
 if( g_RumorRewardRule.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_RumorRewardRule[nKey].Count)
 return g_RumorRewardRule[nKey][nIndex];
 }
 return null;
 }
 public static int GetRumorRewardRuleCount()
 {
 if(g_RumorRewardRule.Count==0)
 {
 InitTable_RumorRewardRule();
 }
 
 return g_RumorRewardRule.Count;
 }
 public static Dictionary<int, List<Tab_RumorRewardRule> > GetRumorRewardRule()
 {
 if(g_RumorRewardRule.Count==0)
 {
 InitTable_RumorRewardRule();
 }
 return g_RumorRewardRule;
 }

public static List<Tab_RumorSub> GetRumorSubLine(int nKey)
 {
 if(g_RumorSub.Count==0)
 {
 InitTable_RumorSub();
 }
 if( g_RumorSub.ContainsKey(nKey))
 {
 return g_RumorSub[nKey];
 }
 return null;
 }
 public static Tab_RumorSub GetRumorSubByID(int nKey)
 {
 return GetRumorSubByID(nKey, 0);
 }
 public static Tab_RumorSub GetRumorSubByID(int nKey, int nIndex)
 {
 if(g_RumorSub.Count==0)
 {
 InitTable_RumorSub();
 }
 if( g_RumorSub.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_RumorSub[nKey].Count)
 return g_RumorSub[nKey][nIndex];
 }
 return null;
 }
 public static int GetRumorSubCount()
 {
 if(g_RumorSub.Count==0)
 {
 InitTable_RumorSub();
 }
 
 return g_RumorSub.Count;
 }
 public static Dictionary<int, List<Tab_RumorSub> > GetRumorSub()
 {
 if(g_RumorSub.Count==0)
 {
 InitTable_RumorSub();
 }
 return g_RumorSub;
 }

public static List<Tab_RumorSubSet> GetRumorSubSetLine(int nKey)
 {
 if(g_RumorSubSet.Count==0)
 {
 InitTable_RumorSubSet();
 }
 if( g_RumorSubSet.ContainsKey(nKey))
 {
 return g_RumorSubSet[nKey];
 }
 return null;
 }
 public static Tab_RumorSubSet GetRumorSubSetByID(int nKey)
 {
 return GetRumorSubSetByID(nKey, 0);
 }
 public static Tab_RumorSubSet GetRumorSubSetByID(int nKey, int nIndex)
 {
 if(g_RumorSubSet.Count==0)
 {
 InitTable_RumorSubSet();
 }
 if( g_RumorSubSet.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_RumorSubSet[nKey].Count)
 return g_RumorSubSet[nKey][nIndex];
 }
 return null;
 }
 public static int GetRumorSubSetCount()
 {
 if(g_RumorSubSet.Count==0)
 {
 InitTable_RumorSubSet();
 }
 
 return g_RumorSubSet.Count;
 }
 public static Dictionary<int, List<Tab_RumorSubSet> > GetRumorSubSet()
 {
 if(g_RumorSubSet.Count==0)
 {
 InitTable_RumorSubSet();
 }
 return g_RumorSubSet;
 }

public static List<Tab_SavePoint> GetSavePointLine(int nKey)
 {
 if(g_SavePoint.Count==0)
 {
 InitTable_SavePoint();
 }
 if( g_SavePoint.ContainsKey(nKey))
 {
 return g_SavePoint[nKey];
 }
 return null;
 }
 public static Tab_SavePoint GetSavePointByID(int nKey)
 {
 return GetSavePointByID(nKey, 0);
 }
 public static Tab_SavePoint GetSavePointByID(int nKey, int nIndex)
 {
 if(g_SavePoint.Count==0)
 {
 InitTable_SavePoint();
 }
 if( g_SavePoint.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SavePoint[nKey].Count)
 return g_SavePoint[nKey][nIndex];
 }
 return null;
 }
 public static int GetSavePointCount()
 {
 if(g_SavePoint.Count==0)
 {
 InitTable_SavePoint();
 }
 
 return g_SavePoint.Count;
 }
 public static Dictionary<int, List<Tab_SavePoint> > GetSavePoint()
 {
 if(g_SavePoint.Count==0)
 {
 InitTable_SavePoint();
 }
 return g_SavePoint;
 }

public static List<Tab_SceneClass> GetSceneClassLine(int nKey)
 {
 if(g_SceneClass.Count==0)
 {
 InitTable_SceneClass();
 }
 if( g_SceneClass.ContainsKey(nKey))
 {
 return g_SceneClass[nKey];
 }
 return null;
 }
 public static Tab_SceneClass GetSceneClassByID(int nKey)
 {
 return GetSceneClassByID(nKey, 0);
 }
 public static Tab_SceneClass GetSceneClassByID(int nKey, int nIndex)
 {
 if(g_SceneClass.Count==0)
 {
 InitTable_SceneClass();
 }
 if( g_SceneClass.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneClass[nKey].Count)
 return g_SceneClass[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneClassCount()
 {
 if(g_SceneClass.Count==0)
 {
 InitTable_SceneClass();
 }
 
 return g_SceneClass.Count;
 }
 public static Dictionary<int, List<Tab_SceneClass> > GetSceneClass()
 {
 if(g_SceneClass.Count==0)
 {
 InitTable_SceneClass();
 }
 return g_SceneClass;
 }

public static List<Tab_SceneClassRandomEntry> GetSceneClassRandomEntryLine(int nKey)
 {
 if(g_SceneClassRandomEntry.Count==0)
 {
 InitTable_SceneClassRandomEntry();
 }
 if( g_SceneClassRandomEntry.ContainsKey(nKey))
 {
 return g_SceneClassRandomEntry[nKey];
 }
 return null;
 }
 public static Tab_SceneClassRandomEntry GetSceneClassRandomEntryByID(int nKey)
 {
 return GetSceneClassRandomEntryByID(nKey, 0);
 }
 public static Tab_SceneClassRandomEntry GetSceneClassRandomEntryByID(int nKey, int nIndex)
 {
 if(g_SceneClassRandomEntry.Count==0)
 {
 InitTable_SceneClassRandomEntry();
 }
 if( g_SceneClassRandomEntry.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneClassRandomEntry[nKey].Count)
 return g_SceneClassRandomEntry[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneClassRandomEntryCount()
 {
 if(g_SceneClassRandomEntry.Count==0)
 {
 InitTable_SceneClassRandomEntry();
 }
 
 return g_SceneClassRandomEntry.Count;
 }
 public static Dictionary<int, List<Tab_SceneClassRandomEntry> > GetSceneClassRandomEntry()
 {
 if(g_SceneClassRandomEntry.Count==0)
 {
 InitTable_SceneClassRandomEntry();
 }
 return g_SceneClassRandomEntry;
 }

public static List<Tab_SceneEventCategory> GetSceneEventCategoryLine(int nKey)
 {
 if(g_SceneEventCategory.Count==0)
 {
 InitTable_SceneEventCategory();
 }
 if( g_SceneEventCategory.ContainsKey(nKey))
 {
 return g_SceneEventCategory[nKey];
 }
 return null;
 }
 public static Tab_SceneEventCategory GetSceneEventCategoryByID(int nKey)
 {
 return GetSceneEventCategoryByID(nKey, 0);
 }
 public static Tab_SceneEventCategory GetSceneEventCategoryByID(int nKey, int nIndex)
 {
 if(g_SceneEventCategory.Count==0)
 {
 InitTable_SceneEventCategory();
 }
 if( g_SceneEventCategory.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneEventCategory[nKey].Count)
 return g_SceneEventCategory[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneEventCategoryCount()
 {
 if(g_SceneEventCategory.Count==0)
 {
 InitTable_SceneEventCategory();
 }
 
 return g_SceneEventCategory.Count;
 }
 public static Dictionary<int, List<Tab_SceneEventCategory> > GetSceneEventCategory()
 {
 if(g_SceneEventCategory.Count==0)
 {
 InitTable_SceneEventCategory();
 }
 return g_SceneEventCategory;
 }

public static List<Tab_SceneEventDesc> GetSceneEventDescLine(int nKey)
 {
 if(g_SceneEventDesc.Count==0)
 {
 InitTable_SceneEventDesc();
 }
 if( g_SceneEventDesc.ContainsKey(nKey))
 {
 return g_SceneEventDesc[nKey];
 }
 return null;
 }
 public static Tab_SceneEventDesc GetSceneEventDescByID(int nKey)
 {
 return GetSceneEventDescByID(nKey, 0);
 }
 public static Tab_SceneEventDesc GetSceneEventDescByID(int nKey, int nIndex)
 {
 if(g_SceneEventDesc.Count==0)
 {
 InitTable_SceneEventDesc();
 }
 if( g_SceneEventDesc.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneEventDesc[nKey].Count)
 return g_SceneEventDesc[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneEventDescCount()
 {
 if(g_SceneEventDesc.Count==0)
 {
 InitTable_SceneEventDesc();
 }
 
 return g_SceneEventDesc.Count;
 }
 public static Dictionary<int, List<Tab_SceneEventDesc> > GetSceneEventDesc()
 {
 if(g_SceneEventDesc.Count==0)
 {
 InitTable_SceneEventDesc();
 }
 return g_SceneEventDesc;
 }

public static List<Tab_SceneNode> GetSceneNodeLine(int nKey)
 {
 if(g_SceneNode.Count==0)
 {
 InitTable_SceneNode();
 }
 if( g_SceneNode.ContainsKey(nKey))
 {
 return g_SceneNode[nKey];
 }
 return null;
 }
 public static Tab_SceneNode GetSceneNodeByID(int nKey)
 {
 return GetSceneNodeByID(nKey, 0);
 }
 public static Tab_SceneNode GetSceneNodeByID(int nKey, int nIndex)
 {
 if(g_SceneNode.Count==0)
 {
 InitTable_SceneNode();
 }
 if( g_SceneNode.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneNode[nKey].Count)
 return g_SceneNode[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneNodeCount()
 {
 if(g_SceneNode.Count==0)
 {
 InitTable_SceneNode();
 }
 
 return g_SceneNode.Count;
 }
 public static Dictionary<int, List<Tab_SceneNode> > GetSceneNode()
 {
 if(g_SceneNode.Count==0)
 {
 InitTable_SceneNode();
 }
 return g_SceneNode;
 }

public static List<Tab_SceneNpc> GetSceneNpcLine(int nKey)
 {
 if(g_SceneNpc.Count==0)
 {
 InitTable_SceneNpc();
 }
 if( g_SceneNpc.ContainsKey(nKey))
 {
 return g_SceneNpc[nKey];
 }
 return null;
 }
 public static Tab_SceneNpc GetSceneNpcByID(int nKey)
 {
 return GetSceneNpcByID(nKey, 0);
 }
 public static Tab_SceneNpc GetSceneNpcByID(int nKey, int nIndex)
 {
 if(g_SceneNpc.Count==0)
 {
 InitTable_SceneNpc();
 }
 if( g_SceneNpc.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneNpc[nKey].Count)
 return g_SceneNpc[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneNpcCount()
 {
 if(g_SceneNpc.Count==0)
 {
 InitTable_SceneNpc();
 }
 
 return g_SceneNpc.Count;
 }
 public static Dictionary<int, List<Tab_SceneNpc> > GetSceneNpc()
 {
 if(g_SceneNpc.Count==0)
 {
 InitTable_SceneNpc();
 }
 return g_SceneNpc;
 }

public static List<Tab_SceneNpcCreateRule> GetSceneNpcCreateRuleLine(int nKey)
 {
 if(g_SceneNpcCreateRule.Count==0)
 {
 InitTable_SceneNpcCreateRule();
 }
 if( g_SceneNpcCreateRule.ContainsKey(nKey))
 {
 return g_SceneNpcCreateRule[nKey];
 }
 return null;
 }
 public static Tab_SceneNpcCreateRule GetSceneNpcCreateRuleByID(int nKey)
 {
 return GetSceneNpcCreateRuleByID(nKey, 0);
 }
 public static Tab_SceneNpcCreateRule GetSceneNpcCreateRuleByID(int nKey, int nIndex)
 {
 if(g_SceneNpcCreateRule.Count==0)
 {
 InitTable_SceneNpcCreateRule();
 }
 if( g_SceneNpcCreateRule.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneNpcCreateRule[nKey].Count)
 return g_SceneNpcCreateRule[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneNpcCreateRuleCount()
 {
 if(g_SceneNpcCreateRule.Count==0)
 {
 InitTable_SceneNpcCreateRule();
 }
 
 return g_SceneNpcCreateRule.Count;
 }
 public static Dictionary<int, List<Tab_SceneNpcCreateRule> > GetSceneNpcCreateRule()
 {
 if(g_SceneNpcCreateRule.Count==0)
 {
 InitTable_SceneNpcCreateRule();
 }
 return g_SceneNpcCreateRule;
 }

public static List<Tab_SceneNpcReplace> GetSceneNpcReplaceLine(int nKey)
 {
 if(g_SceneNpcReplace.Count==0)
 {
 InitTable_SceneNpcReplace();
 }
 if( g_SceneNpcReplace.ContainsKey(nKey))
 {
 return g_SceneNpcReplace[nKey];
 }
 return null;
 }
 public static Tab_SceneNpcReplace GetSceneNpcReplaceByID(int nKey)
 {
 return GetSceneNpcReplaceByID(nKey, 0);
 }
 public static Tab_SceneNpcReplace GetSceneNpcReplaceByID(int nKey, int nIndex)
 {
 if(g_SceneNpcReplace.Count==0)
 {
 InitTable_SceneNpcReplace();
 }
 if( g_SceneNpcReplace.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneNpcReplace[nKey].Count)
 return g_SceneNpcReplace[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneNpcReplaceCount()
 {
 if(g_SceneNpcReplace.Count==0)
 {
 InitTable_SceneNpcReplace();
 }
 
 return g_SceneNpcReplace.Count;
 }
 public static Dictionary<int, List<Tab_SceneNpcReplace> > GetSceneNpcReplace()
 {
 if(g_SceneNpcReplace.Count==0)
 {
 InitTable_SceneNpcReplace();
 }
 return g_SceneNpcReplace;
 }

public static List<Tab_SceneObject> GetSceneObjectLine(int nKey)
 {
 if(g_SceneObject.Count==0)
 {
 InitTable_SceneObject();
 }
 if( g_SceneObject.ContainsKey(nKey))
 {
 return g_SceneObject[nKey];
 }
 return null;
 }
 public static Tab_SceneObject GetSceneObjectByID(int nKey)
 {
 return GetSceneObjectByID(nKey, 0);
 }
 public static Tab_SceneObject GetSceneObjectByID(int nKey, int nIndex)
 {
 if(g_SceneObject.Count==0)
 {
 InitTable_SceneObject();
 }
 if( g_SceneObject.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneObject[nKey].Count)
 return g_SceneObject[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneObjectCount()
 {
 if(g_SceneObject.Count==0)
 {
 InitTable_SceneObject();
 }
 
 return g_SceneObject.Count;
 }
 public static Dictionary<int, List<Tab_SceneObject> > GetSceneObject()
 {
 if(g_SceneObject.Count==0)
 {
 InitTable_SceneObject();
 }
 return g_SceneObject;
 }

public static List<Tab_SceneTimeChange> GetSceneTimeChangeLine(int nKey)
 {
 if(g_SceneTimeChange.Count==0)
 {
 InitTable_SceneTimeChange();
 }
 if( g_SceneTimeChange.ContainsKey(nKey))
 {
 return g_SceneTimeChange[nKey];
 }
 return null;
 }
 public static Tab_SceneTimeChange GetSceneTimeChangeByID(int nKey)
 {
 return GetSceneTimeChangeByID(nKey, 0);
 }
 public static Tab_SceneTimeChange GetSceneTimeChangeByID(int nKey, int nIndex)
 {
 if(g_SceneTimeChange.Count==0)
 {
 InitTable_SceneTimeChange();
 }
 if( g_SceneTimeChange.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SceneTimeChange[nKey].Count)
 return g_SceneTimeChange[nKey][nIndex];
 }
 return null;
 }
 public static int GetSceneTimeChangeCount()
 {
 if(g_SceneTimeChange.Count==0)
 {
 InitTable_SceneTimeChange();
 }
 
 return g_SceneTimeChange.Count;
 }
 public static Dictionary<int, List<Tab_SceneTimeChange> > GetSceneTimeChange()
 {
 if(g_SceneTimeChange.Count==0)
 {
 InitTable_SceneTimeChange();
 }
 return g_SceneTimeChange;
 }

public static List<Tab_ScreenFade> GetScreenFadeLine(int nKey)
 {
 if(g_ScreenFade.Count==0)
 {
 InitTable_ScreenFade();
 }
 if( g_ScreenFade.ContainsKey(nKey))
 {
 return g_ScreenFade[nKey];
 }
 return null;
 }
 public static Tab_ScreenFade GetScreenFadeByID(int nKey)
 {
 return GetScreenFadeByID(nKey, 0);
 }
 public static Tab_ScreenFade GetScreenFadeByID(int nKey, int nIndex)
 {
 if(g_ScreenFade.Count==0)
 {
 InitTable_ScreenFade();
 }
 if( g_ScreenFade.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ScreenFade[nKey].Count)
 return g_ScreenFade[nKey][nIndex];
 }
 return null;
 }
 public static int GetScreenFadeCount()
 {
 if(g_ScreenFade.Count==0)
 {
 InitTable_ScreenFade();
 }
 
 return g_ScreenFade.Count;
 }
 public static Dictionary<int, List<Tab_ScreenFade> > GetScreenFade()
 {
 if(g_ScreenFade.Count==0)
 {
 InitTable_ScreenFade();
 }
 return g_ScreenFade;
 }

public static List<Tab_Secret> GetSecretLine(int nKey)
 {
 if(g_Secret.Count==0)
 {
 InitTable_Secret();
 }
 if( g_Secret.ContainsKey(nKey))
 {
 return g_Secret[nKey];
 }
 return null;
 }
 public static Tab_Secret GetSecretByID(int nKey)
 {
 return GetSecretByID(nKey, 0);
 }
 public static Tab_Secret GetSecretByID(int nKey, int nIndex)
 {
 if(g_Secret.Count==0)
 {
 InitTable_Secret();
 }
 if( g_Secret.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Secret[nKey].Count)
 return g_Secret[nKey][nIndex];
 }
 return null;
 }
 public static int GetSecretCount()
 {
 if(g_Secret.Count==0)
 {
 InitTable_Secret();
 }
 
 return g_Secret.Count;
 }
 public static Dictionary<int, List<Tab_Secret> > GetSecret()
 {
 if(g_Secret.Count==0)
 {
 InitTable_Secret();
 }
 return g_Secret;
 }

public static List<Tab_SecretDesc> GetSecretDescLine(int nKey)
 {
 if(g_SecretDesc.Count==0)
 {
 InitTable_SecretDesc();
 }
 if( g_SecretDesc.ContainsKey(nKey))
 {
 return g_SecretDesc[nKey];
 }
 return null;
 }
 public static Tab_SecretDesc GetSecretDescByID(int nKey)
 {
 return GetSecretDescByID(nKey, 0);
 }
 public static Tab_SecretDesc GetSecretDescByID(int nKey, int nIndex)
 {
 if(g_SecretDesc.Count==0)
 {
 InitTable_SecretDesc();
 }
 if( g_SecretDesc.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SecretDesc[nKey].Count)
 return g_SecretDesc[nKey][nIndex];
 }
 return null;
 }
 public static int GetSecretDescCount()
 {
 if(g_SecretDesc.Count==0)
 {
 InitTable_SecretDesc();
 }
 
 return g_SecretDesc.Count;
 }
 public static Dictionary<int, List<Tab_SecretDesc> > GetSecretDesc()
 {
 if(g_SecretDesc.Count==0)
 {
 InitTable_SecretDesc();
 }
 return g_SecretDesc;
 }

public static List<Tab_SecretKeyword> GetSecretKeywordLine(int nKey)
 {
 if(g_SecretKeyword.Count==0)
 {
 InitTable_SecretKeyword();
 }
 if( g_SecretKeyword.ContainsKey(nKey))
 {
 return g_SecretKeyword[nKey];
 }
 return null;
 }
 public static Tab_SecretKeyword GetSecretKeywordByID(int nKey)
 {
 return GetSecretKeywordByID(nKey, 0);
 }
 public static Tab_SecretKeyword GetSecretKeywordByID(int nKey, int nIndex)
 {
 if(g_SecretKeyword.Count==0)
 {
 InitTable_SecretKeyword();
 }
 if( g_SecretKeyword.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SecretKeyword[nKey].Count)
 return g_SecretKeyword[nKey][nIndex];
 }
 return null;
 }
 public static int GetSecretKeywordCount()
 {
 if(g_SecretKeyword.Count==0)
 {
 InitTable_SecretKeyword();
 }
 
 return g_SecretKeyword.Count;
 }
 public static Dictionary<int, List<Tab_SecretKeyword> > GetSecretKeyword()
 {
 if(g_SecretKeyword.Count==0)
 {
 InitTable_SecretKeyword();
 }
 return g_SecretKeyword;
 }

public static List<Tab_Selection> GetSelectionLine(int nKey)
 {
 if(g_Selection.Count==0)
 {
 InitTable_Selection();
 }
 if( g_Selection.ContainsKey(nKey))
 {
 return g_Selection[nKey];
 }
 return null;
 }
 public static Tab_Selection GetSelectionByID(int nKey)
 {
 return GetSelectionByID(nKey, 0);
 }
 public static Tab_Selection GetSelectionByID(int nKey, int nIndex)
 {
 if(g_Selection.Count==0)
 {
 InitTable_Selection();
 }
 if( g_Selection.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Selection[nKey].Count)
 return g_Selection[nKey][nIndex];
 }
 return null;
 }
 public static int GetSelectionCount()
 {
 if(g_Selection.Count==0)
 {
 InitTable_Selection();
 }
 
 return g_Selection.Count;
 }
 public static Dictionary<int, List<Tab_Selection> > GetSelection()
 {
 if(g_Selection.Count==0)
 {
 InitTable_Selection();
 }
 return g_Selection;
 }

public static List<Tab_ServerList> GetServerListLine(int nKey)
 {
 if(g_ServerList.Count==0)
 {
 InitTable_ServerList();
 }
 if( g_ServerList.ContainsKey(nKey))
 {
 return g_ServerList[nKey];
 }
 return null;
 }
 public static Tab_ServerList GetServerListByID(int nKey)
 {
 return GetServerListByID(nKey, 0);
 }
 public static Tab_ServerList GetServerListByID(int nKey, int nIndex)
 {
 if(g_ServerList.Count==0)
 {
 InitTable_ServerList();
 }
 if( g_ServerList.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ServerList[nKey].Count)
 return g_ServerList[nKey][nIndex];
 }
 return null;
 }
 public static int GetServerListCount()
 {
 if(g_ServerList.Count==0)
 {
 InitTable_ServerList();
 }
 
 return g_ServerList.Count;
 }
 public static Dictionary<int, List<Tab_ServerList> > GetServerList()
 {
 if(g_ServerList.Count==0)
 {
 InitTable_ServerList();
 }
 return g_ServerList;
 }

public static List<Tab_ShopCommon> GetShopCommonLine(int nKey)
 {
 if(g_ShopCommon.Count==0)
 {
 InitTable_ShopCommon();
 }
 if( g_ShopCommon.ContainsKey(nKey))
 {
 return g_ShopCommon[nKey];
 }
 return null;
 }
 public static Tab_ShopCommon GetShopCommonByID(int nKey)
 {
 return GetShopCommonByID(nKey, 0);
 }
 public static Tab_ShopCommon GetShopCommonByID(int nKey, int nIndex)
 {
 if(g_ShopCommon.Count==0)
 {
 InitTable_ShopCommon();
 }
 if( g_ShopCommon.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ShopCommon[nKey].Count)
 return g_ShopCommon[nKey][nIndex];
 }
 return null;
 }
 public static int GetShopCommonCount()
 {
 if(g_ShopCommon.Count==0)
 {
 InitTable_ShopCommon();
 }
 
 return g_ShopCommon.Count;
 }
 public static Dictionary<int, List<Tab_ShopCommon> > GetShopCommon()
 {
 if(g_ShopCommon.Count==0)
 {
 InitTable_ShopCommon();
 }
 return g_ShopCommon;
 }

public static List<Tab_ShopDiamond> GetShopDiamondLine(int nKey)
 {
 if(g_ShopDiamond.Count==0)
 {
 InitTable_ShopDiamond();
 }
 if( g_ShopDiamond.ContainsKey(nKey))
 {
 return g_ShopDiamond[nKey];
 }
 return null;
 }
 public static Tab_ShopDiamond GetShopDiamondByID(int nKey)
 {
 return GetShopDiamondByID(nKey, 0);
 }
 public static Tab_ShopDiamond GetShopDiamondByID(int nKey, int nIndex)
 {
 if(g_ShopDiamond.Count==0)
 {
 InitTable_ShopDiamond();
 }
 if( g_ShopDiamond.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ShopDiamond[nKey].Count)
 return g_ShopDiamond[nKey][nIndex];
 }
 return null;
 }
 public static int GetShopDiamondCount()
 {
 if(g_ShopDiamond.Count==0)
 {
 InitTable_ShopDiamond();
 }
 
 return g_ShopDiamond.Count;
 }
 public static Dictionary<int, List<Tab_ShopDiamond> > GetShopDiamond()
 {
 if(g_ShopDiamond.Count==0)
 {
 InitTable_ShopDiamond();
 }
 return g_ShopDiamond;
 }

public static List<Tab_ShopGiftItem> GetShopGiftItemLine(int nKey)
 {
 if(g_ShopGiftItem.Count==0)
 {
 InitTable_ShopGiftItem();
 }
 if( g_ShopGiftItem.ContainsKey(nKey))
 {
 return g_ShopGiftItem[nKey];
 }
 return null;
 }
 public static Tab_ShopGiftItem GetShopGiftItemByID(int nKey)
 {
 return GetShopGiftItemByID(nKey, 0);
 }
 public static Tab_ShopGiftItem GetShopGiftItemByID(int nKey, int nIndex)
 {
 if(g_ShopGiftItem.Count==0)
 {
 InitTable_ShopGiftItem();
 }
 if( g_ShopGiftItem.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ShopGiftItem[nKey].Count)
 return g_ShopGiftItem[nKey][nIndex];
 }
 return null;
 }
 public static int GetShopGiftItemCount()
 {
 if(g_ShopGiftItem.Count==0)
 {
 InitTable_ShopGiftItem();
 }
 
 return g_ShopGiftItem.Count;
 }
 public static Dictionary<int, List<Tab_ShopGiftItem> > GetShopGiftItem()
 {
 if(g_ShopGiftItem.Count==0)
 {
 InitTable_ShopGiftItem();
 }
 return g_ShopGiftItem;
 }

public static List<Tab_ShopType> GetShopTypeLine(int nKey)
 {
 if(g_ShopType.Count==0)
 {
 InitTable_ShopType();
 }
 if( g_ShopType.ContainsKey(nKey))
 {
 return g_ShopType[nKey];
 }
 return null;
 }
 public static Tab_ShopType GetShopTypeByID(int nKey)
 {
 return GetShopTypeByID(nKey, 0);
 }
 public static Tab_ShopType GetShopTypeByID(int nKey, int nIndex)
 {
 if(g_ShopType.Count==0)
 {
 InitTable_ShopType();
 }
 if( g_ShopType.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ShopType[nKey].Count)
 return g_ShopType[nKey][nIndex];
 }
 return null;
 }
 public static int GetShopTypeCount()
 {
 if(g_ShopType.Count==0)
 {
 InitTable_ShopType();
 }
 
 return g_ShopType.Count;
 }
 public static Dictionary<int, List<Tab_ShopType> > GetShopType()
 {
 if(g_ShopType.Count==0)
 {
 InitTable_ShopType();
 }
 return g_ShopType;
 }

public static List<Tab_ShopTypeDialog> GetShopTypeDialogLine(int nKey)
 {
 if(g_ShopTypeDialog.Count==0)
 {
 InitTable_ShopTypeDialog();
 }
 if( g_ShopTypeDialog.ContainsKey(nKey))
 {
 return g_ShopTypeDialog[nKey];
 }
 return null;
 }
 public static Tab_ShopTypeDialog GetShopTypeDialogByID(int nKey)
 {
 return GetShopTypeDialogByID(nKey, 0);
 }
 public static Tab_ShopTypeDialog GetShopTypeDialogByID(int nKey, int nIndex)
 {
 if(g_ShopTypeDialog.Count==0)
 {
 InitTable_ShopTypeDialog();
 }
 if( g_ShopTypeDialog.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_ShopTypeDialog[nKey].Count)
 return g_ShopTypeDialog[nKey][nIndex];
 }
 return null;
 }
 public static int GetShopTypeDialogCount()
 {
 if(g_ShopTypeDialog.Count==0)
 {
 InitTable_ShopTypeDialog();
 }
 
 return g_ShopTypeDialog.Count;
 }
 public static Dictionary<int, List<Tab_ShopTypeDialog> > GetShopTypeDialog()
 {
 if(g_ShopTypeDialog.Count==0)
 {
 InitTable_ShopTypeDialog();
 }
 return g_ShopTypeDialog;
 }

public static List<Tab_Signboard> GetSignboardLine(int nKey)
 {
 if(g_Signboard.Count==0)
 {
 InitTable_Signboard();
 }
 if( g_Signboard.ContainsKey(nKey))
 {
 return g_Signboard[nKey];
 }
 return null;
 }
 public static Tab_Signboard GetSignboardByID(int nKey)
 {
 return GetSignboardByID(nKey, 0);
 }
 public static Tab_Signboard GetSignboardByID(int nKey, int nIndex)
 {
 if(g_Signboard.Count==0)
 {
 InitTable_Signboard();
 }
 if( g_Signboard.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Signboard[nKey].Count)
 return g_Signboard[nKey][nIndex];
 }
 return null;
 }
 public static int GetSignboardCount()
 {
 if(g_Signboard.Count==0)
 {
 InitTable_Signboard();
 }
 
 return g_Signboard.Count;
 }
 public static Dictionary<int, List<Tab_Signboard> > GetSignboard()
 {
 if(g_Signboard.Count==0)
 {
 InitTable_Signboard();
 }
 return g_Signboard;
 }

public static List<Tab_SignboardDecals> GetSignboardDecalsLine(int nKey)
 {
 if(g_SignboardDecals.Count==0)
 {
 InitTable_SignboardDecals();
 }
 if( g_SignboardDecals.ContainsKey(nKey))
 {
 return g_SignboardDecals[nKey];
 }
 return null;
 }
 public static Tab_SignboardDecals GetSignboardDecalsByID(int nKey)
 {
 return GetSignboardDecalsByID(nKey, 0);
 }
 public static Tab_SignboardDecals GetSignboardDecalsByID(int nKey, int nIndex)
 {
 if(g_SignboardDecals.Count==0)
 {
 InitTable_SignboardDecals();
 }
 if( g_SignboardDecals.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SignboardDecals[nKey].Count)
 return g_SignboardDecals[nKey][nIndex];
 }
 return null;
 }
 public static int GetSignboardDecalsCount()
 {
 if(g_SignboardDecals.Count==0)
 {
 InitTable_SignboardDecals();
 }
 
 return g_SignboardDecals.Count;
 }
 public static Dictionary<int, List<Tab_SignboardDecals> > GetSignboardDecals()
 {
 if(g_SignboardDecals.Count==0)
 {
 InitTable_SignboardDecals();
 }
 return g_SignboardDecals;
 }

public static List<Tab_SignboardTheme> GetSignboardThemeLine(int nKey)
 {
 if(g_SignboardTheme.Count==0)
 {
 InitTable_SignboardTheme();
 }
 if( g_SignboardTheme.ContainsKey(nKey))
 {
 return g_SignboardTheme[nKey];
 }
 return null;
 }
 public static Tab_SignboardTheme GetSignboardThemeByID(int nKey)
 {
 return GetSignboardThemeByID(nKey, 0);
 }
 public static Tab_SignboardTheme GetSignboardThemeByID(int nKey, int nIndex)
 {
 if(g_SignboardTheme.Count==0)
 {
 InitTable_SignboardTheme();
 }
 if( g_SignboardTheme.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SignboardTheme[nKey].Count)
 return g_SignboardTheme[nKey][nIndex];
 }
 return null;
 }
 public static int GetSignboardThemeCount()
 {
 if(g_SignboardTheme.Count==0)
 {
 InitTable_SignboardTheme();
 }
 
 return g_SignboardTheme.Count;
 }
 public static Dictionary<int, List<Tab_SignboardTheme> > GetSignboardTheme()
 {
 if(g_SignboardTheme.Count==0)
 {
 InitTable_SignboardTheme();
 }
 return g_SignboardTheme;
 }

public static List<Tab_Skill> GetSkillLine(int nKey)
 {
 if(g_Skill.Count==0)
 {
 InitTable_Skill();
 }
 if( g_Skill.ContainsKey(nKey))
 {
 return g_Skill[nKey];
 }
 return null;
 }
 public static Tab_Skill GetSkillByID(int nKey)
 {
 return GetSkillByID(nKey, 0);
 }
 public static Tab_Skill GetSkillByID(int nKey, int nIndex)
 {
 if(g_Skill.Count==0)
 {
 InitTable_Skill();
 }
 if( g_Skill.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Skill[nKey].Count)
 return g_Skill[nKey][nIndex];
 }
 return null;
 }
 public static int GetSkillCount()
 {
 if(g_Skill.Count==0)
 {
 InitTable_Skill();
 }
 
 return g_Skill.Count;
 }
 public static Dictionary<int, List<Tab_Skill> > GetSkill()
 {
 if(g_Skill.Count==0)
 {
 InitTable_Skill();
 }
 return g_Skill;
 }

public static List<Tab_SkillEx> GetSkillExLine(int nKey)
 {
 if(g_SkillEx.Count==0)
 {
 InitTable_SkillEx();
 }
 if( g_SkillEx.ContainsKey(nKey))
 {
 return g_SkillEx[nKey];
 }
 return null;
 }
 public static Tab_SkillEx GetSkillExByID(int nKey)
 {
 return GetSkillExByID(nKey, 0);
 }
 public static Tab_SkillEx GetSkillExByID(int nKey, int nIndex)
 {
 if(g_SkillEx.Count==0)
 {
 InitTable_SkillEx();
 }
 if( g_SkillEx.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SkillEx[nKey].Count)
 return g_SkillEx[nKey][nIndex];
 }
 return null;
 }
 public static int GetSkillExCount()
 {
 if(g_SkillEx.Count==0)
 {
 InitTable_SkillEx();
 }
 
 return g_SkillEx.Count;
 }
 public static Dictionary<int, List<Tab_SkillEx> > GetSkillEx()
 {
 if(g_SkillEx.Count==0)
 {
 InitTable_SkillEx();
 }
 return g_SkillEx;
 }

public static List<Tab_SkinData> GetSkinDataLine(int nKey)
 {
 if(g_SkinData.Count==0)
 {
 InitTable_SkinData();
 }
 if( g_SkinData.ContainsKey(nKey))
 {
 return g_SkinData[nKey];
 }
 return null;
 }
 public static Tab_SkinData GetSkinDataByID(int nKey)
 {
 return GetSkinDataByID(nKey, 0);
 }
 public static Tab_SkinData GetSkinDataByID(int nKey, int nIndex)
 {
 if(g_SkinData.Count==0)
 {
 InitTable_SkinData();
 }
 if( g_SkinData.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SkinData[nKey].Count)
 return g_SkinData[nKey][nIndex];
 }
 return null;
 }
 public static int GetSkinDataCount()
 {
 if(g_SkinData.Count==0)
 {
 InitTable_SkinData();
 }
 
 return g_SkinData.Count;
 }
 public static Dictionary<int, List<Tab_SkinData> > GetSkinData()
 {
 if(g_SkinData.Count==0)
 {
 InitTable_SkinData();
 }
 return g_SkinData;
 }

public static List<Tab_SpecialClue> GetSpecialClueLine(int nKey)
 {
 if(g_SpecialClue.Count==0)
 {
 InitTable_SpecialClue();
 }
 if( g_SpecialClue.ContainsKey(nKey))
 {
 return g_SpecialClue[nKey];
 }
 return null;
 }
 public static Tab_SpecialClue GetSpecialClueByID(int nKey)
 {
 return GetSpecialClueByID(nKey, 0);
 }
 public static Tab_SpecialClue GetSpecialClueByID(int nKey, int nIndex)
 {
 if(g_SpecialClue.Count==0)
 {
 InitTable_SpecialClue();
 }
 if( g_SpecialClue.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SpecialClue[nKey].Count)
 return g_SpecialClue[nKey][nIndex];
 }
 return null;
 }
 public static int GetSpecialClueCount()
 {
 if(g_SpecialClue.Count==0)
 {
 InitTable_SpecialClue();
 }
 
 return g_SpecialClue.Count;
 }
 public static Dictionary<int, List<Tab_SpecialClue> > GetSpecialClue()
 {
 if(g_SpecialClue.Count==0)
 {
 InitTable_SpecialClue();
 }
 return g_SpecialClue;
 }

public static List<Tab_SpecialLevelGamePlay> GetSpecialLevelGamePlayLine(int nKey)
 {
 if(g_SpecialLevelGamePlay.Count==0)
 {
 InitTable_SpecialLevelGamePlay();
 }
 if( g_SpecialLevelGamePlay.ContainsKey(nKey))
 {
 return g_SpecialLevelGamePlay[nKey];
 }
 return null;
 }
 public static Tab_SpecialLevelGamePlay GetSpecialLevelGamePlayByID(int nKey)
 {
 return GetSpecialLevelGamePlayByID(nKey, 0);
 }
 public static Tab_SpecialLevelGamePlay GetSpecialLevelGamePlayByID(int nKey, int nIndex)
 {
 if(g_SpecialLevelGamePlay.Count==0)
 {
 InitTable_SpecialLevelGamePlay();
 }
 if( g_SpecialLevelGamePlay.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SpecialLevelGamePlay[nKey].Count)
 return g_SpecialLevelGamePlay[nKey][nIndex];
 }
 return null;
 }
 public static int GetSpecialLevelGamePlayCount()
 {
 if(g_SpecialLevelGamePlay.Count==0)
 {
 InitTable_SpecialLevelGamePlay();
 }
 
 return g_SpecialLevelGamePlay.Count;
 }
 public static Dictionary<int, List<Tab_SpecialLevelGamePlay> > GetSpecialLevelGamePlay()
 {
 if(g_SpecialLevelGamePlay.Count==0)
 {
 InitTable_SpecialLevelGamePlay();
 }
 return g_SpecialLevelGamePlay;
 }

public static List<Tab_StoryChapter> GetStoryChapterLine(int nKey)
 {
 if(g_StoryChapter.Count==0)
 {
 InitTable_StoryChapter();
 }
 if( g_StoryChapter.ContainsKey(nKey))
 {
 return g_StoryChapter[nKey];
 }
 return null;
 }
 public static Tab_StoryChapter GetStoryChapterByID(int nKey)
 {
 return GetStoryChapterByID(nKey, 0);
 }
 public static Tab_StoryChapter GetStoryChapterByID(int nKey, int nIndex)
 {
 if(g_StoryChapter.Count==0)
 {
 InitTable_StoryChapter();
 }
 if( g_StoryChapter.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapter[nKey].Count)
 return g_StoryChapter[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterCount()
 {
 if(g_StoryChapter.Count==0)
 {
 InitTable_StoryChapter();
 }
 
 return g_StoryChapter.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapter> > GetStoryChapter()
 {
 if(g_StoryChapter.Count==0)
 {
 InitTable_StoryChapter();
 }
 return g_StoryChapter;
 }

public static List<Tab_StoryChapterCheckpoint> GetStoryChapterCheckpointLine(int nKey)
 {
 if(g_StoryChapterCheckpoint.Count==0)
 {
 InitTable_StoryChapterCheckpoint();
 }
 if( g_StoryChapterCheckpoint.ContainsKey(nKey))
 {
 return g_StoryChapterCheckpoint[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterCheckpoint GetStoryChapterCheckpointByID(int nKey)
 {
 return GetStoryChapterCheckpointByID(nKey, 0);
 }
 public static Tab_StoryChapterCheckpoint GetStoryChapterCheckpointByID(int nKey, int nIndex)
 {
 if(g_StoryChapterCheckpoint.Count==0)
 {
 InitTable_StoryChapterCheckpoint();
 }
 if( g_StoryChapterCheckpoint.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterCheckpoint[nKey].Count)
 return g_StoryChapterCheckpoint[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterCheckpointCount()
 {
 if(g_StoryChapterCheckpoint.Count==0)
 {
 InitTable_StoryChapterCheckpoint();
 }
 
 return g_StoryChapterCheckpoint.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterCheckpoint> > GetStoryChapterCheckpoint()
 {
 if(g_StoryChapterCheckpoint.Count==0)
 {
 InitTable_StoryChapterCheckpoint();
 }
 return g_StoryChapterCheckpoint;
 }

public static List<Tab_StoryChapterEnding> GetStoryChapterEndingLine(int nKey)
 {
 if(g_StoryChapterEnding.Count==0)
 {
 InitTable_StoryChapterEnding();
 }
 if( g_StoryChapterEnding.ContainsKey(nKey))
 {
 return g_StoryChapterEnding[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterEnding GetStoryChapterEndingByID(int nKey)
 {
 return GetStoryChapterEndingByID(nKey, 0);
 }
 public static Tab_StoryChapterEnding GetStoryChapterEndingByID(int nKey, int nIndex)
 {
 if(g_StoryChapterEnding.Count==0)
 {
 InitTable_StoryChapterEnding();
 }
 if( g_StoryChapterEnding.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterEnding[nKey].Count)
 return g_StoryChapterEnding[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterEndingCount()
 {
 if(g_StoryChapterEnding.Count==0)
 {
 InitTable_StoryChapterEnding();
 }
 
 return g_StoryChapterEnding.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterEnding> > GetStoryChapterEnding()
 {
 if(g_StoryChapterEnding.Count==0)
 {
 InitTable_StoryChapterEnding();
 }
 return g_StoryChapterEnding;
 }

public static List<Tab_StoryChapterEndingDesc> GetStoryChapterEndingDescLine(int nKey)
 {
 if(g_StoryChapterEndingDesc.Count==0)
 {
 InitTable_StoryChapterEndingDesc();
 }
 if( g_StoryChapterEndingDesc.ContainsKey(nKey))
 {
 return g_StoryChapterEndingDesc[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterEndingDesc GetStoryChapterEndingDescByID(int nKey)
 {
 return GetStoryChapterEndingDescByID(nKey, 0);
 }
 public static Tab_StoryChapterEndingDesc GetStoryChapterEndingDescByID(int nKey, int nIndex)
 {
 if(g_StoryChapterEndingDesc.Count==0)
 {
 InitTable_StoryChapterEndingDesc();
 }
 if( g_StoryChapterEndingDesc.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterEndingDesc[nKey].Count)
 return g_StoryChapterEndingDesc[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterEndingDescCount()
 {
 if(g_StoryChapterEndingDesc.Count==0)
 {
 InitTable_StoryChapterEndingDesc();
 }
 
 return g_StoryChapterEndingDesc.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterEndingDesc> > GetStoryChapterEndingDesc()
 {
 if(g_StoryChapterEndingDesc.Count==0)
 {
 InitTable_StoryChapterEndingDesc();
 }
 return g_StoryChapterEndingDesc;
 }

public static List<Tab_StoryChapterEndingRule> GetStoryChapterEndingRuleLine(int nKey)
 {
 if(g_StoryChapterEndingRule.Count==0)
 {
 InitTable_StoryChapterEndingRule();
 }
 if( g_StoryChapterEndingRule.ContainsKey(nKey))
 {
 return g_StoryChapterEndingRule[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterEndingRule GetStoryChapterEndingRuleByID(int nKey)
 {
 return GetStoryChapterEndingRuleByID(nKey, 0);
 }
 public static Tab_StoryChapterEndingRule GetStoryChapterEndingRuleByID(int nKey, int nIndex)
 {
 if(g_StoryChapterEndingRule.Count==0)
 {
 InitTable_StoryChapterEndingRule();
 }
 if( g_StoryChapterEndingRule.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterEndingRule[nKey].Count)
 return g_StoryChapterEndingRule[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterEndingRuleCount()
 {
 if(g_StoryChapterEndingRule.Count==0)
 {
 InitTable_StoryChapterEndingRule();
 }
 
 return g_StoryChapterEndingRule.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterEndingRule> > GetStoryChapterEndingRule()
 {
 if(g_StoryChapterEndingRule.Count==0)
 {
 InitTable_StoryChapterEndingRule();
 }
 return g_StoryChapterEndingRule;
 }

public static List<Tab_StoryChapterLevel> GetStoryChapterLevelLine(int nKey)
 {
 if(g_StoryChapterLevel.Count==0)
 {
 InitTable_StoryChapterLevel();
 }
 if( g_StoryChapterLevel.ContainsKey(nKey))
 {
 return g_StoryChapterLevel[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterLevel GetStoryChapterLevelByID(int nKey)
 {
 return GetStoryChapterLevelByID(nKey, 0);
 }
 public static Tab_StoryChapterLevel GetStoryChapterLevelByID(int nKey, int nIndex)
 {
 if(g_StoryChapterLevel.Count==0)
 {
 InitTable_StoryChapterLevel();
 }
 if( g_StoryChapterLevel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterLevel[nKey].Count)
 return g_StoryChapterLevel[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterLevelCount()
 {
 if(g_StoryChapterLevel.Count==0)
 {
 InitTable_StoryChapterLevel();
 }
 
 return g_StoryChapterLevel.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterLevel> > GetStoryChapterLevel()
 {
 if(g_StoryChapterLevel.Count==0)
 {
 InitTable_StoryChapterLevel();
 }
 return g_StoryChapterLevel;
 }

public static List<Tab_StoryChapterLevelReq> GetStoryChapterLevelReqLine(int nKey)
 {
 if(g_StoryChapterLevelReq.Count==0)
 {
 InitTable_StoryChapterLevelReq();
 }
 if( g_StoryChapterLevelReq.ContainsKey(nKey))
 {
 return g_StoryChapterLevelReq[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterLevelReq GetStoryChapterLevelReqByID(int nKey)
 {
 return GetStoryChapterLevelReqByID(nKey, 0);
 }
 public static Tab_StoryChapterLevelReq GetStoryChapterLevelReqByID(int nKey, int nIndex)
 {
 if(g_StoryChapterLevelReq.Count==0)
 {
 InitTable_StoryChapterLevelReq();
 }
 if( g_StoryChapterLevelReq.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterLevelReq[nKey].Count)
 return g_StoryChapterLevelReq[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterLevelReqCount()
 {
 if(g_StoryChapterLevelReq.Count==0)
 {
 InitTable_StoryChapterLevelReq();
 }
 
 return g_StoryChapterLevelReq.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterLevelReq> > GetStoryChapterLevelReq()
 {
 if(g_StoryChapterLevelReq.Count==0)
 {
 InitTable_StoryChapterLevelReq();
 }
 return g_StoryChapterLevelReq;
 }

public static List<Tab_StoryChapterLevelReward> GetStoryChapterLevelRewardLine(int nKey)
 {
 if(g_StoryChapterLevelReward.Count==0)
 {
 InitTable_StoryChapterLevelReward();
 }
 if( g_StoryChapterLevelReward.ContainsKey(nKey))
 {
 return g_StoryChapterLevelReward[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterLevelReward GetStoryChapterLevelRewardByID(int nKey)
 {
 return GetStoryChapterLevelRewardByID(nKey, 0);
 }
 public static Tab_StoryChapterLevelReward GetStoryChapterLevelRewardByID(int nKey, int nIndex)
 {
 if(g_StoryChapterLevelReward.Count==0)
 {
 InitTable_StoryChapterLevelReward();
 }
 if( g_StoryChapterLevelReward.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterLevelReward[nKey].Count)
 return g_StoryChapterLevelReward[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterLevelRewardCount()
 {
 if(g_StoryChapterLevelReward.Count==0)
 {
 InitTable_StoryChapterLevelReward();
 }
 
 return g_StoryChapterLevelReward.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterLevelReward> > GetStoryChapterLevelReward()
 {
 if(g_StoryChapterLevelReward.Count==0)
 {
 InitTable_StoryChapterLevelReward();
 }
 return g_StoryChapterLevelReward;
 }

public static List<Tab_StoryChapterLevelRule> GetStoryChapterLevelRuleLine(int nKey)
 {
 if(g_StoryChapterLevelRule.Count==0)
 {
 InitTable_StoryChapterLevelRule();
 }
 if( g_StoryChapterLevelRule.ContainsKey(nKey))
 {
 return g_StoryChapterLevelRule[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterLevelRule GetStoryChapterLevelRuleByID(int nKey)
 {
 return GetStoryChapterLevelRuleByID(nKey, 0);
 }
 public static Tab_StoryChapterLevelRule GetStoryChapterLevelRuleByID(int nKey, int nIndex)
 {
 if(g_StoryChapterLevelRule.Count==0)
 {
 InitTable_StoryChapterLevelRule();
 }
 if( g_StoryChapterLevelRule.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterLevelRule[nKey].Count)
 return g_StoryChapterLevelRule[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterLevelRuleCount()
 {
 if(g_StoryChapterLevelRule.Count==0)
 {
 InitTable_StoryChapterLevelRule();
 }
 
 return g_StoryChapterLevelRule.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterLevelRule> > GetStoryChapterLevelRule()
 {
 if(g_StoryChapterLevelRule.Count==0)
 {
 InitTable_StoryChapterLevelRule();
 }
 return g_StoryChapterLevelRule;
 }

public static List<Tab_StoryChapterLevelSceneEvent> GetStoryChapterLevelSceneEventLine(int nKey)
 {
 if(g_StoryChapterLevelSceneEvent.Count==0)
 {
 InitTable_StoryChapterLevelSceneEvent();
 }
 if( g_StoryChapterLevelSceneEvent.ContainsKey(nKey))
 {
 return g_StoryChapterLevelSceneEvent[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterLevelSceneEvent GetStoryChapterLevelSceneEventByID(int nKey)
 {
 return GetStoryChapterLevelSceneEventByID(nKey, 0);
 }
 public static Tab_StoryChapterLevelSceneEvent GetStoryChapterLevelSceneEventByID(int nKey, int nIndex)
 {
 if(g_StoryChapterLevelSceneEvent.Count==0)
 {
 InitTable_StoryChapterLevelSceneEvent();
 }
 if( g_StoryChapterLevelSceneEvent.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterLevelSceneEvent[nKey].Count)
 return g_StoryChapterLevelSceneEvent[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterLevelSceneEventCount()
 {
 if(g_StoryChapterLevelSceneEvent.Count==0)
 {
 InitTable_StoryChapterLevelSceneEvent();
 }
 
 return g_StoryChapterLevelSceneEvent.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterLevelSceneEvent> > GetStoryChapterLevelSceneEvent()
 {
 if(g_StoryChapterLevelSceneEvent.Count==0)
 {
 InitTable_StoryChapterLevelSceneEvent();
 }
 return g_StoryChapterLevelSceneEvent;
 }

public static List<Tab_StoryChapterRule> GetStoryChapterRuleLine(int nKey)
 {
 if(g_StoryChapterRule.Count==0)
 {
 InitTable_StoryChapterRule();
 }
 if( g_StoryChapterRule.ContainsKey(nKey))
 {
 return g_StoryChapterRule[nKey];
 }
 return null;
 }
 public static Tab_StoryChapterRule GetStoryChapterRuleByID(int nKey)
 {
 return GetStoryChapterRuleByID(nKey, 0);
 }
 public static Tab_StoryChapterRule GetStoryChapterRuleByID(int nKey, int nIndex)
 {
 if(g_StoryChapterRule.Count==0)
 {
 InitTable_StoryChapterRule();
 }
 if( g_StoryChapterRule.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryChapterRule[nKey].Count)
 return g_StoryChapterRule[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryChapterRuleCount()
 {
 if(g_StoryChapterRule.Count==0)
 {
 InitTable_StoryChapterRule();
 }
 
 return g_StoryChapterRule.Count;
 }
 public static Dictionary<int, List<Tab_StoryChapterRule> > GetStoryChapterRule()
 {
 if(g_StoryChapterRule.Count==0)
 {
 InitTable_StoryChapterRule();
 }
 return g_StoryChapterRule;
 }

public static List<Tab_StoryLine> GetStoryLineLine(int nKey)
 {
 if(g_StoryLine.Count==0)
 {
 InitTable_StoryLine();
 }
 if( g_StoryLine.ContainsKey(nKey))
 {
 return g_StoryLine[nKey];
 }
 return null;
 }
 public static Tab_StoryLine GetStoryLineByID(int nKey)
 {
 return GetStoryLineByID(nKey, 0);
 }
 public static Tab_StoryLine GetStoryLineByID(int nKey, int nIndex)
 {
 if(g_StoryLine.Count==0)
 {
 InitTable_StoryLine();
 }
 if( g_StoryLine.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StoryLine[nKey].Count)
 return g_StoryLine[nKey][nIndex];
 }
 return null;
 }
 public static int GetStoryLineCount()
 {
 if(g_StoryLine.Count==0)
 {
 InitTable_StoryLine();
 }
 
 return g_StoryLine.Count;
 }
 public static Dictionary<int, List<Tab_StoryLine> > GetStoryLine()
 {
 if(g_StoryLine.Count==0)
 {
 InitTable_StoryLine();
 }
 return g_StoryLine;
 }

public static List<Tab_StrDictionary> GetStrDictionaryLine(int nKey)
 {
 if(g_StrDictionary.Count==0)
 {
 InitTable_StrDictionary();
 }
 if( g_StrDictionary.ContainsKey(nKey))
 {
 return g_StrDictionary[nKey];
 }
 return null;
 }
 public static Tab_StrDictionary GetStrDictionaryByID(int nKey)
 {
 return GetStrDictionaryByID(nKey, 0);
 }
 public static Tab_StrDictionary GetStrDictionaryByID(int nKey, int nIndex)
 {
 if(g_StrDictionary.Count==0)
 {
 InitTable_StrDictionary();
 }
 if( g_StrDictionary.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StrDictionary[nKey].Count)
 return g_StrDictionary[nKey][nIndex];
 }
 return null;
 }
 public static int GetStrDictionaryCount()
 {
 if(g_StrDictionary.Count==0)
 {
 InitTable_StrDictionary();
 }
 
 return g_StrDictionary.Count;
 }
 public static Dictionary<int, List<Tab_StrDictionary> > GetStrDictionary()
 {
 if(g_StrDictionary.Count==0)
 {
 InitTable_StrDictionary();
 }
 return g_StrDictionary;
 }

public static List<Tab_StrFilter> GetStrFilterLine(int nKey)
 {
 if(g_StrFilter.Count==0)
 {
 InitTable_StrFilter();
 }
 if( g_StrFilter.ContainsKey(nKey))
 {
 return g_StrFilter[nKey];
 }
 return null;
 }
 public static Tab_StrFilter GetStrFilterByID(int nKey)
 {
 return GetStrFilterByID(nKey, 0);
 }
 public static Tab_StrFilter GetStrFilterByID(int nKey, int nIndex)
 {
 if(g_StrFilter.Count==0)
 {
 InitTable_StrFilter();
 }
 if( g_StrFilter.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_StrFilter[nKey].Count)
 return g_StrFilter[nKey][nIndex];
 }
 return null;
 }
 public static int GetStrFilterCount()
 {
 if(g_StrFilter.Count==0)
 {
 InitTable_StrFilter();
 }
 
 return g_StrFilter.Count;
 }
 public static Dictionary<int, List<Tab_StrFilter> > GetStrFilter()
 {
 if(g_StrFilter.Count==0)
 {
 InitTable_StrFilter();
 }
 return g_StrFilter;
 }

public static List<Tab_SystemMail> GetSystemMailLine(int nKey)
 {
 if(g_SystemMail.Count==0)
 {
 InitTable_SystemMail();
 }
 if( g_SystemMail.ContainsKey(nKey))
 {
 return g_SystemMail[nKey];
 }
 return null;
 }
 public static Tab_SystemMail GetSystemMailByID(int nKey)
 {
 return GetSystemMailByID(nKey, 0);
 }
 public static Tab_SystemMail GetSystemMailByID(int nKey, int nIndex)
 {
 if(g_SystemMail.Count==0)
 {
 InitTable_SystemMail();
 }
 if( g_SystemMail.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_SystemMail[nKey].Count)
 return g_SystemMail[nKey][nIndex];
 }
 return null;
 }
 public static int GetSystemMailCount()
 {
 if(g_SystemMail.Count==0)
 {
 InitTable_SystemMail();
 }
 
 return g_SystemMail.Count;
 }
 public static Dictionary<int, List<Tab_SystemMail> > GetSystemMail()
 {
 if(g_SystemMail.Count==0)
 {
 InitTable_SystemMail();
 }
 return g_SystemMail;
 }

public static List<Tab_TagData> GetTagDataLine(int nKey)
 {
 if(g_TagData.Count==0)
 {
 InitTable_TagData();
 }
 if( g_TagData.ContainsKey(nKey))
 {
 return g_TagData[nKey];
 }
 return null;
 }
 public static Tab_TagData GetTagDataByID(int nKey)
 {
 return GetTagDataByID(nKey, 0);
 }
 public static Tab_TagData GetTagDataByID(int nKey, int nIndex)
 {
 if(g_TagData.Count==0)
 {
 InitTable_TagData();
 }
 if( g_TagData.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_TagData[nKey].Count)
 return g_TagData[nKey][nIndex];
 }
 return null;
 }
 public static int GetTagDataCount()
 {
 if(g_TagData.Count==0)
 {
 InitTable_TagData();
 }
 
 return g_TagData.Count;
 }
 public static Dictionary<int, List<Tab_TagData> > GetTagData()
 {
 if(g_TagData.Count==0)
 {
 InitTable_TagData();
 }
 return g_TagData;
 }

public static List<Tab_Task> GetTaskLine(int nKey)
 {
 if(g_Task.Count==0)
 {
 InitTable_Task();
 }
 if( g_Task.ContainsKey(nKey))
 {
 return g_Task[nKey];
 }
 return null;
 }
 public static Tab_Task GetTaskByID(int nKey)
 {
 return GetTaskByID(nKey, 0);
 }
 public static Tab_Task GetTaskByID(int nKey, int nIndex)
 {
 if(g_Task.Count==0)
 {
 InitTable_Task();
 }
 if( g_Task.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Task[nKey].Count)
 return g_Task[nKey][nIndex];
 }
 return null;
 }
 public static int GetTaskCount()
 {
 if(g_Task.Count==0)
 {
 InitTable_Task();
 }
 
 return g_Task.Count;
 }
 public static Dictionary<int, List<Tab_Task> > GetTask()
 {
 if(g_Task.Count==0)
 {
 InitTable_Task();
 }
 return g_Task;
 }

public static List<Tab_TaskAward> GetTaskAwardLine(int nKey)
 {
 if(g_TaskAward.Count==0)
 {
 InitTable_TaskAward();
 }
 if( g_TaskAward.ContainsKey(nKey))
 {
 return g_TaskAward[nKey];
 }
 return null;
 }
 public static Tab_TaskAward GetTaskAwardByID(int nKey)
 {
 return GetTaskAwardByID(nKey, 0);
 }
 public static Tab_TaskAward GetTaskAwardByID(int nKey, int nIndex)
 {
 if(g_TaskAward.Count==0)
 {
 InitTable_TaskAward();
 }
 if( g_TaskAward.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_TaskAward[nKey].Count)
 return g_TaskAward[nKey][nIndex];
 }
 return null;
 }
 public static int GetTaskAwardCount()
 {
 if(g_TaskAward.Count==0)
 {
 InitTable_TaskAward();
 }
 
 return g_TaskAward.Count;
 }
 public static Dictionary<int, List<Tab_TaskAward> > GetTaskAward()
 {
 if(g_TaskAward.Count==0)
 {
 InitTable_TaskAward();
 }
 return g_TaskAward;
 }

public static List<Tab_TaskGroup> GetTaskGroupLine(int nKey)
 {
 if(g_TaskGroup.Count==0)
 {
 InitTable_TaskGroup();
 }
 if( g_TaskGroup.ContainsKey(nKey))
 {
 return g_TaskGroup[nKey];
 }
 return null;
 }
 public static Tab_TaskGroup GetTaskGroupByID(int nKey)
 {
 return GetTaskGroupByID(nKey, 0);
 }
 public static Tab_TaskGroup GetTaskGroupByID(int nKey, int nIndex)
 {
 if(g_TaskGroup.Count==0)
 {
 InitTable_TaskGroup();
 }
 if( g_TaskGroup.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_TaskGroup[nKey].Count)
 return g_TaskGroup[nKey][nIndex];
 }
 return null;
 }
 public static int GetTaskGroupCount()
 {
 if(g_TaskGroup.Count==0)
 {
 InitTable_TaskGroup();
 }
 
 return g_TaskGroup.Count;
 }
 public static Dictionary<int, List<Tab_TaskGroup> > GetTaskGroup()
 {
 if(g_TaskGroup.Count==0)
 {
 InitTable_TaskGroup();
 }
 return g_TaskGroup;
 }

public static List<Tab_TaskTab> GetTaskTabLine(int nKey)
 {
 if(g_TaskTab.Count==0)
 {
 InitTable_TaskTab();
 }
 if( g_TaskTab.ContainsKey(nKey))
 {
 return g_TaskTab[nKey];
 }
 return null;
 }
 public static Tab_TaskTab GetTaskTabByID(int nKey)
 {
 return GetTaskTabByID(nKey, 0);
 }
 public static Tab_TaskTab GetTaskTabByID(int nKey, int nIndex)
 {
 if(g_TaskTab.Count==0)
 {
 InitTable_TaskTab();
 }
 if( g_TaskTab.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_TaskTab[nKey].Count)
 return g_TaskTab[nKey][nIndex];
 }
 return null;
 }
 public static int GetTaskTabCount()
 {
 if(g_TaskTab.Count==0)
 {
 InitTable_TaskTab();
 }
 
 return g_TaskTab.Count;
 }
 public static Dictionary<int, List<Tab_TaskTab> > GetTaskTab()
 {
 if(g_TaskTab.Count==0)
 {
 InitTable_TaskTab();
 }
 return g_TaskTab;
 }

public static List<Tab_TeleportPoint> GetTeleportPointLine(int nKey)
 {
 if(g_TeleportPoint.Count==0)
 {
 InitTable_TeleportPoint();
 }
 if( g_TeleportPoint.ContainsKey(nKey))
 {
 return g_TeleportPoint[nKey];
 }
 return null;
 }
 public static Tab_TeleportPoint GetTeleportPointByID(int nKey)
 {
 return GetTeleportPointByID(nKey, 0);
 }
 public static Tab_TeleportPoint GetTeleportPointByID(int nKey, int nIndex)
 {
 if(g_TeleportPoint.Count==0)
 {
 InitTable_TeleportPoint();
 }
 if( g_TeleportPoint.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_TeleportPoint[nKey].Count)
 return g_TeleportPoint[nKey][nIndex];
 }
 return null;
 }
 public static int GetTeleportPointCount()
 {
 if(g_TeleportPoint.Count==0)
 {
 InitTable_TeleportPoint();
 }
 
 return g_TeleportPoint.Count;
 }
 public static Dictionary<int, List<Tab_TeleportPoint> > GetTeleportPoint()
 {
 if(g_TeleportPoint.Count==0)
 {
 InitTable_TeleportPoint();
 }
 return g_TeleportPoint;
 }

public static List<Tab_Title> GetTitleLine(int nKey)
 {
 if(g_Title.Count==0)
 {
 InitTable_Title();
 }
 if( g_Title.ContainsKey(nKey))
 {
 return g_Title[nKey];
 }
 return null;
 }
 public static Tab_Title GetTitleByID(int nKey)
 {
 return GetTitleByID(nKey, 0);
 }
 public static Tab_Title GetTitleByID(int nKey, int nIndex)
 {
 if(g_Title.Count==0)
 {
 InitTable_Title();
 }
 if( g_Title.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_Title[nKey].Count)
 return g_Title[nKey][nIndex];
 }
 return null;
 }
 public static int GetTitleCount()
 {
 if(g_Title.Count==0)
 {
 InitTable_Title();
 }
 
 return g_Title.Count;
 }
 public static Dictionary<int, List<Tab_Title> > GetTitle()
 {
 if(g_Title.Count==0)
 {
 InitTable_Title();
 }
 return g_Title;
 }

public static List<Tab_TranlateDictionary> GetTranlateDictionaryLine(long nKey)
 {
 if(g_TranlateDictionary.Count==0)
 {
 InitTable_TranlateDictionary();
 }
 if( g_TranlateDictionary.ContainsKey(nKey))
 {
 return g_TranlateDictionary[nKey];
 }
 return null;
 }
 public static Tab_TranlateDictionary GetTranlateDictionaryByID(long nKey)
 {
 return GetTranlateDictionaryByID(nKey, 0);
 }
 public static Tab_TranlateDictionary GetTranlateDictionaryByID(long nKey, int nIndex)
 {
 if(g_TranlateDictionary.Count==0)
 {
 InitTable_TranlateDictionary();
 }
 if( g_TranlateDictionary.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_TranlateDictionary[nKey].Count)
 return g_TranlateDictionary[nKey][nIndex];
 }
 return null;
 }
 public static int GetTranlateDictionaryCount()
 {
 if(g_TranlateDictionary.Count==0)
 {
 InitTable_TranlateDictionary();
 }
 
 return g_TranlateDictionary.Count;
 }
 public static Dictionary<long, List<Tab_TranlateDictionary> > GetTranlateDictionary()
 {
 if(g_TranlateDictionary.Count==0)
 {
 InitTable_TranlateDictionary();
 }
 return g_TranlateDictionary;
 }

public static List<Tab_TranlateDictionaryEn> GetTranlateDictionaryEnLine(int nKey)
 {
 if(g_TranlateDictionaryEn.Count==0)
 {
 InitTable_TranlateDictionaryEn();
 }
 if( g_TranlateDictionaryEn.ContainsKey(nKey))
 {
 return g_TranlateDictionaryEn[nKey];
 }
 return null;
 }
 public static Tab_TranlateDictionaryEn GetTranlateDictionaryEnByID(int nKey)
 {
 return GetTranlateDictionaryEnByID(nKey, 0);
 }
 public static Tab_TranlateDictionaryEn GetTranlateDictionaryEnByID(int nKey, int nIndex)
 {
 if(g_TranlateDictionaryEn.Count==0)
 {
 InitTable_TranlateDictionaryEn();
 }
 if( g_TranlateDictionaryEn.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_TranlateDictionaryEn[nKey].Count)
 return g_TranlateDictionaryEn[nKey][nIndex];
 }
 return null;
 }
 public static int GetTranlateDictionaryEnCount()
 {
 if(g_TranlateDictionaryEn.Count==0)
 {
 InitTable_TranlateDictionaryEn();
 }
 
 return g_TranlateDictionaryEn.Count;
 }
 public static Dictionary<int, List<Tab_TranlateDictionaryEn> > GetTranlateDictionaryEn()
 {
 if(g_TranlateDictionaryEn.Count==0)
 {
 InitTable_TranlateDictionaryEn();
 }
 return g_TranlateDictionaryEn;
 }

public static List<Tab_UIDictionary> GetUIDictionaryLine(int nKey)
 {
 if(g_UIDictionary.Count==0)
 {
 InitTable_UIDictionary();
 }
 if( g_UIDictionary.ContainsKey(nKey))
 {
 return g_UIDictionary[nKey];
 }
 return null;
 }
 public static Tab_UIDictionary GetUIDictionaryByID(int nKey)
 {
 return GetUIDictionaryByID(nKey, 0);
 }
 public static Tab_UIDictionary GetUIDictionaryByID(int nKey, int nIndex)
 {
 if(g_UIDictionary.Count==0)
 {
 InitTable_UIDictionary();
 }
 if( g_UIDictionary.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_UIDictionary[nKey].Count)
 return g_UIDictionary[nKey][nIndex];
 }
 return null;
 }
 public static int GetUIDictionaryCount()
 {
 if(g_UIDictionary.Count==0)
 {
 InitTable_UIDictionary();
 }
 
 return g_UIDictionary.Count;
 }
 public static Dictionary<int, List<Tab_UIDictionary> > GetUIDictionary()
 {
 if(g_UIDictionary.Count==0)
 {
 InitTable_UIDictionary();
 }
 return g_UIDictionary;
 }

public static List<Tab_UIItemExtension> GetUIItemExtensionLine(int nKey)
 {
 if(g_UIItemExtension.Count==0)
 {
 InitTable_UIItemExtension();
 }
 if( g_UIItemExtension.ContainsKey(nKey))
 {
 return g_UIItemExtension[nKey];
 }
 return null;
 }
 public static Tab_UIItemExtension GetUIItemExtensionByID(int nKey)
 {
 return GetUIItemExtensionByID(nKey, 0);
 }
 public static Tab_UIItemExtension GetUIItemExtensionByID(int nKey, int nIndex)
 {
 if(g_UIItemExtension.Count==0)
 {
 InitTable_UIItemExtension();
 }
 if( g_UIItemExtension.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_UIItemExtension[nKey].Count)
 return g_UIItemExtension[nKey][nIndex];
 }
 return null;
 }
 public static int GetUIItemExtensionCount()
 {
 if(g_UIItemExtension.Count==0)
 {
 InitTable_UIItemExtension();
 }
 
 return g_UIItemExtension.Count;
 }
 public static Dictionary<int, List<Tab_UIItemExtension> > GetUIItemExtension()
 {
 if(g_UIItemExtension.Count==0)
 {
 InitTable_UIItemExtension();
 }
 return g_UIItemExtension;
 }

public static List<Tab_UIPackage> GetUIPackageLine(int nKey)
 {
 if(g_UIPackage.Count==0)
 {
 InitTable_UIPackage();
 }
 if( g_UIPackage.ContainsKey(nKey))
 {
 return g_UIPackage[nKey];
 }
 return null;
 }
 public static Tab_UIPackage GetUIPackageByID(int nKey)
 {
 return GetUIPackageByID(nKey, 0);
 }
 public static Tab_UIPackage GetUIPackageByID(int nKey, int nIndex)
 {
 if(g_UIPackage.Count==0)
 {
 InitTable_UIPackage();
 }
 if( g_UIPackage.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_UIPackage[nKey].Count)
 return g_UIPackage[nKey][nIndex];
 }
 return null;
 }
 public static int GetUIPackageCount()
 {
 if(g_UIPackage.Count==0)
 {
 InitTable_UIPackage();
 }
 
 return g_UIPackage.Count;
 }
 public static Dictionary<int, List<Tab_UIPackage> > GetUIPackage()
 {
 if(g_UIPackage.Count==0)
 {
 InitTable_UIPackage();
 }
 return g_UIPackage;
 }

public static List<Tab_UIPanel> GetUIPanelLine(int nKey)
 {
 if(g_UIPanel.Count==0)
 {
 InitTable_UIPanel();
 }
 if( g_UIPanel.ContainsKey(nKey))
 {
 return g_UIPanel[nKey];
 }
 return null;
 }
 public static Tab_UIPanel GetUIPanelByID(int nKey)
 {
 return GetUIPanelByID(nKey, 0);
 }
 public static Tab_UIPanel GetUIPanelByID(int nKey, int nIndex)
 {
 if(g_UIPanel.Count==0)
 {
 InitTable_UIPanel();
 }
 if( g_UIPanel.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_UIPanel[nKey].Count)
 return g_UIPanel[nKey][nIndex];
 }
 return null;
 }
 public static int GetUIPanelCount()
 {
 if(g_UIPanel.Count==0)
 {
 InitTable_UIPanel();
 }
 
 return g_UIPanel.Count;
 }
 public static Dictionary<int, List<Tab_UIPanel> > GetUIPanel()
 {
 if(g_UIPanel.Count==0)
 {
 InitTable_UIPanel();
 }
 return g_UIPanel;
 }

public static List<Tab_UIRedDot> GetUIRedDotLine(int nKey)
 {
 if(g_UIRedDot.Count==0)
 {
 InitTable_UIRedDot();
 }
 if( g_UIRedDot.ContainsKey(nKey))
 {
 return g_UIRedDot[nKey];
 }
 return null;
 }
 public static Tab_UIRedDot GetUIRedDotByID(int nKey)
 {
 return GetUIRedDotByID(nKey, 0);
 }
 public static Tab_UIRedDot GetUIRedDotByID(int nKey, int nIndex)
 {
 if(g_UIRedDot.Count==0)
 {
 InitTable_UIRedDot();
 }
 if( g_UIRedDot.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_UIRedDot[nKey].Count)
 return g_UIRedDot[nKey][nIndex];
 }
 return null;
 }
 public static int GetUIRedDotCount()
 {
 if(g_UIRedDot.Count==0)
 {
 InitTable_UIRedDot();
 }
 
 return g_UIRedDot.Count;
 }
 public static Dictionary<int, List<Tab_UIRedDot> > GetUIRedDot()
 {
 if(g_UIRedDot.Count==0)
 {
 InitTable_UIRedDot();
 }
 return g_UIRedDot;
 }

public static List<Tab_VChat> GetVChatLine(int nKey)
 {
 if(g_VChat.Count==0)
 {
 InitTable_VChat();
 }
 if( g_VChat.ContainsKey(nKey))
 {
 return g_VChat[nKey];
 }
 return null;
 }
 public static Tab_VChat GetVChatByID(int nKey)
 {
 return GetVChatByID(nKey, 0);
 }
 public static Tab_VChat GetVChatByID(int nKey, int nIndex)
 {
 if(g_VChat.Count==0)
 {
 InitTable_VChat();
 }
 if( g_VChat.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_VChat[nKey].Count)
 return g_VChat[nKey][nIndex];
 }
 return null;
 }
 public static int GetVChatCount()
 {
 if(g_VChat.Count==0)
 {
 InitTable_VChat();
 }
 
 return g_VChat.Count;
 }
 public static Dictionary<int, List<Tab_VChat> > GetVChat()
 {
 if(g_VChat.Count==0)
 {
 InitTable_VChat();
 }
 return g_VChat;
 }

public static List<Tab_VChatEmoji> GetVChatEmojiLine(int nKey)
 {
 if(g_VChatEmoji.Count==0)
 {
 InitTable_VChatEmoji();
 }
 if( g_VChatEmoji.ContainsKey(nKey))
 {
 return g_VChatEmoji[nKey];
 }
 return null;
 }
 public static Tab_VChatEmoji GetVChatEmojiByID(int nKey)
 {
 return GetVChatEmojiByID(nKey, 0);
 }
 public static Tab_VChatEmoji GetVChatEmojiByID(int nKey, int nIndex)
 {
 if(g_VChatEmoji.Count==0)
 {
 InitTable_VChatEmoji();
 }
 if( g_VChatEmoji.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_VChatEmoji[nKey].Count)
 return g_VChatEmoji[nKey][nIndex];
 }
 return null;
 }
 public static int GetVChatEmojiCount()
 {
 if(g_VChatEmoji.Count==0)
 {
 InitTable_VChatEmoji();
 }
 
 return g_VChatEmoji.Count;
 }
 public static Dictionary<int, List<Tab_VChatEmoji> > GetVChatEmoji()
 {
 if(g_VChatEmoji.Count==0)
 {
 InitTable_VChatEmoji();
 }
 return g_VChatEmoji;
 }

public static List<Tab_VChatGroup> GetVChatGroupLine(int nKey)
 {
 if(g_VChatGroup.Count==0)
 {
 InitTable_VChatGroup();
 }
 if( g_VChatGroup.ContainsKey(nKey))
 {
 return g_VChatGroup[nKey];
 }
 return null;
 }
 public static Tab_VChatGroup GetVChatGroupByID(int nKey)
 {
 return GetVChatGroupByID(nKey, 0);
 }
 public static Tab_VChatGroup GetVChatGroupByID(int nKey, int nIndex)
 {
 if(g_VChatGroup.Count==0)
 {
 InitTable_VChatGroup();
 }
 if( g_VChatGroup.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_VChatGroup[nKey].Count)
 return g_VChatGroup[nKey][nIndex];
 }
 return null;
 }
 public static int GetVChatGroupCount()
 {
 if(g_VChatGroup.Count==0)
 {
 InitTable_VChatGroup();
 }
 
 return g_VChatGroup.Count;
 }
 public static Dictionary<int, List<Tab_VChatGroup> > GetVChatGroup()
 {
 if(g_VChatGroup.Count==0)
 {
 InitTable_VChatGroup();
 }
 return g_VChatGroup;
 }

public static List<Tab_VChatMsg> GetVChatMsgLine(int nKey)
 {
 if(g_VChatMsg.Count==0)
 {
 InitTable_VChatMsg();
 }
 if( g_VChatMsg.ContainsKey(nKey))
 {
 return g_VChatMsg[nKey];
 }
 return null;
 }
 public static Tab_VChatMsg GetVChatMsgByID(int nKey)
 {
 return GetVChatMsgByID(nKey, 0);
 }
 public static Tab_VChatMsg GetVChatMsgByID(int nKey, int nIndex)
 {
 if(g_VChatMsg.Count==0)
 {
 InitTable_VChatMsg();
 }
 if( g_VChatMsg.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_VChatMsg[nKey].Count)
 return g_VChatMsg[nKey][nIndex];
 }
 return null;
 }
 public static int GetVChatMsgCount()
 {
 if(g_VChatMsg.Count==0)
 {
 InitTable_VChatMsg();
 }
 
 return g_VChatMsg.Count;
 }
 public static Dictionary<int, List<Tab_VChatMsg> > GetVChatMsg()
 {
 if(g_VChatMsg.Count==0)
 {
 InitTable_VChatMsg();
 }
 return g_VChatMsg;
 }

public static List<Tab_VChatOption> GetVChatOptionLine(int nKey)
 {
 if(g_VChatOption.Count==0)
 {
 InitTable_VChatOption();
 }
 if( g_VChatOption.ContainsKey(nKey))
 {
 return g_VChatOption[nKey];
 }
 return null;
 }
 public static Tab_VChatOption GetVChatOptionByID(int nKey)
 {
 return GetVChatOptionByID(nKey, 0);
 }
 public static Tab_VChatOption GetVChatOptionByID(int nKey, int nIndex)
 {
 if(g_VChatOption.Count==0)
 {
 InitTable_VChatOption();
 }
 if( g_VChatOption.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_VChatOption[nKey].Count)
 return g_VChatOption[nKey][nIndex];
 }
 return null;
 }
 public static int GetVChatOptionCount()
 {
 if(g_VChatOption.Count==0)
 {
 InitTable_VChatOption();
 }
 
 return g_VChatOption.Count;
 }
 public static Dictionary<int, List<Tab_VChatOption> > GetVChatOption()
 {
 if(g_VChatOption.Count==0)
 {
 InitTable_VChatOption();
 }
 return g_VChatOption;
 }

public static List<Tab_VoiceData> GetVoiceDataLine(int nKey)
 {
 if(g_VoiceData.Count==0)
 {
 InitTable_VoiceData();
 }
 if( g_VoiceData.ContainsKey(nKey))
 {
 return g_VoiceData[nKey];
 }
 return null;
 }
 public static Tab_VoiceData GetVoiceDataByID(int nKey)
 {
 return GetVoiceDataByID(nKey, 0);
 }
 public static Tab_VoiceData GetVoiceDataByID(int nKey, int nIndex)
 {
 if(g_VoiceData.Count==0)
 {
 InitTable_VoiceData();
 }
 if( g_VoiceData.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_VoiceData[nKey].Count)
 return g_VoiceData[nKey][nIndex];
 }
 return null;
 }
 public static int GetVoiceDataCount()
 {
 if(g_VoiceData.Count==0)
 {
 InitTable_VoiceData();
 }
 
 return g_VoiceData.Count;
 }
 public static Dictionary<int, List<Tab_VoiceData> > GetVoiceData()
 {
 if(g_VoiceData.Count==0)
 {
 InitTable_VoiceData();
 }
 return g_VoiceData;
 }

public static List<Tab_VoiceExtraConfig> GetVoiceExtraConfigLine(int nKey)
 {
 if(g_VoiceExtraConfig.Count==0)
 {
 InitTable_VoiceExtraConfig();
 }
 if( g_VoiceExtraConfig.ContainsKey(nKey))
 {
 return g_VoiceExtraConfig[nKey];
 }
 return null;
 }
 public static Tab_VoiceExtraConfig GetVoiceExtraConfigByID(int nKey)
 {
 return GetVoiceExtraConfigByID(nKey, 0);
 }
 public static Tab_VoiceExtraConfig GetVoiceExtraConfigByID(int nKey, int nIndex)
 {
 if(g_VoiceExtraConfig.Count==0)
 {
 InitTable_VoiceExtraConfig();
 }
 if( g_VoiceExtraConfig.ContainsKey(nKey))
 {
 if(nIndex>=0 && nIndex<g_VoiceExtraConfig[nKey].Count)
 return g_VoiceExtraConfig[nKey][nIndex];
 }
 return null;
 }
 public static int GetVoiceExtraConfigCount()
 {
 if(g_VoiceExtraConfig.Count==0)
 {
 InitTable_VoiceExtraConfig();
 }
 
 return g_VoiceExtraConfig.Count;
 }
 public static Dictionary<int, List<Tab_VoiceExtraConfig> > GetVoiceExtraConfig()
 {
 if(g_VoiceExtraConfig.Count==0)
 {
 InitTable_VoiceExtraConfig();
 }
 return g_VoiceExtraConfig;
 }

[SLua.DoNotToLua]
 public static void Clear() {

g_AbilityClue.Clear();

g_AbilityData.Clear();

g_AbilityDataEx.Clear();

g_Action.Clear();

g_ActionAvatarEvent.Clear();

g_ActionReview.Clear();

g_ActionSkip.Clear();

g_AlbumCard.Clear();

g_AlbumLevel.Clear();

g_AlbumStory.Clear();

g_AlbumStorySub.Clear();

g_Appointment.Clear();

g_Article.Clear();

g_ArticleDetail.Clear();

g_ArticleOfficialAccount.Clear();

g_ArticleReply.Clear();

g_AssetGroup.Clear();

g_AssetList.Clear();

g_AttrData.Clear();

g_Audio.Clear();

g_AudioAcb.Clear();

g_Avatar.Clear();

g_BattlePass.Clear();

g_BattlePassTask.Clear();

g_BattleScript.Clear();

g_BehaviorCalcNum.Clear();

g_BundleConfig.Clear();

g_BuyGold.Clear();

g_BuyStamina.Clear();

g_CV.Clear();

g_Camera.Clear();

g_CameraShake.Clear();

g_Card.Clear();

g_CardAsset.Clear();

g_CardAttrGrow.Clear();

g_CardAudio.Clear();

g_CardEnhanceLevel.Clear();

g_CardEx.Clear();

g_CardExpItem.Clear();

g_CardFile.Clear();

g_CardFileLevel.Clear();

g_CardFrame.Clear();

g_CardLevel.Clear();

g_CardPiece.Clear();

g_CardPoolType.Clear();

g_CardResolve.Clear();

g_CardStar.Clear();

g_CardStarItem.Clear();

g_CardTrain.Clear();

g_Channel.Clear();

g_Character.Clear();

g_CharacterAsset.Clear();

g_CharacterContacts.Clear();

g_CharacterIntimacyDialog.Clear();

g_Circle.Clear();

g_CircleReply.Clear();

g_CityCopy.Clear();

g_CityCopyFloor.Clear();

g_CityCopyFloorDesc.Clear();

g_CityWork.Clear();

g_CityWorkTask.Clear();

g_CityWorkTaskDrop.Clear();

g_CommonAward.Clear();

g_Condition.Clear();

g_CoolDown.Clear();

g_CoolDownTimeInfo.Clear();

g_Device.Clear();

g_DeviceAdapter.Clear();

g_Dialog.Clear();

g_DialogAvatar.Clear();

g_Divination.Clear();

g_DivinationProgress.Clear();

g_DivinationReward.Clear();

g_DrawCardAdvanceCard.Clear();

g_DrawCardNormalCard.Clear();

g_DrawCardPreview.Clear();

g_Dressup.Clear();

g_DropPreview.Clear();

g_EffectAsset.Clear();

g_Emoji.Clear();

g_Enviroment.Clear();

g_EverydaySign.Clear();

g_Example.Clear();

g_ExtraConfig.Clear();

g_FateDialog.Clear();

g_FateLine.Clear();

g_FateLineAvatar.Clear();

g_FateLineLevel.Clear();

g_FirstGift.Clear();

g_FuliAddSign.Clear();

g_FuliAddSignAward.Clear();

g_FuliDailyStamina.Clear();

g_FuliDailyStaminaDialog.Clear();

g_FuliFund.Clear();

g_FuliLottery.Clear();

g_FuliNormal.Clear();

g_FuliRecharge.Clear();

g_FuliRiddleCage.Clear();

g_FunctionUnlock.Clear();

g_Gift.Clear();

g_Goto.Clear();

g_Guide.Clear();

g_GuideEx.Clear();

g_Hardware.Clear();

g_HeartBeat.Clear();

g_HeartBeatAction.Clear();

g_HeartBeatDialog.Clear();

g_HeartBeatQuestion.Clear();

g_HelpTips.Clear();

g_Hexagram.Clear();

g_InteractGamePlay.Clear();

g_InteractSpecialSound.Clear();

g_Interflow.Clear();

g_IntimacyLevel.Clear();

g_Item.Clear();

g_ItemPageType.Clear();

g_LevelPlotDesc.Clear();

g_Loading.Clear();

g_LoadingScene.Clear();

g_LoadingText.Clear();

g_LoadingTexture.Clear();

g_LocalizationData.Clear();

g_MainSceneCarouselMap.Clear();

g_MainSceneTimeSceneEnv.Clear();

g_MisReputationLevel.Clear();

g_Mission.Clear();

g_MissionItem.Clear();

g_MissionMail.Clear();

g_MonthCard.Clear();

g_Node.Clear();

g_Notice.Clear();

g_NoticeType.Clear();

g_NoviceGuide.Clear();

g_Npc.Clear();

g_NpcLevel.Clear();

g_NpcQuestion.Clear();

g_NpcState.Clear();

g_NpcTask.Clear();

g_Npclike.Clear();

g_OptItem.Clear();

g_PersonalChapterAward.Clear();

g_PersonalStory.Clear();

g_Personality.Clear();

g_PersonalityData.Clear();

g_PersonalityLevel.Clear();

g_PersonalityMonologue.Clear();

g_PersonalityProcess.Clear();

g_PersonalityQuestion.Clear();

g_PlayerLevel.Clear();

g_Plot.Clear();

g_PlotInteraction.Clear();

g_Preloader.Clear();

g_ProductIDMap.Clear();

g_PushNotification.Clear();

g_PuzzleLevelData.Clear();

g_PuzzleThought.Clear();

g_PuzzleThoughtSet.Clear();

g_Question.Clear();

g_RechargeGift.Clear();

g_RechargeRule.Clear();

g_Retrieval.Clear();

g_RewardPreview.Clear();

g_Role.Clear();

g_Rumor.Clear();

g_RumorRewardRule.Clear();

g_RumorSub.Clear();

g_RumorSubSet.Clear();

g_SavePoint.Clear();

g_SceneClass.Clear();

g_SceneClassRandomEntry.Clear();

g_SceneEventCategory.Clear();

g_SceneEventDesc.Clear();

g_SceneNode.Clear();

g_SceneNpc.Clear();

g_SceneNpcCreateRule.Clear();

g_SceneNpcReplace.Clear();

g_SceneObject.Clear();

g_SceneTimeChange.Clear();

g_ScreenFade.Clear();

g_Secret.Clear();

g_SecretDesc.Clear();

g_SecretKeyword.Clear();

g_Selection.Clear();

g_ServerList.Clear();

g_ShopCommon.Clear();

g_ShopDiamond.Clear();

g_ShopGiftItem.Clear();

g_ShopType.Clear();

g_ShopTypeDialog.Clear();

g_Signboard.Clear();

g_SignboardDecals.Clear();

g_SignboardTheme.Clear();

g_Skill.Clear();

g_SkillEx.Clear();

g_SkinData.Clear();

g_SpecialClue.Clear();

g_SpecialLevelGamePlay.Clear();

g_StoryChapter.Clear();

g_StoryChapterCheckpoint.Clear();

g_StoryChapterEnding.Clear();

g_StoryChapterEndingDesc.Clear();

g_StoryChapterEndingRule.Clear();

g_StoryChapterLevel.Clear();

g_StoryChapterLevelReq.Clear();

g_StoryChapterLevelReward.Clear();

g_StoryChapterLevelRule.Clear();

g_StoryChapterLevelSceneEvent.Clear();

g_StoryChapterRule.Clear();

g_StoryLine.Clear();

g_StrDictionary.Clear();

g_StrFilter.Clear();

g_SystemMail.Clear();

g_TagData.Clear();

g_Task.Clear();

g_TaskAward.Clear();

g_TaskGroup.Clear();

g_TaskTab.Clear();

g_TeleportPoint.Clear();

g_Title.Clear();

g_TranlateDictionary.Clear();

g_TranlateDictionaryEn.Clear();

g_UIDictionary.Clear();

g_UIItemExtension.Clear();

g_UIPackage.Clear();

g_UIPanel.Clear();

g_UIRedDot.Clear();

g_VChat.Clear();

g_VChatEmoji.Clear();

g_VChatGroup.Clear();

g_VChatMsg.Clear();

g_VChatOption.Clear();

g_VoiceData.Clear();

g_VoiceExtraConfig.Clear();

}


}
}

