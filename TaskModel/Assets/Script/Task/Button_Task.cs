using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Task : MonoBehaviour {

    public void GetLearnData()
    {
        Task_Data.Learn_Init();
       /* Task_Class[] task_temp = new Task_Class[7];
        for (int i =0; i < 7; i++){
            task_temp[i] = Task_Data.Learn_Get(i);
        }
        Debug.Log(task_temp[0].GetTitle());*/
        
    }

    public void GetBattleData()
    {
       /* Task_Data.Battle_Init();
        Task_Class[] task_temp = new Task_Class[3];
        for (int i = 1; i <2 ; i++)
        {
            task_temp[i] = Task_Data.Battle_Get(i);
        }
        Debug.Log(task_temp[1].GetTitle());
    */}

    public void BackHome()
    {
        Debug.Log("BackHome");
    }
}
