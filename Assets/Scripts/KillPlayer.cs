using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�v���C���[������������Q�[���I�[�o�[�V�[���Ɉڍs����</summary>
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
