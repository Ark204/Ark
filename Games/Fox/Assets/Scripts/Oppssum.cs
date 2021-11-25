using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oppssum : MonoBehaviour
{
    //public member
    public float speed = 10; //基础移动速度
    //chase
    public float chasespeed = 12;  //追击速度
    //idle
    public float idleTime = 2f;  //站立时间
    //Bleed
    public int MaxRed = 5;  //最大血量
    public int Red = 5;  //当前血量
    public int Maxbalance = 1;  //最大平衡值
    public int balance = 1;  //当前平衡值
    //cut
    public int cutforce = 1;  //攻击力
    public int cutCount = 2;  //攻击次数
    public float cutTime = 0.5f;  //攻击时间
    public float attackR = 0.5f;  //攻击半径
    //stiff
    public float stiffTime = 0.5f; //硬直时间
    public float attackforce = 15;

    //Component
    public Transform[] patrolPoint;
    public Transform[] chasePoint;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Death()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Fox")
        {
            //使角色受伤
            //Debug.Log("attack");
            collision.gameObject.GetComponent<StateController>().ChangeState("Hurt");
            Rigidbody2D rigidbody2D = collision.gameObject.GetComponent<Rigidbody2D>();
            Transform transform = collision.gameObject.GetComponent<Transform>();
            rigidbody2D.velocity = new Vector2(-transform.localScale.x * attackforce, 1 * attackforce);
        }
    }
}
