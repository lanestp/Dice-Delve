using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CameraMover : MonoBehaviour {
	public GameObject Logo;
	// Use this for initialization
	void Start () {
		//transform.DOLocalMove(new Vector3())
		transform.DOLocalMoveY(-8f,2.0f);
		transform.DORotate(new Vector3(-40,0,0),2.0f);
		Logo.transform.DORotate(new Vector3(60,180,0),2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
