using UnityEngine;
using System.Collections;

public class moverCuriosity : MonoBehaviour {
	int[] muestra=new int[7];
	// Use this for initialization
	void Start () {
		for (int i=0; i<muestra.Length; i++) {
			muestra[i]=0;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void recogeMaterial(int lugar){
		muestra [lugar]++;
	}
}
