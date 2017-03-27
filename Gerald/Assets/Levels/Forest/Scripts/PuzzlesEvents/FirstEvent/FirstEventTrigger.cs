using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FirstEventTrigger : MonoBehaviour 
{
	public Text FirstEventIntroText;
	public float timer = 5f;
	bool startTimer = false;

	void FixedUpdate()
	{
		if (startTimer == true)
		{
		timer -= Time.deltaTime;
		}

		if (timer <= 0)
		{
			Destroy(FirstEventIntroText);
			timer = 0;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			FirstEventIntroText.text = "What a strange colour rock......";
			startTimer = true;
		}
	}
}
