using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeaderBar : MonoBehaviour
{
    public GameObject RenamePanel;
    public GameObject ColorPanel;
    public GameObject BrushPanel;
	void Start()
	{
        RenamePanel.SetActive(false);
		ColorPanel.SetActive(false);
        BrushPanel.SetActive(false);
	}

    void Update()
    {
        HideIfClickedOutside(RenamePanel);
        HideIfClickedOutside(ColorPanel);
        HideIfClickedOutside(BrushPanel);
    }
    
    public void GoToHome() 
    {
        SceneManager.LoadScene(0);
    }

    public void OpenRenamePanel() 
    {
        if (RenamePanel != null)
        {
            bool isActive = RenamePanel.activeSelf;
            RenamePanel.SetActive(!isActive);
            ColorPanel.SetActive(false);
            BrushPanel.SetActive(false);
        }
    }

    public void OpenColorPanel()
    {
        if (ColorPanel != null)
        {
            bool isActive = ColorPanel.activeSelf;
            ColorPanel.SetActive(!isActive);
            RenamePanel.SetActive(false);
            BrushPanel.SetActive(false);
        }
     }
 
    public void OpenBrushPanel()
    {
        if (BrushPanel != null)
        {
            bool isActive = BrushPanel.activeSelf;
            BrushPanel.SetActive(!isActive);
            RenamePanel.SetActive(false);
            ColorPanel.SetActive(false);
        }
     }

    public void HideIfClickedOutside(GameObject panel) 
    {
        if (Input.GetMouseButton(0) && panel.activeSelf && 
            !RectTransformUtility.RectangleContainsScreenPoint(
                panel.GetComponent<RectTransform>(), 
                Input.mousePosition, 
                Camera.main)) {
            panel.SetActive(false);
        }
    }
}