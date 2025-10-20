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

    float UED = 0; // ��������� ���� ����� �������� �������  �����
    float UEL = 0; // ��������� ���� ����� �������� ������� ����
    float UEC = 0; // ��������� ���� ����� �������� ������� ������.


      // ��� ����� �������� �������� �� ������ ��� ���
    bool UEL1 = false;
    bool UEC1 = false;


    private void Start()
    {
        
    }




    public void UseEnergyDoor(float UED) // UED ������ ���� ������� �����  ����� ������� �� ����� ������� 
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

    public void UseEnergyLight(float UEL) // UEL ������ ���� ������� ����  ����� ������� �� ����� ������� 
    {
        
        Energy -= UEL;
        
    }

    public void UseEnergyCamera(float UEC) // �������� ���� ���� ���� �� ����� �������� �� �������� ������� �� ����� �������
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
