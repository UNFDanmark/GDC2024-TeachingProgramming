using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamiteThingy : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var surroundingObjects = Physics.OverlapSphere(transform.position, 10f, LayerMask.NameToLayer("Enemy"));
            foreach (var surroundingObject in surroundingObjects)
            {
                Rigidbody rb = surroundingObject.GetComponent<Rigidbody>();
                rb.AddExplosionForce(5f, transform.position, 10f);
            }
        }
    }
}
