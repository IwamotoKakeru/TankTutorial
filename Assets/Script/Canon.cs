using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    //弾を格納する変数
    public GameObject bullet ;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
           //bulletを自分と同じ位置に生成
           Instantiate(bullet,this.transform.position,transform.rotation); 
        }    
    }
}
