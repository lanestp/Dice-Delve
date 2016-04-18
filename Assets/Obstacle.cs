using UnityEngine;
using System.Collections;

public enum ObstacleType {
	Enemy,
	Mana,
	Health,
	Goal
}
public class Obstacle : MonoBehaviour {
	public ObstacleType type;
	public Renderer render;
	// Use this for initialization
	void Awake () {
		render = GetComponent<Renderer>();
	}
	public void Collect() {
		if (type == ObstacleType.Goal){
			foreach (var item in Map.instance.ThePlayer.Victory)
			{
				item.SetActive(true);
			}
			
		}
		else if (type == ObstacleType.Mana){
			GameModel.instance.Mana++;
		}
		else if (type == ObstacleType.Health){
			GameModel.instance.Health++;
		}
		Map.instance.Obstacles.Remove(this);
		Destroy(this.gameObject);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
