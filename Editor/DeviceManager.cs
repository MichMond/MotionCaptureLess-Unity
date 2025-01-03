
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using Michmond.MoCap.Motion.Mechanical;

namespace Michmond.MoCap
{
    public class MotionRecorder : EditorWindow
    {

        private List<Device> objectList = new List<Device>();
        private Vector2 scrollPos;



        [MenuItem("Window/Michmond/Motion Capture")]
        public static void ShowWindow()
        {
            GetWindow<MotionRecorder>("My Editor Extension");
        }
        private void OnGUI()
        {
            EditorGUILayout.LabelField("Object List Editor", EditorStyles.boldLabel);

            // Scrollable area for the list
            scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
            for (int i = 0; i < objectList.Count; i++)
            {
                EditorGUILayout.BeginHorizontal();

                // Object field
                objectList[i] = EditorGUILayout.ObjectField($"Object {i + 1}", objectList[i], typeof(Device), true);

                // Remove button
                if (GUILayout.Button("Remove", GUILayout.Width(60)))
                {
                    objectList.RemoveAt(i);
                }

                EditorGUILayout.EndHorizontal();
            }
            EditorGUILayout.EndScrollView();

            EditorGUILayout.Space();

            // Add new object
            if (GUILayout.Button("Add Object"))
            {
                objectList.Add(null);
            }

            // Save the list (optional)
            if (GUILayout.Button("Save List"))
            {
                SaveObjectList();
            }
        }

        private void SaveObjectList()
        {
            // Implement your save logic here
            Debug.Log("Object list saved!");
        }



    }
}