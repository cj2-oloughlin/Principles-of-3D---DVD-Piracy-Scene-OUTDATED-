using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class TicketCheckerDialogue : Dialogue
{
    [SerializeField] private DialogManager DialogManager;

    public override void Talk()
    {
        if (DialogManager.Printer.activeSelf)
        {
            return;
        }

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Testing.../ Testing...", "Ticket Checker", isSkipable: false));

        DialogManager.Show(dialogTexts);
    }
}
