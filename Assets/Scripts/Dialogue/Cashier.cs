using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class Cashier : Dialogue
{
    [SerializeField] private DialogManager DialogManager;

    public override void Talk()
    {
        if (DialogManager.Printer.activeSelf)
        {
            return;
        }

        var dialogTexts = new List<DialogData>();



        
        dialogTexts.Add(new DialogData("/size:down//size:down//size:down//size:down/Ugh not this guy- /wait:0.1//close/", "Cashier", isSkipable: false));
        dialogTexts.Add(new DialogData("/size:init/Hey. What d'ya want? /wait:0.3//close/", "Cashier", isSkipable: false));
        dialogTexts.Add(new DialogData("/speed:down//speed:down/ . . . /speed:init//wait:0.3//close/", "Cashier", isSkipable: false));




        DialogManager.Show(dialogTexts);
    }
}
