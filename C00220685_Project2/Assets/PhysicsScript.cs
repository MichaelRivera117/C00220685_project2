using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
public class PhysicsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On trigger enter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("On trigger stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("On trigger exit");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On collision enter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("On collision stay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("On collision exit");
    }
}
