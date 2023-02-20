using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    [SerializeField] private Player _player;

    private static List<PickUp> _pickUps;

    public static void Register(PickUp pickUp)
    {
        _pickUps ??= new List<PickUp>();
        
        _pickUps.Add(pickUp);
    }


    private void Start()
    {
        foreach (var pickUp in _pickUps)
        {
            pickUp.OnPickUP += PickUp;
        }
    }

    private void PickUp(PickUp pickUp)
    {
        _player.AddScore(pickUp.Score);
        _pickUps.Remove(pickUp);
        Destroy(pickUp.gameObject);
    }

    private void OnDestroy()
    {
        foreach (var pickUp in _pickUps)
        {
            pickUp.OnPickUP -= PickUp;
        }
    }
}
