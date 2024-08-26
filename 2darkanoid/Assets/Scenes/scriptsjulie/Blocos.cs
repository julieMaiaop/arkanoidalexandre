using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{

    // }
    private void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        if(collisioninfo.gameObject.CompareTag("Bola"))
        {
            Destroy(this.gameObject);
        }
    }

}
