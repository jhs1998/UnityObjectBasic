using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform transform;
    public void Update()
    {
        transform.Rotate(Vector3.up * 6f * Time.deltaTime);
    }
}
