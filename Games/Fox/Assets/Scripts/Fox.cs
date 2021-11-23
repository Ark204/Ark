using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{

    //public member
    public float speed = 10;
    public float jumpforce =15;
    public int jumpCount = 3;
    public float shutStartdistance = 1;
    public float crouchdistance = -0.5f;
    public float sprintdistance = 10;
    public float sprintspeed = 30;
    public float sprintTime = 0.3f;
    public int MaxRed = 5;
    public int Red = 5;
    public int cutforce = 1;
    public int cutCount = 2;
    public float cutTime = 0.5f;
    public bool cutPressed = false;
    public bool sprintPressed = false;
    public bool silkPressed = false;
    public bool jumpPressed = false;
    public bool shutPressed = false;
    public bool grouchPressed = false;
    public bool climbPressed = false;
    public bool inLadder = false;
    public float attackR;
    public Transform attackPoint;
    public Transform silkStart;
    public Transform CellingCheck;
    public Transform Ladder;
    public LayerMask enemies;
    public LayerMask layerMask;
    public Vector3 shutPoint;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //ÊäÈë»ñÈ¡
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpPressed = true;
        }
        if (Input.GetButtonDown("Shut"))
        {
            shutPressed = true;
        }
        if (Input.GetButtonDown("Grouch"))
        {
            grouchPressed = true;
        }
        if (Input.GetButtonUp("Grouch"))
        {
            grouchPressed = false;
        }
        if (Input.GetButtonDown("Vertical"))
        {
            climbPressed = true;
        }
        if (Input.GetButtonUp("Vertical"))
        {
            climbPressed = false;
        }
        if(Input.GetButtonDown("Fire1"))
        {
            silkPressed = true;
            shutPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetButtonDown("Fire3"))
        {
            sprintPressed = true;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            cutPressed = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Ladder")
        {
            inLadder = true;
            Ladder = collision.GetComponentsInChildren<Transform>()[1];
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            inLadder = false;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackR);
    }
}
