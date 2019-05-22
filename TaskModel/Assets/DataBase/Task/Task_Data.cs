using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Task_Data{
    public static string[] Learn_Threshold = new string[7] { "None", "Level 1 Over", "Level 2 Over", "Level 3 Over", "Level 4 Over", "Level 5 Over", "Level 1~6 Over" };
    public static string[] Learn_Request = new string[7] { "Complete the Level 1！", "Complete the Level 2！", "Complete the Level 3！", "Complete the Level 4！", "Complete the Level 5！", "Complete the Level 6！", "Complete the Overall！" };
    public static string[] Learn_Reward = new string[7] { "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "Crystal" };
    public static string[] Learn_Punishment = new string[7] { "Crystal", "Crystal", "Crystal", "Crystal", "Crystal", "crystal", "Crystal" };

    public static void Learn_Get()
    {
        //宣告 Task_Class 陣列 Start
        Task_Class[] task_temp = new Task_Class[7];
        for(int i = 0; i < 7; i++)
        {
            task_temp[i] = new Task_Class();
        }
        //宣告 Task_Class 陣列 End

        //加入資料至 task_temp  Start
        for (int i = 0; i < 7; i++)
        {
            task_temp[i] = new Task_Class();
        }
        //加入資料至 task_temp End

    }
}
