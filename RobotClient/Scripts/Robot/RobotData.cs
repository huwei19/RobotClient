using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class Robot  {

    public PlayerData mainPlayer = new PlayerData();
    public SceneData sceneData = new SceneData();
    public Dictionary<int, NpcData> npcs = new Dictionary<int, NpcData>();
    public StoryData mStoryData = new StoryData();
    public FriendManagerComponent mFriendData = new FriendManagerComponent();

    public StoryLogic mStoryLogic = new StoryLogic();
   
}
