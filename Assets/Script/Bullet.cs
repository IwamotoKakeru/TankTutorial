using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 0.5f;
    private float lifeTime = 1.0f;

    void Start()//スタートしたときに一度だけ実行される
    {
        Destroy(this.gameObject,lifeTime); //自分自身をlifeTime秒後に削除
    }

    void Update()
    {
        transform.Translate(0,0,speed); //毎回speedずつ前に動く
    }

    void OnCollisionEnter(Collision collision) //Bulletに何かがあたったとき
    {
        if(collision.gameObject.CompareTag("Enemy"))//あたったやつのタグがEnemyなら
            Destroy(collision.gameObject);//あたったやつを削除
            Destroy(this.gameObject);
    }
}
