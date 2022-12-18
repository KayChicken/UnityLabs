using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableOpenMenu : MonoBehaviour
{
    public GameObject tableMenu;
    public GameObject player;
    private bool isTrigger = false;
    // Start is called before the first frame update


    private void Update()
    {
        if (isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<BoxCollider2D>().enabled = false;
            player.GetComponent<CharacterController>().enabled = false;
            tableMenu.SetActive(!tableMenu.active);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTrigger = true;
    }

   

    public void CloseMenu()
    {
        player.GetComponent<BoxCollider2D>().enabled = true;
        player.GetComponent<CharacterController>().enabled = true;
        isTrigger = false;
        tableMenu.SetActive(false);

    }

}
