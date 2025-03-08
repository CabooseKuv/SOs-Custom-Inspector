using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EditorExample))]
public class EditorExampleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Get the target object
        EditorExample editorExample = (EditorExample)target;

        // Display the ScriptableObject property field
        editorExample.attachedSO = (CubeStats)EditorGUILayout.ObjectField("Attached SO", editorExample.attachedSO, typeof(CubeStats), false);

        if (editorExample.attachedSO != null)
        {
            // Display all fields from the ScriptableObject
            EditorGUILayout.LabelField("Cube Name", editorExample.attachedSO.cubeName);
            EditorGUILayout.FloatField("Value 1", editorExample.attachedSO.value1);
            EditorGUILayout.FloatField("Value 2", editorExample.attachedSO.value2);

            // Calculated values
            float calculatedValue1 = CubeStats.staticValue1 * editorExample.attachedSO.value1;
            float calculatedValue2 = CubeStats.staticValue2 * editorExample.attachedSO.value2;
            float calculatedValue3 = CubeStats.staticValue3 * editorExample.attachedSO.value1;

            EditorGUILayout.LabelField("Calculated Value 1", calculatedValue1.ToString());
            EditorGUILayout.LabelField("Calculated Value 2", calculatedValue2.ToString());
            EditorGUILayout.LabelField("Calculated Value 3", calculatedValue3.ToString());
        }

        // Ensure serialized values are retained
        if (GUI.changed)
        {
            EditorUtility.SetDirty(editorExample);
        }
    }
}