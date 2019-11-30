using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace LightGive
{
	public class ToggleButton : Button
	{
		private bool isOn;

		public new class UxmlFactory : UxmlFactory<ToggleButton, UxmlTraits> { }

		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			UxmlBoolAttributeDescription isOnAttr = new UxmlBoolAttributeDescription { name = "isOn" };

			// 子要素を持つかどうか
			public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
			{
				get { yield break; }
			}

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				base.Init(ve, bag, cc);

			}


		}


	}
}