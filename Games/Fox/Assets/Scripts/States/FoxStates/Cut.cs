using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : FoxState
{
    private float cutTime;
    public override void enter(StateController stateController)
    {
        base.enter(stateController);
        //初始化状态持续时间
        cutTime = m_fox.cutTime;
        //砍的次数减一
        m_fox.cutCount--;
        if(m_fox.cutCount==1)
        {
            Debug.Log("播放第一砍动画");
        }
        if(m_fox.cutCount==0)
        {
            Debug.Log("播放第二砍动画");
        }
        //开启攻击范围
        m_stateController.GetComponentInChildren<CircleCollider2D>().enabled = true;
    }
    public override void update()
    {
        cutTime -= Time.fixedDeltaTime;
        if(m_fox.cutPressed&&m_fox.cutCount>0)
        {
            m_fox.cutPressed = false;
            //进入二砍状态
            m_stateController.ChangeState(FoxState.cut);
        }
        //如果砍完了
        if(cutTime<0)
        {
            //返回idle状态
            m_stateController.ChangeState(FoxState.idle);
        }
    }
    public override void exit()
    {
        m_stateController.GetComponentInChildren<CircleCollider2D>().enabled = false;
    }
    public override void onTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemies")
        {
            Debug.Log("焯");
            collision.GetComponent<Oppssum>().Red -= 1;
            //collision.GetComponent<Rigidbody2D>().velocity = new Vector2(m_transform.localScale.x * 5, 5);
        }
    }
}
