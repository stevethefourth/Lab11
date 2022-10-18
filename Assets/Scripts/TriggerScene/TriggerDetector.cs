using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject.CompareTag("Red"))
        {
            Debug.Log(otherObj.gameObject);
        }
        
    }

    private void OnTriggerExit(Collider otherObj)
    {
        if (otherObj.gameObject.CompareTag("Blue"))
        {
            Debug.Log(otherObj.gameObject);
        }
    }
}
