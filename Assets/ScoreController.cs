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
    

    //スコア加算関数
    private void AddScore(int a)
    {
        //スコア加算
        score += a;

        //int型をstring型に変換
        scoreText.text = score.ToString();
    }


    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision collision)
    {
        //確認Debug.Log("OncollisionEnter開始");


        //タグによって得点を変える
        if (collision.gameObject.CompareTag("SmallStarTag"))
        {
            //確認Debug.Log("if文1");
            
            AddScore(5);
        }
        else if (collision.gameObject.CompareTag("LargeStarTag"))
        {
            //確認Debug.Log("if文2");
            
            AddScore(10);
        }
        else if (collision.gameObject.CompareTag("SmallCloudTag") || collision.gameObject.CompareTag("LargeCloudTag"))
        {
            //確認Debug.Log("if文3");
            
            AddScore(20);
        }
        
        //確認Debug.Log("OncollisionEnter終了");
        

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         //シーン中のScoreオブジェクトを取得
        this.scoreText = GameObject.Find("Score").GetComponent<Text>();

        //int型をstring型に変換
        scoreText.text = score.ToString();
        
    }
 
}
