using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>�A�C�e����T���ăQ�b�g����</summary>
public class SearchItem : MonoBehaviour
{
    //�u���ׂ�v�e�L�X�g
    [SerializeField] Text _searchText;
    //�Ȃ�̃A�C�e�������������\������w�i�ƃe�L�X�g
    [SerializeField] Image _getItemPanel;
    [SerializeField] Text _getItemText;
    //�ǂ̃A�C�e���������Ă��邩
    //�y��
    public bool _havePen;
    //���C�^�[
    public bool _haveLighter;

    private void Start()
    {
        //�u���ׂ�v�e�L�X�g����
        _searchText.enabled = false;
        //�Ȃ�̃A�C�e�������������\������w�i�ƃe�L�X�g������
        _getItemPanel.enabled = false;
        _getItemText.enabled = false;
        //�A�C�e���������ĂȂ�(�A�C�e���������Ă��邩���I�t)
        //�y��
        _havePen = false;
        //���C�^�[
        _haveLighter = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        //�A�C�e��������Ƃ���ɓ���������u���ׂ�v�e�L�X�g��\��
        if (other.gameObject.tag == "Item")
        {
            _searchText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //�A�C�e��������Ƃ��납�痣�ꂽ��u���ׂ�v�e�L�X�g���\��
        if (other.gameObject.tag == "Item")
        {
            _searchText.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //�A�C�e��������Ƃ����Z�L�[�������ƃA�C�e������肷��
        //�y��
        if (other.gameObject.name == "Pen" && Input.GetKeyDown(KeyCode.Z))
        {
            GetItem("�y��");
            //�y������肵��
            _havePen = true;
            //�u���ׂ�v�e�L�X�g�͏���
            _searchText.enabled = false;
            //�y�����t�B�[���h�ォ�����
            other.gameObject.SetActive(false);
        }
        //���C�^�[
        else if (other.gameObject.name == "Lighter" && Input.GetKeyDown(KeyCode.Z))
        {
            GetItem("���C�^�[");
            //���C�^�[����肵��
            _haveLighter = true;
            //�u���ׂ�v�e�L�X�g�͏���
            _searchText.enabled = false;
            //���C�^�[���t�B�[���h�ォ�����
            other.gameObject.SetActive(false);
        }
    }

    /// <summary>�Ȃ�̃A�C�e�������������\������w�i�ƃe�L�X�g���o��</summary>
    /// <param name="item"></param>
    private void GetItem(string item)
    {
        _getItemText.text = item + "����肵���I(X�{�^���ŃA�C�e�������J��)";
        _getItemPanel.enabled = true;
        _getItemText.enabled = true;
        Invoke("DeleteGetItemUI", 1.5f);
    }

    /// <summary>�Ȃ�̃A�C�e�������������\������w�i�ƃe�L�X�g������</summary>
    private void DeleteGetItemUI()
    {
        _getItemPanel.enabled = false;
        _getItemText.enabled = false;
    }

}
