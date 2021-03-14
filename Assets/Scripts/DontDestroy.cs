using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DontDestroy : MonoBehaviour
{
    void Awake() {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");

        if (objs.Length > 1) {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update() {
        if(SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "GameOver") {
            Destroy(this.gameObject);
        }
    }
}
