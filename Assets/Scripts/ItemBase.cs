using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>アイテムに関する基底クラス</summary>
public abstract class ItemBase : MonoBehaviour
{
    [SerializeField, Tooltip("「探す」テキスト")] Text _searchText;
    [SerializeField, Tooltip("なんのアイテムをゲットしたかを表示するパネル")] GameObject _getItemPanel;
    [SerializeField, Tooltip("なんのアイテムをゲットしたかを表示するテキスト")] Text _getItemText;

    private void Awake()
    {
        _searchText.enabled = false;
        _getItemPanel.SetActive(false);
    }

    public abstract void Activate();

    private void OnTriggerEnter(Collider other)
    {
        //アイテムがあるところに当たったら「調べる」テキストを表示
        if (other.gameObject.tag == "Player")
        {
            _searchText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //アイテムがあるところから離れたら「調べる」テキストを非表示
        if (other.gameObject.tag == "Player")
        {
            _searchText.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //アイテムがあるところでZキーを押すとアイテムを入手する
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Z))
        {
            Activate();
            this.gameObject.SetActive(false);
            GetItem(this.gameObject.name);
            _searchText.enabled = false;
        }
    }

    /// <summary>なんのアイテムを取ったかを表示する背景とテキストを出す</summary>
    /// <param name="item"></param>
    private void GetItem(string item)
    {
        _getItemText.text = item + "を入手した！(Xボタンでアイテム欄を開く)";
        _getItemPanel.SetActive(true);
        //_getItemText.enabled = true;
        Invoke("DeleteGetItemUI", 1.5f);
    }

    /// <summary>なんのアイテムを取ったかを表示する背景とテキストを消す</summary>
    private void DeleteGetItemUI()
    {
        _getItemPanel.SetActive(false);
        //_getItemText.enabled = false;
    }
}