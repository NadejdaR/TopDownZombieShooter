using UnityEngine;

namespace TDZS.Game.Enemy
{
    public class EnemyAnimationAdapter : MonoBehaviour
    {
        [SerializeField] private EnemyAttack _enemyAttack;

        public void AppleDamage()
        {
            _enemyAttack.AppleDamage();
        }
    }
}
