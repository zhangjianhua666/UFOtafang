using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtClke : MonoBehaviour
{
    public GameObject ui1;
    public GameObject ui2;
    public GameObject uiChengGong;
    public GameObject uiShiBai;
    public void UIgo1() { ui1.SetActive(false);ui2.SetActive(true); }
    public void UIgo2() { }
    public void UIgoChengGong() { }
    public void UIgoShiBai() { }
    private void Start()
    {
        ui1.SetActive(true);
        ui2.SetActive(false);
        uiChengGong.SetActive(false);
        uiShiBai.SetActive(false);
    }
    /// <summary>
    /// 关闭游戏
    /// </summary>
    public void offPlay() {
        Application.Quit();
    }
    public void chonxingPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }


}
