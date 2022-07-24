using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Transform playerTransform;
    public GameObject missilePrefab;
    public GameObject missilePosition;
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = transform;
        playerTransform.position = new Vector3(0f, -4f, 0f); 
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("enemy"))
        {
            
            Score.instance.lifeReduce();
            if (Score.instance.playerLife < 1)
            {
                
                Destroy(this.gameObject);
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {

        if(playerTransform.position.x>14)
        {
            playerTransform.position = new Vector3(-11f, playerTransform.position.y, playerTransform.position.z);
        }
        else if(playerTransform.position.x < -14)
        {
            playerTransform.position = new Vector3(11f, playerTransform.position.y, playerTransform.position.z);

        }

        playerTransform.Translate(Vector3.left* playerSpeed*Input.GetAxis("Horizontal")*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab, missilePosition.transform.position, Quaternion.Euler(new Vector3(0f,180f,0f)));
        }
        
    }
}
