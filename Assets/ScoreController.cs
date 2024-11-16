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
        Debug.Log("OncollisionEnter開始");
        //スコアを加算
        score += a;
        Debug.Log("OncollisionEnter終了");
    }
    // Start is called before the first frame update
    void Start()
    {

        //タグによって得点を変える
        if (tag == "SmallStarTag")
        {
            Debug.Log("if文1");
            a = 5;
        }
        else if (tag == "LargeStarTag")
        {
            Debug.Log("if文2");
            a = 10;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            Debug.Log("if文3");
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
