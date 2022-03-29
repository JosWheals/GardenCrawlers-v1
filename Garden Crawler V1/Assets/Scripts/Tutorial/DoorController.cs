using UnityEngine;

public class DoorController : MonoBehaviour
{
    //using floats not ints becuase then i can be more specific with coordinates
    private int X = 0; // continous int, so there is less in the unity editor 
    public float Y;//public so i can define the Y variable in the editor
    void OnCollisionEnter2D(Collision2D collisionInfo)// the collsioninfo allows you to ask info about what was been collided with
    {
        if (collisionInfo.collider.tag == "Player")//tags are used to help define one gameobject from another in unity
        {
            GameObject.FindWithTag("Player").transform.position = new Vector3(X, Y, -.5f);
            GameObject.FindWithTag("MainCamera").transform.position = new Vector3(X, Y, -10.5f);
        }
    }
}