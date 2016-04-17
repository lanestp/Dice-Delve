using UnityEngine;
using System.Collections;
using DG.Tweening;
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
        number.transform.DOMoveY(-0.6f,.2f);
        switch (direction)
        {
            case Direction.Down:
                RollDown(RollDone);
                break;
            case Direction.Up:
                RollUp(RollDone);
                break;
            case Direction.Left:
                RollLeft(RollDone);
                break;
            case Direction.Right:
                RollRight(RollDone);
                break;
            case Direction.None:
                RollNone(RollDone);
                break;
        }
    }
    void RollDone(){
        calculateDirection();
        number.SetNumber(2,direction);
        number.transform.DOMoveY(-0.45f,.2f);
    }
    public Direction direction;
    private Direction lastDirection;
    void calculateDirection () {
        Direction dir1, dir2;
        int x, y, playerx, playery;
        switch (type)
        {
            case EnemyType.Stand:
                direction = Direction.None; 
                break;  
            case EnemyType.Horizontal:
                if (direction == Direction.None) {direction = lastDirection;}
                else if (direction != Direction.Left && direction != Direction.Right) {
                    direction = Direction.Left;
                }
                if (!Map.instance.CanIGo(direction,this.gameObject)) {
                    direction = (direction == Direction.Left) ? Direction.Right : Direction.Left; 
                    if (!Map.instance.CanIGo(direction,this.gameObject)) {
                        direction = Direction.None; 
                    }
                }
                break;  
            case EnemyType.Vertical:
                if (direction == Direction.None) {direction = lastDirection;}
                else if (direction != Direction.Up && direction != Direction.Down) {
                    direction = Direction.Down;
                }
                if (!Map.instance.CanIGo(direction,this.gameObject)) {
                    direction = (direction == Direction.Up) ? Direction.Down : Direction.Up; 
                    if (!Map.instance.CanIGo(direction,this.gameObject)) {
                        direction = Direction.None; 
                    }
                }
                break;
            case EnemyType.MoveTowards:
                x = Map.round(transform.position.x);
                y = Map.round(transform.position.z);
                playerx = Map.round(Map.instance.ThePlayer.transform.position.x);
                playery = Map.round(Map.instance.ThePlayer.transform.position.z);
                if (Mathf.Abs(x-playerx) < Mathf.Abs(y-playery)){
                    Debug.Log("Move Y");
                    dir1 = (y < playery) ? Direction.Up : Direction.Down;
                    dir2 = (x < playerx) ? Direction.Right : Direction.Left;
                }
                else {
                    Debug.Log("Move X");
                    dir2 = (y < playery) ? Direction.Up : Direction.Down;
                    dir1 = (x < playerx) ? Direction.Right : Direction.Left;
                }
                if (!Map.instance.CanIGo(dir1,this.gameObject)) {
                    if (!Map.instance.CanIGo(dir2,this.gameObject)) {
                        direction = Direction.None; 
                    }
                    else {
                        direction = dir2;
                    }
                }
                else {
                    direction = dir1;
                }
                break;
            case EnemyType.MoveAway:
                x = Map.round(transform.position.x);
                y = Map.round(transform.position.z);
                playerx = Map.round(Map.instance.ThePlayer.transform.position.x);
                playery = Map.round(Map.instance.ThePlayer.transform.position.z);
                if (Mathf.Abs(x-playerx) < Mathf.Abs(y-playery)){
                    Debug.Log("Move Y");
                    dir1 = (y < playery) ? Direction.Down : Direction.Up;
                    dir2 = (x < playerx) ? Direction.Left : Direction.Right;
                }
                else {
                    Debug.Log("Move X");
                    dir2 = (y < playery) ? Direction.Down : Direction.Up;
                    dir1 = (x < playerx) ? Direction.Left : Direction.Right;
                }
                if (!Map.instance.CanIGo(dir1,this.gameObject)) {
                    if (!Map.instance.CanIGo(dir2,this.gameObject)) {
                        direction = Direction.None; 
                    }
                    else {
                        direction = dir2;
                    }
                }
                else {
                    direction = dir1;
                }
                break;
            case EnemyType.MoveTowardsVisible :
                x = Map.round(transform.position.x);
                y = Map.round(transform.position.z);
                playerx = Map.round(Map.instance.ThePlayer.transform.position.x);
                playery = Map.round(Map.instance.ThePlayer.transform.position.z);
                if (3 < Mathf.Abs(x-playerx) || 3 < Mathf.Abs(y-playery)) {
                    direction = Direction.None;
                    break; 
                }
                else if (Mathf.Abs(x-playerx) < Mathf.Abs(y-playery)){
                    Debug.Log("Move Y");
                    dir1 = (y < playery) ? Direction.Up : Direction.Down;
                    dir2 = (x < playerx) ? Direction.Right : Direction.Left;
                }
                else {
                    Debug.Log("Move X");
                    dir2 = (y < playery) ? Direction.Up : Direction.Down;
                    dir1 = (x < playerx) ? Direction.Right : Direction.Left;
                }
                if (!Map.instance.CanIGo(dir1,this.gameObject)) {
                    if (!Map.instance.CanIGo(dir2,this.gameObject)) {
                        direction = Direction.None; 
                    }
                    else {
                        direction = dir2;
                    }
                }
                else {
                    direction = dir1;
                }
                break;
            case EnemyType.MoveAwayVisible :
                x = Map.round(transform.position.x);
                y = Map.round(transform.position.z);
                playerx = Map.round(Map.instance.ThePlayer.transform.position.x);
                playery = Map.round(Map.instance.ThePlayer.transform.position.z);
                if (3 < Mathf.Abs(x-playerx) || 3 < Mathf.Abs(y-playery)) {
                    direction = Direction.None;
                    break; 
                }
                else if (Mathf.Abs(x-playerx) < Mathf.Abs(y-playery)){
                    Debug.Log("Move Y");
                    dir1 = (y < playery) ? Direction.Down : Direction.Up;
                    dir2 = (x < playerx) ? Direction.Left : Direction.Right;
                }
                else {
                    Debug.Log("Move X");
                    dir2 = (y < playery) ? Direction.Down : Direction.Up;
                    dir1 = (x < playerx) ? Direction.Left : Direction.Right;
                }
                if (!Map.instance.CanIGo(dir1,this.gameObject)) {
                    if (!Map.instance.CanIGo(dir2,this.gameObject)) {
                        direction = Direction.None; 
                    }
                    else {
                        direction = dir2;
                    }
                }
                else {
                    direction = dir1;
                }
                break;
            case EnemyType.Random :
                direction = (Direction)Random.Range(0,4);
                if (!Map.instance.CanIGo(direction,this.gameObject)) {
                    direction = Direction.Down;
                    if (Map.instance.CanIGo(direction,this.gameObject)) {
                        break;
                    }
                    direction = Direction.Up;
                    if (Map.instance.CanIGo(direction,this.gameObject)) {
                        break;
                    }
                    direction = Direction.Left;
                    if (Map.instance.CanIGo(direction,this.gameObject)) {
                        break;
                    }
                    direction = Direction.Right;
                    if (Map.instance.CanIGo(direction,this.gameObject)) {
                        break;
                    }
                }
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
        calculateDirection();
        lastDirection = direction;
        number.SetNumber(1,direction);
        number.transform.DOMoveY(-0.45f,.2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
