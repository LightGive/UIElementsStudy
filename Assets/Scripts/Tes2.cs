using UnityEngine;
using UnityEngine.UIElements;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UIElements;
#endif

public class Tes2 : MonoBehaviour
{
	[SerializeField]
	private CustomClass custom;
}

#if UNITY_EDITOR
[CustomEditor(typeof(Tes2))]
public class TestEditor : Editor
{
	public override VisualElement CreateInspectorGUI()
	{
		VisualElement container = new VisualElement();
		container.Add(new PropertyField(serializedObject.FindProperty("custom")));
		return container;
	}
}
#endif