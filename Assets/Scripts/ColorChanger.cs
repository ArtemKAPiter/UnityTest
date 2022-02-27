using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material[] colors;//������ � �����������(�������, ������� � �����)
    public GameObject[] pillar;//������ �� ��������(1,2,3)
    float timer = 5f;//��������� �����
    float delayTimer = 5f;//����� ��� ������������� �������, ����� ���� �������� � ��� timer = 5;(38 ������)
    public RandomPillar script1;//������ � ������� ��������� �����, ��� ������
    public RandomColor script2;//������ � ������� ��������� �����, ��� ���������






    public void Start()
    {
        script1.RandomCall();//�������� ����� ��� ��������� ����� ������
        script2.RandomCall();//�������� ����� ��� ��������� ����� �����

    }


    void Update()
    {
        
        timer -= Time.deltaTime;//�������� �����

        if (pillar[0].tag == "3" && pillar[1].tag == "3" && pillar[2].tag == "3")//�������, ���� ��� 3 ������ ����� ���� 3, ��� 3 �������� ��� ��� ��� 3 ������ �����)
        {
            if (timer <= 0)
            {
                pillar[script1.randompillar].GetComponent<Renderer>().material = colors[script2.randomColor];//��� � �����, ����� �������� ���� ����� ������� ������� ������ ��������, ������� ���� ��� ������������
                pillar[script1.randompillar].tag = script2.myTag.ToString();//������ ��� ������(�� 0 �� 2) 
                timer = delayTimer;//������������ � delayTimer, ����� ����� ����� 5 ������
                enabled = false;//�������� ��������� ������ ������
            }

        }
      
    }
 
}
