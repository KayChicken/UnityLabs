using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsController : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public ClassGirl.Girl girl;
    [SerializeField] private GameObject beautiful;
    [SerializeField] private GameObject smart;
    [SerializeField] private GameObject young;
    [SerializeField] private GameObject rich;
    [SerializeField] private GameObject charismatic;
    [SerializeField] private GameObject nervous;
    [SerializeField] private GameObject purposeful;
    [SerializeField] private GameObject canCook;
    [SerializeField] private GameObject talkative;
    [SerializeField] private GameObject programmer;
    [SerializeField] private GameObject gamer;



    private void Start()
    {
        
        cam1.enabled = true;
        cam2.enabled = false;
        

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;

        }

        

        
        
        if (girl != null)
        {

            if (girl.beautiful)
            {
                beautiful.SetActive(true);
            }

            if (girl.smart)
            {
                smart.SetActive(true);
            }

            if (girl.young)
            {
                young.SetActive(true);
            }

            if (girl.rich)
            {
                rich.SetActive(true);
            }

            if (girl.charismatic)
            {
                charismatic.SetActive(true);
            }

            if (girl.nervous)
            {
                nervous.SetActive(true);
            }

            if (girl.purposeful)
            {
                purposeful.SetActive(true);
            }

            if (girl.canCook)
            {
                canCook.SetActive(true);
            }

            if (girl.talkative)
            {
                talkative.SetActive(true);
            }

            if (girl.programmer)
            {
                programmer.SetActive(true);
            }
            if (girl.gamer)
            {
                gamer.SetActive(true);
            }


        }
       

    }
}
