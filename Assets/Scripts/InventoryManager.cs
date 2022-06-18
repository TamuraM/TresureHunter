using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>�A�C�e�����̊Ǘ�</summary>
public class InventoryManager : MonoBehaviour
{
    public SearchItem _searchItem;
    //�A�C�e�����̔w�i
    [SerializeField] Image _inventoryPanel;
    //�Ȃɂ�I��ł邩�̃e�L�X�g
    [SerializeField] public Text _selectText;
    //�A�C�e�������̃{�^���Ɖ摜
    //�y��
    [SerializeField] Image _penImage;
    [SerializeField] Image _penButton;
    //���C�^�[
    [SerializeField] Image _lighterImage;
    [SerializeField] Image _lighterButton;
    //�A�C�e�������J���Ă邩�ǂ���
    private bool _openInventory;

    void Start()
    {
        //�A�C�e�����̔w�i����
        _inventoryPanel.enabled = false;
        //�Ȃɂ�I��ł邩�̃e�L�X�g����
        _selectText.enabled = false;
        //�A�C�e�������̃{�^���Ɖ摜����
        //�y��
        _penImage.enabled = false;
        _penButton.enabled = false;
        //���C�^�[
        _lighterImage.enabled = false;
        _lighterButton.enabled = false;
    }

    void Update()
    {
        //X�L�[����������A�C�e�������J����������肷��
        //�J���Ƃ�
        if(!_openInventory && Input.GetKeyDown(KeyCode.X))
        {
            //�A�C�e�����J�����玞�Ԏ~�܂�
            Time.timeScale = 0;
            //�J�����t���O
            _openInventory = true;
            //�A�C�e�����̔w�i�\��
            _inventoryPanel.enabled = true;
            //�Ȃɂ�I��ł邩�̃e�L�X�g��\��
            _selectText.enabled = true;
            //�A�C�e�����������{�^���Ɖ摜��\��
            //�y��
            if (_searchItem._havePen)
            {
                _penImage.enabled = true;
                _penButton.enabled = true;
            }
            //���C�^�[
            if (_searchItem._haveLighter)
            {
                _lighterImage.enabled = true;
                _lighterButton.enabled = true;
            }
        }
        //����Ƃ�
        else if(_openInventory && Input.GetKeyDown(KeyCode.X))
        {
            //�A�C�e���������玞�ԓ���
            Time.timeScale = 1;
            //�J�����t���O�I�t(�����t���O)
            _openInventory = false;
            //�A�C�e�����̔w�i����
            _inventoryPanel.enabled = false;
            //�Ȃɂ�I��ł邩�̃e�L�X�g����
            _selectText.enabled = false;
            //�A�C�e�������̃{�^���Ɖ摜����
            //�y��
            _penImage.enabled = false;
            _penButton.enabled = false;
            //���C�^�[
            _lighterImage.enabled = false;
            _lighterButton.enabled = false;
        }
    }

    
}
