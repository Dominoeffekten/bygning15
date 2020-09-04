using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make a bombe explode after hitting the floor - flying elements
//https://www.youtube.com/watch?v=xqQkiHI5U9o
//https://www.youtube.com/watch?v=s_v9JnTDCCY
public class Bombe2Broken : MonoBehaviour
{//makes a compoment 
    public GameObject replacement;

    //radius for the elements flying
    public float radius = 3;
    public float force = 500;


    void OnCollisionEnter(){
        
        //an extising object that you want to make a copy of
        GameObject.Instantiate(replacement, transform.position, transform.rotation);
        Destroy(gameObject);

        //the elements around it
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        
        foreach (Collider nearbyObject in colliders){
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody> ();
            if (rb != null){
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }
    }

    
    
}
