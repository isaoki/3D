using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotBase : MonoBehaviour
{
    /// <summary>
    /// �����ɂԂ�������
    /// </summary>
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Enemy")
        {
            if(other.tag == "MeinCamera")
            {
                //�_���[�W���󂯂�

            }
            Destroy(gameObject);
        }
    }

}
