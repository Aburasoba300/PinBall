using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //���_��\������e�L�X�g
    private Text scoreText;
    
    //���_
    private int score = 0;
    

    //�X�R�A���Z�֐�
    private void AddScore(int a)
    {
        //�X�R�A���Z
        score += a;

        //int�^��string�^�ɕϊ�
        scoreText.text = score.ToString();
    }


    //�Փˎ��ɌĂ΂��֐�
    private void OnCollisionEnter(Collision collision)
    {
        //�m�FDebug.Log("OncollisionEnter�J�n");


        //�^�O�ɂ���ē��_��ς���
        if (collision.gameObject.CompareTag("SmallStarTag"))
        {
            //�m�FDebug.Log("if��1");
            
            AddScore(5);
        }
        else if (collision.gameObject.CompareTag("LargeStarTag"))
        {
            //�m�FDebug.Log("if��2");
            
            AddScore(10);
        }
        else if (collision.gameObject.CompareTag("SmallCloudTag") || collision.gameObject.CompareTag("LargeCloudTag"))
        {
            //�m�FDebug.Log("if��3");
            
            AddScore(20);
        }
        
        //�m�FDebug.Log("OncollisionEnter�I��");
        

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         //�V�[������Score�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("Score").GetComponent<Text>();

        //int�^��string�^�ɕϊ�
        scoreText.text = score.ToString();
        
    }
 
}
