using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip clip;
    public GameObject textManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Apple")
        {
            AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
            textManager.GetComponent<TextPrinter>().getpoint++;
            Debug.Log("Hit");
        }
        if (other.tag == "Bomb")
        {
            AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
            textManager.GetComponent<TextPrinter>().getpoint--;
            Debug.Log("Bomb");
        }
        Destroy(other.gameObject);
    }
}
