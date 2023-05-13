using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ro : MonoBehaviour
{
    [SerializeField]
    private float turnSpeed;

    private void Rotate()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }

    void Update()
    {
        Rotate();
    }
}
