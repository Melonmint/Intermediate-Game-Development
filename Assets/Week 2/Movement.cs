using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
    
{
    float speed = 3.0f;
    SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void MoveObject()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.Translate((Vector2.left * Time.deltaTime) * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { 
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spriteRenderer.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
        }
        MoveObject();
    }
}
