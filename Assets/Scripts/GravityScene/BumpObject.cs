using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpObject : MonoBehaviour
{
    private Rigidbody rigid;
    public GravityManager.GravityDirection gravDirection;
    public float bumpForce = 10.0f;
    public Vector3 ZAxis;
    public Vector3 YAxis;
    public Vector3 XAxis;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        if (!gameObject.GetComponent<Rigidbody>())
        {
            rigid = gameObject.AddComponent<Rigidbody>();
        }
        if (gravDirection != GravityManager.GravityDirection.Up)
        {
            rigid.useGravity = false;
        }
        switch (gravDirection)
        {
            case GravityManager.GravityDirection.Down:
                rigid.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
                break;
            case GravityManager.GravityDirection.Right:
                rigid.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
                break;
            case GravityManager.GravityDirection.Left:
                rigid.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
                break;
            case GravityManager.GravityDirection.Up:
                rigid.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
                break;
        }

    }
    void Update()
    {
       
        switch (gravDirection)
        {
            case GravityManager.GravityDirection.Down:                
                if (Input.GetKeyDown(KeyCode.Space))
                    rigid.AddForce(Vector3.up * bumpForce, ForceMode.Impulse);               
                break;
            case GravityManager.GravityDirection.Right:                
                if (Input.GetKeyDown(KeyCode.Space))
                    rigid.AddForce(Vector3.left * bumpForce, ForceMode.Impulse);                
                break;
            case GravityManager.GravityDirection.Left:                
                if (Input.GetKeyDown(KeyCode.Space))
                    rigid.AddForce(Vector3.right * bumpForce, ForceMode.Impulse);                
                break;
            case GravityManager.GravityDirection.Up:
                if (Input.GetKeyDown(KeyCode.Space))
                    rigid.AddForce(Vector3.down * bumpForce, ForceMode.Impulse);              
                break;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        switch (gravDirection)
        {
            case GravityManager.GravityDirection.Down:
                rigid.AddForce(Vector3.down * GravityManager.GravityStrength);
                break;
            case GravityManager.GravityDirection.Right:
                rigid.AddForce(Vector3.right * GravityManager.GravityStrength);               
                break;
            case GravityManager.GravityDirection.Left:
                rigid.AddForce(Vector3.left * GravityManager.GravityStrength);              
                break;
            case GravityManager.GravityDirection.Up:                
                break;
        }

        
        
    }
            
}

    

