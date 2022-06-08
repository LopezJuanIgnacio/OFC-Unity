using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuVIeja : MonoBehaviour
{
    public float movement = 10f;
    Vector3 input;
    Rigidbody rb;
    Vector3 posInicial;
    
    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();
     posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        rb.AddForce(input*movement);

        if(transform.position.y < -5){
            ReAparecer();
        }

    }

    void ReAparecer(){
        transform.position= posInicial;

    }
}
