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
        LootAngle myLootAngle = new LootAngle(45);
        for (int i = 0; i < numberOfSpawns; i++)
        {
            SpawnPotion(myLootAngle.NextAngle(), 2.0f, 15.0f);
        }

    }
    // Let's set 2 parameters (minDistance and maxDistance)
    void SpawnPotion(int angle, float minDistance, float maxDistance)
    {
       

        //int angle = Random.Range(0, 360);

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

    public LootAngle(int increment)
    {
        step = increment;
        angle = 0;
    }

    public int NextAngle()
    {
        //NextAngle will give us the next angle
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);
        return currentAngle;
    }
}