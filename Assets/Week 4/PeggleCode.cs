using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeggleCode : MonoBehaviour
{
    BoxCollider2D floorCollider;
    //public BallLauncher reload;
    
    // Start is called before the first frame update
    private void Awake()
    {
        floorCollider = GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        floorCollider.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        //reload.Reload();
    }
    // Update is called once per frame
    
}
