using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab01 : MonoBehaviour
{
    public class Grid2D
    {
        public Vector3 screenSize;
        public Vector3 origin;

        float gridSize = 10f;
        float minGridSize = 2f;
        public float originSize = 20f;

        int divisionCount = 5;
        int minDivisionCount = 2;
    }

    public Color axisColor = Color.white;
    public Color lineColor = Color.gray;
    public Color divisionColor = Color.yellow;

    public bool isDrawingOrigin = false;	
    public bool isDrawingAxis = true;
    public bool isDrawingDivisions = true;

    Grid2D grid = new Grid2D();

    private void Start()
    {
        grid.origin = new Vector3(Screen.width / 2, Screen.height / 2);
    }

    void Update()
    {

    }


    //Takes the potential grid space and outputs it into screen space
	public Vector3 GridToScreen(Vector3 gridSpace)
    {
        return Vector3.zero;
    }

    //Takes in screen space and outputs it as grid space
	public Vector3 ScreenToGrid(Vector3 screenSpace)
    {
        return Vector3.zero;
    }

    //Draws the given line
    public void DrawLine(Line line)
    {
        Glint.AddCommand(line);
    }

    //Draws the Origin Point (or Symbol)
    public void DrawOrigin()
    {
        
    }
}
