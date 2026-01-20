using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private float _minSpawnTime = 1f;
    [SerializeField] private float _maxSpawnTime = 2f;
    [SerializeField] private TMP_Text _scoreText;
    private float _spawnTimer;
    private float _timeRemaining;
    private int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_coinPrefab, new Vector3(15f, 12.91f, 0f), Quaternion.identity);
        ResetSpawnTimer();
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        if(_timeRemaining > 0f)
        {
            _timeRemaining -= Time.deltaTime;
        }
        if(_timeRemaining <= 0)
        {
            Instantiate(_coinPrefab, new Vector3(15f, 12.91f, 0f), Quaternion.identity);
            ResetSpawnTimer();
        }
    }
    void ResetSpawnTimer()
    {
        _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        _timeRemaining = _spawnTimer;
    }

    public void AddScore()
    {
        _score += 1;
        UpdateScoreText();
        Debug.Log("Score: " + _score);
    }
    void UpdateScoreText()
    {
        _scoreText.text = "Score: " + _score;
    }
}
