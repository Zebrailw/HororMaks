using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySystem : MonoBehaviour
{
    GameObject UED2; // обращение к объектам 
    GameObject UEL2;
    GameObject UEC2;

    float Energy = 100;

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
        if(UED2. = true)
        Energy -= UED;
    }

    public void UseEnergyLight(float UEL) // UEL вместо него сколько свет  будет тратить от Общей энергии 
    {
        Energy -= UEL;
    }
    public void UseEnergyCamera(float UEC) // UEC вместо него сколько камеры будут тратить от Общей энергии 
    {
        Energy -= UEC;
    }


    


    




}
