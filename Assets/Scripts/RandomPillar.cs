using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPillar : MonoBehaviour
{
   public int randompillar;

    public void RandomCall()
    {
        randompillar = Random.Range(0, 3);//generation of piller number
    }
}
