using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float PLAYER_STEP_ON_Y_POS_MIN = 0.7f;


    public AudioClip deathSound = default;
    public float jumpForce = default;

    private int jumpCount = default;
    private bool isGrounded = false;
    private bool isDead = false;


    #region player's component
    private Rigidbody2D playerRigid = default;
    private Animator playerAni = default;
    private AudioSource playerAudio = default;
    #endregion  //player's component

    // Start is called before the first frame update
    void Start()
    {
        //Set player's components
        playerRigid = gameObject.GetComponentMust<Rigidbody2D>();
        playerAni = gameObject.GetComponentMust<Animator>();
        playerAudio = gameObject.GetComponentMust<AudioSource>();

        GFunc.Assert(playerRigid != null || playerRigid != default);
        GFunc.Assert(playerAni != null || playerAni != default);
        GFunc.Assert(playerAudio != null || playerAudio != default);

    }

    // Update is called once per frame
    void Update()
    {
        //Return. If player dead
        if (isDead == true) { return; }

        //{플레이어 점프 관련 로직
        if (Input.GetMouseButtonDown(0) && jumpCount < 2)
        {
            jumpCount++;
            //점프키 누르는 순간 움직임을 완전히 멈춤
            playerRigid.velocity = Vector2.zero;

            playerRigid.AddForce(new Vector2(0, jumpForce));

            playerAudio.Play();
        }       //if : Player jump
        else if (Input.GetMouseButtonUp(0) && 0 < playerRigid.velocity.y)
        {
            playerRigid.velocity = playerRigid.velocity * 0.5f;
        }       //if : 플레이어가 공중에 떠 있을 때
        //  } 플레이어 점프 관련 로직
        playerAni.SetBool("Grounded", isGrounded);

        //점프 중이 아닐 때 그라운드에서 사용하는 로직
    }       //Update


    //! player die
    private void Die()
    {
        playerAni.SetTrigger("Die");

        playerAudio.clip = deathSound;
        playerAudio.Play();

        playerRigid.velocity = Vector2.zero;
        isDead = true;
    }

    //! 트리거 충돌 감지 처리를 위한 함수
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("DeadZone") && !isDead)
        {
            Die();
        }
    }

    //! 바닥에 닿았는지 체크하는 함수
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (PLAYER_STEP_ON_Y_POS_MIN < collision.contacts[0].normal.y)
        {
            isGrounded = true;
            jumpCount = 0;
        }
    }

    //! 바닥에서 벗어났는지 체크하는 함수
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

}
