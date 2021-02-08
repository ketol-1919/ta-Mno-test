using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");//水平
        var z = Input.GetAxis("Vertical");//垂直

        var dir = new Vector3(x, 0, z);//Vector3によるベクトルの生成

        this.transform.Translate(dir * Time.deltaTime);//このゲームオブジェクトのtransformは（）内の様にTranslateしますよ
    }
   
}
