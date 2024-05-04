using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class ReceptionistTalk : Dialogue
{
    [SerializeField] private DialogManager DialogManager;

    public override void Talk()
    {
        if (DialogManager.Printer.activeSelf)
        {
            return;
        }

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Good Morning!/wait:1/The next screening is about to begin./wait:1/Enjoy!/wait:1//close/", "Receptionist", isSkipable: false));

        DialogManager.Show(dialogTexts);
    }
}
