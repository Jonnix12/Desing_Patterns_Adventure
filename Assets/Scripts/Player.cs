using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static event Action<int> OnScoreCanage;
    public static event Action<int> OnTakeHit;
    public event Action OnPlayerDied;
    
    [SerializeField] private int _hp;
    private int _score;

    public int Hp => _hp;

    public int Score => _score;

    private void Awake()
    {
        _score = 0;
        OnTakeHit?.Invoke(_hp);
    }

    public void RedusHp()
    {
        _hp--;
        OnTakeHit?.Invoke(_hp);

        if (_hp <= 0)
        {
            OnPlayerDied?.Invoke(); 
            Destroy(gameObject);
        }
    }

    public void AddScore(int score)
    {
        _score += score;
        OnScoreCanage?.Invoke(_score);
    }
}