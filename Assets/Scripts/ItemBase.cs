using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>�A�C�e���Ɋւ�����N���X</summary>
public abstract class ItemBase : MonoBehaviour
{
    [SerializeField, Tooltip("�u�T���v�e�L�X�g")] Text _searchText;
    [SerializeField, Tooltip("�Ȃ�̃A�C�e�����Q�b�g��������\������p�l��")] GameObject _getItemPanel;
    [SerializeField, Tooltip("�Ȃ�̃A�C�e�����Q�b�g��������\������e�L�X�g")] Text _getItemText;

    private void Awake()
    {
        _searchText.enabled = false;
        _getItemPanel.SetActive(false);
    }

    public abstract void Activate();

    private void OnTriggerEnter(Collider other)
    {
        //�A�C�e��������Ƃ���ɓ���������u���ׂ�v�e�L�X�g��\��
        if (other.gameObject.tag == "Player")
        {
            _searchText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //�A�C�e��������Ƃ��납�痣�ꂽ��u���ׂ�v�e�L�X�g���\��
        if (other.gameObject.tag == "Player")
        {
            _searchText.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //�A�C�e��������Ƃ����Z�L�[�������ƃA�C�e������肷��
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Z))
        {
            Activate();
            this.gameObject.SetActive(false);
            GetItem(this.gameObject.name);
            _searchText.enabled = false;
        }
    }

    /// <summary>�Ȃ�̃A�C�e�������������\������w�i�ƃe�L�X�g���o��</summary>
    /// <param name="item"></param>
    private void GetItem(string item)
    {
        _getItemText.text = item + "����肵���I(X�{�^���ŃA�C�e�������J��)";
        _getItemPanel.SetActive(true);
        //_getItemText.enabled = true;
        Invoke("DeleteGetItemUI", 1.5f);
    }

    /// <summary>�Ȃ�̃A�C�e�������������\������w�i�ƃe�L�X�g������</summary>
    private void DeleteGetItemUI()
    {
        _getItemPanel.SetActive(false);
        //_getItemText.enabled = false;
    }
}