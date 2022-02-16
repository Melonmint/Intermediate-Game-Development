using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    BoxCollider2D boxCollider;
    public Transform mover;
    public Vector3 cameraPosition;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        boxCollider.isTrigger = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        mover.position = cameraPosition;
    }
}
