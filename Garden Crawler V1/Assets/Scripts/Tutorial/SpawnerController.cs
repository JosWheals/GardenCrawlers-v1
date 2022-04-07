using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//allows me to use premade commands for scenes 

public class SpawnerController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo) // the collsioninfo allows you to ask info about what was been collided with
    {
        if (collisionInfo.collider.tag == "Player")
        {
            SceneManager.LoadScene("Battle");//switches the scenes to the specifically called one 
        }      
    }
}
