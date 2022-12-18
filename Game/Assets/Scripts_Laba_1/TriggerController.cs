using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class TriggerController : MonoBehaviour
{
    GameObject enterGameObject;
    public TextMeshProUGUI text;
    public bool inTrigger;

   

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.tag == "Player")
        {

            text.enabled = true;
            inTrigger = true;




        }

    }





    private void OnTriggerExit2D(Collider2D collision)
    {
        text.enabled = false;
        inTrigger = false;

    }

}
