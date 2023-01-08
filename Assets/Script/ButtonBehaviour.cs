using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public TextMeshProUGUI myText; 
    // Start is called before the first frame update
    public void OnButtonPressed()
    {
        myText.text = "Button was pressed";
    }
}
