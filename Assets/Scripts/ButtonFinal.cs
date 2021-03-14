using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFinal : MonoBehaviour {

    [SerializeField] SpriteRenderer button1;

    [SerializeField] Sprite buttonPressed;
    [SerializeField] Sprite buttonNormal;

    [SerializeField] GameObject button2GameObject;
    [SerializeField] SpriteRenderer button2;

    [SerializeField] GameObject metalBar1;
    [SerializeField] GameObject metalBar2;
    [SerializeField] GameObject metalBar3;


    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("ButtonFinal1")) {
            SoundManager.PlaySound("botao");
            button1.sprite = buttonPressed;
            button2.sprite = buttonNormal;
            metalBar1.SetActive(false);
            metalBar2.SetActive(false);
            metalBar3.SetActive(true);
            button2GameObject.SetActive(true);
           
        }
        if (collision.CompareTag("ButtonFinal2")) {
            SoundManager.PlaySound("botao");
            button2.sprite = buttonPressed;
            button1.sprite = buttonNormal;
            metalBar1.SetActive(true);
            metalBar2.SetActive(true);
            metalBar3.SetActive(false);

        }
    }

}
