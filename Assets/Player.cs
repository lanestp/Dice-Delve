using UnityEngine;
using System.Collections;

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
        UpNumber.SetNumber(FaceValue(Direction.Up), Direction.Up);
        DownNumber.SetNumber(FaceValue(Direction.Down), Direction.Down);
        LeftNumber.SetNumber(FaceValue(Direction.Left), Direction.Left);
        RightNumber.SetNumber(FaceValue(Direction.Right), Direction.Right);
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
            Map.instance.Roll();
        }
	}
}
