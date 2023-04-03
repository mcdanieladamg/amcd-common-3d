using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private TextMeshProUGUI _switchModesButtonText;


    void Start()
    {
        _menuPanel.SetActive(false);
        //var mText = _switchModesButton.GetComponent<TextMeshProUGUI>();
        if (SceneManager.GetActiveScene().name == "EditorScene") { _switchModesButtonText.text = "Switch to Game Mode"; }
        else { _switchModesButtonText.text = "Switch to Editor Mode"; }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        _menuPanel.SetActive(!_menuPanel.activeInHierarchy);
    }

    public void ToggleGameMode()
    {
        if (SceneManager.GetActiveScene().name == "EditorScene") { SceneManager.LoadScene("LevelOneScene"); }
        else { SceneManager.LoadScene("EditorScene"); }
    }

}
