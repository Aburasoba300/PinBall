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

    int a;


    //�Փˎ��ɌĂ΂��֐�
    private void OnCollisionEnter(Collision other)
    {
        //�X�R�A�����Z
        score += a;
    }
    // Start is called before the first frame update
    void Start()
    {

        //�^�O�ɂ���ē��_��ς���
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
        

        //�V�[������Score�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("Score").GetComponent<Text>();

        //int�^��string�^�ɕϊ�
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}
