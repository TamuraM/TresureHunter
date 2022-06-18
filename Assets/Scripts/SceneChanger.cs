using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>�V�[���J��</summary>
public class SceneChanger : MonoBehaviour
{
    /// <summary>�^�C�g���V�[���֑J��</summary>
    public void LoadTitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    /// <summary>���[�������V�[���֑J��</summary>
    public void LoadRuleScene()
    {
        SceneManager.LoadScene("Rule");
    }

    /// <summary>�Q�[���V�[���֑J��</summary>
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    /// <summary>�Q�[���I�[�o�[�V�[���֑J��</summary>
    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    /// <summary>�Q�[���N���A�V�[���֑J��</summary>
    public void LoadClearScene()
    {
        SceneManager.LoadScene("Clear");
    }

    /// <summary>�Q�[�����I������</summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}
