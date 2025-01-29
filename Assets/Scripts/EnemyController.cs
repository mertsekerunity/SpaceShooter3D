using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject explosionVFX;
    [SerializeField] Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        GameObject vfx = Instantiate(explosionVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parent;

        Destroy(gameObject);
    }
}
