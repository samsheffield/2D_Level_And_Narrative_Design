using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add DG namespace
using DG.Tweening;

// Check DOTween documentation for full set of functionality: http://dotween.demigiant.com/documentation.php

public class DoTween_Demo : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        // DoTween extends the functionality of most base classes
        spriteRenderer.DOFade(0, 1).SetDelay(2);
        transform.DOMoveX(10, 1).SetEase(Ease.InBack);
    }
    private void OnMouseDown()
    {
        // OnComplete() can be used to call a method once it finishes
        transform.DOPunchScale(new Vector2(.1f, .1f), .5f).OnComplete(ResetScale);
    }

    // DOTween is not great at resetting the transform, but we can force it to do so
    private void ResetScale()
    {
        transform.localScale = new Vector2(1, 1);
    }
    
}
