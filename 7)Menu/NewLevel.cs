using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour
{
	public string NameLevel = "Level 1";
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			if(NameLevel == "Level 1") PlayerPrefs.SetInt("Count", 0);
            SceneManager.LoadScene(NameLevel);
		}
	}
}