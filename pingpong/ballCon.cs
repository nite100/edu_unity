using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballCon : MonoBehaviour
{
    public AudioClip hitPlayerSound;
    public AudioClip hitWalllSound;
    Rigidbody ballRGbody; // ballRGbody 변수에 리지드바디 컴포넌트 대입
    public float ballSpeed = 3000.0f; // 공의 속도
    public float ballplayerSpeed = 5000.0f; // 공의 속도
    Vector3 startPos; // 공의 출발 위치 정보를 넣을 변수
    Vector3 reflectVec;
    float waitTime;
    void Start()
    {
        ballRGbody = GetComponent<Rigidbody>(); // 리지드바디 컴포넌트 대입
        startPos = new Vector3(0, 0, 0); // 공의 초기 위치 저장
        ballRGbody.AddForce(ballSpeed, 0, ballSpeed); // 시작시 공이 움직임
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= -5)
        {
            gameObject.transform.position = new Vector3(0, 0.5f, 0);
            ballRGbody.AddForce(ballSpeed, 0, ballSpeed);
        }
        if (gameObject.transform.position.z <= -5)
        {
            SceneManager.LoadScene("Restart");
        }
        waitTime += Time.deltaTime;
        if (waitTime >= 5)
        {
            ballRGbody.AddForce(ballSpeed, 0, ballSpeed);
            waitTime = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            waitTime = 0;
            Vector3 endPos = collision.transform.position; // 충돌한 대상의 현재 위치정보 변수에 저장
            Vector3 incomVec = endPos - startPos; // 현재 위치 벡터에서 출발 위치 벡터를 빼서 입사각을 계산하고 변수에 저장
            Vector3 normalVec = collision.contacts[0].normal; // Collision 클래스가 가지고 있는 법선 벡터 정보를 변수에 저장
            reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized; // 반사각 정규화
            ballRGbody.AddForce(reflectVec * ballSpeed); // ball에 반가각 벡터 방향으로 힘이 가해져서 이동
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            waitTime = 0;
            Vector3 endPos = collision.transform.position; // 충돌한 대상의 현재 위치정보 변수에 저장
            Vector3 incomVec = endPos - startPos; // 현재 위치 벡터에서 출발 위치 벡터를 빼서 입사각을 계산하고 변수에 저장
            Vector3 normalVec = collision.contacts[0].normal; // Collision 클래스가 가지고 있는 법선 벡터 정보를 변수에 저장
            reflectVec = Vector3.Reflect(incomVec, normalVec);

            reflectVec = reflectVec.normalized; // 반사각 정규화
            ballRGbody.AddForce(reflectVec * ballplayerSpeed); // ball에 반가각 벡터 방향으로 힘이 가해져서 이동
        }
        
    }
}
