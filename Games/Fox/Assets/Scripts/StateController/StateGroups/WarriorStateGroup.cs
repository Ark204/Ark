using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ö÷½Ç×´Ì¬×é
public class WarriorStateGroup : IStateGroup
{
    public override void InitDictionary(StateController stateController)
    {
        states.Add("WarIdle", new WarIdle(stateController));
        states.Add("WarRun", new WarRun(stateController));
        states.Add("WarChase", new WarChase(stateController));
        firststate = states["WarIdle"];
    }
}
