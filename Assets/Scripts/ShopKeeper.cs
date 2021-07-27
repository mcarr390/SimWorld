
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShopKeeper : MonoBehaviour, INpc
{
    public GameObject upObject;
    public GameObject downObject;
    public GameObject rightObject;
    public GameObject leftObject;

	public GameObject dialougeObject;
	public GameObject npcActionObject;

	private DialougePanel dialougePanelScript;

	public UnityAction npcAction;

    private void Awake()
    {
		dialougePanelScript = dialougeObject.GetComponent<DialougePanel>();
		npcAction = ActivateNPCAction;
		dialougePanelScript.AssignNpcActionsToButtons(npcAction);
    }
    public void InteractWith(Vector3 playersLookDirection)
    {
        Debug.Log(gameObject.name + " has been interacted with");
		LookAtPlayer(playersLookDirection);
		ActivateDialouge();
		
    }

	private void ActivateDialouge()
    {
		dialougeObject.SetActive(true);
    }
	public void ActivateNPCAction()
    {
		dialougeObject.SetActive(false);
		npcActionObject.SetActive(true);
	}
	public void DismissNPCAction()
    {
		dialougeObject.SetActive(false);

	}

	private void LookAtPlayer(Vector3 playersLookDirection)
    {
		if (playersLookDirection == Vector3.down)
		{
			// Activate appropiate game object
			upObject.SetActive(true);
			rightObject.SetActive(false);
			leftObject.SetActive(false);
			downObject.SetActive(false);

		}

		else if (playersLookDirection == Vector3.up)
		{
			// Activate appropiate game object
			upObject.SetActive(false);
			rightObject.SetActive(false);
			leftObject.SetActive(false);
			downObject.SetActive(true);

		}

		else if (playersLookDirection == Vector3.left)
		{
			// Activate appropiate game object
			upObject.SetActive(false);
			rightObject.SetActive(true);
			leftObject.SetActive(false);
			downObject.SetActive(false);

		}

		else if (playersLookDirection == Vector3.right)
		{
			// Activate appropiate game object
			upObject.SetActive(false);
			rightObject.SetActive(false);
			leftObject.SetActive(true);
			downObject.SetActive(false);

		}

	}
}

