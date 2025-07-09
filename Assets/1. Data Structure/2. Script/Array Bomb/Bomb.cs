using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private Rigidbody boomRb;
    public float boomTime = 4f;
    public float bombRange = 10f;
    public LayerMask layerMask;

    void Awake()
    {
        boomRb = GetComponent<Rigidbody>();
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(boomTime);

        BombForce();
    }

    private void BombForce()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, bombRange, layerMask);

        foreach (var collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            
            rb.AddExplosionForce(500f, transform.position,bombRange,1f);
        }
        Destroy(gameObject);
    }
}
