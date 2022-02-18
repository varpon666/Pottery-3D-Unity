using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Wood : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer _skinned;

    public void ApplyDamage(int keyIndex,float damage)
    {
        float newWeight = _skinned.GetBlendShapeWeight(keyIndex) + damage * (100f / 2f);
        _skinned.SetBlendShapeWeight(keyIndex, newWeight);
    }
}
