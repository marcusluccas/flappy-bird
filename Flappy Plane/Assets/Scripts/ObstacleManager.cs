using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    float spawnRate = 3f;
    float cooldown;

    [SerializeField] GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        cooldown = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown();
    }

    void SpawnObstacle()
    {
        GameObject obstacleInstance = Instantiate(obstacle, new Vector3(5f, Random.Range(-3f, 3f), 0f), Quaternion.identity);
        Destroy(obstacleInstance, 10f);
    }

    void Cooldown()
    {
        cooldown -= Time.deltaTime;
        
        if (cooldown <= 0f)
        {
            SpawnObstacle();
            cooldown = Random.Range(1f, spawnRate);
        }
    }
}
