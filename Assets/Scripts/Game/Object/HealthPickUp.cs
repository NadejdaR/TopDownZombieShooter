using TDZS.Game.Player;
using TDZS.Utility.Constants;
using UnityEngine;

namespace TDZS.Game.Object
{
    public class HealthPickUp : MonoBehaviour
    {
        [SerializeField] private PlayerHealth _playerState;
        [SerializeField] private int _addLife;
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Tags.Player))
            {
                //_playerState.AddLive(_addLife); 
                Destroy(this);
            }
        }
    }
}
