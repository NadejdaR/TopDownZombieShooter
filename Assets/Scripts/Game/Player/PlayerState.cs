using TDZS.Utility.Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TDZS.Game.Player
{
  public class PlayerState : MonoBehaviour
  {
    [Header("Lives")] 
    [SerializeField] private int _maxLives = 5;
    [SerializeField] private int _startLives = 3;
    
    [Header("")]
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerAttack _playerAttack;
    [SerializeField] private CircleCollider2D _circleCollider2D;

    public int MaxLives => _maxLives;
    public int CurrentLives { get; private set; }

    private void Awake()
    {
      CurrentLives = _startLives;
    }

    public void AddLive(int liveToAdd)
    {
      CurrentLives++;

      if (CurrentLives >= _maxLives)
        CurrentLives = _maxLives;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag(Tags.Bullet))
        RemoveLive();
    }

    private void RemoveLive()
    {
      CurrentLives--;

      if (CurrentLives <= 0)
      {
        _playerAnimation.PlayDead();
        Death();
      }
    }

    private void Death()
    {
      _playerMovement.enabled = false;
      _playerAttack.enabled = false;
      _circleCollider2D.enabled = false;
    }

    private void Reload()
    {
      CurrentLives = _startLives;
    }
  }
}