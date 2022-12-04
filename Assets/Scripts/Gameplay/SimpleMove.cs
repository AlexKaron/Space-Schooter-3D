using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    void Update()
    {
    transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time,8), transform.position.z);
    }
}
