using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float fallSpeed;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        //fallSpeed = Random.Range(1, 5);
        gameObject.transform.position = new Vector3(Mathf.RoundToInt(Random.Range(-1, 2)), 5, Mathf.RoundToInt(Random.Range(-1, 2)));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, -fallSpeed * Time.deltaTime, 0);
        
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
        }
    }
    
}
