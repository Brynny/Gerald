using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public static class Extentions
//{
//	public static void SetTransparency(this UnityEngine.UI.Image _image, float _transparency)
//	{
//		if (_image != null)
//		{
//			UnityEngine.Color _alpha = _image.color;
//			_alpha.a = _transparency;
//			_image.color = _alpha;
//		}
//	}
//}

public class ButtonTransparancy : MonoBehaviour
{
	public Button menuButton;

	void Start()
	{
		menuButton.image.color = new Color (0f, 0f, 0f, .1f);
	}
}