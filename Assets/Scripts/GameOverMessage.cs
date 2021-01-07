using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMessage : MonoBehaviour, IEndGameObserver
{
	public void Notify()
	{
		Debug.Log("Game Over");
	}
}