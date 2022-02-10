using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public int Level = 1;
    public GameObject apple;
    public GameObject bomb;
    public float respawnTime;
    public float fallSpeed;
    float time = 0.0f;

    public GameObject textManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.fallSpeed = Random.Range(Level, 5 + Level);
        time += Time.deltaTime;
        if(textManager.GetComponent<TextPrinter>().getpoint >= Level * 30 + 10)
        {
            Level++;
            textManager.GetComponent<TextPrinter>().time += 60;
        }
        if (respawnTime <= time)
        {
            time = 0.0f;
            if (Random.Range(0, 10) >= 3)
            {
                Instantiate(apple).GetComponent<ItemController>().fallSpeed = this.fallSpeed;
                
            }
            else
            {
                Instantiate(bomb).GetComponent<ItemController>().fallSpeed = this.fallSpeed;
                
            }
        }
        
    }
}
