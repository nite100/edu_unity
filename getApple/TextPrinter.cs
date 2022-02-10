using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPrinter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject timer;
    public GameObject point;

    public float time;
    public int getpoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timer.GetComponent<Text>().text = "Time : " + this.time.ToString("F2");
        this.point.GetComponent<Text>().text = "Point : " + this.getpoint;
    }
}
