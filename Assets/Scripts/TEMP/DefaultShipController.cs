using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultShipController : MonoBehaviour
{
    public float moveSpeed = 9f;
    private float hInput; // Horizontal Input
    private float vInput; // Vertical Input

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(hInput, vInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}