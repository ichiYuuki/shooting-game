using UnityEngine;
using System.Collections;

public class Explodion : MonoBehaviour {

	void OnAnimationFinish(){
		Destroy (gameObject);
	}
}
