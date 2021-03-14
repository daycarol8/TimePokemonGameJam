using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    [SerializeField] private int scene;
    [SerializeField] private GameObject img;
    private float varia = 1;
    void Start() {
        //img = this.gameObject.GetComponent<GameObject>();
        Invoke("StartScene", 5);

    }
    void Update() {
        if (this.gameObject) {
            if (varia > 0) {
                varia -= 0.001f;
            }

            img.GetComponent<Renderer>().material.color = Color.HSVToRGB(0, 0, varia);
        }
        
    }

    void StartScene() {
        SceneManager.LoadScene(scene);
    }


}
