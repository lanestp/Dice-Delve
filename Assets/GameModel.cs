using UnityEngine;
using System.Collections;

public class GameModel : MonoBehaviour {
    public int Mana = 3;
    public int Health = 3;
    public static GameModel instance = null;
	// Use this for initialization
	void Awake(){
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);    
            DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
