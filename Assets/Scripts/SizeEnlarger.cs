using DG.Tweening;
using UnityEngine;

public class SizeEnlarger : ItemOperation
{
    [SerializeField] private float _targetScale;

    private void Start()
    {
        transform.DOScale(_targetScale, Duration).SetLoops(Repeats, LoopType);
    }
}
