﻿using System;
using System.Collections;
using System.Collections.Generic;
using SODefinitions;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    private SpriteRenderer _sprite;
    private int _maxAmmo;
    private int _currentAmmo;
    
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private WeaponSO weaponInfo;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _sprite.sprite = weaponInfo.sprite;
        _bulletPrefab = weaponInfo.bulletPrefab;
        _maxAmmo = weaponInfo.maxAmmo;
    }

    public GameObject bulletPrefab
    {
        get => _bulletPrefab;
    }

    public Transform shootPoint
    {
        get => _shootPoint;
    }

    public float bulletForce
    {
        get => weaponInfo.bulletForce;
    }

    public int currrentAmmo
    {
        get => _currentAmmo;
        set => _currentAmmo -= value;
    }

    public void reload()
    {
        _currentAmmo = _maxAmmo;
    }
}
