using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnItem : MonoBehaviour
{
    [SerializeField]
    GameObject[] row1SpawnPoints;
    [SerializeField]
    GameObject[] row2SpawnPoints;
    [SerializeField]
    GameObject[] items;
    public int maximumSpawnRow1;
    public int maximumSpawnRow2;

    bool isScene2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            SpawningItem();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
            isScene2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawningItem()
    {
        if (isScene2)
        {
            for (int i = 0; i < row1SpawnPoints.Length; i++)
                Instantiate(items[Random.Range(0, items.Length)], row1SpawnPoints[i].transform.position, Quaternion.Inverse(transform.rotation));
            for (int i = 0; i < row2SpawnPoints.Length; i++)
                Instantiate(items[Random.Range(0, items.Length)], row2SpawnPoints[i].transform.position, Quaternion.Inverse(transform.rotation));
        }
        else
        {
            for (int i = 0; i < row1SpawnPoints.Length; i++)
            {
                var rate1 = Random.Range(0, 2);
                if (rate1 == 1)
                    Instantiate(items[Random.Range(0, items.Length)], row1SpawnPoints[i].transform.position, Quaternion.Inverse(transform.rotation));
            }

            for (int i = 0; i < row2SpawnPoints.Length; i++)
            {
                var rate2 = Random.Range(0, 2);
                if (rate2 == 1)
                    Instantiate(items[Random.Range(0, items.Length)], row2SpawnPoints[i].transform.position, Quaternion.Inverse(transform.rotation));
            }
        }
    }
}
