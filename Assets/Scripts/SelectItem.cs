using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>アイテム欄からアイテムを選ぶ</summary>
public class SelectItem : MonoBehaviour
{
    [SerializeField] InventoryManager _inventoryManager;
    //使用範囲たち
    [SerializeField] GameObject _frontRange1Renderer;
    [SerializeField] GameObject _frontRange2Renderer;
    [SerializeField] GameObject _RightRangeRenderer;
    [SerializeField] GameObject _LeftRangeRenderer;

    private void Start()
    {
        //使用範囲たちを消す
        _frontRange1Renderer.SetActive(false);
        _frontRange2Renderer.SetActive(false);
        _RightRangeRenderer.SetActive(false);
        _LeftRangeRenderer.SetActive(false);
    }

    public void UsePen()
    {
        //ペンを装備したことを表示
        _inventoryManager._selectText.text = "ペンをそうびしてるよ";
        //ペンを選んだらプレイヤーの正面の１つだけが使用範囲として出てくる
        _frontRange1Renderer.SetActive(true);
        //ペンは偽のアイテム
        GameManager.Instance._selectedFakeItem = true;
    }

    public void UseLighter()
    {
        //ライターを装備したことを表示
        _inventoryManager._selectText.text = "ライターをそうびしてるよ";
        //ライターを選んだらプレイヤーの正面の１つだけが使用範囲として出てくる
        _frontRange1Renderer.SetActive(true);
        //ライターは本物のアイテム
        GameManager.Instance._selectedItem = true;
    }
}
