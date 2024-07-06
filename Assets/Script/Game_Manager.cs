using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public GameObject Ball;
    public Text Ga_Txt;
    public GameObject Bck_Par;

    // Update is called once per frame
    void Update()
    {
        if(Ball !=null && Ball.transform.position.y < -6)
        {
            Destroy(Ball.gameObject);
            Ga_Txt.text = "Game Over";
        }

        //ƒQ[ƒ€ƒNƒŠƒA    
        if(Bck_Par.transform.childCount == 0)
        {
            Time.timeScale = 0;
            Ga_Txt.text = "Game Clear";
        }
    }
}
