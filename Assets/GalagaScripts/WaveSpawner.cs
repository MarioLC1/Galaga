using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemyWaves;


    public float waveTimer = 0, waveWait = 3;

    // Update is called once per frame
    void Update()
    {
        waveTimer += Time.deltaTime;

        if(waveTimer > waveWait)
        {
            waveTimer = 0;
            Instantiate(enemyWaves[Random.Range(0, enemyWaves.Length)], transform.position, Quaternion.identity);
        }
    }
}
