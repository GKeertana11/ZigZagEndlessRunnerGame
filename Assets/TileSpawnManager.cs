using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawnManager : MonoBehaviour
{
    public GameObject currentTile;
   GameObject RightTile;
    public GameObject[] TilesPrefab;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            int k = Random.Range(0, 2);
            currentTile = Instantiate(TilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

   
        
        
    }
}
