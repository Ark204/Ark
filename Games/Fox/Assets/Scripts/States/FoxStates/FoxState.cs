using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxState : IState
{
    //static Fox's states
    public static Idle idle = new Idle();
    public static Run run= new Run();
    public static Up up= new Up();
    public static Down down= new Down();
    public static Grouch grouch = new Grouch();
    public static Climb climb = new Climb();
    public static Hurt hurt = new Hurt();
    public static SilkJump silkJump = new SilkJump();
    public static Sprint sprint = new Sprint();
    public static Cut cut = new Cut();

    //components
    protected Animator m_animator;
    protected Rigidbody2D m_rigidbody2D;
    protected Fox m_fox;
    protected Transform m_transform;
    //类似常规脚本中的start
    public override void enter(StateController stateController)
    {
        //组件获取
        base.enter(stateController);
        m_animator = m_stateController.GetComponent<Animator>();
        m_rigidbody2D = m_stateController.GetComponent<Rigidbody2D>();
        m_fox = m_stateController.GetComponent<Fox>();
        m_transform = m_stateController.GetComponent<Transform>();
    }
    public override void update()
    {
        //移动输入更新
        MoveMent();
        Cut();
        //Shut();
        Silk();
        Climb();
    }
    //通用移动方法
    protected void MoveMent()
    {
        float horizontalmove = Input.GetAxisRaw("Horizontal");
        float speed = m_fox.speed;
        m_rigidbody2D.velocity = new Vector2(horizontalmove * speed, m_rigidbody2D.velocity.y);
        if(horizontalmove!=0)
        {
            m_transform.localScale = new Vector3(horizontalmove, 1, 1);
        }
    }
    //通用射击方法
    protected virtual void Shut()
    {
        //如果按下射击
        if(m_fox.shutPressed)
        {
            GameObject bullet = m_stateController.LoadPrefabs("Prefabs/bullet");
            bullet.transform.position = new Vector2(m_transform.position.x + m_fox.shutStartdistance * m_transform.localScale.x, m_transform.position.y);
            Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
            bulletRb.velocity = new Vector2(10 * m_transform.localScale.x, bulletRb.velocity.y);
            m_fox.shutPressed = false;
        }
    }
    protected void Climb()
    {
        //如果按下“上/下”键，且在梯子周围
        if (m_fox.climbPressed&&m_fox.inLadder)
        {
            //防止后面被切换为趴下状态
            m_fox.grouchPressed = false;
            //切换为climb状态
            m_stateController.ChangeState(FoxState.climb);
        }
    }
    protected virtual void Silk()
    {
        //如果按下射蜘蛛丝
        if (m_fox.silkPressed)
        {
            //加载蜘蛛丝预制体
            GameObject Silk = m_stateController.LoadPrefabs("Prefabs/silk");
            //初始化预制体的坐标
            Vector2 silkStart = m_fox.silkStart.position;
            Silk.transform.position = new Vector2(silkStart.x+1, silkStart.y);
            //设置发射点为父物体
            Silk.transform.SetParent(m_fox.silkStart);
            //计算旋转角度
            Vector3 vector3 = new Vector3(m_fox.shutPoint.x - m_transform.position.x, m_fox.shutPoint.y - m_transform.position.y, 0);
            vector3.Normalize();
            Vector3 horizontal = new Vector3(1, 0, 0);
            float degree = Vector3.Angle(horizontal, vector3);
            //旋转发射点
            m_fox.silkStart.transform.Rotate(0, 0,m_transform.localScale.x* degree);
            m_fox.silkPressed = false;
        }
    }
    protected void Cut()
    {
        if(m_fox.cutPressed)
        {
            m_fox.cutPressed = false;
            m_stateController.ChangeState(FoxState.cut);
        }
    }
}
