using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gonji : MonoBehaviour
{
    /// <summary>
    /// 血条图片
    /// </summary>
    public Image XieTiao;
    /// <summary>
    /// 剩余分数
    /// </summary>
    public Text numTxt;
    /// <summary>
    /// 总分数
    /// </summary>
    private int a = 10;
    /// <summary>
    /// 失败UI界面
    /// </summary>
    public GameObject shibaiUI;
    /// <summary>
    /// 游戏中UI
    /// </summary>
    public GameObject playUI;

    public GameObject UFO;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("攻击");
        a--;
        XieTiao.fillAmount -= 0.1F;
        numTxt.text = "10/" + a;
        Destroy(other.gameObject);
    }
    private void Update()
    {
        if (a<=0)
        {
            shibaiUI.SetActive(true);
            playUI.SetActive(false);
            UFO.SetActive(false);
        }
    }
}
