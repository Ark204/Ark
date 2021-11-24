using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : OnGround
{
    public Defense(StateController stateController) : base(stateController) { }
    public override void enter()
    {
        //����hurt����
        Debug.Log("���ŷ�������");
    }
    public override void update()
    {
        //������ٰ����¶׼�
        if (!m_fox.defensePressed)
        {
            //�л�վ��״̬
            m_stateController.ChangeState("Idle");
        }
    }
    public override void exit()
    {
        Debug.Log("��������");
    }
}
