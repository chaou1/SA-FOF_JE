using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSpawner : MonoBehaviour
{


    public int opening;
    public bool hasspawned = false;
    int randNumber;
    roomTemplate rooms;
    

    // Start is called before the first frame update
    void Start()
    {
        rooms = GameObject.FindGameObjectWithTag("rooms").GetComponent<roomTemplate>();
        Invoke("spawn", 0.2f);
    }
    void spawn() 
    {
        if (hasspawned == false) 
        {
            switch (opening)
            {
                case 0:
                    randNumber = Random.Range(0, rooms.upRooms.Length);
                    Instantiate(rooms.upRooms[randNumber],transform.position,rooms.upRooms[randNumber].transform.rotation);
                    break;
                case 1:
                    randNumber = Random.Range(0, rooms.rightRooms.Length);
                    Instantiate(rooms.rightRooms[randNumber], transform.position, rooms.rightRooms[randNumber].transform.rotation);
                    break;
                case 2:
                    randNumber = Random.Range(0, rooms.downRooms.Length);
                    Instantiate(rooms.downRooms[randNumber], transform.position, rooms.downRooms[randNumber].transform.rotation);
                    break;
                case 3:
                    randNumber = Random.Range(0, rooms.leftRooms.Length);
                    Instantiate(rooms.leftRooms[randNumber], transform.position, rooms.leftRooms[randNumber].transform.rotation);
                    break;
                case 4:
                    break;
            }
            hasspawned = true;
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
