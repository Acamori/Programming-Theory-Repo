using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals:MonoBehaviour
	{

	[SerializeField]
	public float jumpForce;

	[SerializeField]
	string _petNickName;
	public string petNickName
		{
		get { return _petNickName; }
		set
			{

			if (value.Length >16)
				{
				Debug.Log("Nick name is too long");
				}
			else
				{
				_petNickName = value;
				}
			}
		}
	public virtual void Start()
		{ 
		jumpForce = 100;
		}
	public virtual void Update()
		{ }

	public virtual void Jump(Rigidbody _rb, float _jumpforce)
		{
		_rb.AddRelativeForce(Vector3.up * _jumpforce, ForceMode.Impulse);
		}


	}
