using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingMove : MonoBehaviour
{
    public float Speed;
    public GameObject swing;
    public bool play;
    public void Update()
    {
        while (play == true)
        {                    
            for (int i = 11; i > Speed; i--)
            {
                Speed += 1;
                Debug.Log("加档 +1");
                transform.RotateAround(swing.transform.position, Vector3.right, Time.deltaTime * Speed * 5.0f);
            }
            for (int i = 0; i < Speed; i++)
            {
                Speed -= 1;
                Debug.Log("加档 -1");
                transform.RotateAround(swing.transform.position, Vector3.right, Time.deltaTime * Speed * 5.0f);
            }
            if (Speed == 0)
            {
                for (int i = 11; i > Speed; i--)
                {
                    Speed += 1;
                    Debug.Log("加档 +1");
                    transform.RotateAround(swing.transform.position, Vector3.left, Time.deltaTime * Speed * 5.0f);
                }
                for (int i = 0; i < Speed; i++)
                {
                    Speed -= 1;
                    Debug.Log("加档 -1");
                    transform.RotateAround(swing.transform.position, Vector3.left, Time.deltaTime * Speed * 5.0f);
                }
            }
        }
    }
}


