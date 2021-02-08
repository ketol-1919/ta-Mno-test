using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Uiをスクリプトで扱うため


public class CoinCounter : MonoBehaviour
{
    public Text coinNum;
    public static int count;

    // Start is called before the first frame update
    void Start()
    {
       count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinNum.text = string.Format("{0:000} Coin", count);//数字桁が無くても0埋め表示
        Debug.Log(count);
    }
}
