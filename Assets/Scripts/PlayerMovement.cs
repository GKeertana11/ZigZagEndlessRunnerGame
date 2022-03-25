using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 direction;
    public float playerSpeed;
    public int score;
    public Text ScoreText;
    public bool GameOver;
    public bool istrue = false;

    TileSpawnManager spawnTile;
   // ScoreManager score;
    public GameObject temp;
    Rigidbody rb;
    public Text gameover;

    // Start is called before the first frame update
    void Start()
    {
        spawnTile = GameObject.Find("TileSpawnManager").GetComponent<TileSpawnManager>();
       // score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();


    }

    // Update is called once per frame
    void Update()
    {
        if (istrue == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //if player moving forward then move him left
                if (direction == Vector3.forward)
                {
                    direction = Vector3.left;
                }
                else
                {
                    direction = Vector3.forward;
                }

            }

            transform.Translate(direction * playerSpeed * Time.deltaTime);
            if (transform.position.y < -1 && GameOver == false)
            {
                GameOver = true;
                gameover.GetComponent<Text>().enabled = true;
                istrue = true;

            }
        }
        

    }
    


    public void OnTriggerEnter(Collider other)
    {
       /* if(other.gameObject.tag=="Player")
       {

            TileSpawnManager.Instance.SpawnTile();



        }//
        //spawnTile.SpawnTile();
        //if(other.tag == "Player")
        //{
        //    TileSpawnManager.Instance.SpawnTile();

        //}*/

        if (other.gameObject.tag == "coin")
        {
      
              other.gameObject.SetActive(false);
            score = score + 1;
            Debug.Log(score);
            ScoreText.text = score.ToString();
        }
    /*  if (other.gameObject.tag == "Right")
        {
            temp = other.gameObject;
            //temp.GetComponent<Rigidbody>().isKinematic = false;
            temp.GetComponentInParent<Rigidbody>().isKinematic = false;

            StartCoroutine("RightPool");
        }
        else if (other.gameObject.tag == "Forward")
        {
            temp = other.gameObject;
            temp.GetComponentInParent<Rigidbody>().isKinematic = false;

        if(other.gameobject.tag=="Player")
        {
            StartCoroutine("ForwardPool");
        }
        */



    }

   // public void OnCollisionExit(Collision collision)
    //{
       /* if (collision.gameObject.tag == "RightTile")
        {
            //Destroy(collision.gameObject, 3f);
            TileSpawnManager.Instance.BackToRightPool(collision.gameObject);
            temp = collision.gameObject;
            //StartCoroutine("RightPool");
        }
        if (collision.gameObject.tag == "ForwardTile")
        {
            //Destroy(collision.gameObject, 3f);
            TileSpawnManager.Instance.BackToForwardPool(collision.gameObject);
            temp = collision.gameObject;
            //StartCoroutine("ForwardPool");

        }*/

  //  }
  /* IEnumerator RightPool()
    {
        yield return new WaitForSeconds(1f);

        TileSpawnManager.Instance.BackToRightPool(temp);
        // TileSpawnManager.Instance.BackToForwardPool(temp);


    }*/
   // IEnumerator ForwardPool()
   /* {
        yield return new WaitForSeconds(1f);
        // TileSpawnManager.Instance.BackToRightPool(temp);
        TileSpawnManager.Instance.BackToForwardPool(temp);


    }*/





}
