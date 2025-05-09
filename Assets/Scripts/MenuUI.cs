using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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

    public void Exit()
    {

#if UNITY_EDITOR //# isnt' "code" persay, but rather telling the editor what to do, so our exit button will exit the play mode
        EditorApplication.ExitPlaymode();
#else
               Application.Quit(); // original code to quit Unity when the player is playing the game
#endif
    }

}
