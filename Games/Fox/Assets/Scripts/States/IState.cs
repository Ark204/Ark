using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[System.Serializable]
public class IState 
{
    protected StateController m_stateController;
    public virtual void update()
    {

    }
    public virtual void enter(StateController stateController)
    {
        //start
        m_stateController = stateController;
    }
    public virtual void exit()
    { }
    public virtual void onCollisionEnter2D(Collision2D collision)
    { }
    public virtual void onTriggerEnter2D(Collider2D collision)
    { }
    public virtual void onTriggerStay2D(Collider2D collision)
    { }
    public virtual void onTriggerExit2D(Collider2D collision)
    { }
}
