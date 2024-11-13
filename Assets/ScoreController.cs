using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //Materialを入れる
    Material myMaterial;
    //角度
    private int degree = 0;

    //得点を表示するテキスト
    private GameObject scoreText;
    //得点
    private int score = 0;

    //オブジェクトの点数
    private int a;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreオブジェクトを取得
        this.scoreText = GameObject.Find("Score");
        //タグによって得点を変える
        if (tag == "SmallStar") 
        {
            a = 5;
        }
        else if (tag == "LargeStar") 
        {
            a = 10;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag") 
        {
            a = 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(this.degree >= 0)
        {
            //衝突時scoreに得点を加算する
            score += a;

        }
    }
    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision other)
    {
        //角度を180に設定
        this.degree = 180;
    }
    scoreText.GetComponent<Text>().text = score;
}
