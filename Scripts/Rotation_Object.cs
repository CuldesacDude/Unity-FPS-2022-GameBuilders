using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Object : MonoBehaviour{
    
    public float xRotSpeed = 0f;
    public float yRotSpeed = 0f;
    public float zRotSpeed = 0f;

    void Update(){
        transform.Rotate(xRotSpeed,yRotSpeed,zRotSpeed);
    }
}
