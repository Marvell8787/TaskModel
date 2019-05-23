using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Function_Task : MonoBehaviour {
    private Task_Class[] learn_temp = new Task_Class[7];
    private Task_Class[] battle_temp = new Task_Class[3];
    private bool learn_flag = false;
    private bool battle_flag = false;
    void Start()
    {
        ClearAllText();
        Task_Data.Learn_Init();
        Task_Data.Battle_Init();
    }
    public void GetLearnData()
    {
        learn_flag = true;
        battle_flag = false;
        ClearAllText();
        for (int i =0; i < 7; i++){
            learn_temp[i] = Task_Data.Learn_Get(i);
        }

        Text t_temp;
        for (int i = 0; i < 7; i++)
        {
            t_temp = GameObject.Find("Text_Task_" + (i + 1).ToString()).GetComponent<Text>();
            t_temp.text = learn_temp[i].GetTitle();
            switch (learn_temp[i].GetStatus())
            {
                case 0: //未接
                    t_temp.color = Color.black;
                    break;
                case 1: //接下
                    t_temp.color = Color.blue;
                    break;
                case 2: //失敗
                    t_temp.color = Color.red;
                    break;
                case 3: //成功
                    t_temp.color = Color.green;
                    break;
                case 4: //完成
                    t_temp.color = Color.gray;
                    t_temp.fontStyle = FontStyle.Italic;
                    break;
            }
        }

    }

    public void GetBattleData()
    {
        learn_flag = false;
        battle_flag = true;
        ClearAllText();
        for (int i = 0; i <3 ; i++)
        {
            battle_temp[i] = Task_Data.Battle_Get(i);
        }

        Text t_temp;
        for (int i = 0; i < 3; i++)
        {
            t_temp = GameObject.Find("Text_Task_" + (i+1).ToString()).GetComponent<Text>();
            t_temp.text = battle_temp[i].GetTitle();
            switch(battle_temp[i].GetStatus())
            {
                case 0: //未接
                    t_temp.color = Color.black;
                    break;
                case 1: //接下
                    t_temp.color = Color.blue;
                    break;
                case 2: //失敗
                    t_temp.color = Color.red;
                    break;
                case 3: //成功
                    t_temp.color = Color.green;
                    break;
                case 4: //完成
                    t_temp.color = Color.gray;
                    t_temp.fontStyle = FontStyle.Italic;
                    break;
            }
        }
    }

    public void BackHome()
    {
        Debug.Log("BackHome");
    }
    public void ClearAllText()
    {
        Text t_temp;
        for(int i = 0; i < 7; i++)
        {
            t_temp = GameObject.Find("Text_Task_" + (i+1).ToString() ).GetComponent<Text>();
            t_temp.text = "";
        }
    }
    public void ShowContent()
    {
        Text t_temp;

        if (learn_flag)
        {
            t_temp = GameObject.Find("Text_ThresholdContent").GetComponent<Text>();
            t_temp.text = learn_temp[0].GetThreshold();
            Debug.Log("ok");
        }
        else if (battle_flag)
        {
            t_temp = GameObject.Find("Text_ThresholdContent").GetComponent<Text>();
            t_temp.text = battle_temp[0].GetThreshold();
        }



    }
}
