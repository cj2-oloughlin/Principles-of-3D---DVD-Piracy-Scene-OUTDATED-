using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class Receptionist : Dialogue
{
    [SerializeField] private DialogManager DialogManager;

    public override void Talk()
    {
        if (DialogManager.Printer.activeSelf)
        {
            return;
        }

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Hello there!/wait:0.1/ Oh wait.../wait:0.5/ It's you!/wait:0.3/ Hi!/wait:0.5//close/", "Receptionist", isSkipable: false));
        dialogTexts.Add(new DialogData("This is the third time you've been here this week,/wait:0.3/ big fan huh?/wait:0.3/ /close/", "Receptionist", isSkipable: false));
        dialogTexts.Add(new DialogData("/size:up/Luckily,/size:init/ we have a new screening so you shouldn't be too bored.../wait:0.5//close/", "Receptionist", isSkipable: false));
        dialogTexts.Add(new DialogData("/speed:down/ And... /wait:0.3//speed:init/Here's your ticket! /wait:0.3//close/", "Receptionist", isSkipable: false));
        dialogTexts.Add(new DialogData("/size:up/ Enjoy the movie! /size:init//wait:0.3//close/", "Receptionist", isSkipable: false));



        DialogManager.Show(dialogTexts);
    }
}
