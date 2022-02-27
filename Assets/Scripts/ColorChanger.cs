using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material[] colors;//Массив с материалами(Красный, зеленый и синий)
    public GameObject[] pillar;//Массив со столбами(1,2,3)
    float timer = 5f;//Начальное время
    float delayTimer = 5f;//Время для приравнивания таймера, можно было записать и так timer = 5;(38 строка)
    public RandomPillar script1;//Скрипт с вызовом генерации числа, для столба
    public RandomColor script2;//Скрипт с вызовом генерации числа, для материала






    public void Start()
    {
        script1.RandomCall();//Вызываем метод для генерации числа столба
        script2.RandomCall();//Вызываем метод для генерации числа цвета

    }


    void Update()
    {
        
        timer -= Time.deltaTime;//Отнимаем время

        if (pillar[0].tag == "3" && pillar[1].tag == "3" && pillar[2].tag == "3")//Сверяем, если все 3 столба равны тегу 3, тег 3 означает что они все 3 серего цвета)
        {
            if (timer <= 0)
            {
                pillar[script1.randompillar].GetComponent<Renderer>().material = colors[script2.randomColor];//Тут в столб, число которого было равно индексу массива вешаем материал, который тоже был сгенерирован
                pillar[script1.randompillar].tag = script2.myTag.ToString();//Задаем тег столбу(От 0 до 2) 
                timer = delayTimer;//Приравниваем к delayTimer, чтобы время стало 5 секунд
                enabled = false;//Временно отключаем данный скрипт
            }

        }
      
    }
 
}
