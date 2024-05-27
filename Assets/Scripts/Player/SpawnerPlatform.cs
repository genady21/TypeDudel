using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerPlatform : MonoBehaviour
{
    [SerializeField] private GameObject _platformPrefab;


    private void Start()
    {
        Vector3 SpawnerPos = new Vector3();
        for (int i = 0; i < 10; i++)
        {
            SpawnerPos.x = Random.Range(-1.7f, 1.7f);
            SpawnerPos.y += Random.Range(2f, 3f);
            Instantiate(_platformPrefab,SpawnerPos,Quaternion.identity);
        }

    }
}
