using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogDisplay : MonoBehaviour
{
    public Dialog startingDialog;

    public TMP_Text dialogText;
    public GridLayoutGroup dialogOptions;

    public GameObject dialogOptionPrefab;

    void Start()
    {
        ShowDialog(startingDialog);
    }

    void ShowDialog(Dialog dialogToShow)
    {
        dialogText.text = dialogToShow.message;

        // Clear all existing options
        foreach (Transform child in dialogOptions.transform)
        {
            Destroy(child.gameObject);
        }

        // populate options
        for (var i = 0; i < dialogToShow.options.Length; i++)
        {
            var option = Instantiate(dialogOptionPrefab);
            option.transform.SetParent(dialogOptions.transform);
            option.GetComponentInChildren<TMP_Text>().text = dialogToShow.options[i].text;

            //make it so you can click on each option
            var nextDialog = dialogToShow.options[i].dialog;
            option.GetComponent<Button>().onClick.AddListener(() => ShowDialog(nextDialog));
        }
    }
}
