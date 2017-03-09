﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {

    public GameObject AdvanceRation;
    public Text AdvanceRationText;

    public void Begin()
    {
		AdvanceRationText.text = AdvanceRation.GetComponent<AdvanceRation>().GetAdvanceRation().ToString() + "%";
        SoundManager.LoadSe("Death", "_n_death_music");
        SoundManager.PlaySe("Death");
    }
}