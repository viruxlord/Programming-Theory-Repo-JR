using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : ShapeBehavior
{   
    // Start is called before the first frame update
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
        MoveTo= new Vector3(0,0,3);
        base.MoveShape();
        
    }

}