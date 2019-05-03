using System.Collections.Generic;
using UnityEngine;


public class DialogueManager : GaLiOne.DialogueManager {
    public override List<string> listString {
        get {
            List<string> listString = new List<string>();
            listString.Add("text1");
            listString.Add("text2");
            listString.Add("text3");
            listString.Add("text4");
            return listString;
        }
    }

    public override bool getTriggerButtonValue() {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
