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
        if (!render.enabled){return;}
        if (type == EnemyType.MoveTowardsVisible) {
                int x = Map.round(transform.position.x);
                int y = Map.round(transform.position.z);
                int playerx = Map.round(Map.instance.ThePlayer.transform.position.x);
                int playery = Map.round(Map.instance.ThePlayer.transform.position.z);
                if ((Mathf.Abs(x - playerx) == 1 && Mathf.Abs(y - playery) == 0) ||
                    (Mathf.Abs(x - playerx) == 0 && Mathf.Abs(y - playery) == 1) || 
                    (Mathf.Abs(x - Map.round(Map.instance.ThePlayer.newPos.x)) == 0 && Mathf.Abs(y - Map.round(Map.instance.ThePlayer.newPos.z)) == 1) ||
                    (Mathf.Abs(x - Map.round(Map.instance.ThePlayer.newPos.x)) == 1 && Mathf.Abs(y - Map.round(Map.instance.ThePlayer.newPos.z)) == 0)){
                        EnemyDirection = Direction.None; 
                }

            //calculateDirection();
        }
        number.transform.position = new Vector3(number.transform.position.x,-0.6f,number.transform.position.z);
        //number.transform.DOMoveY(-0.6f,.15f);
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
    public override void Damaged() {
        Die();
    }
    public override void Attack() {
        transform.DOMoveY(.1f,.1f).OnComplete(()=>{
            transform.DOMoveY(0f,.1f);
        });

    }
    public override void Die(){
        Map.instance.Enemies.Remove(this);
        transform.DOScale(Vector3.zero,0.5f).OnComplete(()=>{
            Destroy(this.gameObject);
        });
        
    }

    void RollDone(){
        calculateDirection();
        number.SetNumber(FaceValue(EnemyDirection),EnemyDirection);
        number.transform.position = new Vector3(number.transform.position.x,-0.5f,number.transform.position.z);

        //number.transform.DOMoveY(-0.5f,.2f);
    }
    public Direction EnemyDirection;
    private Direction lastDirection;
    void calculateDirection () {
        Direction dir1, dir2;
        int x, y, playerx, playery, newplayerx, newplayery;
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
                /*if ((x == playerx && y == playery) || (x == Map.instance.ThePlayer.newPos.x && y == Map.instance.ThePlayer.newPos.z){
                        EnemyDirection = Direction.None; 
                        break;                    
                }*/
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
                if ((Mathf.Abs(x - playerx) == 1 && Mathf.Abs(y - playery) == 0) ||
                    (Mathf.Abs(x - playerx) == 0 && Mathf.Abs(y - playery) == 1) || 
                    (Mathf.Abs(x - Map.round(Map.instance.ThePlayer.newPos.x)) == 0 && Mathf.Abs(y - Map.round(Map.instance.ThePlayer.newPos.z)) == 1) ||
                    (Mathf.Abs(x - Map.round(Map.instance.ThePlayer.newPos.x)) == 1 && Mathf.Abs(y - Map.round(Map.instance.ThePlayer.newPos.z)) == 0)){
                        EnemyDirection = Direction.None; 
                        break;                    
                }
                if (4 < Mathf.Abs(x-playerx) || 4 < Mathf.Abs(y-playery)) {
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
        //number.SetNumber(FaceValue(EnemyDirection),EnemyDirection);
        Debug.Log(FaceValue(EnemyDirection));
    }
	// Use this for initialization
	void Start () {
        calculateDirection();
        lastDirection = EnemyDirection;
        number.SetNumber(FaceValue(EnemyDirection),EnemyDirection);
        number.transform.position = new Vector3(number.transform.position.x,-0.6f,number.transform.position.z);
        //number.transform.DOMoveY(-0.5f,.2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
}
