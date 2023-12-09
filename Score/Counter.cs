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
}
