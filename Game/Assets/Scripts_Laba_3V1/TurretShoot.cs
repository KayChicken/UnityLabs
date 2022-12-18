
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour, IMovable
{
    public GameObject placeBullet, bullet;
    public Animator animationTurretFire;
    private GameObject goBullet;
    public void Shoot(GameObject placeBullet, GameObject bullet)
    {
        goBullet = Instantiate(bullet, placeBullet.transform.position, bullet.transform.rotation);
        goBullet.transform.localScale = new Vector3(0.4f, 0.1f, 0.2f);
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


        if (Input.GetKey(KeyCode.E))
        {
            Shoot(placeBullet, bullet);
            animationTurretFire.Play("Fire");

        }

        else
        {
            animationTurretFire.Play("idle_fire");
        }


    }
}
