using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Task_Learn : MonoBehaviour {

    public void GetLearnData()
    {

        Task_Class[] task_temp = new Task_Class[7];
        task_temp = Task_Data.Learn_Get();
        Debug.Log(task_temp[0].GetThreshold());
    }
}
