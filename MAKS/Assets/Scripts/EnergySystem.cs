using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySystem : MonoBehaviour
{
    GameObject UED2; // ��������� � �������� 
    GameObject UEL2;
    GameObject UEC2;

    float Energy = 100;

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
        if(UED2. = true)
        Energy -= UED;
    }

    public void UseEnergyLight(float UEL) // UEL ������ ���� ������� ����  ����� ������� �� ����� ������� 
    {
        Energy -= UEL;
    }
    public void UseEnergyCamera(float UEC) // UEC ������ ���� ������� ������ ����� ������� �� ����� ������� 
    {
        Energy -= UEC;
    }


    


    




}
