using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawnManager : MonoBehaviour
{
    public GameObject currentTile;
   GameObject RightTile;
    public GameObject[] TilesPrefab;
    public float time;

    // Start is called before the first frame update

    //SingleTon Pattern: Can only create single object out of it. We can't create multiple objects from it.
    private static TileSpawnManager instance;


    //static TileSpawnManager Instance { get => instance; }
   /* private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
      
    }*/
   public static TileSpawnManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileSpawnManager>();
            }
            return instance;
        }
    }

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {

            SpawnTile();
        }

    }

    // Update is called once per frame
    void Update()
    {

       /* time = time + Time.deltaTime;
        if(time>6f)
        {
            Destroy(GameObject.FindGameObjectWithTag("Tile"));
            time = 0;
        }*/
    
        
        
    }
     
    public void SpawnTile()
    {
        int index = Random.Range(0, 10);
        if (index == 2)
        {
            currentTile.transform.GetChild(3).gameObject.SetActive(true);
        }
            int k = Random.Range(0, 2);
            currentTile = Instantiate(TilesPrefab[k], currentTile.transform.GetChild(k).position, Quaternion.identity);

        
    }

  
}
