using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTpsy : MonoBehaviour
{
    Rigidbody ourRigidBody;


    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidBody.AddExplosionForce(1000,transform.position+Vector3.right, 2);

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }
}
