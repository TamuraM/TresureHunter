using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�ǂ̃A�C�e����I�񂾂��̊Ǘ�</summary>
public class GameManager : MonoBehaviour
{
    //�V���O���g���Ƃ��������
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

    //�����|����A�C�e����I��
    public bool _selectedItem;
    //�����|�����A�Ԃ蓢���ɂ����A�C�e����I��
    public bool _selectedFakeItem;
    //����|����
    public bool _killPaper;
    [SerializeField] Animator _leftWall;
    [SerializeField] Animator _rightWall;

    private void Update()
    {
        if(_killPaper)
        {
            _leftWall.SetBool("PaperDied", true);
            _rightWall.SetBool("PaperDied", true);
        }
    }
}
