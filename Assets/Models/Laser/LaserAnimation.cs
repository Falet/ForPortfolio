using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class LaserAnimation : MonoBehaviour
{
    public Color Min;
    public Color Max;
    public float Power;
    public float alpha;
    public int AnimationDuration = 1;
    private MeshRenderer _meshRenderer;
    private Material _material;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _material = _meshRenderer.material;
    }

    private void Update()
    {
        var color = Color.Lerp(Min, Max, Mathf.Pow(Random.value, Power));
        color.a = alpha;
        _meshRenderer.material.color = color;
    }
    private Tween _tween;
    public void SetLaser(bool on)
    {
        var toAlpha = on ? 1 : 0;
        DOTween.To(()=> alpha, x=> alpha = x, toAlpha, AnimationDuration)
            .OnComplete(()=>AnimationComplete(on));
    }

    private void AnimationComplete(bool on)
    {
        //gameObject.SetActive(on);
    }
}
