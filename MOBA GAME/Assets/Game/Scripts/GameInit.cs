using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 游戏初始化脚本
/// </summary>
public class GameInit : MonoBehaviour
{
    void Start()
    {
        //加载登录UI
        UIManager.Instance.ShowUIPanel(UIDefinit.UIAccount);
    }
}
