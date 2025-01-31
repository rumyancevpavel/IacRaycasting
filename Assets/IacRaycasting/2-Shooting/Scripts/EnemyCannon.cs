using UnityEngine;

namespace IacRaycasting.Shooting
{
	public class EnemyCannon : MonoBehaviour
	{
		[SerializeField] private GameObject _explosionPrefab;
		[SerializeField] private int _health = 100;
	}
}