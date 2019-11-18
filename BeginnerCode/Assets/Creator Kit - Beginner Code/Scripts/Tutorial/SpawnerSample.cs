using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

   
   
    void Start()
    {
        
        SpawnPotion(2.0f, 15.0f);
        SpawnPotion(5.0f, 15.0f);
        SpawnPotion(2.0f, 8.0f);

    }
    // Let's set 2 parameters (minDistance and maxDistance)
    void SpawnPotion(float minDistance, float maxDistance)
    {
        Vector3 spawnPosition = transform.position;

        int angle = Random.Range(0, 360);

        float distance = Random.Range( minDistance, maxDistance);

        
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * distance;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

