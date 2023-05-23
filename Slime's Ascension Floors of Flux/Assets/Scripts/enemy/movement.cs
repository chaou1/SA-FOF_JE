using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
    
{
    public enemy enemy;
    public Transform[] points;
    public int index=0;
    public float speed;
    public float waitingTime;

    private bool cooldown= false;
    // Start is called before the first frame update
    void Start()
    {
        //enemy.transform.position = points[index].transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }
    public void Movement() {
        enemy.transform.position = Vector2.MoveTowards(enemy.transform.position,points[index].transform.position, speed*Time.deltaTime );
        if (enemy.transform.position == points[index].transform.position && cooldown==false) {
            
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
