using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Task_Class {
    public static string Title = "";
    public static string Threshold ="";
    public static string Request = "";
    public static string Reward = "";
    public static string Punishment = "";
    public static int Status = 0;
    public Task_Class(string _Title,string _Threshold, string _Request, string _Reward, string _Punishment)
    {
        Title = _Title;
        Threshold = _Threshold;
        Request = _Request;
        Reward = _Reward;
        Punishment = _Punishment;
    }
    public string GetTitle()
    {
        return Title;
    }
    public string GetThreshold()
    {
        return Threshold;
    }
    public string GetRequest()
    {
        return Request;
    }
    public string GetReward()
    {
        return Reward;
    }
    public string GetPunishment()
    {
        return Punishment;
    }
    public int GetStatus()
    {
        return Status;
    }
    public void Overwrite(Task_Class t)
    {
        Title = t.GetTitle();
        Threshold = t.GetThreshold();
        Request = t.GetRequest();
        Reward = t.GetReward();
        Request = t.GetRequest();
        Punishment = t.GetPunishment();
    }
    public void ChangeStatus(int n)
    {
        Status = n;
    }
}
