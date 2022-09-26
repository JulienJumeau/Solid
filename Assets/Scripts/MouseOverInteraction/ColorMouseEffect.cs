using UnityEngine;

namespace JCreative.SolidPrinciple.MouseInteraction
{
	[RequireComponent(typeof(MouseInputDetection))]
	internal sealed class ColorMouseEffect : MouseEffectBase
	{
		#region Fields & Properties

		[Header("** InteractableCube System **")]
		[Space]
		[SerializeField] private Material _highlightMaterial = null;
		private Material _defaultMeterial;
		private MeshRenderer _meshRenderer;

		#endregion

		#region Unity Methods + Event Sub

		// Awake is called when the script instance is being loaded
		private void Awake()
		{
			_meshRenderer = GetComponent<MeshRenderer>();
			_defaultMeterial = _meshRenderer.material;
		}

		#endregion

		#region Custom Methods

		public override void MouseEnter()
		{
			if (_meshRenderer != null && _highlightMaterial != null)
			{
				ChangeGOMaterial(_highlightMaterial);
			}
		}

		public override void MouseExit()
		{
			if (_meshRenderer != null && _highlightMaterial != null)
			{
				ChangeGOMaterial(_defaultMeterial);
			}
		}

		private void ChangeGOMaterial(Material material)
		{
			_meshRenderer.material = material;
		}

		#endregion
	}
}