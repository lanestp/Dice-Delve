using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class Rolling : MonoBehaviour {
    public List<SideValue> Values;
    public GameObject child;
    bool isRolling = false;
    public Vector3 newPos;
    public int FaceValue(Direction dir) {
        foreach (var item in Values) {
           switch (dir) {
            case Direction.Down :
                if ((int)Mathf.Round(item.transform.position.z - transform.position.z) == 1) {return item.Side;}
                break;
            case Direction.Up :
                if ((int)Mathf.Round(item.transform.position.z - transform.position.z) == -1) {return item.Side;}
                break;
            case Direction.Left :
                if ((int)Mathf.Round(item.transform.position.x - transform.position.x) == 1) {return item.Side;}
                break;
            case Direction.Right :
                if ((int)Mathf.Round(item.transform.position.x - transform.position.x) == -1) {return item.Side;}
                break;
            case Direction.None :
                if ((int)Mathf.Round(item.transform.position.y - transform.position.y) == 1) {return item.Side;}
                break;
        }

        }
        return -1;        
    }
    int showingFace;
    IEnumerator Roll(Vector3 rot, Vector3 move, Action callback) {
       isRolling = true;
       newPos = transform.position + move;
       yield return new WaitForEndOfFrame();
       transform.DOBlendableLocalRotateBy(rot,0.5f,RotateMode.LocalAxisAdd);
       transform.DOBlendableLocalMoveBy(move,0.5f,false);
       var mySequence = DOTween.Sequence();
       mySequence.Append(transform.DOBlendableLocalMoveBy(new Vector3(0,0.175f,0),.2f,false).SetEase(Ease.OutQuart));
       mySequence.Append(transform.DOBlendableLocalMoveBy(new Vector3(0,-0.175f,0),.25f,false).SetEase(Ease.Linear));
       yield return new WaitForSeconds(.55f);
       child.transform.parent = null;
       transform.localRotation = Quaternion.identity;
       child.transform.parent = transform;       
       isRolling = false;
       showingFace = FaceValue(Direction.None);
       if (callback != null){callback();}
    }
    IEnumerator NoRoll(Action callback) {
       isRolling = true;
       yield return new WaitForEndOfFrame();
       yield return new WaitForSeconds(.55f);
       isRolling = false;
       if (callback != null){callback();}
    }
    public bool RollLeft(Action callback = null) {
       if (isRolling || !Map.instance.CanIGo(Direction.Left,this.gameObject)) {return false;}
       StartCoroutine(Roll(new Vector3(0,0,90),new Vector3(-1,0,0),callback));
       return true;
    }
    public bool RollRight(Action callback = null) {
       if (isRolling || !Map.instance.CanIGo(Direction.Right,this.gameObject)) {return false;}
       StartCoroutine(Roll(new Vector3(0,0,-90),new Vector3(1,0,0),callback));
       return true;
    }
    public bool RollUp(Action callback = null) {
       if (isRolling || !Map.instance.CanIGo(Direction.Up,this.gameObject)) {return false;}
       StartCoroutine(Roll(new Vector3(90,0,0),new Vector3(0,0,1),callback));
       return true;
    }
    public bool RollDown(Action callback = null) {
       if (isRolling || !Map.instance.CanIGo(Direction.Down,this.gameObject)) {return false;}
       StartCoroutine(Roll(new Vector3(-90,0,0),new Vector3(0,0,-1),callback));
       return true;
    }
    public bool RollNone(Action callback = null) {
       if (isRolling) {return false;}
       StartCoroutine(NoRoll(callback));
       return true;
    }
	// Use this for initialization
	void Awake () {
       showingFace = FaceValue(Direction.None);
       newPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
