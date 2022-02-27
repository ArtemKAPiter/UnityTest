using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFixing : MonoBehaviour
{
    public Material fixMaterial;//серый цвет
    public ColorChanger script;//Скрипт с изменением цвета
    public PlayerMoving script1;//Скрипт с движением персонажа

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
            other.tag = "3";//тег столба, к которому прикоснулись приравниваем к 3
            other.GetComponent<Renderer>().material = fixMaterial;//цвет столба, к которому прикоснулись меняем на серый 
            script.Start();//Вызываем метод start для того чтобы он вызвал методы генерации чисел для случайного столба и случайного цвета
            script.enabled = true;//включаем скрипт с изменением цвета
            script1.goBack = true;//булевую переменную goBack из скрипта движения(PlayerMoving) делаем истингой , чтобы персонаж пошел обратно
        }
    }

}
