using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{

    public int randomColor;
    public int myTag;

   public void RandomCall()
    {
        randomColor = Random.Range(0, 3);//Генерация рандомного числа, от 0 до 3 
        myTag = randomColor;//целочисленную переменную myTag уравниваем с сгенерированным числом, для того чтобы задать тег столбу в строке 37 скрипта ColorChanger
    }
}


