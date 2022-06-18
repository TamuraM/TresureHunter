using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>アイテムを使用して敵を攻撃する</summary>
public class ItemAttack : MonoBehaviour
{
    [SerializeField] SceneChanger _gameOver;
    //「使う」テキスト
    [SerializeField] Text _useText;

    private void Start()
    {
        //「使う」テキスト消す
        _useText.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        //使用範囲が敵に当たった時、「使う」テキストを表示
        if (other.gameObject.tag == "Enemy")
        {
            _useText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //使用範囲が敵から離れた時、「使う」テキストを非表示
        if (other.gameObject.tag == "Enemy")
        {
            _useText.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //使用範囲に敵がいる間にスペースを押したらアイテムで攻撃する
        if (other.gameObject.tag == "Enemy")
        {
            //相手を倒せるアイテムを選んでたら敵が消えて壁が開く
            if(GameManager.Instance._selectedItem && Input.GetKeyDown(KeyCode.Space)) //GameManager.Instance._hasLighter &&
            {
                other.gameObject.SetActive(false);
                GameManager.Instance._killPaper = true;
            }
            //相手に返り討ちにされるアイテムを選んでたらゲームオーバー画面に遷移する
            else if (GameManager.Instance._selectedFakeItem && Input.GetKeyDown(KeyCode.Space)) //_selectItem._isUseFakeItem &&
            {
                _gameOver.LoadGameOverScene();
            }
        }
    }
}
