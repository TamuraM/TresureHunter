using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemAttack : MonoBehaviour
{
    [SerializeField] SceneChanger _gameOver;
    [SerializeField] Text _useText;

    private void Start()
    {
        _useText.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            _useText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            _useText.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            if(GameManager.Instance._isUseItem && Input.GetKeyDown(KeyCode.Space)) //GameManager.Instance._hasLighter &&
            {
                other.gameObject.SetActive(false);
            }
            else if (GameManager.Instance._isUseFakeItem && Input.GetKeyDown(KeyCode.Space)) //_selectItem._isUseFakeItem &&
            {
                _gameOver.LoadGameOverScene();
            }
        }
    }
}
