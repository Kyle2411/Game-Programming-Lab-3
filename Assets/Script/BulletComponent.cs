using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    
    public float force = 1000;
   
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Rigidbody>().AddForce(transform.up * force , ForceMode.Impulse);
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
