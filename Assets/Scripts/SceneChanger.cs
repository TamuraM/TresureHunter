using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>シーン遷移</summary>
public class SceneChanger : MonoBehaviour
{
    /// <summary>タイトルシーンへ遷移</summary>
    public void LoadTitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    /// <summary>ルール説明シーンへ遷移</summary>
    public void LoadRuleScene()
    {
        SceneManager.LoadScene("Rule");
    }

    /// <summary>ゲームシーンへ遷移</summary>
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    /// <summary>ゲームオーバーシーンへ遷移</summary>
    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    /// <summary>ゲームクリアシーンへ遷移</summary>
    public void LoadClearScene()
    {
        SceneManager.LoadScene("Clear");
    }

    /// <summary>ゲームを終了する</summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}
