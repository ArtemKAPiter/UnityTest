using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material[] colors;//array with colors
    public GameObject[] pillar;//array with pillars(1,2,3)
    float timer = 2f;//first time
    float delayTimer = 2f;//time to equate timer,also we can write (timer = 5;)(38 line)
    public RandomPillar script1;//script with number generation
    public RandomColor script2;//script with color generatin






    public void Start()
    {
        script1.RandomCall();//we are calling method to generate pillar
        script2.RandomCall();//we are calling method to generate color

    }


    void Update()
    {
        
        timer -= Time.deltaTime;//take away time

        if (pillar[0].tag == "3" && pillar[1].tag == "3" && pillar[2].tag == "3")//we are checking, if all pillars are gray, if their tag equals "3"
        {
            if (timer <= 0)
            {
                pillar[script1.randompillar].GetComponent<Renderer>().material = colors[script2.randomColor];//here we are putting material on our pilla
                pillar[script1.randompillar].tag = script2.myTag.ToString();//ask tag to pillar 
                timer = delayTimer;//equate to delayTimer, case make timer 5 seconds
                enabled = false;//temporarily disable script
            }

        }
      
    }
 
}
