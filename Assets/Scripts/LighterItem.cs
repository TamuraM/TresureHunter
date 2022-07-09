using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterItem : ItemBase
{
    public bool _haveLighter;

    void Start()
    {
        _haveLighter = false;
    }

    public override void Activate()
    {
        _haveLighter = true;
    }
}
