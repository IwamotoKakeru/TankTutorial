using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    
    private GameObject Player;  

    private Vector3 offset;         //カメラとプレイヤーの距離
    private float offsetHeight = 1.0f;   //カメラが見るところの高さ

    private float angleDif;
    private Vector3 planeFrom,planeTo;

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーを取得
        Player = GameObject.FindGameObjectWithTag("Player");

        //カメラとプレイヤーのベクトルをoffsetに格納
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player == null){ //プレイヤーが消滅したとき
            //何もしない 
        }else{              //プレイヤーが存在するとき
            CameraTracking();
        }
    }

    void CameraTracking(){
        //位置を再調整
        transform.position = Player.transform.position + offset;

        //プレイヤーの少し上を見る
        transform.LookAt(Player.transform.position+new Vector3(0,offsetHeight,0));
        
        //カメラの向きとプレイヤーの向きを平面に投影
        planeFrom = Vector3.ProjectOnPlane(this.transform.forward,Vector3.up);
        planeTo = Vector3.ProjectOnPlane(Player.transform.forward,Vector3.up);

        //カメラとプレイヤーの角度差を求める
        angleDif = Vector3.SignedAngle(planeFrom,planeTo,Vector3.up); 

        //プレイヤーを中心にangleDif度回転する
        transform.RotateAround(Player.transform.position,Vector3.up,angleDif);

    }

}
