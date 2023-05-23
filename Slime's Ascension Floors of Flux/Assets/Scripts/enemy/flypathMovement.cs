using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flypathMovement : MonoBehaviour
    
{
    public enemy enemy;
    public Transform[] points;
    public int index=0;
    public float speed;
    public float waitingTime;

    private bool cooldown= false;
 
    void FixedUpdate()
    {
        //calls the moving fuction
        FlypathMovement();
    }
    public void FlypathMovement()
 {
        //movement to the point with the Indexedfdllkl
        enemy.transform.position = Vector2.MoveTowards(enemy.transform.position,points[index].transform.position, speed*Time.deltaTime );
        //moving to next point
        if (enemy.transform.position == points[index].transform.position && cooldown==false) {
            //the wait inbetween movements
            StartCoroutine(Stop());
            cooldown = true;
        }


    }
    IEnumerator Stop()
    {
        yield return new WaitForSeconds(waitingTime);
        index++;
        cooldown = false;
        if (index == points.Length)
        {
            index = 0;

        }
    }
}
