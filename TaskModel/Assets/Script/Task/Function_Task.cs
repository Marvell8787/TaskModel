using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
static class Check
{
    public static string s = "";
}
public class Function_Task : MonoBehaviour {
    void Start()
    {
        ClearAllText();

        Task_Data.Learn_Init();
        Task_Data.Battle_Init();
    }
    public void GetLearnData()
    {
        Check.s = "learn";
        ClearAllText();
        Task_Class[] learn_temp = new Task_Class[7];
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
        Check.s = "battle";
        ClearAllText();
        Task_Class[] battle_temp = new Task_Class[3];
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
        t_temp = GameObject.Find("Text_ThresholdContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_RequestContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_RewardContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_PunishmentContent").GetComponent<Text>();
        t_temp.text = "";
    }
    public void PressContent_1()
    {
        ShowContent(Check.s, 0);
    }
    public void PressContent_2()
    {
        ShowContent(Check.s, 1);
    }
    public void PressContent_3()
    {
        ShowContent(Check.s, 2);
    }
    public void PressContent_4()
    {
        ShowContent(Check.s, 3);
    }
    public void PressContent_5()
    {
        ShowContent(Check.s, 4);
    }
    public void PressContent_6()
    {
        ShowContent(Check.s, 5);
    }
    public void PressContent_7()
    {
        ShowContent(Check.s, 6);
    }

    public void ShowContent(string s,int n)
    {
        Text t_temp;
        Task_Class task_temp = new Task_Class();
        if (s == "learn")
            task_temp = Task_Data.Learn_Get(n);
        else if (s == "battle")
            task_temp = Task_Data.Battle_Get(n);

        t_temp = GameObject.Find("Text_ThresholdContent").GetComponent<Text>();
        t_temp.text = task_temp.GetThreshold();
        t_temp = GameObject.Find("Text_RequestContent").GetComponent<Text>();
        t_temp.text = task_temp.GetRequest();
        t_temp = GameObject.Find("Text_RewardContent").GetComponent<Text>();
        t_temp.text = task_temp.GetReward();
        t_temp = GameObject.Find("Text_PunishmentContent").GetComponent<Text>();
        t_temp.text = task_temp.GetPunishment();
    }
}
