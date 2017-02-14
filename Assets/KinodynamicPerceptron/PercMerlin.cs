using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PercMerlin : MonoBehaviour {

	protected Intent intent;

	public bool BeliefOf(Intent i){

	int oldValue = (int)intent.priority;
	int newValue = (int)i.priority;
	if(newValue <= oldValue)
		return false;
	return true;

}


public void Percieve(Intent i){

	StopCoroutine(Investigate());
	intent = i;
	StartCoroutine(Investigate());

}

public virtual IEnumerator Investigate(){
	
yield break;

}


public virtual IEnumerator Lead(){

	yield break;
}


}
