
using UnityEditor;
using UnityEngine;

namespace Michmond.MoCap
{
    public class MotionCapture : EditorWindow
    {
        private string inputText = "Hello, Unity!";

        [MenuItem("Window/Michmond/Motion Capture")]
        public static void ShowWindow()
        {
            GetWindow<MotionCapture>("My Editor Extension");
        }
        private void OnGUI()
        {
            GUILayout.Label("This is my custom editor extension", EditorStyles.boldLabel);
            inputText = EditorGUILayout.TextField("Input Text", inputText);

            if (GUILayout.Button("Click Me"))
            {
                Debug.Log("Button clicked: " + inputText);
            }
        }
    }
}