using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tile : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();

       
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(0.1f);
        rb.isKinematic = false;

        yield return new WaitForSeconds(1f);
        rb.isKinematic = true;
       /* if (TileSpawnManager.Instance.name == "RightTile")
        {
            TileSpawnManager.Instance.BackToRightPool(gameObject);
        }
        if (TileSpawnManager.Instance.name == "ForwardTile")
        {
            TileSpawnManager.Instance.BackToForwardPool(gameObject);
        }*/




    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            TileSpawnManager.Instance.SpawnTile();
            StartCoroutine("FallDown");
        }
        if(name=="RightTile")
        {
            TileSpawnManager.Instance.BackToRightPool(gameObject);
        }
       else if (name == "ForwardTile")
        {
            TileSpawnManager.Instance.BackToForwardPool(gameObject);
        }
    }
   
}
