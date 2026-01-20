using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameController _gameController;
    // Start is called before the first frame update
    void Start()
    {
        _gameController = GameObject.FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 11f * Time.deltaTime);
        //destroy coins after they go off screen
        if(transform.position.x < -3f)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _gameController.AddScore();
            Destroy(gameObject);
        }
    }
}
