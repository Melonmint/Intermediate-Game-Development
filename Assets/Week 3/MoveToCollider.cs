using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCollider : MonoBehaviour
{
    BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;
    public Transform mover;
    public Transform targetLocation;
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        boxCollider.isTrigger = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.color = new Color(1.0f, 0.5f, 0.25f, 0.5f);
        //mover.position = new Vector3(5.0f, 0.0f, 0.0f);
        mover.position = targetLocation.position;
        Debug.Log("Entered Trigger");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit Trigger");
    }

}

