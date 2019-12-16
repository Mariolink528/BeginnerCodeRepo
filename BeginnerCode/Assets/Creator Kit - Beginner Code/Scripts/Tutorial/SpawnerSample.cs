using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public int numberOfSpawns;
    Vector3 spawnPosition;

    void Start()
    {
        spawnPosition = transform.position;
        for (int i = 0; i < numberOfSpawns; i++)
        {
            SpawnPotion(2.0f, 15.0f);
        }

    }
    // Let's set 2 parameters (minDistance and maxDistance)
    void SpawnPotion(float minDistance, float maxDistance)
    {
       

        int angle = Random.Range(0, 360);

        float distance = Random.Range( minDistance, maxDistance);

        
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * distance;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}


// Add a new LootAngle class below:
public class LootAngle
{
    int angle;
    int step;

    int NextAngle()
    {
        int currentAngle = angle;
    }
}