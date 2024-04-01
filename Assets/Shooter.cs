using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            foreach (RaycastHit hit in Physics.SphereCastAll(ray,3f)) {
                Destroy(hit.collider.gameObject);
            }
        }
        
    }
    /*
    hero1.setHp(hero1.getHp()+10);
    hero1.HP += 10;
    */
}
