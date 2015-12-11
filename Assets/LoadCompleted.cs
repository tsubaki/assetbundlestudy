using UnityEngine;
using System.Collections;

public class LoadCompleted : MonoBehaviour {

	public void Switch()
	{
		gameObject.SetActive(false);
		gameObject.SetActive(true);
	}
}
