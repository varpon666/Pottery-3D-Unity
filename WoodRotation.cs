using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class WoodRotation : MonoBehaviour
{
    private Transform _wood;

    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _duration;

    private void Start()
    {
        _wood = GetComponent<Transform>();

        Rotate();
    }

    private void Rotate()
    {
        _wood
            .DOLocalRotate(_direction, _duration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart)
            .SetEase(Ease.Linear);
    }
}
