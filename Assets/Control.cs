using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public InputActionReference ControlButton;

    public CanvasGroup ControlPanel;

    private bool isExpanded = false;

    private bool isButtonClick = false;

    private Tweener currentTween;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ControlInputDown() )
        {
            isExpanded = !isExpanded;
            
            if (isExpanded)
            {
                RetractControl();
            }
            else
            {
                ExpandControl();
            }
            
        }
    }
    void ExpandControl()
    {
        // if (currentTween == null || currentTween.IsComplete())
        // {
        // }
        ControlPanel.GetComponent<GraphicRaycaster>().enabled = false;
        currentTween = ControlPanel.DOFade(0f, 1f);

        
    }

    void RetractControl()
    {
        ControlPanel.GetComponent<GraphicRaycaster>().enabled = true;
        currentTween = ControlPanel.DOFade(1f, 1f);

    }

    public void TogglePanel()
    {
        isExpanded = !isExpanded;
            
        if (isExpanded)
        {
            RetractControl();
        }
        else
        {
            ExpandControl();
        }
    }
    
    bool ControlInputDown()
    {
        if (ControlButton != null)
        {
            if (ControlButton.action.triggered)
            {
                return true;
            }
        }
        return false;
    }
}
