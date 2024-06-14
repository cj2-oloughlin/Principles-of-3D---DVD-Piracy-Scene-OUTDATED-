using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    [SerializeField] private string interactText;
    [SerializeField] private Dialogue dialogue;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        Debug.Log("Interact!");

        animator.SetTrigger("Talk");
        dialogue.Talk();
    }

    public string GetInteractText()
    {
        return interactText;
    }

}
