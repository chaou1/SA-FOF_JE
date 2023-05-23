using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject weakpoint;

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
