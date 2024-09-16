using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogDisplay : MonoBehaviour
{
    public GridLayoutGroup optionsContainer;
    public TMP_Text dialogText;
    public GameObject optionPrefab;

    public Dialog firstDialog;

    void Start()
    {
        firstDialog.Display(this);
    }
    
}
