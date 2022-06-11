using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] Image _penImage;
    [SerializeField] Image _lighterImage;
    [SerializeField] Image _penButton;
    [SerializeField] Image _lighterButton;
    [SerializeField] Image _inventoryPanel;
    public SearchItem _searchItem;
    private bool _openInventory;

    // Start is called before the first frame update
    void Start()
    {
        _inventoryPanel.enabled = false;
        _penImage.enabled = false;
        _lighterImage.enabled = false;
        _penButton.enabled = false;
        _lighterButton.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!_openInventory && Input.GetKeyDown(KeyCode.X))
        {
            Time.timeScale = 0;
            _inventoryPanel.enabled = true;
            _openInventory = true;
            if (_searchItem.isPen)
            {
                _penImage.enabled = true;
                _penButton.enabled = true;
            }
            if (_searchItem.isLighter)
            {
                _lighterImage.enabled = true;
                _lighterButton.enabled = true;
            }
        }
        else if(_openInventory && Input.GetKeyDown(KeyCode.X))
        {
            Time.timeScale = 1;
            _inventoryPanel.enabled = false;
            _openInventory = false;
            _penImage.enabled = false;
            _penButton.enabled = false;
            _lighterImage.enabled = false;
            _lighterButton.enabled = false;
        }
    }

    
}
