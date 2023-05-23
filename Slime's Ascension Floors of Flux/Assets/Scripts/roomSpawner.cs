using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSpawner : MonoBehaviour
{


    public int opening;
    bool hasspawned;
    int randNumber;
    roomTemplate rooms;
    // Start is called before the first frame update
    void Start()
    {
        rooms = GameObject.FindGameObjectWithTag("rooms").GetComponent<roomTemplate>();
        Invoke("spawn", 0.1f);
    }
    void spawn() 
    {
        if (hasspawned == false) 
        {
            switch (opening) 
            {
                case 0:

                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        
        }

    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("roomSpawner")) 
        {
            Destroy(collision.gameObject);
            hasspawned = true;
        }
    }
}
