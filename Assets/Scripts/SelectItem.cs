using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    [SerializeField] GameObject _frontRange1Renderer;
    [SerializeField] GameObject _frontRange2Renderer;
    [SerializeField] GameObject _RightRangeRenderer;
    [SerializeField] GameObject _LeftRangeRenderer;

    private void Start()
    {
        //_useText.enabled = false;
        _frontRange1Renderer.SetActive(false);
        _frontRange2Renderer.SetActive(false);
        _RightRangeRenderer.SetActive(false);
        _LeftRangeRenderer.SetActive(false);
    }

    public void UsePen()
    {
        //_useText.enabled = true;
        _frontRange1Renderer.SetActive(true);
        GameManager.Instance._isUseFakeItem = true;
    }

    public void UseLighter()
    {
        //_useText.enabled = true;
        _frontRange1Renderer.SetActive(true);
        GameManager.Instance._isUseItem = true;
    }
}
