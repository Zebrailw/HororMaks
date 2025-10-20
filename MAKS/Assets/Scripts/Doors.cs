using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Doors : MonoBehaviour
{
    public bool conditionRight = true; //открыта закрыта?
    UnityEvent Open;
    UnityEvent Close;

    void Awake()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.CompareTag("rightButton"))
        {
            Debug.Log("правая кнопка");
            if (conditionRight)
            {
                conditionRight = !conditionRight;
                Close.Invoke();
            }
            else if (!conditionRight)
            {
                conditionRight = !conditionRight;
                Open.Invoke();
            }
        }
    }

    
    void Update()
    {
        
    }
}
