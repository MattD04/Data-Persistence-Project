using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{

    public InputField nameinputField;
    public void StartNew()
    {
        DataManager.Instance.playerName = nameinputField.text;
        SceneManager.LoadScene(1);
    }
}
