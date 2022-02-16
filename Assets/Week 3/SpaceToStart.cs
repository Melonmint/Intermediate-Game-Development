using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceToStart : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Vector3 target; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.WakeUp();
        }
    }
}
