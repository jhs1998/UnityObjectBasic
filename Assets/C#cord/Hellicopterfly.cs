using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellicopterfly : MonoBehaviour
{
    [SerializeField] float flySpeed = 5f;
    public float Speed;
    public GameObject planet;
    public void Update()
    {
        // Space 키를 누르고 있는 동안 상승
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
            transform.RotateAround(planet.transform.position, Vector3.up, Time.deltaTime * Speed * 5.0f);
        }
    }
}
