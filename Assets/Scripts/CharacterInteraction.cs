using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    private SimpleCharacterController characterController;
    [SerializeField]
    private float rayOffset;
    public GameObject playersInventory;
    public GameObject dialougeTextPanel;
    public GameObject shop;


    private void Start()
    {
        characterController = GetComponent<SimpleCharacterController>();
    }
    void Update()
    {
        Debug.DrawRay(transform.position + new Vector3(0, 2f, 0), characterController.lookDirection, Color.green);
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0, 2f, 0), characterController.lookDirection * 2.5f);
            
            Debug.Log(hit.collider.gameObject.name);
            if(hit.collider.gameObject.GetComponent<INpc>() != null)
            {
                hit.collider.gameObject.GetComponent<INpc>().InteractWith(characterController.lookDirection);
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            playersInventory.SetActive(!playersInventory.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            playersInventory.SetActive(false);
            dialougeTextPanel.SetActive(false);
            shop.SetActive(false);

        }

    }

    

}
