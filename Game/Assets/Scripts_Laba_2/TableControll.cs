using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class TableControll : MonoBehaviour
{

    [SerializeField] private Transform parentTransform;
    [SerializeField] private GameObject arrow;
    [SerializeField] private GameObject schemePrefab;
    
    private Transform p0;
    private Transform p1;
    public Material material;
    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);


            

            if (hit.collider != null && hit.collider.gameObject.tag == "ArrowTrigger")
            {
                p0 = hit.transform;
                
                
            }

            
        }

        if (Input.GetMouseButtonUp(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject.tag == "ArrowTrigger" && hit.transform != p0)
            {
                p1 = hit.transform;

            }
        }



        if (p0 != null && p1 != null)
        {
            
            GameObject line = new GameObject("Line");
            line.transform.parent = parentTransform;
            line.AddComponent<LineRenderer>();
            LineRenderer lineOption = line.GetComponent<LineRenderer>();
            lineOption.positionCount = 2;
            lineOption.sortingOrder = 999;
            lineOption.material = material;
            lineOption.startWidth = 0.15f;
            lineOption.endWidth = 0.15f;
            lineOption.SetPosition(0, p0.position);
            lineOption.SetPosition(1, p1.position);
            var arrowClone = Instantiate(arrow, Vector2.Lerp(p0.position,p1.position,1), Quaternion.Euler(0, 0, 0));
            arrowClone.transform.parent = parentTransform;
            SpriteRenderer spriteLayer = arrowClone.GetComponent<SpriteRenderer>();
            spriteLayer.sortingOrder = 1000;
            line.AddComponent<UpdateLine>();
            UpdateLine script = line.GetComponent<UpdateLine>();
            script.p0 = p0;
            script.p1 = p1;
            script.line = lineOption;
            script.arrowPosition = arrowClone.transform;
            p0 = null;
            p1 = null;

        }


        

    }


    public void DeleteButton()
    {
        var childs = parentTransform.transform.childCount;
        for (int i = childs - 1; i >= 0; i--)
        {
            Destroy(parentTransform.transform.GetChild(i).gameObject);
        }
    }



    public void CreateWindow()
    {
        Instantiate(schemePrefab, parentTransform);
    }
}

