
using UnityEngine;
using UnityEditor;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("kScriptsDefaultApp = " + EditorPrefs.GetString("kScriptsDefaultApp"));
        EditorPrefs.SetString("kScriptsDefaultApp", "C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community\\Common7\\IDE\\devenv.exe");
    }
}