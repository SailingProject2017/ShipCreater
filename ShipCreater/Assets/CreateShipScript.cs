using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShipScript : MonoBehaviour {

    public Transform someShip;

    private int shipNum = 0;


    //外観設定
    const float GUI_WIDTH = 75f;     //GUI矩形幅
    const float GUI_HEIGHT = 30f;    //GUI矩形高さ
    const float MARGIN_X = 100f;      //画面からの横マージン
    const float MARGIN_Y = 10f;      //画面からの縦マージン
    const float INNER_X = 8f;        //文字のGUI外枠からの横マージン
    const float INNER_Y = 5f;        //文字のGUI外枠からの縦マージン

    Rect outer;        //外枠(GUI矩形領域)
    Rect inner;        //内枠(文字領域)

    void Start() {
        outer = new Rect(MARGIN_X, MARGIN_Y, GUI_WIDTH, GUI_HEIGHT);
        inner = new Rect(MARGIN_X + INNER_X, MARGIN_Y + INNER_Y, GUI_WIDTH - INNER_X * 2f, GUI_HEIGHT - INNER_Y * 2f);
        Debug.Log("If you input space, Create a ship!");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(someShip, transform.position, transform.rotation);
            shipNum++;
        }
	}

    void OnGUI() {

        GUI.Box(outer, "");
        GUILayout.BeginArea(inner);
        {
            GUILayout.BeginVertical();
            GUILayout.Label(shipNum.ToString("") + " Ships");
            GUILayout.EndVertical();
        }
        GUILayout.EndArea();
    }
}
