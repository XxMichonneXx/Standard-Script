using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Config")]
    public int moveSpeed = 30;
    public int rotateSpeed = 10;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate((Vector3.forward) * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate((Vector3.back) * moveSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotateSpeed);
        }
        
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotateSpeed);
        }
    
    }
}
