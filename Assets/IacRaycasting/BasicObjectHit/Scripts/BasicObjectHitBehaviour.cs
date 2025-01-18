using UnityEngine;

namespace IacRaycasting.BasicObjectHit
{
	public class BasicObjectHitBehaviour : MonoBehaviour
	{
		[SerializeField, Range(1, 100)]private float _rayDuration = 10;
		
		private Camera _camera;
		private Ray _ray;
		
		private void Start()
		{
			_camera = GetComponent<Camera>();
		}

		private void Update()
		{
			_ray = new Ray(_camera.transform.position, _camera.transform.forward);
			if (Physics.Raycast(_ray, out var hit, _rayDuration))
			{
				Debug.Log($"Hit!!! {hit.transform.gameObject.name}");
			}
			Debug.DrawRay(_ray.origin, _ray.direction * _rayDuration, Color.red);
		}
	}
}