using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Player : Rolling {
	// Use this for initialization
	public Number UpNumber;
	public Number DownNumber;
	public Number LeftNumber;
	public Number RightNumber;
    void Start () {
	    DoneRoll();
	}
	void DoneRoll(){
        RightNumber.transform.parent = LeftNumber.transform.parent = DownNumber.transform.parent = UpNumber.transform.parent = transform;
        UpNumber.SetNumber(FaceValue(Direction.Up), Direction.Up);
        DownNumber.SetNumber(FaceValue(Direction.Down), Direction.Down);
        LeftNumber.SetNumber(FaceValue(Direction.Left), Direction.Left);
        RightNumber.SetNumber(FaceValue(Direction.Right), Direction.Right);
        RightNumber.transform.DOMoveY(-0.45f,.2f);
        LeftNumber.transform.DOMoveY(-0.45f,.2f);
        UpNumber.transform.DOMoveY(-0.45f,.2f);
        DownNumber.transform.DOMoveY(-0.45f,.2f);
    }
	// Update is called once per frame
	void Update () {
        bool didRoll = false;
        if (0.25f < Input.GetAxis("Horizontal")) {
            didRoll = RollRight(DoneRoll);
        }
        else if (Input.GetAxis("Horizontal") < -0.25f) {
            didRoll = RollLeft(DoneRoll);
        }
        else if (0.25f < Input.GetAxis("Vertical")) {
            didRoll = RollUp(DoneRoll);
        }
        else if (Input.GetAxis("Vertical") < -0.25f) {
            didRoll = RollDown(DoneRoll);
        }
        if (didRoll) {
            RightNumber.transform.parent = LeftNumber.transform.parent = DownNumber.transform.parent = UpNumber.transform.parent = null;
            RightNumber.transform.DOMoveY(-0.6f,.2f);
            LeftNumber.transform.DOMoveY(-0.6f,.2f);
            UpNumber.transform.DOMoveY(-0.6f,.2f);
            DownNumber.transform.DOMoveY(-0.6f,.2f);
            Map.instance.Roll();
        }
	}
}
