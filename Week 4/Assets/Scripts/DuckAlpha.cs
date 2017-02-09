using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DuckAlpha : MonoBehaviour
{
    private Transform player;
    private SpriteRenderer spriteRenderer;

    [Range(0f, 1f)]
    public float alpha;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (player.position.y > transform.position.y)
        {
            //spriteRenderer.color = new Color(1, 1, 1, alpha);
            spriteRenderer.DOFade(alpha, .5f);
        }
        else
        {
            //spriteRenderer.color = Color.white;
            spriteRenderer.DOFade(1, .5f);
        }
    }
}
