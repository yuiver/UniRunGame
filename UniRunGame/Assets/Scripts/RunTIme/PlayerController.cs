using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
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

        GlobalFnuc.Assert(playerRigid != null || playerRigid != default);
        GlobalFnuc.Assert(playerAni != null || playerAni != default);
        GlobalFnuc.Assert(playerAudio != null || playerAudio != default);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //! player die
    private void Die()
    {

    }

    //! 트리거 충돌 감지 처리를 위한 함수
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    //! 바닥에 닿았는지 체크하는 함수
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    //! 바닥에서 벗어났는지 체크하는 함수
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

}
