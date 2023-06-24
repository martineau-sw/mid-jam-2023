using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TerminalUI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _terminalText;
    [SerializeField]
    Dialogue _dialogue;

    public const int CHARACTER_RATE_MS = 30;
    public string _display;
    public int index;
    public float time;

    public void Start()
    {
        Append();
    }

    public void Update()
    {
        AppendCharacter();
    }

    // Update is called once per frame
    public void Append()
    {
        _display += Format() + '\n';
    }

    private void AppendCharacter()
    {
        if(index < _display.Length) 
        {
            time += Time.deltaTime;
            if(time > (CHARACTER_RATE_MS + Random.Range(-10f, 10f)) / 1000f)
            {
                _terminalText.text += _display[index++];
                time = 0;
            }
        }
    }

    string Format() 
    {
        return "[" + _dialogue.GetDialogue().speaker + "] " + _dialogue.GetDialogue().message + FormatOptions();
    }

    string FormatOptions()
    {
        string str = "";

        if(_dialogue.GetDialogue().HasOptions())
        {
            str = "\n";
            foreach(DialogueOption option in _dialogue.GetDialogue().options)
            {
                str += " > " + option.content + "\n";
            }
        }

        return str;
    }
}
