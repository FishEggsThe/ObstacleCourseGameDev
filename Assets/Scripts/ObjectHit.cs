using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Color32 bumpColor = Color.red;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player") {
            gameObject.tag = "Hit";
            meshRenderer.material.color = bumpColor;
        }
    }
}
