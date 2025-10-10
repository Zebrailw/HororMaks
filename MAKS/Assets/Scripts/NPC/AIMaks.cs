using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMaks : MonoBehaviour
{
    public GameObject[] positions;
    public float AILevel = 0f;
    public GameObject[] nextposition;
    public float energy = 0f;
    public bool active;
    void Awake()
    {
        
    }

    void Update()
    {
        if (active)
        {
            energy += AILevel * 2;
        }
    }
}
