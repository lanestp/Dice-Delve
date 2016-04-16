using UnityEngine;
using System.Collections;

public class Player : Rolling {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        bool didRoll = false;
        if (0.25f < Input.GetAxis("Horizontal")) {
            didRoll = RollRight();
        }
        else if (Input.GetAxis("Horizontal") < -0.25f) {
            didRoll = RollLeft();
        }
        else if (0.25f < Input.GetAxis("Vertical")) {
            didRoll = RollUp();
        }
        else if (Input.GetAxis("Vertical") < -0.25f) {
            didRoll = RollDown();
        }
        if (didRoll) {
            Map.instance.Roll();
        }
	}
}
