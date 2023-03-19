using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer _renderer;
    Rigidbody _rigidBody;
    [SerializeField] float timeToWait = 2f;
    
    void Start() 
    {
        _rigidBody = GetComponent<Rigidbody>();
        _renderer = GetComponent<MeshRenderer>();
        _renderer.enabled = false;
        _rigidBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            _renderer.enabled = true;
            _rigidBody.useGravity = true;
        }
    }
}
