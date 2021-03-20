using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private GameObject carPrefab;
    public float timeMin;
    public float timeMax;

    private float timeToSpawn;
    private float counter;

    public float positionY;

    public bool shot = false;

    void Start() {
        timeToSpawn = RandomTimeToSpawn();
    }

    void Update() {

        counter += Time.deltaTime;

        if (counter >= timeToSpawn) {
            counter = 0;
            timeToSpawn = RandomTimeToSpawn();
            Spawn();
        }
    }
    private float RandomTimeToSpawn() {
        return Random.Range(timeMin, timeMax);
    }


    private void Spawn() {
        Vector3 position = new Vector3(transform.position.x, positionY, transform.position.z);

        Instantiate(carPrefab, position, Quaternion.identity);
        SoundManager.PlaySound("pulo");

    }

    /*
        struct SpawnTime {
            public float interval; // intervalo em segundos para aparecer
            public float instantiateTime; // tempo para instanciar
            public float variation;
        }

        public GameObject tiroPrefabRef;

        SpawnTime tiro;

        public bool stopSpawn = false;

        void Start() {
            tiro.interval = RandomTimeToSpawn();
            tiro.instantiateTime = 5;
            tiro.variation = 0.5f;
        }

        void Update() {
            // spawn tiro
            if (Time.time > tiro.instantiateTime && !stopSpawn) {
                // instancia o objeto
                GameObject obj = Instantiate(tiroPrefabRef, new Vector3(transform.position.x, positionY), Quaternion.identity); // posi��o dos tiros
                //obj.AddComponent<BoxCollider2D>();
                tiro.instantiateTime = Time.time + Random.Range(tiro.interval - tiro.variation, tiro.interval + tiro.variation); // intervalo diferente
                if (shot) {
                    SoundManager.PlaySound("pulo");
                }
            }
        }

        private float RandomTimeToSpawn() {
            return Random.Range(timeMin, timeMax);
        } */
}
