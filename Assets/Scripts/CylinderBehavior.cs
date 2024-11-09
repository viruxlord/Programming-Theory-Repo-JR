using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderBehavior : ShapeBehavior
{
    void Start()
    {
        SetColor();
    }

    // Update is called once per frame
    void Update()
    {
        MoveShape();
    }

    public override void MoveShape()
    {
        MoveTo = new Vector3(0, 0, 4);
        base.MoveShape();

    }
}
