using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public static Score instance;
    public float scoreValue;
    [SerializeField] TextMeshProUGUI scoreText;
    private string _scoreText;
    public float playerLife = 3;
    [SerializeField] private List<GameObject> lifeRepresent = new List<GameObject>();

    private float score;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        _scoreText = "Score: ";
        scoreText.text = _scoreText + score.ToString();
    }
    public void AddScore()
    {
        score += scoreValue;
        scoreText.text = _scoreText + score.ToString();
        
    }
    public void lifeReduce()
    {
     playerLife--;

        for (int i=0;i< lifeRepresent.Count; i++)
        {
            lifeRepresent[i].SetActive(false);
        }
        LifeUpdate();
    }
    private void LifeUpdate()
    {
        for (int i = 0; i < playerLife; i++)
        {
            lifeRepresent[i].SetActive(true);
        }
    }
}
