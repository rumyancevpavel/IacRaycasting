using UnityEngine;

namespace IacRaycasting.Aiming
{
	public class LaserCannonShoot : MonoBehaviour
	{
		[SerializeField] private Transform _muzzleTip;
		[SerializeField] private float _rayLength;

		private Outline _currentHighlight;
		
		private void Update()
		{
			AimLogic();
		}

		private void AimLogic()
		{
			RaycastHit hitInfo;
			var isSomethingHit = Physics.Raycast(_muzzleTip.position, _muzzleTip.forward, out hitInfo, _rayLength);
			if (isSomethingHit)
			{
				var hitObject = hitInfo.transform.gameObject;
				_currentHighlight = hitObject.GetComponent<Outline>();
				if (_currentHighlight != null)
				{
					_currentHighlight.Highlight();
				}
			}
			else
			{
				if (_currentHighlight != null)
				{
					_currentHighlight.ClearHighlight();
					_currentHighlight = null;
				}
			}
		}
	}
}