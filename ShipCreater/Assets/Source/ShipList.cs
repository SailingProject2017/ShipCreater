using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipList : MonoBehaviour
{

    public GameObject someShip; // 生成するオブジェクト
    public GameObject spown;    // 生成する位置

    private int shipNum;    // 生成されている船の数を数える
    private bool moveFlag;  // 船が動いているかのフラグ

    List<GameObject> list_ship_ = new List<GameObject>(); // 生成したprefabをlistに登録する

    /* 外観設定 */
    const float GUI_WIDTH = 75f;     // GUI矩形幅
    const float GUI_HEIGHT = 30f;    // GUI矩形高さ
    const float MARGIN_X = 100f;     // 画面からの横マージン
    const float MARGIN_Y = 10f;      // 画面からの縦マージン
    const float INNER_X = 8f;        // 文字のGUI外枠からの横マージン
    const float INNER_Y = 5f;        // 文字のGUI外枠からの縦マージン

    Rect outer;                      // 外枠(GUI矩形領域)
    Rect inner;                      // 内枠(文字領域)


    void Start()
    {
        // ボタンUIの位置を固定させる
        outer = new Rect(MARGIN_X, MARGIN_Y, GUI_WIDTH, GUI_HEIGHT); 
        inner = new Rect(MARGIN_X + INNER_X, MARGIN_Y + INNER_Y, GUI_WIDTH - INNER_X * 2f, GUI_HEIGHT - INNER_Y * 2f);

        // 生成位置の座標を取得
        GameObject spown = GetComponent<GameObject>();

        // 変数の初期化
        shipNum = 0;
        moveFlag = false;
    }

    void Update()
    {
        // Forwardボタンが押されたとき
        if (moveFlag)
        {
            // リストに登録されている船を動かす
            for (int i = 0; i < list_ship_.Count; i++)
            {
                list_ship_[i].transform.position += new Vector3(0.0f, 0.0f, 0.1f);
            }
        }
    }

    // UI用関数
    public static void AutoResize(int screenWidth, int screenHeight)
    {
        Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
        GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
    }


    void OnGUI()
    {
        // UIの大きさを指定
        AutoResize(320, 480);


        GUI.Box(outer, "");
        GUILayout.BeginArea(inner);
        {
            GUILayout.BeginVertical();
            GUILayout.Label(shipNum.ToString("") + " Ships");
            GUILayout.EndVertical();
        }
        GUILayout.EndArea();

        if (GUI.Button(new Rect(30, 50, 100, 40), "Create"))
        {
            var Ship_Object = (GameObject)Instantiate(someShip, spown.transform.position, spown.transform.rotation);
            list_ship_.Add(Ship_Object);
            shipNum++;
        }

        if (GUI.Button(new Rect(30, 100, 100, 40), "Forward"))
        {
            moveFlag = true;
        }

        if (GUI.Button(new Rect(30, 150, 100, 40), "Stop"))
        {
            moveFlag = false;
        }

        if (GUI.Button(new Rect(30, 200, 100, 40), "Delete"))
        {
            for (int i = 0; i < list_ship_.Count; i++)
            {
                Destroy(list_ship_[i]);
            }
            // リスト自体をキレイにする
            list_ship_.Clear();
            shipNum = 0;
        }
    }
}