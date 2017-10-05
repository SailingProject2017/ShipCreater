/* **********************************************
 * CopyRight ©︎ Ryo Sugiyama all write reserved
 * **********************************************/

using System.Collections;
using UnityEngine;

public class BaseButton : MonoBehaviour {

	public BaseButton button;

	public void OnClick(){
		if (button == null) {
			throw new System.Exception ("Bottun instance is null");
		}
		button.OnClick(this.gameObject.name);
	}

	protected virtual void OnClick(string objectName){
		Debug.Log ("Base Button");
	}
}
