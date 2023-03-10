using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾丸の処理
/// </summary>
public class ShotMove : MonoBehaviour
{
    private float _shotLifeTimer = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //時間を減らす
        _shotLifeTimer -= Time.deltaTime;
        //生存時間が無いなら
        if(_shotLifeTimer <= 0)
        {
            Destroy(gameObject);    
        }
    }
    /// <summary>
    /// 何かにぶつかったら呼び出される処理
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
            
    }
}
