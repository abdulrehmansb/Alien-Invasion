using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator anim;
    public float moveSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public GameObject winPanel;
    public GameObject gameOverPanel;

    void start()
    {
        winPanel.SetActive(false);
        gameOverPanel.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            anim.SetBool("isJump", true);

        }
        else
        {
            anim.SetBool("isJump", false);
        }

    }



    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Enemy"))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        if (collision.gameObject.name.StartsWith("Winner"))
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if (collision.gameObject.name.StartsWith("level3Hit"))
        {
            SceneManager.LoadScene("level3");
        }

        if (collision.gameObject.name.StartsWith("level2Hit"))
        {
            SceneManager.LoadScene("level2");
        }
    }
}
