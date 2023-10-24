using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireing : MonoBehaviour
{
    int x=0;
    int y=0;
    float z=-0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.W))   
     {
        transform.position += new Vector3(x,y,z);
     }
    }

    public void OnCollisionEnter(Collision collision)
    {
         
    if(collision.gameObject.CompareTag("Finish"))
     {
        Destroy(gameObject);
     }
    }
}
