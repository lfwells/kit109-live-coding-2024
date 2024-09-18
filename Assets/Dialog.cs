using UnityEngine;

[CreateAssetMenu(fileName = "Dialog", menuName = "Scriptable Objects/Dialog")]
public class Dialog : ScriptableObject
{
    public string message;
    public DialogOption[] options;

    [System.Serializable]
    public class DialogOption
    {
        public string text;
        public Dialog dialog;
    }
}
