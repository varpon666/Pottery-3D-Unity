using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private Wood _wood;
    [SerializeField] private WoodParticle _woodParticle;

    [SerializeField] private float _damage;

    private void OnCollisionStay(Collision collision)
    {
        WoodCollider collider = collision.collider.GetComponent<WoodCollider>();

        if(collider != null)
        {
            _woodParticle.Enable(collision);

            collider.ApplyDamage(_damage);
            _wood.ApplyDamage(collider.Index, _damage);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        _woodParticle.Disable();
    }
}
