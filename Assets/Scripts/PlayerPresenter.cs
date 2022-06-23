using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPresenter : MonoBehaviour
{
    private bool _isFinished;

    public float MouseDeltaX { get; private set; }
    private void Start()
    {
        StartCoroutine(SetDelta());
    }

    public IEnumerator SetDelta()
    {
        float delay = 0.06f;
        WaitForSeconds waitForSeconds = new WaitForSeconds(delay);

        while (_isFinished == false)
        {
            yield return waitForSeconds;
            MouseDeltaX = Mouse.current.delta.x.ReadValue();
        }
    }
}
