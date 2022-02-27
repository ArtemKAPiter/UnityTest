using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFixing : MonoBehaviour
{
    public Material fixMaterial;//����� ����
    public ColorChanger script;//������ � ���������� �����
    public PlayerMoving script1;//������ � ��������� ���������

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == gameObject.tag)
        {
            other.tag = "3";//��� ������, � �������� ������������ ������������ � 3
            other.GetComponent<Renderer>().material = fixMaterial;//���� ������, � �������� ������������ ������ �� ����� 
            script.Start();//�������� ����� start ��� ���� ����� �� ������ ������ ��������� ����� ��� ���������� ������ � ���������� �����
            script.enabled = true;//�������� ������ � ���������� �����
            script1.goBack = true;//������� ���������� goBack �� ������� ��������(PlayerMoving) ������ �������� , ����� �������� ����� �������
        }
    }

}
