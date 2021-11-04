using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eatable : MonoBehaviour
{

    public int points = 10;
    public AudioClip eatenSound;

    
    void Start()
    {

    }
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            collected(coll);
        }
    }

    protected virtual void collected(Collider2D coll)
    {
        coll.gameObject.GetComponent<pacStudentController>().addPoints(points);
        AudioSource.PlayClipAtPoint(eatenSound, transform.position);
        gameObject.SetActive(false);
    }
}
