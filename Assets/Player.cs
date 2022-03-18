using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
   public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//if player moving in forward make him move left, if not make him move forward    
    { 
        if(Input.GetMouseButtonDown(0))

        {
            if(Vector3.forward==direction)
            {
                direction=Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }

            
        }
        transform.Translate(direction * speed * Time.deltaTime);

    }
}
