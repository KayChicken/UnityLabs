using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLine : MonoBehaviour
{
    public Material material;
    public Transform arrowPosition;
    public Transform p0;
    public Transform p1;
    public LineRenderer line;
    



    




    // Update is called once per frame
    void Update()
    {
        if (p0.hasChanged || p1.hasChanged)
        {
            arrowPosition.transform.position = Vector2.Lerp(p0.position, p1.position, 0.99f);

            Vector3 vectorToTarget = arrowPosition.position - p1.transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            arrowPosition.transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
            line.SetPosition(0, p0.position);
            line.SetPosition(1, p1.position);


        }
        


    }
}
