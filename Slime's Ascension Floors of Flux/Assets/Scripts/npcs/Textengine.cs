using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Textengine : MonoBehaviour
{
   
    public string[] textLines;
    bool inrange;
    int counter;
    int howManyTimes;

    public GameObject DialogC;
    public TextMeshProUGUI cText;

    
    void Start()
    {
        counter = textLines.Length;
        DialogC.SetActive(false);
        howManyTimes = 0;
    }

  
    void Update()
    {
        Dialog();
    }

    void Dialog()
    {
        if(inrange== true && Input.GetKeyDown(KeyCode.F))
        {
            DialogC.SetActive(true);
            cText.text = textLines[counter - 1];

        }



    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inrange= true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inrange = false;
        }
    }
}
