using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab; // 벽 프리팹 지정
    public float span = 1.0f; // 스폰 시간
    float delta = 0;
    public float range = 0; // 높낮이 변경 범위


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; // 시간 고정
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject wall = Instantiate(wallPrefab) as GameObject; // 벽 생성
            wall.transform.position = new Vector3(0, Random.Range(-range, range), 0); // 랜덤한 위치 스폰
        }
    }
}
