using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScreamerController : MonoBehaviour
{

    public GameObject s;
    public static UnityEvent OnDetectEvent = new UnityEvent();
   


    void Skreamer_activate()
    {
        s.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "trap")
        {
            
            OnDetectEvent?.Invoke();
        }

    }
    public void Start()
    {
        
        OnDetectEvent.AddListener(Skreamer_activate);
    }


    
}