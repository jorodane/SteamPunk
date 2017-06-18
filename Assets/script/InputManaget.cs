using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManaget : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody2D rigidbody;

    private float speed; //이동 속도
    private float jump;  //점프력
    private bool isJump = false; //점프 체크

    private Vector3 direction; //이동 방향

    // Use this for initialization
    void Start ()
    {
        //이동속도와 점프력을 플레이어 오브젝트에서 가져옴
        speed = Player.GetComponent<PlayerStat>().speed;
        jump = Player.GetComponent<PlayerStat>().jump;

        //점프를 위한 강체 가져옴
        rigidbody = Player.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //캐릭터 이동 관련 키
        if (Input.GetKey(KeyCode.W) == true) isJump = true;
        if (Input.GetKey(KeyCode.S) == true) direction.y += 0f;
        if (Input.GetKey(KeyCode.A) == true) direction.x += -1.0f;
        if (Input.GetKey(KeyCode.D) == true) direction.x += 1.0f;
        Debug.Log(isJump);

        //점프 처리
        if (isJump == true)
        {
            rigidbody.AddForce(new Vector2(0, jump));
        }

        //이동 처리
        direction.Normalize();
        Player.transform.Translate(direction * speed * Time.deltaTime);
        direction = Vector3.zero;


        isJump = false;
    }

    
}