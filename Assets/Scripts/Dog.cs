using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog:Animals
{
	[SerializeField]
	private string animalType = "Dog";

	Rigidbody _rb;

	public override void Start()
		{
		base.Start();
		_rb = GetComponent<Rigidbody>();
		
		}

	// Update is called once per frame
	public override void Update()
		{
		if (Input.GetKeyDown(KeyCode.Space))
			{
			Jump(_rb, jumpForce);
			}
		}


}
