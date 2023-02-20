using System;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public event Action<PickUp> OnPickUP;

    [SerializeField] private int _score = 1;

    public int Score => _score;

    private void Awake()
    {
        PickUpManager.Register(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            OnPickUP?.Invoke(this);
    }

}