using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    int index;
    [SerializeField]
    List<DialogueElement> _dialogue;

    public void Start() {
        index = 0;
    }

    private void Advance() 
    {
        index++;
    }

    public void Select(int option) 
    {
        if(!_dialogue[index].HasOptions()) 
        {
            Advance();
            return;
        }
        _dialogue[index].options[option].Do();
        index += _dialogue[index].options[option].offsetIndex;
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

    public bool HasOptions() 
    {
        Debug.Log(options.Count);
        return options.Count > 0;
    }
}


