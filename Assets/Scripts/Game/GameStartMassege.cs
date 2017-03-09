using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStartMassege : MonoBehaviour {

	public void MassegeClear()
    {
        GetComponent<Text>().text = "";
	}
}
