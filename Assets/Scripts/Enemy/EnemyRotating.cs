using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotating : MonoBehaviour
{
   [SerializeField] float speed;
   [SerializeField] float rotationSpeed;
    void Start()
    {
        
    }


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3 (horizontalInput,0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation,toRotation,rotationSpeed * Time.deltaTime);
        }
    }
}
