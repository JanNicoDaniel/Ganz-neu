using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
    private float spawn = 20;
    public GameObject enemy;               

    // Use this for initialization
    void Start () {
        Spawn();
    }
    private void Update()
    {
        if (spawn >= 0)
        {
            spawn = spawn - 1 * Time.deltaTime;
        }
        if(spawn <= 0)
        {
            Spawn();
            spawn = 20;
        }
    }

    void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
