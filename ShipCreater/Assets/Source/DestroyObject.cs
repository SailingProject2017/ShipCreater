/* **********************************************
 * CopyRight ©︎ Ryo Sugiyama all write reserved
 * **********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	public void Update() {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			Debug.Log ("Destroy");
			GameObject.Destroy(gameObject);
		}
	}
}
