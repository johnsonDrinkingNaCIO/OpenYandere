using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMultiPersonActivity 
{
    public bool waitForPeople();
    public void giveActivity();
}
