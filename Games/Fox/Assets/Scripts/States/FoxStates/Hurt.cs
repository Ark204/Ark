using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : FoxState
{
    public Hurt(StateController stateController) : base(stateController) { }
    public override void enter()
    {
        base.enter();
        //����hurt����
        m_animator.Play("hurt");
    }
    public override void update()
    {
        //���ٵ��û�����ƶ��Լ����
    }
    public override void exit()
    {
        
    }
}
