using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetoCam : MonoBehaviour
{
    public GameObject followobject;
    
    void Start()
    {
    }

    
    void Update()
    {
        gameObject.transform.position = new Vector3(followobject.transform.position.x, 40, followobject.transform.position.z);
    }
}
