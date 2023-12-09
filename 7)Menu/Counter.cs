using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int Count = 0;
	public GameObject ScoreCounter;

	private void Start()
	{
		if (PlayerPrefs.HasKey("Count"))
		{
			Count = PlayerPrefs.GetInt("Count");
			ScoreCounter.GetComponent<Text>().text = Count.ToString();
		}
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Cherry")
		{
			Count += 50;
			ScoreCounter.GetComponent<Text>().text = Count.ToString();
			PlayerPrefs.SetInt("Count", Count);
		}
		if (collision.gameObject.tag == "Gem")
		{
			Count += 1000;
			ScoreCounter.GetComponent<Text>().text = Count.ToString();
			PlayerPrefs.SetInt("Count", Count);
		}
	}
	// 1t variant (By awake)
    private void Awake()
    {
        // making score zero
        Count = 0;

        // check saving value in PlayerPrefs
        if (PlayerPrefs.HasKey("Count"))
        {
            Count = PlayerPrefs.GetInt("Count");
        }

        // Sets score value in text ScoreCounter
        ScoreCounter.GetComponent<Text>().text = Count.ToString();
    }
	// 2d variant (by ending game)
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Count", 0);
        PlayerPrefs.Save();
    }
}
