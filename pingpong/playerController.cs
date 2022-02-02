using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerContoller : MonoBehaviour
{
    public float speed;
    public float cntTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        cntTime += Time.deltaTime;
        if(cntTime >= 60 && gameObject.transform.localScale.x > 5)
        {
            cntTime = 0;
            gameObject.transform.localScale += new Vector3(-1, 0, 0);
        }

    }
}
