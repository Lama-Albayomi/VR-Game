using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;

    bool isEnemyDestroyed = false;    


    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyRandomlyOnXAxis();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnemyDestroyed)
        {
            isEnemyDestroyed = false;
            SpawnEnemyRandomlyOnXAxis();
        }
    }

    void SpawnEnemyRandomlyOnXAxis()
    {
        Vector3 pos = new Vector3(Random.Range(-5, 5), .5f, 3); ;
        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }

}
