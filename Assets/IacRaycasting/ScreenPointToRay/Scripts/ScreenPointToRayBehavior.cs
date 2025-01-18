using UnityEngine;

namespace IacRaycasting.ScreenPointToRay.Scripts
{
	[RequireComponent(typeof(Camera))]
	public class ScreenPointToRayBehavior : MonoBehaviour
	{
		[SerializeField, Range(1, 100)] private float _rayLength = 10;
		
		private Camera _camera;

		private void Awake()
		{
			_camera = GetComponent<Camera>();
		}

		private void Update()
		{
			var ray = _camera.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out var hit, _rayLength))
			{
				Debug.Log($"Hit!!! {hit.transform.gameObject.name}");
			}
			Debug.DrawRay(ray.origin, ray.direction * _rayLength, Color.red);
		}
	}
}