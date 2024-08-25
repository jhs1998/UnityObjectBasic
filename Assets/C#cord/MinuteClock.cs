using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteClock : MonoBehaviour
{
    public Transform transform;
    public void Update()
    {
        transform.Rotate(Vector3.up * 0.1f * Time.deltaTime);
    }
}
