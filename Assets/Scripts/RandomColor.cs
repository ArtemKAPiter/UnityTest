using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{

    public int randomColor;
    public int myTag;

   public void RandomCall()
    {
        randomColor = Random.Range(0, 3);//Random number generation from 0 to 3 
        myTag = randomColor;//Integer variable equate to Random number
    }
}


