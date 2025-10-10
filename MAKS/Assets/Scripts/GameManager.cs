using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [HideInInspector] public static int NightLevel;
    public static GameManager gm;

    void Awake()
    {
        gm = this.GetComponent<GameManager>();
    }
    public void Loose()
    {

    }
    public void Win()
    {
        
    }

}
