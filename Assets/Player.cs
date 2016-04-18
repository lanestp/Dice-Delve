using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Player : Rolling {
	// Use this for initialization
	public GameObject Skull;
	public List<GameObject> Victory;
    public Renderer Spell;
    public Number UpNumber;
	public Number DownNumber;
	public Number LeftNumber;
	public Number RightNumber;
    public override void Damaged() {
        GameModel.instance.Health--;
        if (GameModel.instance.Health <= 0) {
            Die();
        }
        else {
            CastSpell(new Color(0xaa/255f,0,0,1f));

            /*transform.DOMoveY(.1f,.1f).OnComplete(()=>{
                transform.DOMoveY(0f,.1f);
            });*/
        }
    }
    public override void Attack() {
            transform.DOMoveY(.1f,.1f).OnComplete(()=>{
                transform.DOMoveY(0f,.1f);
            });
    }
    public override void Die() {
        Skull.transform.localScale = Vector3.zero;
        Skull.SetActive(true);
        Skull.transform.DOScale(new Vector3(8,8,8),2.0f);
        Skull.transform.DORotate(new Vector3(40,0,0),3f,RotateMode.LocalAxisAdd).OnComplete(()=>{
                SceneManager.LoadScene(0);
        });
    }
    public void CastSpell(Color c){
        Spell.transform.localScale = new Vector3(0,0,0);
        Spell.gameObject.SetActive(true);
        Spell.material.color = c;
        Spell.material.DOColor(new Color(c.r,c.g,c.b,0),0.5f);
        Spell.transform.DOScale(new Vector3(2f,2f,2f),.5f).OnComplete(()=>{
            Spell.transform.localScale = new Vector3(0,0,0);
            Spell.gameObject.SetActive(false);
        });
    }
    public void SetSlide (){
        Slide = true;
        UpNumber.SetNumber(FaceValue(Direction.None), Direction.Up);
        DownNumber.SetNumber(FaceValue(Direction.None), Direction.Down);
        LeftNumber.SetNumber(FaceValue(Direction.None), Direction.Left);
        RightNumber.SetNumber(FaceValue(Direction.None), Direction.Right);
    }
    public void Scramble(){
        var list = new List<Vector3>();
        list.Add(new Vector3(90,0,0));
        list.Add(new Vector3(-90,0,0));
        list.Add(new Vector3(0,0,90));
        list.Add(new Vector3(0,0,-90));
        list.Add(new Vector3(180,0,0));
        StartCoroutine(Roll(list[Random.Range(0,list.Count)],Vector3.zero, DoneRoll ));
            RightNumber.transform.parent = LeftNumber.transform.parent = DownNumber.transform.parent = UpNumber.transform.parent = null;
            RightNumber.transform.DOMoveY(-0.6f,.2f);
            LeftNumber.transform.DOMoveY(-0.6f,.2f);
            UpNumber.transform.DOMoveY(-0.6f,.2f);
            DownNumber.transform.DOMoveY(-0.6f,.2f);
    }
    void Start () {
        UnityEngine.EventSystems.EventSystem.current.sendNavigationEvents = !UnityEngine.EventSystems.EventSystem.current.sendNavigationEvents;
	    DoneRoll();
	}
	void DoneRoll(){
        RightNumber.transform.parent = LeftNumber.transform.parent = DownNumber.transform.parent = UpNumber.transform.parent = transform;
        UpNumber.SetNumber(FaceValue(Direction.Up), Direction.Up);
        DownNumber.SetNumber(FaceValue(Direction.Down), Direction.Down);
        LeftNumber.SetNumber(FaceValue(Direction.Left), Direction.Left);
        RightNumber.SetNumber(FaceValue(Direction.Right), Direction.Right);
        //if (Map.instance.CanIGo(Direction.Right,gameObject))
            RightNumber.transform.DOMoveY(-0.45f,.2f);
        //if (Map.instance.CanIGo(Direction.Left,gameObject))
            LeftNumber.transform.DOMoveY(-0.45f,.2f);
        //if (Map.instance.CanIGo(Direction.Up,gameObject))
            UpNumber.transform.DOMoveY(-0.45f,.2f);
        //if (Map.instance.CanIGo(Direction.Down,gameObject))
            DownNumber.transform.DOMoveY(-0.45f,.2f);
        Map.instance.RollDone();
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
        /*else if (Input.GetKeyDown("space")){
            didRoll = RollNone(DoneRoll);
        }*/
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
