using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oppssum : MonoBehaviour
{
    //public member
    public float speed = 10; //�����ƶ��ٶ�
    //chase
    public float chasespeed = 12;  //׷���ٶ�
    //idle
    public float idleTime = 2f;  //վ��ʱ��
    //Bleed
    public int MaxRed = 5;  //���Ѫ��
    public int Red = 5;  //��ǰѪ��
    public int Maxbalance = 1;  //���ƽ��ֵ
    public int balance = 1;  //��ǰƽ��ֵ
    //cut
    public int cutforce = 1;  //������
    public int cutCount = 2;  //��������
    public float cutTime = 0.5f;  //����ʱ��
    public float attackR = 0.5f;  //�����뾶
    //stiff
    public float stiffTime = 0.5f; //Ӳֱʱ��
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
            //ʹ��ɫ����
            //Debug.Log("attack");
            collision.gameObject.GetComponent<StateController>().ChangeState("Hurt");
            Rigidbody2D rigidbody2D = collision.gameObject.GetComponent<Rigidbody2D>();
            Transform transform = collision.gameObject.GetComponent<Transform>();
            rigidbody2D.velocity = new Vector2(-transform.localScale.x * attackforce, 1 * attackforce);
        }
    }
}
