using UnityEngine;
using System.Collections;

public enum EnemyType {
    Stand,
    Horizontal,
    Vertical,
    MoveTowards,
    MoveAway,
    MoveTowardsVisible,
    MoveAwayVisible,
    Random
}
public class Enemy : Rolling {
    public EnemyType type;
    public Number number;
    public void Roll(){
        
    }
    public Direction direction;
    private Direction lastDirection;
    void calculateDirection () {
        switch (type)
        {
            case EnemyType.Stand:
                direction = Direction.None; 
                break;  
            case EnemyType.Horizontal:
                if (direction == Direction.None) {direction = lastDirection;}
                if (!Map.instance.CanIGo(direction,this.gameObject)) {
                    direction = (direction == Direction.Left) ? Direction.Right : Direction.Left; 
                    if (!Map.instance.CanIGo(direction,this.gameObject)) {
                        direction = Direction.None; 
                    }
                }
                break;  
            case EnemyType.Vertical:
                if (direction == Direction.None) {direction = lastDirection;}
                if (!Map.instance.CanIGo(direction,this.gameObject)) {
                    direction = (direction == Direction.Up) ? Direction.Down : Direction.Up; 
                    if (!Map.instance.CanIGo(direction,this.gameObject)) {
                        direction = Direction.None; 
                    }
                }
                break;
            case EnemyType.MoveTowards:
                Direction dir1, dir2;
                int x = Map.round(transform.position.x);
                int y = Map.round(transform.position.z);
                int playerx = Map.round(Map.instance.ThePlayer.transform.position.x);
                int playery = Map.round(Map.instance.ThePlayer.transform.position.y);
                if (Mathf.Abs(x-playerx) < Mathf.Abs(y-playery)){
                    dir1 = (y < playery) ? Direction.Up : Direction.Down;
                    dir2 = (x < playerx) ? Direction.Right : Direction.Up;
                }
                else {
                    dir2 = (y < playery) ? Direction.Up : Direction.Down;
                    dir1 = (x < playerx) ? Direction.Right : Direction.Up;
                }
                if (!Map.instance.CanIGo(dir1,this.gameObject)) {
                    if (!Map.instance.CanIGo(dir2,this.gameObject)) {
                        direction = Direction.None; 
                    }
                }
                
                break;
            case EnemyType.Random :
                
                break;
            default:
                break;
        }
        if (direction != Direction.None){
            lastDirection = direction;
        }
        number.SetNumber(1,direction);
    }
	// Use this for initialization
	void Start () {
        lastDirection = direction;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
