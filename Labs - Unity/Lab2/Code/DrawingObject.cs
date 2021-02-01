using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Drawing.Glint;

public class DrawingObject : MonoBehaviour
{
    public bool PerformDraw = true;
    public float Roation = 0;
    public Vector3 Scale = Vector3.zero;
    public Vector3 Location = Vector3.zero;
    public List<ICommandInstruction> Lines = new List<ICommandInstruction>();

    public void Start()
    {
        Initalize(); 
    }

    public virtual void Initalize()
    {
    }

    public virtual void Update()
    {

       if (PerformDraw)
        {
            Draw(); 
        }
    }
    public virtual void Draw()
    {
        if (Lines.Count != 0)
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                Lines[i].Draw(Location);
            }
        }
    }
}
