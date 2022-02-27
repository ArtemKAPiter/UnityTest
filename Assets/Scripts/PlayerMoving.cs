using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public GameObject[] pillars;//array on pillar
    private Transform target; 
    public float speed;//our character speed
    Vector3 startPosition;//our current state
    float step;
    public bool goBack;//boolean variable goBack at first is false, because person is standing
    int myCharacter;
    void Start()
    {
        startPosition = transform.position;//our first position
        step = speed * Time.deltaTime;//
        myCharacter = 2;
    }

    void Update()
    {
        target = transform;
        if (goBack == true){ // if boolean variable (goBack) is true we are calling method MoveBack() and charactar is going back
            MoveBack();
        }

        for (int i = 0; i <= 2; i++)// here we are getting numbers from 0 to 3 to our array
        {
            if (pillars[i].tag == "2" && gameObject.tag=="1") {//if pillar is blue is going first character

                transform.position = Vector3.MoveTowards(transform.position, pillars[i].transform.position, step);//our person moving to pillar
                goBack = false;

            }
            if (pillars[i].tag == "1" && gameObject.tag == "2") //if pillar is green is going second character 
            {
                transform.position = Vector3.MoveTowards(transform.position, pillars[i].transform.position, step);//our person moving to pillar
                goBack = false;
            }
            else
            {
                randomPlayer();
            }


        }
    }
        
    
    public void MoveBack()//method to go back
    {
        transform.position = Vector3.MoveTowards(transform.position, startPosition, step);//we are changing our character position an it is going back 
            }
    void randomPlayer()
    {
        Debug.Log(myCharacter);
        for (int i = 0; i <= 2; i++)
        {
            
                if (pillars[i].tag == "0" && gameObject.tag == myCharacter.ToString())// if pillar color is red character to fix is random character which is calling with method callRandomPerson
                {
                    transform.position = Vector3.MoveTowards(transform.position, pillars[i].transform.position, step);
                    goBack = false;
               

                }
            }
           
           
        }
        }
    

