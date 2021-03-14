using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShotObject : MonoBehaviour
{
    public float speed = 4;
    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Borda")) Destroy(this.gameObject);

        if (collision.gameObject.CompareTag("Player2")) SceneManager.LoadScene(4);
    }
}
