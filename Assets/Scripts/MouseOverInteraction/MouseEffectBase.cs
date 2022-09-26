using UnityEngine;

namespace JCreative.SolidPrinciple.MouseInteraction
{
	internal abstract class MouseEffectBase : MonoBehaviour, IMouseHighlight
	{
		public abstract void MouseEnter();
		public abstract void MouseExit();
	}
}