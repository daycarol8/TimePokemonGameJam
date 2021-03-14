using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigornaCollision : MonoBehaviour
{
    public GameObject bigornaPrefab;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Player1")) {
            SceneManager.LoadScene("GameOver");
            
        }
        if (collision.collider.CompareTag("Door")) {
            Destroy(bigornaPrefab);
        }
    }
}
