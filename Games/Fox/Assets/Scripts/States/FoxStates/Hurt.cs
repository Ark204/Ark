using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : FoxState
{
    public Hurt(StateController stateController) : base(stateController) { }
    public override void enter()
    {
        base.enter();
        //播放hurt动画
        m_animator.Play("hurt");
    }
    public override void update()
    {
        //不再调用基类的移动以及射击
    }
    public override void exit()
    {
        
    }
}
