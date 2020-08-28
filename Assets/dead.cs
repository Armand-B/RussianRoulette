using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{

    public AudioSource sound;
    public int nbBullet = 1;
    public GameObject textScore;
    int score = 0;
    
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject manager = GameObject.Find("manager");

        
        

        textScore.GetComponent<TextMesh>().text = "Score : 0";

      


    }

    // Update is called once per frame
    void Update()
    {

    }




    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<SpriteRenderer>().enabled)
        {
            sound.Play();
            score = 0;
            textScore.GetComponent<TextMesh>().text = "Score : 0";
        }
        else
        {
            switch (nbBullet)
            {
                case 1:
                    score += 1;
                    break;
                case 2:
                    score += 3;
                    break;
                case 3:
                    score += 5;
                    break;
                case 4:
                    score += 10;
                    break;
                default:
                    break;
            }
            textScore.GetComponent<TextMesh>().text = "Score : " + score;
        }
    }
}



