using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacespin : MonoBehaviour
{
    public float Speed;
    public GameObject planet;

    public void Update()
    {
        transform.RotateAround(planet.transform.position, Vector3.up, Time.deltaTime * Speed * 5.0f);
    }
}
