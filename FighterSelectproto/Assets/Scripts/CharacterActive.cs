using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterActive : MonoBehaviour
{
    public GameObject[] Charactermodels;
    public Text Characternames;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void timber()
    {
        Charactermodels[0].SetActive(true);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(false);
        Characternames.text = "LumberJack";
    }
    public void Capsule()
    {
        Charactermodels[1].SetActive(true);
        Charactermodels[0].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(false);
        Characternames.text = "Martial Artist";
    }

    public void cilender()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(true);
        Charactermodels[3].SetActive(false);
        Characternames.text = "ShopOwner";

    }
    public void plane()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(true);
        Characternames.text = "Soldier";
    }
}
