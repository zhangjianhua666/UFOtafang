using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daojishi : MonoBehaviour
{
    ///声明Text变量
    private Text txt;

    /// <summary>
    /// 游戏运行时间
    /// </summary>
    float timer;

    /// <summary>
    /// 倒计时多少秒
    /// </summary>
    private int second = 85;
   
    public GameObject thisUI;
    public GameObject nixtUI;

   
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //计时器（等一秒执行下面的代码）
        timer += Time.deltaTime;
        if (timer >= 1 && second > 0)
        {
            //倒计时减一秒
            second--;
            txt.text = $"剩余时间：{second / 60}:{second % 60}";
            timer = 0;
            if (second <= 10)
            {
                txt.color = Color.red;
            }
            if (second == 0)
            {
                thisUI.SetActive(false);
                nixtUI.SetActive(true);
            }
        }
    }
}
