using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshotPower : MonoBehaviour
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
    	if(other.gameObject.tag == "box")
        other.gameObject.GetComponent<Rigidbody>().AddForce(transform.right*20, ForceMode.Impulse);
    }

}
