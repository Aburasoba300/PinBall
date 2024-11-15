using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //得点を表示するテキスト
    private Text scoreText;
    //得点
    private int score = 0;

    int a;


    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision other)
    {
        //スコアを加算
        score += a;
    }
    // Start is called before the first frame update
    void Start()
    {

        //タグによって得点を変える
        if (tag == "SmallStarTag")
        {
            a = 5;
        }
        else if (tag == "LargeStarTag")
        {
            a = 10;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            a = 20;
        }
        

        //シーン中のScoreオブジェクトを取得
        this.scoreText = GameObject.Find("Score").GetComponent<Text>();

        //int型をstring型に変換
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}
