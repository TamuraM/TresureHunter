using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadTitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    public void LoadRuleScene()
    {
        SceneManager.LoadScene("Rule");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadClearScene()
    {
        SceneManager.LoadScene("Clear");
    }
}
