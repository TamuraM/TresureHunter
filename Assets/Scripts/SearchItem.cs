using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchItem : MonoBehaviour
{
    [SerializeField] Text searchText;
    public bool isPen;
    public bool isLighter;

    private void Start()
    {
        searchText.enabled = false;
        isPen = false;
        isLighter = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            searchText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            searchText.enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Pen" && Input.GetKeyDown(KeyCode.Z))
        {
            isPen = true;
            searchText.enabled = false;
        }
        else if (other.gameObject.name == "Lighter" && Input.GetKeyDown(KeyCode.Z))
        {
            isLighter = true;
            searchText.enabled = false;
            //GameManager.Instance._hasLighter = true;
        }
    }
}
