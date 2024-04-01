using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void OnBecameInvisible() {
        Destroy(gameObject);
        
    }
    void Update(){
        if(Time.timeScale != 0f){
            transform.localScale=Vector3.Lerp(transform.localScale,Vector3.one,0.1f);
        }
    }
}
