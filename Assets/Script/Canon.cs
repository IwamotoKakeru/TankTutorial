using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject bullet ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
           //bulletを自分と同じ位置に生成
           Instantiate(bullet,this.transform.position,transform.rotation); 
        }    
    }
}
