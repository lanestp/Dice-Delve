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
    public List<Mesh> numbers;
    MeshFilter meshFilter;
    int currentValue = 1;
    public void SetNumber(int val, Direction dir) {
        if (val != currentValue) {
            meshFilter.mesh = Instantiate(numbers[val]);
            currentValue = val;
        }
        switch (dir)
        {
            case Direction.Down :
                transform.position = new Vector3(0,0,-1);
                break;
            case Direction.Up :
                transform.position = new Vector3(0,0,1);
                break;
            case Direction.Left :
                transform.position = new Vector3(-1,0,0);
                break;
            case Direction.Right :
                transform.position = new Vector3(1,0,0);
                break;
            case Direction.None :
                transform.position = new Vector3(0,0,0);
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
