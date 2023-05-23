using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject weakpoint;
    public bool test = false;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    public void Kill() {
        test = true;
        Destroy(this.gameObject);
    }
}
