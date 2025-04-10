using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class bulletcount : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerInput.OnShoot.AddListener(CountBullets);
    }

    private void CountBullets()
    {
        print("er is geschoten");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
