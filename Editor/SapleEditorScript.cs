using UnityEngine;
using UnityEditor;

public class SapleEditorScript : EditorWindow
{
    //[MenuItem("Tools/Sample Editor Script")]
    public static void ShowWindow()
    {
        GetWindow<SapleEditorScript>("Sample Editor Script");
    }
}
