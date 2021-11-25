using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarChase : WarriorState
{
    public WarChase(StateController stateController) : base(stateController) { }
    public override void enter()
    {
        //≤•∑≈≈‹≤Ω∂Øª≠
        m_animator.Play("run");
        Debug.Log("Chase");
    }
    public override void update()
    {
        FlipTo(m_oppssum.target);
        if(m_oppssum.target)
        {
            m_transform.position = Vector2.MoveTowards(m_transform.position,
                m_oppssum.target.position, m_oppssum.chasespeed * Time.fixedDeltaTime);
        }
        if (m_oppssum.target == null ||
            m_transform.position.x < m_oppssum.chasePoint[0].position.x ||
            m_transform.position.x > m_oppssum.chasePoint[1].position.x)
        {
            m_stateController.ChangeState("WarIdle");
        }

    }
    public override void exit()
    {
        Debug.Log("exit Chase");
    }
    
}
