using UnityEngine;
using System.Collections;

public class SideValue : MonoBehaviour {
    public int Side;
	// Use this for initialization
    void OnDrawGizmos()
 {
   Gizmos.color = Color.yellow;
   Gizmos.DrawSphere(transform.position, .1f);
 }
}
