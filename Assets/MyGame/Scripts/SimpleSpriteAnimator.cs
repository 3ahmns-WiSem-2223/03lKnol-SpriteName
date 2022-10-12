using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpriteAnimator : MonoBehaviour
{
    [SerializeField] private Sprite[] idel;

    private void Start()
    {
        Debug.Log("AnzahlElemente: " + idel.Length);
    }
}
