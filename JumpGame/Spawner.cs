using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Jump : MonoBehaviour
{
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // 점프 키 입력
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0); // velocity 변경
        }
    }

    private void OnTriggerEnter(Collider other) // 다른 콜라이더에 닿았을 경우
    {
        SceneManager.LoadScene(gameObject.scene.name); // 씬 리로드
    }
}
