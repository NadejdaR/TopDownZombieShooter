using System.Collections;
using TDZS.Game.Enemy;
using TDZS.Utility.Constants;
using UnityEngine;

namespace TDZS.Game.Object
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _lifeTime;
        [SerializeField] private EnemyStat _enemyStat;

        private Vector3 _velocity;

        private void Start()
        {
            _velocity = Vector3.up * _speed;

            StartCoroutine(KillBulletByLifeTime());
        }

        private void Update() =>
            Move();
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Tags.Enemy))
            {
                _enemyStat.RemoveLive();
                StopCoroutine(KillBulletByLifeTime());
                Kill();
            }
        }

        private void Move() =>
            transform.Translate(_velocity * Time.deltaTime);

        private IEnumerator KillBulletByLifeTime()
        {
            yield return new WaitForSeconds(_lifeTime);

            Kill();
        }

        private void Kill() =>
            Destroy(gameObject);
    }
}
