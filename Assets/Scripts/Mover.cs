using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    float moveSpeed = 5f;

    Vector2 rawInput;
    GameObject fishEggs;

    void Awake()
    {
        fishEggs = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        Move();
    }
    
    void Move()
    {
        Vector2 delta = rawInput * moveSpeed * Time.deltaTime;
        if(rawInput.x != 0 || rawInput.y != 0) {
            float makeAngle = Mathf.Atan2(rawInput.x, rawInput.y)*(180/Mathf.PI) + 180f;
            fishEggs.transform.rotation = Quaternion.Euler(0, makeAngle, 0);
        }
        transform.Translate(delta.x, 0, delta.y);
    }

    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
    }
}
