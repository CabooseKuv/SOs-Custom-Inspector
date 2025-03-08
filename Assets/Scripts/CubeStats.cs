using UnityEngine;

[CreateAssetMenu(fileName = "CubeStats", menuName = "Cube Stats")]
public class CubeStats : ScriptableObject
{
    // Static values
    public static int staticValue1 = 100;
    public static int staticValue2 = 200;
    public static int staticValue3 = 300;

    // Instance-specific values
    public string cubeName;
    public float value1;
    public float value2;
    [HideInInspector] public float value3; // Hidden in the inspector
}