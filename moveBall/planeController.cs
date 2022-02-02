using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeController : MonoBehaviour
{
    // Start is called before the first frame update

    float xAngle = 0;
    float zAngle = 0;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            xAngle += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            xAngle -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            zAngle += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            zAngle -= speed * Time.deltaTime;
        }
        gameObject.transform.rotation = Quaternion.Euler(xAngle, 0, zAngle);
        
    }
}
