using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�{�^������������\�������������ς��</summary>
public class RuleFrameChange : MonoBehaviour
{
    //�e�����̃t���[��
    [SerializeField] GameObject _ruleFrame;
    [SerializeField] GameObject _controlFrame1;
    [SerializeField] GameObject _controlFrame2;
    //�u�v���C�v�{�^��
    [SerializeField] GameObject _playButton;
    //���
    [SerializeField] GameObject _rightArrow;
    [SerializeField] GameObject _leftArrow;

    void Start()
    {
        //�����̂Q���ڂ�3���ڂ͔�\��
        _controlFrame1.SetActive(false);
        _controlFrame2.SetActive(false);
        //�v���C�{�^���ƍ����͔�\��
        _playButton.SetActive(false);
        _leftArrow.SetActive(false);
        //1���ڂ�\�����Ă邱�Ƃ������Ă���
        RuleManager.Instance._displayRuleFrame = true;
    }

    /// <summary>�E���̊֐�</summary>
    public void RightArrow()
    {
        //1���ڂ��\������Ă鎞�ɉ�������2���ڂɕς��
        if (RuleManager.Instance._displayRuleFrame)
        {
            RuleManager.Instance._displayRuleFrame = false;
            _ruleFrame.SetActive(false);
            _controlFrame1.SetActive(true);
            RuleManager.Instance._displayControlFrame1 = true;
            _leftArrow.SetActive(true);
        }
        //2���ڂ��\������Ă鎞�ɉ�������3���ڂɕς��
        else if (RuleManager.Instance._displayControlFrame1)
        {
            RuleManager.Instance._displayControlFrame1 = false;
            this.gameObject.SetActive(false);
            _controlFrame1.SetActive(false);
            _controlFrame2.SetActive(true);
            RuleManager.Instance._displayControlFrame2 = true;
            _playButton.SetActive(true);
        }
        //3���ڂ��\������Ă鎞�ɉ�������1���ڂɕς��
        //else if (RuleManager.Instance._displayControlFrame2)
        //{
        //    RuleManager.Instance._displayControlFrame2 = false;
        //    _controlFrame2.SetActive(false);
        //    _ruleFrame.SetActive(true);
        //    RuleManager.Instance._displayRuleFrame = true;
        //}
    }

    /// <summary>�����̊֐�</summary>
    public void LeftArrow()
    {
        //1���ڂ��\������Ă鎞�ɉ�������3���ڂɕς��
        //if (RuleManager.Instance._displayRuleFrame)
        //{
        //    RuleManager.Instance._displayRuleFrame = false;
        //    _ruleFrame.SetActive(false);
        //    _controlFrame2.SetActive(true);
        //    RuleManager.Instance._displayControlFrame2 = true;
        //}
        //2���ڂ��\������Ă鎞�ɉ�������1���ڂɕς��
        if (RuleManager.Instance._displayControlFrame1)
        {
            RuleManager.Instance._displayControlFrame1 = false;
            this.gameObject.SetActive(false);
            _controlFrame1.SetActive(false);
            _ruleFrame.SetActive(true);
            RuleManager.Instance._displayRuleFrame = true;
        }
        //3���ڂ��\������Ă鎞�ɉ�������2���ڂɕς��
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
