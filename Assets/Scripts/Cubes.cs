using UnityEngine;

public class Cubes : MonoBehaviour
{
    [Header("Static Values")]
    public CubeStats cubeStats;

    [Header("Properties")]
    [Tooltip("This is a custom tooltip for additionalVariable1.")]
    public int additionalVariable1;

    [Range(5f, 10f)]
    public float additionalVariable2;

    public bool additionalVariable3;

    // Hidden variable (not editable in the inspector)
    [HideInInspector] public float hiddenVariable;
}