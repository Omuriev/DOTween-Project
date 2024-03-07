using UnityEngine;
using DG.Tweening;

public class ColorChanger : ItemOperation
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;

    private void Start()
    {
        _material.DOColor(_color, Duration).SetLoops(Repeats, LoopType);
    }
}
