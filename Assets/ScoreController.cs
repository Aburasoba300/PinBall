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
        Debug.Log("OncollisionEnter�J�n");
        //�X�R�A�����Z
        score += a;
        Debug.Log("OncollisionEnter�I��");
    }
    // Start is called before the first frame update
    void Start()
    {

        //�^�O�ɂ���ē��_��ς���
        if (tag == "SmallStarTag")
        {
            Debug.Log("if��1");
            a = 5;
        }
        else if (tag == "LargeStarTag")
        {
            Debug.Log("if��2");
            a = 10;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            Debug.Log("if��3");
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
