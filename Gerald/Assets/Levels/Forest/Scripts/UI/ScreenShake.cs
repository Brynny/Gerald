using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour 
{
	public bool shaking = false;
	float _ShakeDecay;
	float _ShakeIntensity;
	Vector3 _OriginalPos;
	Quaternion _OriginalRot;

	void Awake()
	{

	}
		
	

	void FixedUpdate () 
	{
		Shake ();
	}

	void Shake()
	{
		if (_ShakeIntensity > 0) {
			transform.position = _OriginalPos + Random.insideUnitSphere * _ShakeIntensity;
			transform.rotation = new Quaternion (_OriginalRot.x + Random.Range (_ShakeIntensity, _ShakeIntensity) * .2f,
				_OriginalRot.y + Random.Range (-_ShakeIntensity, _ShakeIntensity) * .2f,
				_OriginalRot.z + Random.Range (-_ShakeIntensity, _ShakeIntensity) * .2f,
				_OriginalRot.w + Random.Range (-_ShakeIntensity, _ShakeIntensity) * .2f);
			
			_ShakeIntensity -= _ShakeDecay;
		} 

		else if (shaking)
			shaking = false;
	}

	public void DoShake()
	{
		_OriginalPos = transform.position;
		_OriginalRot = transform.rotation;

		_ShakeIntensity = 0.3f;
		_ShakeDecay = 0.02f;
		shaking = true;
	}
}
