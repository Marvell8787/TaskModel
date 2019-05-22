using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Task_Class {
    public static string Threshold ="";
    public static string Request = "";
    public static string Reward = "";
    public static string Punishment = "";
    public static int Status = 0;
    public Task_Class(string _Threshold, string _Request, string _Reward, string _Punishment)
    {
        Threshold = _Threshold;
        Request = _Request;
        Reward = _Reward;
        Punishment = _Punishment;
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
    public void ChangeStatus(int n)
    {
        Status = n;
    }
}
