using UnityEngine;
using UnityEngine.EventSystems;

namespace JCreative.SolidPrinciple.MouseInteraction
{
	internal sealed class MouseInputDetection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
	{
		#region Fields & Properties

		private IMouseHighlight mouseHighlight;

		#endregion

		#region Unity Methods + Event Sub

		// Awake is called when the script instance is being loaded
		private void Awake()
		{
			mouseHighlight = GetComponent<IMouseHighlight>();
		}

		// Called when the mouse enters the Collider
		public void OnPointerEnter(PointerEventData eventData)
		{
			if (mouseHighlight != null)
			{
				mouseHighlight.MouseEnter();
			}
		}

		// Called when the mouse is not any longer over the Collider
		public void OnPointerExit(PointerEventData eventData)
		{
			if (mouseHighlight != null)
			{
				mouseHighlight.MouseExit();
			}
		}

		#endregion
	}
}