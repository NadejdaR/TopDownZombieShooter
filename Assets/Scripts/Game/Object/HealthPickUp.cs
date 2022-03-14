using TDZS.Game.Player;
using UnityEngine;

namespace TDZS.Game.Object
{
    public class HealthPickUp : MonoBehaviour
    {
        [SerializeField] private PlayerState _playerState;
        [SerializeField] private int _addLife;
        private void OnTriggerEnter2D(Collider2D other)
        {
            _playerState.AddLive(_addLife);
            Destroy(gameObject);
        }
    }
}
