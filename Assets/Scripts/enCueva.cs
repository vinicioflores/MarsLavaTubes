using UnityEngine;
using System.Collections;

public class enCueva : MonoBehaviour {

	// Use this for initialization
	void Start () {
		enable ();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void enable(){
		GameObject.FindWithTag("MainCamera").GetComponent<recursosCamara>().setEnCueva();
	}

	void OnTriggerStay(Collider myCollision){
		if(myCollision.gameObject.tag == "jugador")
			enable ();
	}
}
