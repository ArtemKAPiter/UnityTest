using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public GameObject[] pillars;//ћассив на столбы
    private Transform target; 
    public float speed = 1.0f;//—корость нашего персонажа, из-за public можно мен€ть пр€мо в инспекторе
    Vector3 startPosition;//начальна€ позици€
    float step;//ѕеременна€, назвал шагом
    public bool goBack;//Ѕулева€ переменна€ goBack изначально ложна€, так как персонаж стоит на месте
    private Quaternion _lookRotation;

    void Start()
    {
        startPosition = transform.position;//Ќаша начальна€ позици€
        step = speed * Time.deltaTime;//
    }

    void Update()
    {
        target = transform;
        if (goBack == true){ //≈сли булева€ переменна€ goBack истинна€ то вызываем метод MoveBack() и персонаж идет обратно
            MoveBack();
        }

        for (int i = 0; i <= 2; i++)//“ут в цикле for получаем все наши 3 числа, от 0 до 2 и дальше делаем проверку
        {
            if (pillars[i].tag == "0"|| pillars[i].tag == "2" && gameObject.tag=="1") {//ѕровер€ем, какой это из персонажей пойдет, тут с красным и с синим навыком

                transform.position = Vector3.MoveTowards(transform.position, pillars[i].transform.position, step);//ƒвижение нашего персонажа, к столбу, который был вызван в массиве
                    goBack = false;

            }
            else if (pillars[i].tag == "0" || pillars[i].tag == "1" && gameObject.tag == "2") //ѕровер€ем, какой это из персонажей пойдет, тут с красным и с зеленым навыком
            {

                transform.position = Vector3.MoveTowards(transform.position, pillars[i].transform.position, step);//ƒвижение нашего персонажа, к столбу, который был вызван в массиве
                    goBack = false;

            }

        }
    }
        
    
    public void MoveBack()//ћетод дл€ возврашени€ обратно
    {
        transform.position = Vector3.MoveTowards(transform.position, startPosition, step);//ћен€ем позицию персонажа, на ту, где он был изначально и передвигаемс€ со скоростью step

    }
}
