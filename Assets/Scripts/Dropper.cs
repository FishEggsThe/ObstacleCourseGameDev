using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    float timeToWait = 3f;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        //meshRenderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Time.time > timeToWait){
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
