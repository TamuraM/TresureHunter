using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>アイテム欄の管理</summary>
public class InventoryManager : MonoBehaviour
{
    public SearchItem _searchItem;
    //アイテム欄の背景
    [SerializeField] Image _inventoryPanel;
    //なにを選んでるかのテキスト
    [SerializeField] public Text _selectText;
    //アイテムたちのボタンと画像
    //ペン
    [SerializeField] Image _penImage;
    [SerializeField] Image _penButton;
    //ライター
    [SerializeField] Image _lighterImage;
    [SerializeField] Image _lighterButton;
    //アイテム欄を開いてるかどうか
    private bool _openInventory;

    void Start()
    {
        //アイテム欄の背景消す
        _inventoryPanel.enabled = false;
        //なにを選んでるかのテキスト消す
        _selectText.enabled = false;
        //アイテムたちのボタンと画像消す
        //ペン
        _penImage.enabled = false;
        _penButton.enabled = false;
        //ライター
        _lighterImage.enabled = false;
        _lighterButton.enabled = false;
    }

    void Update()
    {
        //Xキーを押したらアイテム欄が開いたり閉じたりする
        //開くとき
        if(!_openInventory && Input.GetKeyDown(KeyCode.X))
        {
            //アイテム欄開いたら時間止まる
            Time.timeScale = 0;
            //開いたフラグ
            _openInventory = true;
            //アイテム欄の背景表示
            _inventoryPanel.enabled = true;
            //なにを選んでるかのテキストを表示
            _selectText.enabled = true;
            //アイテムを取ったらボタンと画像を表示
            //ペン
            if (_searchItem._havePen)
            {
                _penImage.enabled = true;
                _penButton.enabled = true;
            }
            //ライター
            if (_searchItem._haveLighter)
            {
                _lighterImage.enabled = true;
                _lighterButton.enabled = true;
            }
        }
        //閉じるとき
        else if(_openInventory && Input.GetKeyDown(KeyCode.X))
        {
            //アイテム欄閉じたら時間動く
            Time.timeScale = 1;
            //開いたフラグオフ(閉じたフラグ)
            _openInventory = false;
            //アイテム欄の背景消す
            _inventoryPanel.enabled = false;
            //なにを選んでるかのテキスト消す
            _selectText.enabled = false;
            //アイテムたちのボタンと画像消す
            //ペン
            _penImage.enabled = false;
            _penButton.enabled = false;
            //ライター
            _lighterImage.enabled = false;
            _lighterButton.enabled = false;
        }
    }

    
}
