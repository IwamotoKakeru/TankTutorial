using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 0.05f;     //speedという小数の変数を用意して代入

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(0,0,speed); //毎回speedずつ前に動く
    }

    //自分の当たり判定になにかが入ったとき
    void OnCollisionEnter(Collision collision)
    {
        //あたったオブジェクトのタグがプレイヤーだったとき
        if(collision.gameObject.CompareTag("Player"))
            Destroy(collision.gameObject);  //あたったオブジェクトを削除
    }
}
