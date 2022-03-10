using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public static MenuUIHandler Instance;
    public string playerName;
    public TMP_InputField textBoxPlayerName;

    private bool isGameActive;
    
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = false;
        Instance = this;
        textBoxPlayerName.GetComponent<InputField>();
        
    }

    // Update is called once per frame
    public void StartNew()
    {
        SceneManager.LoadScene(1);
        isGameActive = true;
        playerName = textBoxPlayerName.text;
        

    }
}
