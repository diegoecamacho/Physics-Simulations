using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI Components")]
    public SliderController slider;

    [SerializeField] private GameObject gateWay;

    [SerializeField] private int NumberOfObjectives;
    public int objectivesDone = 0;

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {
        
        if (objectivesDone >= NumberOfObjectives)
        {
            Destroy(gateWay, 0.5f);
        }
    }
}
