using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int selectPlayer;
    public float deslocamento;
    public float jumpSpeed;

    public Animator playerAnimator;
    public GameObject player;

    Rigidbody2D rigidBody;

    public bool isGrounded = true;

    /* void Awake() {
         rigidBody = GetComponent<Rigidbody2D>();
     }*/

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Chao")) {
            isGrounded = true;
        }
        if (other.gameObject.CompareTag("Spike")) {
            //Debug.Log("Ai!");
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
         if (collision.CompareTag("Chao")) {
            isGrounded = true;
        }
        if (collision.CompareTag("Lama")) {
            deslocamento = 0;
        }
    }

    private void Start() {
       playerAnimator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Update() {
        // checa qual o player selecionado
        if (selectPlayer == 1) {

            if (Input.GetKey(KeyCode.A)) {
                player.transform.position = new Vector3(player.transform.position.x - deslocamento, player.transform.position.y, player.transform.position.z);
                playerAnimator.SetFloat("Speed", -1);
                //SoundManager.PlaySound("passos");
            }
            else if (Input.GetKey(KeyCode.D)) {
                player.transform.position = new Vector3(player.transform.position.x + deslocamento, player.transform.position.y, player.transform.position.z);
                playerAnimator.SetFloat("Speed", 1);
            }
            else {
                playerAnimator.SetFloat("Speed", 0);
            }
            if (Input.GetKeyDown(KeyCode.W) && isGrounded) {
               rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
               isGrounded = false;
               SoundManager.PlaySound("pulo");

            }

        }
        else {
            // movimento player2
            if (Input.GetKey(KeyCode.LeftArrow)) {
                player.transform.position = new Vector3(player.transform.position.x - deslocamento, player.transform.position.y, player.transform.position.z);
                playerAnimator.SetFloat("Speed", -1);
              //  SoundManager.PlaySound("passos");
            }
            else if (Input.GetKey(KeyCode.RightArrow)) {
                player.transform.position = new Vector3(player.transform.position.x + deslocamento, player.transform.position.y, player.transform.position.z);
                playerAnimator.SetFloat("Speed", 1);
            }
            else {
                playerAnimator.SetFloat("Speed", 0);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded) {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
                isGrounded = false;
                SoundManager.PlaySound("pulo");
            }
        }
    }
}