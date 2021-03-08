using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1f,30f)]
    public float speed;
    Rigidbody rb;

    public int CurrentScore = 0;
    private void Start() {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (horizontal,0f,vertical);
        rb.AddForce(movement * speed);
    }
}
