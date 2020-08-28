using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addbullet : MonoBehaviour
{

    bool activated;
    dead _dead;
    // Start is called before the first frame update
    void Start()
    {
        activated = this.GetComponent<SpriteRenderer>().enabled;


        GameObject manager = GameObject.Find("triangle");

        _dead = manager.GetComponent<dead>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        activated = !activated;
        this.GetComponent<SpriteRenderer>().enabled = activated;
        if (activated)
        {
            _dead.nbBullet += 1;
        }
        else
        {
            _dead.nbBullet -= 1;
        }
    }
}
