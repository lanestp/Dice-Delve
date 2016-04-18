using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuViewController : MonoBehaviour {
	public Button StartButton;
	public Button TutorialButton;
	public Canvas TutorialCanvas;
	public Canvas MainCanvas;
	// Use this for initialization
	void Start () {
		StartButton.onClick.AddListener(()=>{
			MainCanvas.gameObject.SetActive(true);
			gameObject.SetActive(false);
		});
		TutorialButton.onClick.AddListener(()=>{
			TutorialCanvas.gameObject.SetActive(true);
			gameObject.SetActive(false);
		});
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
