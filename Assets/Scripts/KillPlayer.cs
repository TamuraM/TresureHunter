using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>プレイヤーが当たったらゲームオーバーシーンに移行する</summary>
public class KillPlayer : MonoBehaviour
{
    [SerializeField] SceneChanger _gameOver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gameOver.LoadGameOverScene();
        }
    }


}
