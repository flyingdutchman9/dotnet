using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreBounceNumbers : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    int number = 0;

    void Start()
    {
        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        BounceRandomly.updateCollidedStatusEvent += BounceRandomly_updateCollidedStatusEvent;
    }

    private void OnDisable()
    {
        BounceRandomly.updateCollidedStatusEvent -= BounceRandomly_updateCollidedStatusEvent;
    }

    private void BounceRandomly_updateCollidedStatusEvent(GameObject collidedGameObject)
    {
        if (gameObject.tag == collidedGameObject.tag)
        {
            textMesh.text = (++number).ToString();
        }
    }
}
