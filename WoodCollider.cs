using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCollider : MonoBehaviour
{
    public int Index => transform.GetSiblingIndex();

    private BoxCollider _boxCollider;

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
    }

    public void ApplyDamage(float damage)
    {
        if (_boxCollider.size.y - damage > 0.0f)
            _boxCollider.size = new Vector3(_boxCollider.size.x, _boxCollider.size.y - damage, _boxCollider.size.z);
        else
            Destroy(this);
    }
}
