using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lujing : MonoBehaviour
{
    /// <summary>
    /// 目标点路径
    /// </summary>
    public Transform[] UfoLJ;
    /// <summary>
    /// 目标点下标
    /// </summary>
    private int index = 0;
    /// <summary>
    /// 速度
    /// </summary>
    public static int i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 让我们的物体朝目标移动
        transform.LookAt(UfoLJ[i % UfoLJ.Length]);
        transform.Translate(Vector3.forward * Time.deltaTime * 5);

    }
    public static void add() {
        i++;
        Debug.Log("加一个");
    }

    
}
