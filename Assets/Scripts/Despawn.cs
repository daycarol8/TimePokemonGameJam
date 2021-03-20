using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    [SerializeField] private GameObject bigornaPrefab;
    public float despawnTime;
    private float counter;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if (counter >= despawnTime)
        {
            counter = 0;
            DespawnBigorna();
        }

    }

    private void DespawnBigorna()
    {
        Destroy(bigornaPrefab);
    }
}
