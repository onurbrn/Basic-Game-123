using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yValue = 1.5f;
    void Update()
    {
        transform.Rotate(0,yValue,0);       
    }
}
