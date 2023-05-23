using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    public bool isGrounded = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("grounded"))
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("grounded"))
        {
            isGrounded = false;
        }
    }
    
        
    }

