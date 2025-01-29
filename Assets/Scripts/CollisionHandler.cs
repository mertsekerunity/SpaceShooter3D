using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 2f;

    [SerializeField] ParticleSystem explosionVFX;

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
        StartCrashSequence();
        Debug.Log($"{this.name} Player collided with: {collision.gameObject.name}"); //string interpolation
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{this.name} triggered by: {other.gameObject.name}"); //string interpolation
    }

    void StartCrashSequence()
    {
        explosionVFX.Play();
        GetComponent<PlayerController>().enabled = false;
        GetComponentInChildren<MeshRenderer>().enabled = false;
        Invoke(nameof(ReloadLevel), loadDelay);
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
