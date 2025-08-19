using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectDestroyerController : MonoBehaviour
{

    //MainCameraのオブジェクト
    private GameObject MainCamera;


    // Start is called before the first frame update 
    void Start()
    {
        //MainCameraのオブジェクトを取得
        this.MainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //MainCameraの位置に合わせて壁の位置を移動させる
        this.transform.position = new Vector3(0, this.transform.position.y, this.MainCamera.transform.position.z);

    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    private void OnTriggerEnter(Collider other)
    {
        //障害物(車)に衝突した場合
        if (other.gameObject.CompareTag("CarTag"))
        {
            //接触したオブジェクトを破棄            
            Destroy(other.gameObject);
        }
        //障害物(交通コーン)に衝突した場合
        else if (other.gameObject.CompareTag("TrafficConeTag"))
        {
            //接触したオブジェクトを破棄            
            Destroy(other.gameObject);
        }
        //障害物(コイン)に衝突した場合
        else if (other.gameObject.CompareTag("CoinTag"))
        {
            //接触したオブジェクトを破棄            
            Destroy(other.gameObject); 
        }
    }
}
