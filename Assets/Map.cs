using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour {
    public static Map instance = null;
	public List<GameObject> Tile;
    public GameObject Wall;
	public Player ThePlayer;
	public List<Enemy> Enemies;
	private List<Rolling> Obstacles;
	private List<GameObject> Floor;
	private List<GameObject> Walls;

    int XSize = 100;
    int YSize = 100;
	GameObject randomTile(){
		return Tile [Random.Range (0, Tile.Count)];
	}
    public void Roll() {
        foreach (var item in Enemies)
        {
            
        }
    }
    public static int round(float num){
        return (int)Mathf.Round(num);
    }
    /*public int round(float num){
        return (int)Mathf.Round(num);
    }*/
    public bool CanIGo(Direction direction, GameObject go) {
        int xPos=-1, yPos=-1;
        switch (direction)
        {
            case Direction.Down :
                xPos = round(go.transform.position.x);
                yPos = round(go.transform.position.z)-1;
                break;
            case Direction.Up :
                xPos = round(go.transform.position.x);
                yPos = round(go.transform.position.z)+1;
                break;
            case Direction.Left :
                xPos = round(go.transform.position.x)-1;
                yPos = round(go.transform.position.z);
                break;
            case Direction.Right :
                xPos = round(go.transform.position.x)+1;
                yPos = round(go.transform.position.z);
                break;
            case Direction.None :
                return true;
        }
        Debug.Log(xPos + " " + yPos + " " + direction);
        if (xPos < 0 || yPos < 0 || XSize < xPos || YSize < yPos) {
            return false;
        }
        if (xPos == round(ThePlayer.transform.position.x) && yPos == round(ThePlayer.transform.position.z) ) {
            return false;
        }
        if (Obstacles != null && Obstacles.Count > 0) {
            foreach (var item in Obstacles)
            {
                if (xPos == round(item.transform.position.x) && yPos == round(item.transform.position.z)) {
                    return false;
                }
            }
        }
        if (Walls != null && Walls.Count > 0) {
            foreach (var item in Walls)
            {
                if (xPos == round(item.transform.position.x) && yPos == round(item.transform.position.z)) {
                    return false;
                }
            }
        }
        return true;
    }
	// Use this for initialization
	void Start () {
		Floor = new List<GameObject> ();
		Walls = new List<GameObject> ();
		for (var x = 0; x < 20; x++) {
			for (var y = 0; y < 20; y++) {
				Floor.Add ((GameObject)Instantiate (randomTile (), new Vector3 (x, -.55f, y), Quaternion.identity));
                if (x == 0 || y == 0) {
                    Walls.Add((GameObject)Instantiate (Wall, new Vector3 (x, 0, y), Quaternion.identity));
                }
			}
		}
	}
    void Awake(){
         if (instance == null)
             instance = this;
         else if (instance != this)
             Destroy(gameObject);    
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
