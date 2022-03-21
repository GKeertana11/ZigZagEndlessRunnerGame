using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public int score;
    public Text ScoreText;
    
    // public TileSpawnManager TileSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //TileSpawn =GameObject.Find("TileSpawnManager").GetComponent<TileSpawnManager>();
       
    }


    // Update is called once per frame
    void Update()//if player moving in forward make him move left, if not make him move forward    
    {
        if (Input.GetMouseButtonDown(0))

        {
            if (Vector3.forward == direction)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }


        }
        transform.Translate(direction * speed * Time.deltaTime);

    }




    private void OnTriggerExit(Collider other)
    {
        // if (gameObject.tag=="")

        if (other.gameObject.tag == "Tile")
        {
            // TileSpawn.SpawnTile();
            TileSpawnManager.Instance.SpawnTile();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            collision.gameObject.SetActive(false);
            score = score + 1;
            Debug.Log(score);
            ScoreText.text = score.ToString();
        }
    }

    /*RayCast: 

  /*  private void OnCollisionExit(Collision collision) 
    {
        
    }*/



}

