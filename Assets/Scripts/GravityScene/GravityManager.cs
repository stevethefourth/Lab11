using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour {
    public enum GravityDirection { Up, Down, Left, Right }
    public static Vector3[] GravityVectors;
    public static float GravityStrength = 9.80665f;

    void Awake () {
        GravityVectors = new Vector3[]{ Vector3.up*GravityStrength, Vector3.down, Vector3.left, Vector3.right };
	}

    private void Start()
    {
        Physics.gravity = GravityVectors[0];
    }
}
