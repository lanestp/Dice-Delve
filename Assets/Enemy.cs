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
        switch (EnemyDirection)
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
        number.SetNumber(2,EnemyDirection);
        number.transform.DOMoveY(-0.45f,.2f);
    }
    public Direction EnemyDirection;
    private Direction lastDirection;
    void calculateDirection () {
        Direction dir1, dir2;
        int x, y, playerx, playery;
        switch (type)
        {
            case EnemyType.Stand:
                EnemyDirection = Direction.None; 
                break;  
            case EnemyType.Horizontal:
                if (EnemyDirection == Direction.None) {EnemyDirection = lastDirection;}
                else if (EnemyDirection != Direction.Left && EnemyDirection != Direction.Right) {
                    EnemyDirection = Direction.Left;
                }
                if (!Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                    EnemyDirection = (EnemyDirection == Direction.Left) ? Direction.Right : Direction.Left; 
                    if (!Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                        EnemyDirection = Direction.None; 
                    }
                }
                break;  
            case EnemyType.Vertical:
                if (EnemyDirection == Direction.None) {EnemyDirection = lastDirection;}
                else if (EnemyDirection != Direction.Up && EnemyDirection != Direction.Down) {
                    EnemyDirection = Direction.Down;
                }
                if (!Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                    EnemyDirection = (EnemyDirection == Direction.Up) ? Direction.Down : Direction.Up; 
                    if (!Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                        EnemyDirection = Direction.None; 
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
                        EnemyDirection = Direction.None; 
                    }
                    else {
                        EnemyDirection = dir2;
                    }
                }
                else {
                    EnemyDirection = dir1;
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
                        EnemyDirection = Direction.None; 
                    }
                    else {
                        EnemyDirection = dir2;
                    }
                }
                else {
                    EnemyDirection = dir1;
                }
                break;
            case EnemyType.MoveTowardsVisible :
                x = Map.round(transform.position.x);
                y = Map.round(transform.position.z);
                playerx = Map.round(Map.instance.ThePlayer.transform.position.x);
                playery = Map.round(Map.instance.ThePlayer.transform.position.z);
                if (3 < Mathf.Abs(x-playerx) || 3 < Mathf.Abs(y-playery)) {
                    EnemyDirection = Direction.None;
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
                        EnemyDirection = Direction.None; 
                    }
                    else {
                        EnemyDirection = dir2;
                    }
                }
                else {
                    EnemyDirection = dir1;
                }
                break;
            case EnemyType.MoveAwayVisible :
                x = Map.round(transform.position.x);
                y = Map.round(transform.position.z);
                playerx = Map.round(Map.instance.ThePlayer.transform.position.x);
                playery = Map.round(Map.instance.ThePlayer.transform.position.z);
                if (3 < Mathf.Abs(x-playerx) || 3 < Mathf.Abs(y-playery)) {
                    EnemyDirection = Direction.None;
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
                        EnemyDirection = Direction.None; 
                    }
                    else {
                        EnemyDirection = dir2;
                    }
                }
                else {
                    EnemyDirection = dir1;
                }
                break;
            case EnemyType.Random :
                EnemyDirection = (Direction)Random.Range(0,4);
                if (!Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                    EnemyDirection = Direction.Down;
                    if (Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                        break;
                    }
                    EnemyDirection = Direction.Up;
                    if (Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                        break;
                    }
                    EnemyDirection = Direction.Left;
                    if (Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                        break;
                    }
                    EnemyDirection = Direction.Right;
                    if (Map.instance.CanIGo(EnemyDirection,this.gameObject)) {
                        break;
                    }
                }
                break;
            default:
                break;
        }
        if (EnemyDirection != Direction.None){
            lastDirection = EnemyDirection;
        }
        number.SetNumber(1,EnemyDirection);
    }
	// Use this for initialization
	void Start () {
        calculateDirection();
        lastDirection = EnemyDirection;
        number.SetNumber(1,EnemyDirection);
        number.transform.DOMoveY(-0.45f,.2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
