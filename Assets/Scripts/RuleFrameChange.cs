using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>ボタンを押したら表示される説明が変わる</summary>
public class RuleFrameChange : MonoBehaviour
{
    //各説明のフレーム
    [SerializeField] GameObject _ruleFrame;
    [SerializeField] GameObject _controlFrame1;
    [SerializeField] GameObject _controlFrame2;
    //「プレイ」ボタン
    [SerializeField] GameObject _playButton;
    //矢印
    [SerializeField] GameObject _rightArrow;
    [SerializeField] GameObject _leftArrow;

    void Start()
    {
        //説明の２枚目と3枚目は非表示
        _controlFrame1.SetActive(false);
        _controlFrame2.SetActive(false);
        //プレイボタンと左矢印は非表示
        _playButton.SetActive(false);
        _leftArrow.SetActive(false);
        //1枚目を表示してることを示しておく
        RuleManager.Instance._displayRuleFrame = true;
    }

    /// <summary>右矢印の関数</summary>
    public void RightArrow()
    {
        //1枚目が表示されてる時に押したら2枚目に変わる
        if (RuleManager.Instance._displayRuleFrame)
        {
            RuleManager.Instance._displayRuleFrame = false;
            _ruleFrame.SetActive(false);
            _controlFrame1.SetActive(true);
            RuleManager.Instance._displayControlFrame1 = true;
            _leftArrow.SetActive(true);
        }
        //2枚目が表示されてる時に押したら3枚目に変わる
        else if (RuleManager.Instance._displayControlFrame1)
        {
            RuleManager.Instance._displayControlFrame1 = false;
            this.gameObject.SetActive(false);
            _controlFrame1.SetActive(false);
            _controlFrame2.SetActive(true);
            RuleManager.Instance._displayControlFrame2 = true;
            _playButton.SetActive(true);
        }
        //3枚目が表示されてる時に押したら1枚目に変わる
        //else if (RuleManager.Instance._displayControlFrame2)
        //{
        //    RuleManager.Instance._displayControlFrame2 = false;
        //    _controlFrame2.SetActive(false);
        //    _ruleFrame.SetActive(true);
        //    RuleManager.Instance._displayRuleFrame = true;
        //}
    }

    /// <summary>左矢印の関数</summary>
    public void LeftArrow()
    {
        //1枚目が表示されてる時に押したら3枚目に変わる
        //if (RuleManager.Instance._displayRuleFrame)
        //{
        //    RuleManager.Instance._displayRuleFrame = false;
        //    _ruleFrame.SetActive(false);
        //    _controlFrame2.SetActive(true);
        //    RuleManager.Instance._displayControlFrame2 = true;
        //}
        //2枚目が表示されてる時に押したら1枚目に変わる
        if (RuleManager.Instance._displayControlFrame1)
        {
            RuleManager.Instance._displayControlFrame1 = false;
            this.gameObject.SetActive(false);
            _controlFrame1.SetActive(false);
            _ruleFrame.SetActive(true);
            RuleManager.Instance._displayRuleFrame = true;
        }
        //3枚目が表示されてる時に押したら2枚目に変わる
        else if (RuleManager.Instance._displayControlFrame2)
        {
            RuleManager.Instance._displayControlFrame2 = false;
            _controlFrame2.SetActive(false);
            _controlFrame1.SetActive(true);
            RuleManager.Instance._displayControlFrame1 = true;
            _rightArrow.SetActive(true);
        }
    }
}
