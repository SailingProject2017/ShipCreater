/* **********************************************
 * CopyRight ©︎ Ryo Sugiyama all write reserved
 * **********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwordShip : MonoBehaviour {

	private bool forwordShipFlag;

	public void Update() {
		if (Input.GetKeyDown (KeyCode.Return)) {
			forwordShipFlag = true;
			}

		if (forwordShipFlag == true) {			
			this.transform.position += new Vector3 (0.0f, 0.0f, 0.1f);
		}
	}
}
