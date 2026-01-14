using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinPlayer : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    [SerializeField]private GameObject _coinPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate( _coinPrefab, new Vector3(transform.position.x + 15f, transform.position.y, transform.position.z), Quaternion.identity);
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector2.up * 7f, ForceMode2D.Impulse);
        }
    }
}
