using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSizeBoxCollider2D : MonoBehaviour
{
    void Start()
    {
        BoxCollider2D boxCollider_ =
        gameObject.GetComponentMust<BoxCollider2D>();

        boxCollider_.size = gameObject.GetComponentMust<RectTransform>().sizeDelta;
    }

}
