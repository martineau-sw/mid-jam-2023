using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/DialogueOptions")]
public class DialogueOption : ScriptableObject
{
    public string content;
    public int gotoIndex;
    public int offsetIndex;
    public void Do()
    {
        
    }
}