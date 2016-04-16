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
    int currentValue = 1;
    public void SetNumber(int val, Direction dir) {
        Debug.Log("SetNumber " + val);
        if (val != currentValue) {
            meshFilter.sharedMesh = Instantiate(numbers[val-1].sharedMesh);
            currentValue = val;
        }
        switch (dir)
        {
            case Direction.Down :
                transform.localPosition = new Vector3(0,-0.45f,-1);
                break;
            case Direction.Up :
                transform.localPosition = new Vector3(0,-0.45f,1);
                break;
            case Direction.Left :
                transform.localPosition = new Vector3(-1,-0.45f,0);
                break;
            case Direction.Right :
                transform.localPosition = new Vector3(1,-0.45f,0);
                break;
            case Direction.None :
                transform.localPosition = new Vector3(0,0,0);
                break;
        }
    }
    public void HideNumber() {
        
    }
	// Use this for initialization
	void Start () {
	    meshFilter = GetComponent<MeshFilter>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
