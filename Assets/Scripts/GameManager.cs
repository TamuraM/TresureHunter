using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>どのアイテムを選んだかの管理</summary>
public class GameManager : MonoBehaviour
{
    //シングルトンとかいうやつ
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //相手を倒せるアイテムを選んだ
    public bool _selectedItem;
    //相手を倒せず、返り討ちにされるアイテムを選んだ
    public bool _selectedFakeItem;
    //紙を倒した
    public bool _killPaper;
    //壁が開くアニメーション
    [SerializeField] Animator _leftWall;　//左
    [SerializeField] Animator _rightWall; //右

    private void Update()
    {
        if(_killPaper)
        {
            _leftWall.SetBool("PaperDied", true);
            _rightWall.SetBool("PaperDied", true);
        }
    }
}
