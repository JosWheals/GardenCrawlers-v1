using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Battleloop : MonoBehaviour
{
    public Text PCHealth;
    public Text EnHealth;
    public Text EnTitle;
    public Text MoveTitle;
    public int MaxHealth;
    private int CurrentHealth;
    private int damage;
    private int EnMaxHealth;
    private int ENCurrentHealth;
    private string EnMove; // for the move number
    private string Enmove; // for move name
    private string name;
    private int Def;
    private int EnDamage;
    private int Speed;
    private int EnSpeed;
    private int heal;
    private int TotalDamage;
    private int turnumber;   
    private int RNG;
    private bool next;
    public GameObject Moves;

    // Start is called before the first frame update
    void Start()
    {
        
        RNG = Random.Range(1,4);
        //PCHealth.text = "HP: " + CurrentHealth + "/" + MaxHealth;
        if (RNG == 1)
        {
            name = "Commander Carrot";
            EnTitle.text = name;
            EnMaxHealth = 20;
            Def = 8;
            Enmove = "Barrage";
            EnDamage = 6;
            EnSpeed = 3; 
        }
            

        if (RNG == 2)
        {
            name = "Olivander The Onion";
            EnTitle.text = name;
            EnMaxHealth = 30;
            Def = 10;
            Enmove = "Bad Breath";
            EnDamage = 3;
            EnSpeed = 3;
                      
        }
           

        if (RNG == 3)
        {
            name = "Randy Radish";
            EnTitle.text = name;
            EnMaxHealth = 10;
            Def = 5;
            Enmove = "Head Butt";
            EnDamage = 5;
            EnSpeed = 10;                      
        }
        CurrentHealth = MaxHealth;
        ENCurrentHealth = EnMaxHealth;    
  
    }

    // Update is called once per frame
    void Update()
    {
        next = false;
        PCHealth.text = "HP:" + CurrentHealth + "/" + MaxHealth;
        EnHealth.text = "HP: " + ENCurrentHealth + "/" + EnMaxHealth;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            turn(1);
            turnumber = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            turn(2);
            turnumber = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            turn(3);
            turnumber = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            turn(4);
            turnumber = 4;
        }
        if (Input.GetKeyDown("enter"))
        {
           
            turn(5);
        }
      
        
    }

    public void turn(int move)
    {
        if (move == 1)
        {
            Debug.Log("Pitchfork");
            damage = 17;
            GameObject.FindWithTag("Moves").SetActiveRecursively(false);
            MoveTitle.text = "you use your pitchfork";
            TotalDamage = damage - Def;
            ENCurrentHealth = ENCurrentHealth - TotalDamage;
            StartCoroutine(WaitBeforNext());

        }

        if (move == 2)
        {
            Debug.Log("Fertiliser");
            heal = 17;
            GameObject.FindWithTag("Moves").SetActiveRecursively(false);
            MoveTitle.text = "you use your Fertiliser";
            if (CurrentHealth < 30)
            {
                CurrentHealth = CurrentHealth + heal;
            }
            StartCoroutine(WaitBeforNext());
        }

    }
    public void EnTurn()
    {
        MoveTitle.text = (name + " uses " + Enmove);
        CurrentHealth = CurrentHealth - damage;
        StartCoroutine(WaitBeforloop());

    }
    public void LoopTurn()
    {
        MoveTitle.text = ("");
        Moves.SetActive(true);
    }
    IEnumerator WaitBeforNext()
    {
        yield return new WaitForSeconds(1);
        EnTurn();
    }

    IEnumerator WaitBeforloop()
    {
        yield return new WaitForSeconds(1);
        LoopTurn();
    }
    public void death()
    {
        
    }

}
