using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeClock : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transform;
    public float time;
    
    public void Update()
    {
        time = 1 / 120;
        transform.Rotate(Vector3.up * time * Time.deltaTime);
    }
}
