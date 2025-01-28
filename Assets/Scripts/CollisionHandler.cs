using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"{this.name} Player collided with: {collision.gameObject.name}"); //string interpolation
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{this.name} triggered by: {other.gameObject.name}"); //string interpolation
    }
}
