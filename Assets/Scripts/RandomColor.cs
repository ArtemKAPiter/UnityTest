using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{

    public int randomColor;
    public int myTag;

   public void RandomCall()
    {
        randomColor = Random.Range(0, 3);//��������� ���������� �����, �� 0 �� 3 
        myTag = randomColor;//������������� ���������� myTag ���������� � ��������������� ������, ��� ���� ����� ������ ��� ������ � ������ 37 ������� ColorChanger
    }
}


