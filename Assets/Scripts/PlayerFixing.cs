using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFixing : MonoBehaviour
{
    public Material fixMaterial;//gray color
    public ColorChanger script;//script with color changing
    public PlayerMoving script1;//script with person moving
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
            other.tag = "3";//tag of pillar which we touched is 3
            other.GetComponent<Renderer>().material = fixMaterial;//color of pillar which we touched is gray
            script.Start();//calling start method, to generate pillar and color numbers
            script.enabled = true;//enable script with color changing
            script1.goBack = true;//boolean goBack from (PlayerMoving) we ar making true ,  to make the character go back 
        }
    }

}
