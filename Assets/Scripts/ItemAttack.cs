using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>�A�C�e�����g�p���ēG���U������</summary>
public class ItemAttack : MonoBehaviour
{
    [SerializeField] SceneChanger _gameOver;
    //�u�g���v�e�L�X�g
    [SerializeField] Text _useText;

    private void Start()
    {
        //�u�g���v�e�L�X�g����
        _useText.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        //�g�p�͈͂��G�ɓ����������A�u�g���v�e�L�X�g��\��
        if (other.gameObject.tag == "Enemy")
        {
            _useText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //�g�p�͈͂��G���痣�ꂽ���A�u�g���v�e�L�X�g���\��
        if (other.gameObject.tag == "Enemy")
        {
            _useText.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //�g�p�͈͂ɓG������ԂɃX�y�[�X����������A�C�e���ōU������
        if (other.gameObject.tag == "Enemy")
        {
            //�����|����A�C�e����I��ł���G�������ĕǂ��J��
            if(GameManager.Instance._selectedItem && Input.GetKeyDown(KeyCode.Space)) //GameManager.Instance._hasLighter &&
            {
                other.gameObject.SetActive(false);
                GameManager.Instance._killPaper = true;
            }
            //����ɕԂ蓢���ɂ����A�C�e����I��ł���Q�[���I�[�o�[��ʂɑJ�ڂ���
            else if (GameManager.Instance._selectedFakeItem && Input.GetKeyDown(KeyCode.Space)) //_selectItem._isUseFakeItem &&
            {
                _gameOver.LoadGameOverScene();
            }
        }
    }
}
