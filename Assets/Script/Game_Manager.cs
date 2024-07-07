using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public GameObject Ball;
    public Text Ga_Txt;
    public GameObject Bck_Par;
    bool IsGameOver;//ゲームオーバーになっているかを判定する
    bool IsGameClear;//ゲームクリアしたかを判定する

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if(Ball !=null && Ball.transform.position.y < -6)
        {
            Destroy(Ball.gameObject);
            Time.timeScale = 0;
            Ga_Txt.text = "Game Over";
            IsGameOver = true;
        }

        //ゲームクリア    
        if(Bck_Par.transform.childCount == 0)
        {
            Time.timeScale = 0;
            Ga_Txt.text = "Game Clear";
            IsGameClear = true;
        }

        //リスタート
        if ((IsGameClear || IsGameOver)&& Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Game_Play_Scene");
            Time.timeScale = 1;
        }
    }
}
