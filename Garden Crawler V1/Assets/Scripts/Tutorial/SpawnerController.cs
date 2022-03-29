using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.SceneManager;

public class SpawnerController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo) // the collsioninfo allows you to ask info about what was been collided with
    {
        if (collisionInfo.collider.tag == "Player")
        {
            scene.load()
        }
    }

}
