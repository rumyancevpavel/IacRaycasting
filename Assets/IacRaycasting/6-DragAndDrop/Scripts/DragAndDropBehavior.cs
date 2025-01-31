using UnityEngine;

namespace IacRaycasting.DragAndDrop
{
	[RequireComponent(typeof(Camera))]
	public class DragAndDropBehavior : MonoBehaviour
	{
		[SerializeField, Range(1, 100)] private float _rayLength = 10;
		[SerializeField] private string _highlightableTag;
		[SerializeField] private string _groundPlaneTag;

		private Camera _camera;
		private Outline _currentHighlight;
		private Outline _currentSelection;
		private Transform _currentlyDraggedObject;

		private void Awake()
		{
			_camera = GetComponent<Camera>();
		}
	}
}