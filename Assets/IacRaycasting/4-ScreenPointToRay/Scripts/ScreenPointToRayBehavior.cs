using UnityEngine;

namespace IacRaycasting.ScreenPointToRay
{
	[RequireComponent(typeof(Camera))]
	public class ScreenPointToRayBehavior : MonoBehaviour
	{
		[SerializeField, Range(1, 100)] private float _rayLength = 10;
		[SerializeField] private string _highlightableTag;

		private Camera _camera;
		private Outline _currentHighlight;
		private Outline _currentSelection;

		private void Awake()
		{
			_camera = GetComponent<Camera>();
		}
	}
}