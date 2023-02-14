using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject spawnBullet;
    public GameObject cannon;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButton("Fire1")){
            timer += Time.deltaTime;
 
        }

        if(Input.GetButtonUp("Fire1")){
        spawnBullet = Instantiate(bulletPrefab, cannon.transform.position, cannon.transform.rotation);
        spawnBullet.GetComponent<BulletComponent>().force = timer*50;
        timer = 0;
    }
    }

    
}
