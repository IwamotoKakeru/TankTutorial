using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 0.06f;     //speedという小数の変数を用意して代入

    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Player == null){ //プレイヤーが消滅したとき
            //何もしない 
        }else{              //プレイヤーが存在するとき
            transform.Translate(0, 0, speed); //毎回speedずつ前に動く
            transform.LookAt(Player.transform,Vector3.up);
        }
    }

    //自分の当たり判定になにかが入ったとき
    void OnCollisionEnter(Collision collision)
    {
        //あたったオブジェクトのタグがプレイヤーだったとき
        if(collision.gameObject.CompareTag("Player"))
            Destroy(collision.gameObject);  //あたったオブジェクトを削除
    }
}
