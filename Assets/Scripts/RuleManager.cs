using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>���[���V�[���łǂ̐�����\�����Ă��邩</summary>
public class RuleManager : MonoBehaviour
{
    //�V���O���g���Ƃ��������
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
    
    //�e�t���[����\�����Ă邩�ǂ���
    public bool _displayRuleFrame;
    public bool _displayControlFrame1;
    public bool _displayControlFrame2;
}
