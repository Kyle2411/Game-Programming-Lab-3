using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
       if(other.gameObject.tag == "Projectile")
       {
            GameManager.Instance.IncrementScore();
            gameObject.SetActive(false);
            Invoke(nameof(activate), 5);
            GetComponent<Renderer>().material.color = Color.green;  
            
       }
    }

    public void activate(){
    gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
