using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class ArcadeGame : MonoBehaviour
{
    
    public GameObject arcadeObject;
    [SerializeField] private GameObject enterGameObject;
    private GameObject activeCar;
    public TextMeshProUGUI text;
    public Camera arcadeCamera;
    public Camera mainCamera;
    private bool TimerOn = false;
    public float TimeLeft;
    private float gameTime;


    
    

    private void Awake()
    {
        text.enabled = false;
        
    }

   

    void Start()
    {
        gameTime = TimeLeft;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (TimerOn)
        {
            
            if (TimeLeft > 0)
            {
               
                TimeLeft -= Time.deltaTime;
                
            }

            else
            {
                mainCamera.enabled = !mainCamera.enabled;
                arcadeCamera.enabled = !arcadeCamera.enabled;
                TimerOn = false;
                TimeLeft = gameTime;
                Destroy(activeCar);
                enterGameObject.SetActive(true);
                enterGameObject = null;
            }
        }




        if (GameObject.Find("arcadeGameTrigger").GetComponent<TriggerController>().inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            enterGameObject.SetActive(false);
            activeCar = Instantiate(arcadeObject, new Vector2(-10,23), transform.rotation);
            mainCamera.enabled = !mainCamera.enabled;
            arcadeCamera.enabled = !arcadeCamera.enabled;
            TimerOn = true;
            
            
            
        }



    }


    

   


}
