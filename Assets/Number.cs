using UnityEngine;
using System.Collections.Generic;
public enum Direction {
    Up,
    Down,
    Left,
    Right,
    None
}

public class Number : MonoBehaviour {
	public List<MeshFilter> numbers;
    MeshFilter meshFilter;
    Renderer render;
    int currentValue = 1;
    public void SetNumber(int val, Direction dir) {
        //Debug.Log("SetNumber " + val);
        if (val != currentValue) {
            meshFilter.sharedMesh = Instantiate(numbers[val-1].sharedMesh);
            currentValue = val;
        }
        switch (dir)
        {
            case Direction.Down :
                render.enabled = true;
                transform.localPosition = new Vector3(0,transform.localPosition.y,-1);
                break;
            case Direction.Up :
                render.enabled = true;
                transform.localPosition = new Vector3(0,transform.localPosition.y,1);
                break;
            case Direction.Left :
                render.enabled = true;
                transform.localPosition = new Vector3(-1,transform.localPosition.y,0);
                break;
            case Direction.Right :
                render.enabled = true;
                transform.localPosition = new Vector3(1,transform.localPosition.y,0);//-0.45f
                break;
            case Direction.None :
                render.enabled = false;
                transform.localPosition = new Vector3(0,transform.localPosition.y,0);
                break;
        }
    }
    public void HideNumber() {
        
    }
	// Use this for initialization
	void Awake () {
	    meshFilter = GetComponent<MeshFilter>();
        render = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
