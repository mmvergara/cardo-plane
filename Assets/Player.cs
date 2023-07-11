using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private float moveSpeed  = 8f;
    Vector2 rawInput;
    // Update is called once per frame
    private void Start() {
        Debug.Log("Hello World");
    }
    void Update()
    {
        Vector3 delta = rawInput;
        transform.position += delta * Time.deltaTime * moveSpeed; 
    }

    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
        Debug.Log(rawInput);
    }
}
