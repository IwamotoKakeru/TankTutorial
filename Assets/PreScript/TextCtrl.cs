using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCtrl : MonoBehaviour
{
    private GameObject[] Enemys;
    private GameObject Player;

    private Text textUI;

    private int EnemyNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        //タグごとにオブジェクトを取得
        Enemys = GameObject.FindGameObjectsWithTag("Enemy");
        Player = GameObject.FindGameObjectWithTag("Player");

        textUI = GetComponent<Text>();
    }

    void Update()
    {
        if(EnemyCount() == 0){
            textUI.text = "Game Clear!!"; 
        }else if(Player == null){   //Playerが消滅したとき
            textUI.text = "Game Over...";
        }
    }

    int EnemyCount(){
        EnemyNum = 0;   

        //Enemysという配列の中身のゲームオブジェクトをEnemyとしてとりだす
        foreach(GameObject Enemy in Enemys)
        {
            if(Enemy != null) EnemyNum++; //Enemyが存在するならEnemyNumを1増やす
        }

        return EnemyNum;
    }

    

}
