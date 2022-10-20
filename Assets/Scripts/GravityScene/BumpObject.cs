using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpObject : MonoBehaviour
{
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        if (!gameObject.GetComponent<Rigidbody>())
        {
            gameObject.AddComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
