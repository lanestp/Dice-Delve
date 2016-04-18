using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HudViewController : MonoBehaviour {
    public Canvas Menu;
    public Image HeartImage;
    public Image ManaImage;
	public Transform HeartParent;
	public Transform ManaParent;
    
    public Button Spellbook;
    public Button Slide;
    public Button Randomize;
    public Button ManaToHealth;
    public Button HealthToMana;
    
    private List<Image> Hearts;
    private List<Image> Manas;
    // Use this for initialization
	void Start () {
	    Hearts = new List<Image>();
	    Manas = new List<Image>();
        for (var i = 0; i < GameModel.instance.Mana; ++i) {
            var m = (Image)Instantiate(ManaImage);
            m.transform.parent = ManaParent;
                    m.transform.localScale = new Vector3(1,1,1);
            Manas.Add(m);
        }
        for (var i = 0; i < GameModel.instance.Health; ++i) {
            var m = (Image)Instantiate(HeartImage);
            m.transform.parent = HeartParent;
                    m.transform.localScale = new Vector3(1,1,1);
            Hearts.Add(m);
        }
        Spellbook.onClick.AddListener(()=>{
            gameObject.SetActive(false);
            Menu.gameObject.SetActive(true);
        });
        ManaToHealth.onClick.AddListener(()=>{
            if (GameModel.instance.Mana > 0 && !Map.instance.ThePlayer.isRolling) {
                GameModel.instance.Mana--;
                GameModel.instance.Health++;
                Map.instance.ThePlayer.CastSpell(new Color(0x00/255f,0x00/255f,0xaa/255f,128/255f));
            }
        });
        Slide.onClick.AddListener(()=>{
            if (GameModel.instance.Mana > 0 && !Map.instance.ThePlayer.Slide && !Map.instance.ThePlayer.isRolling) {
                Map.instance.ThePlayer.SetSlide();
                GameModel.instance.Mana--;
                Map.instance.ThePlayer.CastSpell(new Color(0xaa/255f,0,0xaa/255f,128/255f));
            }
        });
        HealthToMana.onClick.AddListener(()=>{
            if (GameModel.instance.Health > 1 && !Map.instance.ThePlayer.isRolling) {
                GameModel.instance.Mana++;
                GameModel.instance.Health--;
                Map.instance.ThePlayer.CastSpell(new Color(0xaa/255f,0,0,128/255f));
            }
        });
        Randomize.onClick.AddListener(()=>{
            if (GameModel.instance.Mana > 0 && !Map.instance.ThePlayer.isRolling) {
                Map.instance.ThePlayer.Scramble();
                GameModel.instance.Mana--;
                Map.instance.ThePlayer.CastSpell(new Color(0xff/255f,0x55/255f,0x55/255f,128/255f));
            }
        });
	}
	
	// Update is called once per frame
	void Update () {
	    if (GameModel.instance.Mana != Manas.Count) {
	        if (GameModel.instance.Mana < Manas.Count) {
                while (GameModel.instance.Mana < Manas.Count) {
                    var m = Manas[0];
                    Manas.Remove(m);
                    Destroy(m);
                } 
            }
            else {
                while (Manas.Count < GameModel.instance.Mana) {
                    var m = (Image)Instantiate(ManaImage);
                    m.transform.parent = ManaParent;
                    m.transform.localScale = new Vector3(1,1,1);
                    Manas.Add(m);
                } 
            }
        }

	    if (GameModel.instance.Health != Hearts.Count) {
	        if (GameModel.instance.Health < Hearts.Count) {
                while (GameModel.instance.Health < Hearts.Count) {
                    var m = Hearts[0];
                    Hearts.Remove(m);
                    Destroy(m);
                } 
            }
            else {
                while (Hearts.Count < GameModel.instance.Health) {
                    var m = (Image)Instantiate(HeartImage);
                    m.transform.parent = HeartParent;
                    m.transform.localScale = new Vector3(1,1,1);
                    Hearts.Add(m);
                } 
            }
        }
	}
}
