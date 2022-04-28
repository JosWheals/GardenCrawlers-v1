using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 mousePos;
    public int Keys = 0;
    public Text Text;
    public Camera Cam;
    public bool weapon;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        Text.text = "Keys:" + Keys;
        mousePos = Cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
        //Vector2 lookDir = mousePos - rb.position;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg ;
        //rb.rotation = angle;
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)// the collsioninfo allows you to ask info about what was been collided with
    {
        if (collisionInfo.collider.tag == "Key")//tags are used to help define one gameobject from another in unity
        {
            GameObject.FindWithTag("Key").SetActiveRecursively(false);
            Keys += 1;

        }
        if (collisionInfo.collider.tag == "Door")
        {
            if (Keys > 0)
            {
                GameObject.FindWithTag("Door").SetActiveRecursively(false);
                Keys -= 1;
            }

        }
        if (collisionInfo.collider.tag == "Weapon")
        {
            GameObject.FindWithTag("Weapon").SetActiveRecursively(false);
            weapon = true;
        }
    }

}