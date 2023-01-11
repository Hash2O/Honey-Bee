using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeManager : MonoBehaviour
{
    public Rigidbody beeRigidbody;
    [SerializeField] private float _force;
    [SerializeField] private float _forceImpulse;

    // Start is called before the first frame update
    void Start()
    {
        beeRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        beeRigidbody.AddForce(Vector3.up * _force / 2);

        if (transform.position.y < 0.5f)
        {
            beeRigidbody.AddForce(Vector3.up * _forceImpulse, ForceMode.Impulse);
        }
    }

    public void antiGravity()
    {
        //9.81 = AddForce de catégorie Vector3.down, du moteur physique de Unity pour la gravité, vers le bas donc
        beeRigidbody.AddForce(Vector3.up * _forceImpulse, ForceMode.Impulse);
    }
}
