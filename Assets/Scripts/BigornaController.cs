using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigornaController : MonoBehaviour
{
    [SerializeField] private GameObject bigornaPrefab;
    [SerializeField] private GameObject bigornaWarningPrefab;

    public float minX;
    public float maxX;

    public float warningY;
    public float warningTime;

    public float timeMin;
    public float timeMax;

    private float counter;
    private float timeToSpawn;

    void Start() {
        timeToSpawn = RandomTimeToSpawn();

        bigornaWarningPrefab = Instantiate(bigornaWarningPrefab);
        bigornaWarningPrefab.transform.SetParent(transform);
        bigornaWarningPrefab.SetActive(false);
    }

    void Update() {

        counter += Time.deltaTime;

        if (counter >= timeToSpawn) {
            counter = 0;
            timeToSpawn = RandomTimeToSpawn();
            Spawn();
        }

        if (counter >= warningTime) {
            bigornaWarningPrefab.SetActive(false);
        }
    }
    private float RandomTimeToSpawn() {
        return Random.Range(timeMin, timeMax);
    }

    private Vector2 RandomPosition() {
        float xPosition = Random.Range(minX, maxX);

        return new Vector3(xPosition, transform.position.y, transform.position.z);
    }

    private void Spawn() {
        Vector3 position = RandomPosition();
        Vector3 warningPosition = new Vector3(position.x, warningY, position.z);

        Instantiate(bigornaPrefab, position, Quaternion.identity);
        SoundManager.PlaySound("bigorna");

        if (bigornaWarningPrefab != null) {
            bigornaWarningPrefab.SetActive(true);
            bigornaWarningPrefab.transform.position = warningPosition;
        }
    }

    private void SetWarnsToSpawn() {
        GameObject temp = Instantiate(bigornaWarningPrefab);
        temp.transform.SetParent(transform);
        temp.SetActive(false);
    }
}
