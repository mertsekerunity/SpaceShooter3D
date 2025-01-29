using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] float timeToDestruct = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDestruct);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
