using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketChecker : Dialogue
{
    [SerializeField] private DialogManager DialogManager;
    [SerializeField] private Animator animator;

    public override void Talk()
    {
        if (DialogManager.Printer.activeSelf)
        {
            return;
        }

        animator.SetBool("Talk", true);

        var dialogData = new List<DialogData>();

        dialogData.Add(new DialogData("Hi./wait:0.5//close/", "Ticket Checker", isSkipable: false));


        dialogData.Add(new DialogData("Hi./wait:0.5//close/", "Ticket Checker", () => animator.SetBool("Talk", false), isSkipable: false));

        DialogManager.Show(dialogData);
    }
}
