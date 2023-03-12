using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is an optional class to animate the slider, feel free to write your own.
/// </summary>
public class SliderAnimator : MonoBehaviour 
{
	[SerializeField] private float _speed = 1f;
	[SerializeField] private float _maxX = 1f;
	[SerializeField] private float _minX =0f;
	[SerializeField] private Morpher _morpher;
	
	private void Update () {
		_morpher.SetSlider(Mathf.Lerp(_minX, _maxX, Mathf.PingPong(Time.time * _speed, 1f)));
	}
}
