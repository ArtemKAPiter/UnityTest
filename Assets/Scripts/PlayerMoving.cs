using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public GameObject[] pillars;//������ �� ������
    private Transform target; 
    public float speed = 1.0f;//�������� ������ ���������, ��-�� public ����� ������ ����� � ����������
    Vector3 startPosition;//��������� �������
    float step;//����������, ������ �����
    public bool goBack;//������� ���������� goBack ���������� ������, ��� ��� �������� ����� �� �����
    private Quaternion _lookRotation;

    void Start()
    {
        startPosition = transform.position;//���� ��������� �������
        step = speed * Time.deltaTime;//
    }

    void Update()
    {
        target = transform;
        if (goBack == true){ //���� ������� ���������� goBack �������� �� �������� ����� MoveBack() � �������� ���� �������
            MoveBack();
        }

        for (int i = 0; i <= 2; i++)//��� � ����� for �������� ��� ���� 3 �����, �� 0 �� 2 � ������ ������ ��������
        {
            if (pillars[i].tag == "0"|| pillars[i].tag == "2" && gameObject.tag=="1") {//���������, ����� ��� �� ���������� ������, ��� � ������� � � ����� �������

                transform.position = Vector3.MoveTowards(transform.position, pillars[i].transform.position, step);//�������� ������ ���������, � ������, ������� ��� ������ � �������
                    goBack = false;

            }
            else if (pillars[i].tag == "0" || pillars[i].tag == "1" && gameObject.tag == "2") //���������, ����� ��� �� ���������� ������, ��� � ������� � � ������� �������
            {

                transform.position = Vector3.MoveTowards(transform.position, pillars[i].transform.position, step);//�������� ������ ���������, � ������, ������� ��� ������ � �������
                    goBack = false;

            }

        }
    }
        
    
    public void MoveBack()//����� ��� ����������� �������
    {
        transform.position = Vector3.MoveTowards(transform.position, startPosition, step);//������ ������� ���������, �� ��, ��� �� ��� ���������� � ������������� �� ��������� step

    }
}
