using System;
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _shotFrom;
    [SerializeField] private GameObject _proJectile;
    private WaitForSeconds _waitForSeconds;

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(2);

        StartCoroutine(Shot());
    }

    void Update()
    {
        transform.LookAt(_player);    
    }

    private IEnumerator Shot()
    {
        while (true)
        {
            yield return _waitForSeconds;
            Instantiate(_proJectile, _shotFrom.position,transform.rotation);
        }
    }
}