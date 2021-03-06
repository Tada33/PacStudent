using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public int points = 100;
    public AudioClip collectSound;

    
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
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        gameObject.SetActive(false);
    }
}
