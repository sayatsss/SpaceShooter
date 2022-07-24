using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform enemyTransform;
    public float minSpeed = 5.0f;
    public float maxSpeed = 20.0f;
    float x, y, z;
    public float currentSpeed;
    private Vector3 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        y = -4f;
        z = 16f;
        x = Random.Range(-14, 14);
        enemyTransform = transform;
        enemyTransform.position = new Vector3(x, y, z);
        currentSpeed = Random.Range(minSpeed, maxSpeed);
        movement = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
       x = Random.Range(-14, 14);
        
        enemyTransform.Translate(movement*currentSpeed*Time.deltaTime);
        if(enemyTransform.position.z<-10)
        {
            enemyTransform.position = new Vector3(x, y, z);
            currentSpeed = Random.Range(minSpeed, maxSpeed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("missile"))
        {
            Score.instance.AddScore();
            enemyTransform.position = new Vector3(x, y, z);
        }
    }
}
