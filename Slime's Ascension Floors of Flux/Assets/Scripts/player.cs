using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public basicMovement basicmovement;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "death") { GameObject.Destroy(this.gameObject); }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

}
