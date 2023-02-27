using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daziji : MonoBehaviour
{
    //定义显示文字
    private string Words = "点击下方炮台图标安装炮台，防守外星来客入侵。您有5秒钟的准备时间";
    public Text TxtText;
    public GameObject ThisGameObject;
    public GameObject XianJiGb;
    public GameObject NixtXianJiGb;
    public GameObject UI5s;


    private Queue<char> _NeedShow = new Queue<char>();//泛型集合（存储文字）

    char chGetword; private string _Showed = string.Empty;
    private string _strAllShowInfo = string.Empty;
    public float JianGeTime = 0.1F;

    // Use this for initialization
    void Start()
    {
        
        foreach (var item in Words)
        {
            _NeedShow.Enqueue(item);
        }
        StartShow();

    }
    private void StartShow()
    {
        //启动调用函数
        InvokeRepeating("_StrAllShowInfo", 0F, JianGeTime);
    }
    private void _StrAllShowInfo()
    {
        if (_NeedShow.Count > 0)
        {
            chGetword = _NeedShow.Dequeue();//出队列，数据输出
            _strAllShowInfo = _Showed + chGetword;//把显示过的字符和新输出的字符相连接
            _Showed += chGetword;//将新输出的字符追加到变量
            TxtText.text = _strAllShowInfo;//将变量赋值给控件

            if (_strAllShowInfo.Length >= Words.Length)//判断是否完全显示
            {
                CancelInvoke("_StrAllShowInfo");//停止调用函数

                _Showed = string.Empty;
                _strAllShowInfo = string.Empty;
                _NeedShow.Clear();
                ThisGameObject.SetActive(false);
                XianJiGb.SetActive(false);
                NixtXianJiGb.SetActive(true);
                UI5s.SetActive(true);
            }
        }
    }
}
