﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	Spaceship spaceship;

	IEnumerator Start () {
		spaceship = GetComponent<Spaceship>();

		spaceship.Move (transform.up * -1);

		if(spaceship.canShot == false){
			yield break;
		}
		while(true){
			for (int i = 0; i  < transform.childCount; i++){
				Transform shotPoshition = transform.GetChild (i);
				spaceship.Shot (shotPoshition);
			}
			yield return new WaitForSeconds(spaceship.shotDelay);
		}
	}
	

}