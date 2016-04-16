using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
    public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	     transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x+2.22f, 8.2f, target.position.z-3.6f),0.05f);
	}
}
