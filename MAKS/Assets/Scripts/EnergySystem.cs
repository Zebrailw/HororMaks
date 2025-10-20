using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySystem : MonoBehaviour
{
    public GameObject UED2;
    public GameObject UEL2;
    public GameObject[] UEC2 = new GameObject[5];
    public GameObject LeftDoor;
    public GameObject RightDoor;



    public float Energy = 100;

    float UED = 0; // обявление скок будет забирать энергии  двери
    float UEL = 0; // обявление скок будет забирать энергии свет
    float UEC = 0; // обявление скок будет забирать энергии камеры.


      // тут будет проверка включена ли камера или нет
    bool UEL1 = false;
    bool UEC1 = false;


    private void Start()
    {
        
    }




    public void UseEnergyDoor(float UED) // UED вместо него сколько двери  будут тратить от Общей энергии 
    {
        if (LeftDoor.activeSelf && RightDoor.activeSelf)
        {
            Energy -= 2 * UED;
        }
        else if (LeftDoor.activeSelf || RightDoor.activeSelf)
        {
            Energy -= UED;
        }

    }

    public void UseEnergyLight(float UEL) // UEL вместо него сколько свет  будет тратить от Общей энергии 
    {
        
        Energy -= UEL;
        
    }

    public void UseEnergyCamera(float UEC) // Проверка если хоть одна из камер включена то вычетает энергию из общей энергии
    {
        for (int i = 0; i <= 10 ; i++)
        {
            if (UEC2[i].activeSelf == false)
            {
                continue;
            }
            else
            {
                Energy -=  UEC;
            }
        }
        
    }

}
