using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //Material������
    Material myMaterial;
    //�p�x
    private int degree = 0;

    //���_��\������e�L�X�g
    private GameObject scoreText;
    //���_
    private int score = 0;

    //�I�u�W�F�N�g�̓_��
    private int a;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������Score�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("Score");
        //�^�O�ɂ���ē��_��ς���
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
            //�Փˎ�score�ɓ��_�����Z����
            score += a;

        }
    }
    //�Փˎ��ɌĂ΂��֐�
    private void OnCollisionEnter(Collision other)
    {
        //�p�x��180�ɐݒ�
        this.degree = 180;
    }
    scoreText.GetComponent<Text>().text = score;
}
