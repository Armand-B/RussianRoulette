using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public GameObject barillet;
    float mult = 0;
    public bool launched = false;
    public GameObject triangle;
    bool debut = true;
    // Start is called before the first frame update
    void Start()
    {
        triangle.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (launched)
        {
            debut = false;
            triangle.GetComponent<BoxCollider>().enabled = false;
            launched = false;
            mult = Random.Range(2.0f, 30f);
          
        }
        if (mult > 0)
        {
            mult -= 0.1f;
            barillet.transform.rotation = Quaternion.Euler(barillet.transform.eulerAngles + new Vector3(0, 0, 60f));
        }
        else if (!debut)
        {
            triangle.GetComponent<BoxCollider>().enabled = true;
        }


    }


    public void activate()
    {
        launched = true;
    }
}
