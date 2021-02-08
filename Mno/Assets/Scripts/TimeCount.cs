using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour
{
    private float TimeLimit; //制限時間の変数
    public Text TimeText; //制限時間の文字の変数

    // Start is called before the first frame update
    void Start()
    {
        TimeLimit = 20.0f;//制限時間を50に
    }

    // Update is called once per frame
    void Update()
    {
        TimeText.text = "Time:" + TimeLimit.ToString(); //TimeTextの文字をTime:LimitTimeの値にする
        TimeLimit -= Time.deltaTime; //LimitTimeを時間の経過分ずつ減らす

        if(TimeLimit < 0)
        {
            SceneManager.LoadScene("ゲームオーバー");
        }    
    }
}
