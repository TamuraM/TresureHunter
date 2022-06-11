using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemAttack : MonoBehaviour
{
    [SerializeField] SelectItem _selectItem;
    [SerializeField] SceneChanger _gameOver;
    [SerializeField] Text _useText;

    private void Start()
    {
        _useText.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Enemy" && Input.GetKeyDown(KeyCode.Space))
        {
            if (_selectItem._isUseItem)
            {
                _useText.enabled = true;
                Debug.Log(5);
                other.gameObject.SetActive(false);
            }
            else if(_selectItem._isUseFakeItem)
            {
                _useText.enabled = true;
                _gameOver.LoadGameOverScene();
            }
        }
    }
}
