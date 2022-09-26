using DG.Tweening;
using UnityEngine;

namespace JCreative.SolidPrinciple.MouseInteraction
{
	[RequireComponent(typeof(MouseInputDetection))]
	internal sealed class ScaleMouseEffect : MouseEffectBase
	{
		#region Custom Methods

		public override void MouseEnter()
		{
			TweeningScale(true);
		}

		public override void MouseExit()
		{
			TweeningScale(false);
		}

		private void TweeningScale(bool mustBeScaled)
		{
			transform.DOScale(mustBeScaled ? 1.2f * Vector3.one : Vector3.one, 2f);
		}

		#endregion
	}
}