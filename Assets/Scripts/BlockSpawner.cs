using System.Collections;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    [SerializeField] Transform[] spawnPoint;
    [SerializeField] GameObject blockPrefab;
    
    void Start()
    {
        StartCoroutine(generateBlockCoroutine());

    }

    IEnumerator generateBlockCoroutine()
    {

        yield return new WaitForSeconds(2);
        int randomEmptyIndext = Random.Range(0, spawnPoint.Length);

        for (int i = 0; i < spawnPoint.Length; i++)
        {
            if (randomEmptyIndext != i)
            {
                // Init Block
                GameObject block = Instantiate(blockPrefab, spawnPoint[i].transform.position, Quaternion.identity);
                Destroy(block, 2);
            }
        }
        StartCoroutine(generateBlockCoroutine());
    }
}
