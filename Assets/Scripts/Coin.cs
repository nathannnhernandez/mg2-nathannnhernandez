using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float timer;
    private float timeRemaining;
    private int currentCoins;
    private float initialPositionX;
 
    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
        initialPositionX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if(timeRemaining <= 0)
        {
            Instantiate(gameObject, new Vector3(initialPositionX, transform.position.y, transform.position.z), Quaternion.identity);
            ResetTimer();
        }

        transform.Translate(Vector3.left * Time.deltaTime * 3f);
        //destroy coins after they go off screen
        if(transform.position.x < -5f)
        {
            Destroy(gameObject);
        }
    }
    void ResetTimer()
    {
        timer = Random.Range(1f, 2f);
        timeRemaining = timer;
    }
}
