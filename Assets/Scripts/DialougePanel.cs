using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialougePanel : MonoBehaviour
{
    public Button yesButton;
    public Button noButton;
    void Awake()
    {
        yesButton.onClick.AddListener(Yes);
        noButton.onClick.AddListener(No);

    }

    public void AssignNpcActionsToButtons(UnityAction npcAction)
    {
        yesButton.onClick.AddListener(npcAction);
    }

    void Yes()
    {

    }
    void No()
    {
        gameObject.SetActive(false);
    }
}
