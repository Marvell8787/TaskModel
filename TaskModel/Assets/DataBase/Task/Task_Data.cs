﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Task_Data{
    public static string[] Learn_Title = new string[7] { "Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6", "Overall" };
    public static string[] Learn_Threshold = new string[7] { "None", "Level 1's Over", "Level 2's Over", "Level 3's Over", "Level 4's Over", "Level 5's Over", "Level 1~6're Over" };
    public static string[] Learn_Request = new string[7] { "Complete the Level 1！", "Complete the Level 2！", "Complete the Level 3！", "Complete the Level 4！", "Complete the Level 5！", "Complete the Level 6！", "Complete the Overall！" };
    public static string[] Learn_Reward = new string[7] { "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "Crystal" };
    public static string[] Learn_Punishment = new string[7] { "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "crystal", "Crystal" };

    public static string[] Battle_Title = new string[3] { "Battle 1", "Battle 2", "Battle 3" };
    public static string[] Battle_Threshold = new string[3] { "None", "Battle 1's Over", "Battle 2's Over"};
    public static string[] Battle_Request = new string[3] { "Get 1 win in Battle", "Get 3 win in Battle", "Get 5 win in Battle" };
    public static string[] Battle_Reward = new string[3] { "Crystal", "Crystal", "Crystal"};
    public static string[] Battle_Punishment = new string[3] { "Crystal", "Crystal", "Crystal"};

    public static Task_Class[] learn_temp = new Task_Class[7];
    public static Task_Class[] battle_temp = new Task_Class[3];
    public static void Learn_Init()
    {
        //宣告 learn_temp 陣列並加入資料 Start
        
        for(int i = 0; i < 7; i++)
        {
            learn_temp[i] = new Task_Class(Learn_Title[i], Learn_Threshold[i], Learn_Request[i], Learn_Reward[i], Learn_Punishment[i]);
        }
        //宣告 learn_temp 陣列並加入資料 End
        Debug.Log(learn_temp[2].GetTitle());
    }
    public static Task_Class Learn_Get(int n)
    {
        return learn_temp[n];
    }
    public static void Battle_Init()
    {
        //宣告 battle_temp 陣列並加入資料 Start

        for (int i = 0; i < 3; i++)
        {
            battle_temp[i] = new Task_Class(Battle_Title[i], Battle_Threshold[i], Battle_Request[i], Battle_Reward[i], Battle_Punishment[i]);
        }
        //宣告 battle_temp 陣列並加入資料 End
    }
    public static Task_Class Battle_Get(int n)
    {
        return battle_temp[n];
    }
}
