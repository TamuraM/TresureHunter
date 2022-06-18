using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>アイテムを探してゲットする</summary>
public class SearchItem : MonoBehaviour
{
    //「調べる」テキスト
    [SerializeField] Text _searchText;
    //なんのアイテムを取ったかを表示する背景とテキスト
    [SerializeField] Image _getItemPanel;
    [SerializeField] Text _getItemText;
    //どのアイテムを持っているか
    //ペン
    public bool _havePen;
    //ライター
    public bool _haveLighter;

    private void Start()
    {
        //「調べる」テキスト消す
        _searchText.enabled = false;
        //なんのアイテムを取ったかを表示する背景とテキストを消す
        _getItemPanel.enabled = false;
        _getItemText.enabled = false;
        //アイテムを持ってない(アイテムを持っているかをオフ)
        //ペン
        _havePen = false;
        //ライター
        _haveLighter = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //アイテムがあるところに当たったら「調べる」テキストを表示
        if (other.gameObject.tag == "Item")
        {
            _searchText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //アイテムがあるところから離れたら「調べる」テキストを非表示
        if (other.gameObject.tag == "Item")
        {
            _searchText.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //アイテムがあるところでZキーを押すとアイテムを入手する
        //ペン
        if (other.gameObject.name == "Pen" && Input.GetKeyDown(KeyCode.Z))
        {
            GetItem("ペン");
            //ペンを入手した
            _havePen = true;
            //「調べる」テキストは消す
            _searchText.enabled = false;
            //ペンをフィールド上から消す
            other.gameObject.SetActive(false);
        }
        //ライター
        else if (other.gameObject.name == "Lighter" && Input.GetKeyDown(KeyCode.Z))
        {
            GetItem("ライター");
            //ライターを入手した
            _haveLighter = true;
            //「調べる」テキストは消す
            _searchText.enabled = false;
            //ライターをフィールド上から消す
            other.gameObject.SetActive(false);
        }
    }

    /// <summary>なんのアイテムを取ったかを表示する背景とテキストを出す</summary>
    /// <param name="item"></param>
    private void GetItem(string item)
    {
        _getItemText.text = item + "を入手した！(Xボタンでアイテム欄を開く)";
        _getItemPanel.enabled = true;
        _getItemText.enabled = true;
        Invoke("DeleteGetItemUI", 1.5f);
    }

    /// <summary>なんのアイテムを取ったかを表示する背景とテキストを消す</summary>
    private void DeleteGetItemUI()
    {
        _getItemPanel.enabled = false;
        _getItemText.enabled = false;
    }

}
