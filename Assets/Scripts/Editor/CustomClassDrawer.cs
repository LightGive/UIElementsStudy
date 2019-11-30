using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[CustomPropertyDrawer(typeof(CustomClass))]
public class CustomClassDrawer : PropertyDrawer
{
	public override VisualElement CreatePropertyGUI(SerializedProperty property)
	{
		var container = new VisualElement();
		container.Add(new PropertyField(property.FindPropertyRelative("Str"))
		{
			label = "文字列型"
		});
		container.Add(new PropertyField(property.FindPropertyRelative("Val"))
		{
			label = "浮動小数点型"
		});

		return container;
	}
}