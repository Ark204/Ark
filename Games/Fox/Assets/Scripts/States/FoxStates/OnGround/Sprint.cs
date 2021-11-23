using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : OnGround
{
    private float moveTime;
    public override void enter(StateController stateController)
    {
        base.enter(stateController);
        //��ʼ���ƶ�ʱ��
        moveTime= m_fox.sprintTime;
        //�����޵�
        //ȡ������
        m_rigidbody2D.gravityScale = 0;
        //ȡ��������ײ��
        m_stateController.GetComponent<BoxCollider2D>().enabled = false;
        m_stateController.GetComponent<PolygonCollider2D>().enabled = false;
    }
    public override void update()
    {
        moveTime -= Time.fixedDeltaTime;
        //�����̽���
        if(moveTime<0)
        {
            m_stateController.ChangeState(FoxState.idle);
        }
        else
        {
            m_rigidbody2D.velocity = new Vector2(m_transform.localScale.x * m_fox.sprintspeed, m_rigidbody2D.velocity.y);
        }
    }
    public override void exit()
    {
        //��ԭ������ײ��
        m_stateController.GetComponent<BoxCollider2D>().enabled = true;
        m_stateController.GetComponent<PolygonCollider2D>().enabled = true;
        //�ָ�����
        m_rigidbody2D.gravityScale = 3;
        //�˳��޵�
    }
}
