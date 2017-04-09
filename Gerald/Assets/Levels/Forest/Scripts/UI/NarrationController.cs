using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarrationController : MonoBehaviour
{
	public Text introOneText, introTwoText, introThreeText;

	float introductionTimer;

	void FixedUpdate()
	{
		introductionTimer += Time.deltaTime;
		Introduction ();
	}

	public void Introduction()
	{
		Debug.Log (introductionTimer);

		if (introductionTimer >= 0f)
			introOneText.text = "Welcome Gerald, to the darkened Enchanted Forest!";
		if (introductionTimer >= 4f)
			Destroy (introOneText);

		if (introductionTimer >= 4.5f)
			introTwoText.text = "A place filled with a terror that only darkness can controll.";
		if (introductionTimer >= 8.5f)
			Destroy (introTwoText);

		if (introductionTimer >= 9f)
			introThreeText.text = "Find the light within, and you might live to see another day.... or Nightmare!!";
		if (introductionTimer >= 13f)
			Destroy (introThreeText);
	}
}
