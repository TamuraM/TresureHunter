using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>壁の向こうに行けたらクリア画面を見せる</summary>
public class GameClear : MonoBehaviour
{
    [SerializeField] SceneChanger _sceneChanger;

    private void OnCollisionEnter(Collision other)
    {
        //プレイヤーが当たったらクリアシーンに移行
        if (other.gameObject.tag == "Player")
        {
            _sceneChanger.LoadClearScene();
        }
    }
}
