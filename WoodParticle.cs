using UnityEngine;

public class WoodParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem _woodFx;

    private ParticleSystem.EmissionModule _emission;

    private void Start()
    {
        _emission = _woodFx.emission;
    }

    public void Enable(Collision collision)
    {
        _emission.enabled = true;
        _woodFx.transform.position = collision.contacts[0].point;
    }

    public void Disable()
    {
        _emission.enabled = false;
    }
}
