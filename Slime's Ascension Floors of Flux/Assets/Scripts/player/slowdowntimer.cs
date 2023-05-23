using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slowdowntimer : MonoBehaviour
{
    public basicMovement basicMovement;
    public Image bar;
    public float percentage;

    public TextMeshProUGUI jumpNumber;
    private void FixedUpdate()
    {
        Staminadecreasing();
        jumpcounter();
    }

    public void Staminadecreasing() {
        percentage = basicMovement.stamina / basicMovement.maxStamina;
        bar.fillAmount = percentage;
        
    }

    public void jumpcounter() {
        jumpNumber.text = basicMovement.cmidairJump.ToString();
    
    }
}
