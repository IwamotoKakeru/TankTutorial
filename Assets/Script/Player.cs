using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float speed = 0.1f;     //speedという小数の変数を用意して代入
    private float rotSpeed = 0.3f;

    void Start()//始まったときに1回だけ実行される場所
    {
        
    }

    void Update()//毎回実行される場所
    {
        if(Input.GetKey(KeyCode.W)){ //Wが押されたとき
            transform.Translate(0,0,speed); //毎回speedメートルずつ前に動く
        }

        if(Input.GetKey(KeyCode.S)){//Sが押されたとき
            transform.Translate(0,0,-speed);
        }

        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(new Vector3(0,rotSpeed,0)); //毎回右にrotSpeed度ずつ回転する
        }

        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0,-rotSpeed,0)); 
        }
    }

}
