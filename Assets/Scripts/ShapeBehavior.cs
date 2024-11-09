using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBehavior : MonoBehaviour
{
    public Material[] materials;
    public int timesClicked { get; private set; }
    public Vector3 MoveTo = new Vector3(0, 0, 5);
    // Start is called before the first frame update
    void Start()
    {
        timesClicked = 0;
        SetColor();
    }

    // Update is called once per frame
    void Update()
    {
        MoveShape();
    }
   public virtual void SetColor()
    {
        MeshRenderer material = gameObject.GetComponent<MeshRenderer>();
        material.material = materials[0];
    }
    public virtual void MoveShape()
    {
        if (Input.GetKeyDown(KeyCode.Space) && timesClicked<1)
        {
            transform.position = transform.position + MoveTo;
            timesClicked++;
        }

    }
 
}
