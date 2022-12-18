using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    public float move, moveSpeed, rotation, rotationSpeed;
    

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        transform.Translate(0f, move, 0f);
        transform.Rotate(0f,0f, rotation);
    }
}
