using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>ルールシーンでどの説明を表示しているか</summary>
public class RuleManager : MonoBehaviour
{
    //シングルトンとかいうやつ
    public static RuleManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    //各フレームを表示してるかどうか
    public bool _displayRuleFrame;
    public bool _displayControlFrame1;
    public bool _displayControlFrame2;
}
