using UnityEngine;
using DG.Tweening;

public class Mover : ItemOperation
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        transform.DOMove(_position, Duration).SetLoops(Repeats, LoopType);
    }
}
