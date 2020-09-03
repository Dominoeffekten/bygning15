using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=xqQkiHI5U9o

public class BrokenItem : MonoBehaviour
{
    //makes a compoment 
    public GameObject replacement;

    void OnCollisionEnter(){

        //an extising object that you want to make a copy of
        GameObject.Instantiate(replacement, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
