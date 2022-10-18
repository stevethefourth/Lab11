using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauseExplosion : MonoBehaviour
{
    private List<Rigidbody> explosionTargets = new List<Rigidbody>();
    public float explosionRadius = 2.0f;
    SphereCollider collider;
    public float explosionStrength = 1000.0f;
    public float explosionLift = 2.0f;
    void Start()
    {
        collider = GetComponent<SphereCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            for (int i = 0; i < explosionTargets.Count; i++)
            {
                explosionTargets[i].AddExplosionForce(explosionStrength, gameObject.transform.position, explosionRadius, explosionLift);
            }
            
        }
    }

    void FixedUpdate()
    {
        if (collider.radius != explosionRadius)
        {
            collider.radius = explosionRadius;
        }
    }

    void OnTriggerEnter(Collider otherObj)
    {
        explosionTargets.Add(otherObj.gameObject.GetComponent<Rigidbody>());

    }

    void OnTriggerExit(Collider otherObj)
    {
        explosionTargets.Remove(otherObj.gameObject.GetComponent<Rigidbody>());
    }
}
