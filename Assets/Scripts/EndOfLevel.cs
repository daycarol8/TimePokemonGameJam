using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    public int nextScene;

    //[SerializeField] MudaCena cena;

    private bool player1 = false, player2 = false;

    void Update() {
        if (player1 && player2) {
            SceneManager.LoadScene(nextScene);
            player1 = false;
            player2 = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
       // Debug.Log("colisao com " + other.tag);
        if (other.tag == "Player1") {
            player1 = true;
        }
        if (other.tag == "Player2") {
            player2 = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player1") {
            player1 = false;
        }
        if (other.tag == "Player2") {
            player2 = false;
        }
    }

}
