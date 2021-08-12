using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotChooseBuildings : ChooseBuildings
{
    private void Start()
    {
        ScriptText = null;
        ScriptTextPanel = null;
    }
    public void PopupIsOpen()
    {
        IsPopupOpen = true;
    }

    public void PopupIsClose()
    {
        IsPopupOpen = false;
    }
}
