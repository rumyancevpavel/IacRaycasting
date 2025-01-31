using UnityEngine;

namespace IacRaycasting.BasicObjectHit
{
	[RequireComponent(typeof(Camera))]
	public class BasicObjectHitBehaviour : MonoBehaviour
	{
		[SerializeField, Range(1, 100)] private float _rayLength;
		
		private Camera _camera;
		
		private void Start()
		{
			_camera = GetComponent<Camera>();
		}
	}
}