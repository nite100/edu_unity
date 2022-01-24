using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Move : MonoBehaviour
{
    public float WallSpeed; // 벽 스피드
    void Start()
    {
        Destroy(gameObject, 10f); // 생성된지 10초 뒤에 삭제
    }

    private void FixedUpdate()
    {
        gameObject.transform.position += new Vector3(WallSpeed, 0, 0); // 벽이 움직이도록 position 변경
    }
}
