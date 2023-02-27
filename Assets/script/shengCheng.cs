using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shengCheng : MonoBehaviour
{
    /// <summary>
    /// UFO预制体
    /// </summary>
    public GameObject UFO;
     float time ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //计时器
        time += Time.deltaTime;
        if (time>=0.5f)
        {
            GameObject gb = GameObject.Instantiate(UFO, transform.position, transform.rotation) as GameObject;
            time = 0;
        }
        
    }
}
