using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject helice;
    public float rotationSpeed;
    public float flySpeed;
    private Rigidbody myRigidBody;
    public GameObject smoke;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            helice.transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
            myRigidBody.AddForce(transform.forward * flySpeed *Time.deltaTime);
            Instantiate(smoke, transform);

        }

        myRigidBody.AddForce(new Vector3(0f, Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0f));
        transform.Rotate(0, 0, Input.GetAxis("Horizontal"));
        //myRigidBody.AddTorque(new Vector3(0f, Input.GetAxis("Vertical"), 0f));

        
    }
}
