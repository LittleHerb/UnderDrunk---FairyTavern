﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrRig : MonoBehaviour
{
    public static VrRig instance = null;

    public Transform Headset { get { return headset; } }
    public VrController LeftController { get { return leftController; } }
    public VrController RightController { get { return rightController; } }

    [SerializeField]
    private Transform headset;
    [SerializeField]
    private VrController leftController;
    [SerializeField]
    private VrController rightController;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }

        leftController.Setup();
        rightController.Setup();

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
