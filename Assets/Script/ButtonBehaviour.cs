using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public TextMeshProUGUI myText; 
    // Start is called before the first frame update
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    
}
