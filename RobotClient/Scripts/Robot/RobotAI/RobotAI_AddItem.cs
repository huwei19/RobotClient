using UnityEngine;
using System.Collections;

public class RobotAI_AddItem : RobotAIBase
{
    private static int[] itemArray99 = new int[]
    {
        3000, 3000,
        3101, 3102,
        3300, 3309,
        4002, 4002,
        4212, 4212,
        8000, 8001,
        13201, 13210,
        15401,15409,
    };

    private static int[] itemArray1 = new int[]
    {
        37000, 37022,
        3101, 3102,
        3300, 3309,
        4002, 4002,
        4212, 4212,
        8000, 8001,
       
    };

    private static int[] itemJumpArray1 = new int[]
    {
        41100,6, 100,
        41104,6, 100,

    };

    public RobotAI_AddItem(Robot curRobot)
        : base(curRobot)
    {
        for(int i=0; i<itemArray99.Length;)
        {
            for(int itemStartID =itemArray99[i]; itemStartID<itemArray99[i+1]; itemStartID++)
            {
                string strSend = "item," + itemStartID.ToString() + ",99";
                curRobot.SendCMD(strSend);
            }
            i += 2;
        }

        for (int i = 0; i < itemArray1.Length;)
        {
            for (int itemStartID = itemArray1[i]; itemStartID < itemArray1[i + 1]; itemStartID++)
            {
                string strSend = "item," + itemStartID.ToString() + ",1";
                curRobot.SendCMD(strSend);
            }
            i += 2;
        }

        for (int i = 0; i < itemJumpArray1.Length;)
        {
            for (int jumpCount =0; jumpCount < itemJumpArray1[i + 1];jumpCount++)
            {
                string strSend = "item," + (itemJumpArray1[i] + jumpCount * itemJumpArray1[i+2]).ToString() + ",1";
                curRobot.SendCMD(strSend);
            }
            i += 3;
        }

        for(int i=0; i<50; i++)
        {
            curRobot.SendCMD("mails");
        }
    }

    public override string getName()
    {
        return "AddItem";
    }
}
