using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class StarController : MonoBehaviour
{
    private float rotspeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0,this.rotspeed,0);
    }
}
