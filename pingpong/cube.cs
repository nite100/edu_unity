using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    int hit_cnt;
    public int fromspawnAreaX;
    public int spawnAreaX;
    public int fromspawnAreaZ;
    public int spawnAreaZ;
    // Start is called before the first frame update
    void Start()
    {
        hit_cnt = Random.Range(1, 5);
        transform.position = new Vector3(Random.Range(fromspawnAreaX, spawnAreaX), 0.5f, Random.Range(fromspawnAreaZ, spawnAreaZ));
    }

    // Update is called once per frame
    void Update()
    {
        if (hit_cnt <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        hit_cnt--;
    }
}
