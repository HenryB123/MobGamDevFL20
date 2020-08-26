using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Controller Starting Up!");
        
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) Jump();
    }

    void FixedUpdate(){
        Debug.Log("Fixed Update frame time = " + Time.deltaTime);

        //adding forward force
        rb.AddRelativeForce(Vector3.right * 10);
    }

    void Jump() {
        rb.AddRelativeForce(Vector3.up * 20, ForceMode.Impulse );
    }
}
