using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenItem : ItemBase
{
    public bool _havePen;

    private void Start()
    {
        _havePen = false;
    }

    public override void Activate()
    {
        _havePen = true;
    }
}
