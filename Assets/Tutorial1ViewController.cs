using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial1ViewController : MonoBehaviour {
	public Button Next;
	public Button Back;
	public Canvas BackCanvas;
	public Canvas NextCanvas;
	// Use this for initialization
	void Start () {
		Next.onClick.AddListener(()=>{
			NextCanvas.gameObject.SetActive(true);
			gameObject.SetActive(true);
		});
		Back.onClick.AddListener(()=>{
			BackCanvas.gameObject.SetActive(true);
			gameObject.SetActive(true);
		});
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
