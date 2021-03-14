using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDown : MonoBehaviour
{
    [SerializeField] GameObject porta;

    [SerializeField] SpriteRenderer button;
    [SerializeField] Sprite buttonPressed;

    [SerializeField] bool isWithTheKey;

    [SerializeField] GameObject MetalBar;

    [SerializeField] GameObject plataformaLeft;
    [SerializeField] GameObject plataformaRight;
    [SerializeField] GameObject spike;


    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Button")) {
            button.sprite = buttonPressed;
            porta.SetActive(false);
            SoundManager.PlaySound("botao");
        }
        if (collision.CompareTag("Key")){
            isWithTheKey = true;
            Destroy(collision.gameObject);
            SoundManager.PlaySound("chave");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Key1")) {
            Destroy(collision.gameObject);
            plataformaRight.SetActive(true);
            spike.SetActive(false);
            SoundManager.PlaySound("chave");
        }
        if (collision.CompareTag("Key2")) {
            Destroy(collision.gameObject);
            plataformaLeft.SetActive(true);
            SoundManager.PlaySound("chave");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("MetalBar") && isWithTheKey) {
            Destroy(MetalBar);
        }
    }
}
