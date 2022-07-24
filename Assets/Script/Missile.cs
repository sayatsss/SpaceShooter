using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private Transform missileTransform;
    public int projectileSpeed = 7;
    private Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        missileTransform = transform;
        movement = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
        missileTransform.Translate(movement * projectileSpeed * Time.deltaTime);
        if(missileTransform.position.z>20)
        {
            Destroy(this.gameObject);
        }
    }
}
