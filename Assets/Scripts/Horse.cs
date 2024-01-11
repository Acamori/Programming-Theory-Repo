using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse:Animals
{
	[SerializeField]
	private string animalType = "Horse";

	Rigidbody _rb;

	public override void Start()
		{
		base.Start();
		_rb = GetComponent<Rigidbody>();
		
		}

	public override void Update()
		{
		if (Input.GetKeyDown(KeyCode.Space))
			{
			Jump(_rb, jumpForce);
			}
		}

	public override void Jump(Rigidbody _rb, float _jumpforce)
		{
		_rb.AddRelativeForce(Vector3.up * (_jumpforce*1.5f), ForceMode.Impulse);
		}
	
}
