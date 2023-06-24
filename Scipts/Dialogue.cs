using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    int index;
    [SerializeField]
    List<DialogueElement> _dialogue;

    public void Advance() 
    {
        if(_dialogue[index].HasOptions()) return;

        index++;
    }

    public void Select(int option) 
    {
        _dialogue[index].options[option].Do();
        _dialogue[index].options = null;
    }

    public DialogueElement GetDialogue() 
    {
        return _dialogue[index];
    }
}

[System.Serializable]
public class DialogueElement 
{
    public string speaker;
    public string message;
    [SerializeField]public List<DialogueOption> options;

    public bool HasOptions() {
        return options.Count > 0;
    }
}

[System.Serializable]
public class DialogueOption 
{
    public string content;
    public void Do()
    {
        
    }
}
