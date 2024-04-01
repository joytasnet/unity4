using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject prefab;
    public GameManager gm;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        float delta = 1.5f;
        while(true){
            GameObject cube = Instantiate(
                prefab,
                new Vector3(
                    Random.Range(-12f,12f),
                    Random.Range(8f,12f),
                    Random.Range(-3f,3f)
                ),
                Quaternion.identity
            );

            cube.GetComponent<CubeController>().GM=gm;
            yield return new WaitForSeconds(delta);

            if(delta > 0.5f){
                delta -= 0.05f;
            }
        }
        
    }

}
