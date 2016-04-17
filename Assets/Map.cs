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
	private List<List<Renderer>> Floor;
	private List<List<string>> mapData;
	private List<List<Renderer>> Walls;

    int XSize = 100;
    int YSize = 100;
	GameObject randomTile(){
		return Tile [Random.Range (0, Tile.Count)];
	}
    public void Roll() {
        int i;
        List<Renderer> f;
        List<Renderer> w;
        switch (ThePlayer.direction)
        {
            case Direction.Down :
                f = Floor[Floor.Count-1];
                w = Walls[Walls.Count-1];
                for (i = 0; i < f.Count; ++i) {
                    f[i].transform.position = new Vector3(f[i].transform.position.x,f[i].transform.position.y,f[i].transform.position.z-Floor.Count);
                    if (round(f[i].transform.position.z) < 0 || round(f[i].transform.position.x) < 0 || round(f[i].transform.position.z) >= mapData.Count || round(f[i].transform.position.x) >= mapData[0].Count){ f[i].enabled = false;}
                    else {f[i].enabled = (mapData[round(f[i].transform.position.z)][round(f[i].transform.position.x)] == "F");}
                    w[i].transform.position = new Vector3(w[i].transform.position.x,w[i].transform.position.y,w[i].transform.position.z-Floor.Count);
                    if (round(w[i].transform.position.z) < 0 || round(w[i].transform.position.x) < 0 || round(w[i].transform.position.z) >= mapData.Count || round(w[i].transform.position.x) >= mapData[0].Count){ w[i].enabled = true;}
                    else {w[i].enabled = (mapData[round(w[i].transform.position.z)][round(w[i].transform.position.x)] != "F");}
                }
                Floor.Remove(f);
                Floor.Insert(0,f);
                Walls.Remove(w);
                Walls.Insert(0,w);
                break;
            case Direction.Up :
                f = Floor[0];
                w = Walls[0];
                for (i = 0; i < f.Count; ++i) {
                    f[i].transform.position = new Vector3(f[i].transform.position.x,f[i].transform.position.y,f[i].transform.position.z+Floor.Count);
                    if (round(f[i].transform.position.z) < 0 || round(f[i].transform.position.x) < 0 || round(f[i].transform.position.z) >= mapData.Count || round(f[i].transform.position.x) >= mapData[0].Count){ f[i].enabled = false;}
                    else {f[i].enabled = (mapData[round(f[i].transform.position.z)][round(f[i].transform.position.x)] == "F");}
                    w[i].transform.position = new Vector3(w[i].transform.position.x,w[i].transform.position.y,w[i].transform.position.z+Floor.Count);
                    if (round(w[i].transform.position.z) < 0 || round(w[i].transform.position.x) < 0 || round(w[i].transform.position.z) >= mapData.Count || round(w[i].transform.position.x) >= mapData[0].Count){ w[i].enabled = true;}
                    else {w[i].enabled = (mapData[round(w[i].transform.position.z)][round(w[i].transform.position.x)] != "F");}
                }
                Floor.Remove(f);
                Floor.Add(f);
                Walls.Remove(w);
                Walls.Add(w);
                break;
            case Direction.Left :
                for (i = 0; i < Floor.Count; ++i) {
                    var v = Floor[i][Floor[i].Count-1];
                    v.transform.position = new Vector3(v.transform.position.x-Floor[i].Count,v.transform.position.y,v.transform.position.z);
                    if (round(v.transform.position.z) < 0 || round(v.transform.position.x) < 0 || round(v.transform.position.z) >= mapData.Count || round(v.transform.position.x) >= mapData[0].Count){ v.enabled = false;}
                    else {v.enabled = (mapData[round(v.transform.position.z)][round(v.transform.position.x)] == "F");}
                    Floor[i].Remove(v);
                    Floor[i].Insert(0,v);

                    v = Walls[i][Walls[i].Count-1];
                    v.transform.position = new Vector3(v.transform.position.x-Walls[i].Count,v.transform.position.y,v.transform.position.z);
                    if (round(v.transform.position.z) < 0 || round(v.transform.position.x) < 0 || round(v.transform.position.z) >= mapData.Count || round(v.transform.position.x) >= mapData[0].Count){ v.enabled = true;}
                    else {v.enabled = (mapData[round(v.transform.position.z)][round(v.transform.position.x)] != "F");}
                    Walls[i].Remove(v);
                    Walls[i].Insert(0,v);
                }
                break;
            case Direction.Right :
                for (i = 0; i < Floor.Count; ++i) {
                    var v = Floor[i][0];
                    v.transform.position = new Vector3(v.transform.position.x+Floor[i].Count,v.transform.position.y,v.transform.position.z);
                    if (round(v.transform.position.z) < 0 || round(v.transform.position.x) < 0 || round(v.transform.position.z) >= mapData.Count || round(v.transform.position.x) >= mapData[0].Count){ v.enabled = false;}
                    else {v.enabled =  ( mapData[round(v.transform.position.z)][round(v.transform.position.x)] == "F");}
                    Floor[i].Remove(v);
                    Floor[i].Add(v);

                    v = Walls[i][0];
                    v.transform.position = new Vector3(v.transform.position.x+Walls[i].Count,v.transform.position.y,v.transform.position.z);
                    if (round(v.transform.position.z) < 0 || round(v.transform.position.x) < 0 || round(v.transform.position.z) >= mapData.Count || round(v.transform.position.x) >= mapData[0].Count){ v.enabled = true;}
                    else {v.enabled = (mapData[round(v.transform.position.z)][round(v.transform.position.x)] != "F");}
                    Walls[i].Remove(v);
                    Walls[i].Add(v);
                }
                break;
            case Direction.None :
                break;
        }

        foreach (var item in Enemies) {
            item.Roll();
            item.render.enabled = (Mathf.Abs(item.transform.position.x-ThePlayer.transform.position.x) < 10 && Mathf.Abs(item.transform.position.z-ThePlayer.transform.position.z) < 10);
        }
        /*foreach (var item in Obstacles) {
            item.render.enabled = (Mathf.Abs(item.transform.position.x-ThePlayer.transform.position.x) < 10 && Mathf.Abs(item.transform.position.z-ThePlayer.transform.position.z) < 10);
        }*/
        /*foreach (var item in Walls) {
            item.enabled = (Mathf.Abs(item.transform.position.x-ThePlayer.transform.position.x) < 10 && Mathf.Abs(item.transform.position.z-ThePlayer.transform.position.z) < 10);
        }*/
        
    }
    public void RollDone(){
        foreach (var item in Enemies) {
            if ((round(item.transform.position.x-ThePlayer.transform.position.x) == 0 && round(Mathf.Abs(item.transform.position.z-ThePlayer.transform.position.z)) == 1)
            || (round(item.transform.position.z-ThePlayer.transform.position.z) == 0 && round(Mathf.Abs(item.transform.position.x-ThePlayer.transform.position.x)) == 1)) {
                if (item.FaceValue(Direction.None) < ThePlayer.FaceValue(Direction.None)) {
                    item.Damaged();
                    ThePlayer.Attack();
                }   
                else {
                    item.Attack();
                    ThePlayer.Damaged();
                } 
            }
            item.Roll();
            item.render.enabled = (Mathf.Abs(item.transform.position.x-ThePlayer.transform.position.x) < 10 && Mathf.Abs(item.transform.position.z-ThePlayer.transform.position.z) < 10);
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
        //Debug.Log(xPos + " " + yPos + " " + direction);
        if (xPos < 0 || yPos < 0 || XSize < xPos || YSize < yPos) {
            return false;
        }
        if ((xPos == round(ThePlayer.transform.position.x) && yPos == round(ThePlayer.transform.position.z) ) ||
            (xPos == round(ThePlayer.newPos.x) && yPos == round(ThePlayer.newPos.z) )) {
            return false;
        }
        if (Obstacles != null && Obstacles.Count > 0) {
            foreach (var item in Obstacles)
            {
                if ((xPos == round(item.transform.position.x) && yPos == round(item.transform.position.z)) ||
                    (xPos == round(item.newPos.x) && yPos == round(item.newPos.z))) {
                    return false;
                }
            }
        }
        if (Walls != null && Walls.Count > 0) {
            /*foreach (var item in Walls) {
                foreach (var i in item)
                {
                    if (xPos == round(i.transform.position.x) && yPos == round(i.transform.position.z) && i.enabled) {
                        return false;
                    }
                }
            }*/
            if (mapData[yPos][xPos] != "F") {
                Debug.Log(mapData[yPos][xPos]);
                return false;
            }
        }
        return true;
    }
	// Use this for initialization
	void Start () {
		Floor = new List<List<Renderer>> ();
		Walls = new List<List<Renderer>> ();
		for (var y = 0; y < 20; y++) {
            Floor.Add(new List<Renderer>());
            Walls.Add(new List<Renderer>());
		    for (var x = 0; x < 20; x++) {
                var f = ((GameObject)Instantiate (Tile[(x+y)&1], new Vector3 (x, -.1f, y), Quaternion.identity)).GetComponent<Renderer>();
                f.enabled = (mapData[y][x] == "F");
                Floor[y].Add (f);
                //if (x == 0 || y == 0) {
                    var r = ((GameObject)Instantiate (Wall, new Vector3 (x, 0, y), Quaternion.identity)).GetComponent<Renderer>();
                    r.enabled = (mapData[y][x] != "F");
                    Walls[y].Add(r);
                    
                //}
			}
		}
	}
    void Awake(){
         if (instance == null)
             instance = this;
         else if (instance != this)
             Destroy(gameObject);    
         var level = Resources.Load("dungeonV1") as TextAsset;
         var a = level.text.Split("\n"[0]);
         
         mapData = new List<List<string>>(); 
         foreach (var item in a) {
             var l = new List<string>();
             var b = item.Split("\t"[0]);
             foreach (var i in b) {
                l.Add(i);
             }
             mapData.Add(l);
         }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
