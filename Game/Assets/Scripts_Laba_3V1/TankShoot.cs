
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour, IMovable
{
    public GameObject placeBullet, bullet;
    private GameObject goBullet;
    public void Shoot(GameObject placeBullet, GameObject bullet)
    {
        goBullet = Instantiate(bullet, placeBullet.transform.position, bullet.transform.rotation);
        goBullet.transform.localScale = new Vector3(1f, 1f, 1f);
        goBullet.GetComponent<Rigidbody2D>().velocity = new Vector3(30.0f, 0, 0);
        Destroy(goBullet, 1.0f);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.F))
        {
            Shoot(placeBullet, bullet);


        }


    }
}
