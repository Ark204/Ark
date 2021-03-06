using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    //public member
    public float speed = 10; //基础移动速度
    //jump
    public float jumpforce =10;  //跳跃力
    public int jumpCount = 2;  //跳跃次数
    //sprint  
    public float sprintspeed = 30;  //冲刺速度
    public float sprintTime = 0.1f;  //冲刺时间
    //Bleed
    public int MaxRed = 5;  //最大血量
    public int Red = 5;  //当前血量
    public int Maxbalance = 3;  //最大平衡值
    public int balance = 3;  //当前平衡值
    //cut
    public int cutforce = 1;  //攻击力
    public int cutCount = 2;  //攻击次数
    public float cutTime = 0.5f;  //攻击时间
    public float attackR=0.5f;  //攻击半径
    //stiff
    public float stiffTime = 0.5f; //硬直时间
    //Obsolete
    [System.Obsolete("", true)]
    public float shutStartdistance = 1;
    [System.Obsolete("", true)]
    public float crouchdistance = -0.5f;
    [System.Obsolete("", true)]
    public bool shutPressed = false;
    [System.Obsolete("",true)]
    public float sprintdistance = 10;
    //Inputs
    public bool cutPressed = false;
    public bool sprintPressed = false;
    public bool silkPressed = false;
    public bool jumpPressed = false;
    public bool defensePressed = false;
    public bool climbPressed = false;
    public bool inLadder = false;
    
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
        //输入获取
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpPressed = true;
        }
        //if (Input.GetButtonDown("Shut"))
        //{
        //    shutPressed = true;
        //}
        if (Input.GetButtonDown("Grouch"))
        {
            defensePressed = true;
        }
        if (Input.GetButtonUp("Grouch"))
        {
            defensePressed = false;
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
