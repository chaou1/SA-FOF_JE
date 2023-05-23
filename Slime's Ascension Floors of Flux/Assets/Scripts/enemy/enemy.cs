using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject weakpoint;
    public bool flying;
    public bool walking;

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    public void Kill() {
        Destroy(this.gameObject);
    }
}
