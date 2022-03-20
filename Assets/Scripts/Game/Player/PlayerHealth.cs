using UnityEngine;

namespace TDZS.Game.Player
{
  public class PlayerHealth : MonoBehaviour
  {
    [SerializeField] private int _maxHp;

    public int CurrentHp;

    private void Start()
    {
      CurrentHp = _maxHp;
    }
  }
}