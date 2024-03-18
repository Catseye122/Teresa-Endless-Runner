using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Obstacle") 
        { 

            gameObject.SetActive(false);
            GameManager.Instance.GameOver();
            //To do connect this to Game Manager and triiger GameOver

        }
    
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
