using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�A�C�e��������A�C�e����I��</summary>
public class SelectItem : MonoBehaviour
{
    [SerializeField] InventoryManager _inventoryManager;
    //�g�p�͈͂���
    [SerializeField] GameObject _frontRange1Renderer;
    [SerializeField] GameObject _frontRange2Renderer;
    [SerializeField] GameObject _RightRangeRenderer;
    [SerializeField] GameObject _LeftRangeRenderer;

    private void Start()
    {
        //�g�p�͈͂���������
        _frontRange1Renderer.SetActive(false);
        _frontRange2Renderer.SetActive(false);
        _RightRangeRenderer.SetActive(false);
        _LeftRangeRenderer.SetActive(false);
    }

    public void UsePen()
    {
        //�y���𑕔��������Ƃ�\��
        _inventoryManager._selectText.text = "�y���������т��Ă��";
        //�y����I�񂾂�v���C���[�̐��ʂ̂P�������g�p�͈͂Ƃ��ďo�Ă���
        _frontRange1Renderer.SetActive(true);
        //�y���͋U�̃A�C�e��
        GameManager.Instance._selectedFakeItem = true;
    }

    public void UseLighter()
    {
        //���C�^�[�𑕔��������Ƃ�\��
        _inventoryManager._selectText.text = "���C�^�[�������т��Ă��";
        //���C�^�[��I�񂾂�v���C���[�̐��ʂ̂P�������g�p�͈͂Ƃ��ďo�Ă���
        _frontRange1Renderer.SetActive(true);
        //���C�^�[�͖{���̃A�C�e��
        GameManager.Instance._selectedItem = true;
    }
}
