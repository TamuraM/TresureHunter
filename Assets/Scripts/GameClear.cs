using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�ǂ̌������ɍs������N���A��ʂ�������</summary>
public class GameClear : MonoBehaviour
{
    [SerializeField] SceneChanger _sceneChanger;

    private void OnCollisionEnter(Collision other)
    {
        //�v���C���[������������N���A�V�[���Ɉڍs
        if (other.gameObject.tag == "Player")
        {
            _sceneChanger.LoadClearScene();
        }
    }
}
