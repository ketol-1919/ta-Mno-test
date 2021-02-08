using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Uiをスクリプトで扱うため

public class CoinCatch : MonoBehaviour
{
   // public Text NumberCoin;
    //public static int count;//これがないとそれぞれがcount変数を持っているため１から増えない

    // Start is called before the first frame update
    void Start()
    {
        //countの初期値を0に
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))//Playerがふれると
        {
            CoinCounter.count += 1;//カウントが増える
            //Debug.Log(CoinCounter.count);
            Destroy(gameObject);//コインが消える

        }       
        //NumberCoin.text = string.Format("{0:000} Coin", count);
    }
   
}
