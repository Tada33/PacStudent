using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dragonMove : MonoBehaviour
{
  
    [SerializeField] Transform[] Positions;
    [SerializeField] float speed;
    Transform NextPos;

    int NextPosIndex;

    
    // Start is called before the first frame update
    void Start()
    {
        NextPos = Positions[0];
       
    }
   
   
    // Update is called once per frame
    void Update()
       
    {
        MoveDragon();

       
    }
    void MoveDragon()
    {
        if (transform.position == NextPos.position)
        {
            NextPosIndex++;
            if (NextPosIndex >= Positions.Length)
            {
                NextPosIndex = 0;
            }
            NextPos = Positions[NextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, speed * Time.deltaTime);
        }
    }
}
