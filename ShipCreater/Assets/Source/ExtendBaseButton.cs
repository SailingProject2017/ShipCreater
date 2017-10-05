using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendBaseButton : BaseButton {

	private GameObject otherCreate;
	private GameObject otherDestroy;
	private GameObject otherForword;

	CreateShipScript createShipScript;
	DestroyObject destroyScript;
	ForwordShip forwordScript;

	protected override void OnClick(string objectName){
		if ("Button1".Equals (objectName)) {
			otherCreate = GameObject.Find ("CreateShipScript");
			createShipScript = otherCreate.GetComponent<CreateShipScript> ();
			this.Button1Click ();
		} 
		else if ("Button2".Equals (objectName)) {
			otherDestroy = GameObject.Find ("");
			destroyScript = otherDestroy.GetComponent<DestroyObject> ();
			this.Button2Click ();

		} 
		else if ("Button3".Equals (objectName)) {
			otherForword = GameObject.Find ("CreateShip");
			forwordScript = otherForword.GetComponent<ForwordShip> ();
			this.Button3Click ();
		} 
		else {
			throw new System.Exception ("Not implemented");
		}
	}

	private void Button1Click(){
		//createShipScript.Creating ();
	}

	private void Button2Click(){
		//destroyScript.Destroying ();
	}

	private void Button3Click(){
		//forwordScript.Forwording ();
	}


}
