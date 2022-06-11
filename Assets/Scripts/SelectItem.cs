using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectItem : MonoBehaviour
{
    //[SerializeField] Text _useText;
    [SerializeField] GameObject _frontRange1Renderer;
    [SerializeField] GameObject _frontRange2Renderer;
    [SerializeField] GameObject _RightRangeRenderer;
    [SerializeField] GameObject _LeftRangeRenderer;
    public bool _isUseItem;
    public bool _isUseFakeItem;

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
        _isUseFakeItem = true;
    }

    public void UseLighter()
    {
        //_useText.enabled = true;
        _frontRange1Renderer.SetActive(true);
        _isUseItem = true;
    }
}
