using DG.Tweening;
using UnityEngine;

public class Rotator : ItemOperation
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        transform.DORotate(_rotation, Duration, RotateMode.Fast).SetLoops(Repeats, LoopType);
    }
}
