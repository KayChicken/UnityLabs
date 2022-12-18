using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioTrigger : MonoBehaviour
{
    public GameObject radioMenu;
    private bool isTrigger = false;
    // Start is called before the first frame update
    

    private void Update()
    {
        if (isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            radioMenu.SetActive(!radioMenu.active);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isTrigger = false;
        radioMenu.SetActive(false);
    }
}
