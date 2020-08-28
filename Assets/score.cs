using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class score : MonoBehaviour
{


    public GameObject[] balles = new GameObject[5];
    


    
    public int numberOfBullets { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        numberOfBullets = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



