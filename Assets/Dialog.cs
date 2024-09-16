using UnityEngine;

[CreateAssetMenu(fileName = "Dialog", menuName = "Scriptable Objects/Dialog")]
public class Dialog : ScriptableObject
{
    public string dialogText;
    public DialogOption[] options;

    [System.Serializable]
    public class DialogOption
    {
        public string text;
        public Dialog nextDialog;
    }

    public void Display(DialogDisplay display)
    {
        //clear away any old options first
        foreach (Transform child in display.optionsContainer.transform)
        {
            Destroy(child.gameObject);
        }

        //display the text for this dialog
        display.dialogText.text = dialogText;

        //display the options
        foreach (var option in options)
        {
            var optionObject = Instantiate(display.optionPrefab, display.optionsContainer.transform);
            optionObject.GetComponentInChildren<TMPro.TMP_Text>().text = option.text;
            optionObject.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => option.nextDialog.Display(display));
        }
    }
}
