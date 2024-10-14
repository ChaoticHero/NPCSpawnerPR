using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterActive : MonoBehaviour
{
    public GameObject[] Charactermodels;
    public Text Characternames;
    public Text Infotext;
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
        Charactermodels[4].SetActive(false);
        Characternames.text = "LumberJack";
        Infotext.text = "LumberJack is about 7 foot tall " +
            "and is a ceo of lumberco";
    }
    public void Capsule()
    {
        Charactermodels[1].SetActive(true);
        Charactermodels[0].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(false);
        Charactermodels[4].SetActive(false);
        Characternames.text = "Martial Artist";
        Infotext.text = "A young Child with a dream to become the " +
            "strongest fighter to ever live";
    }

    public void cilender()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(true);
        Charactermodels[3].SetActive(false);
        Charactermodels[4].SetActive(false);
        Characternames.text = "ShopOwner";
        Infotext.text = "A greedy man that only cares about the 100 " +
            "million dollars that the winner wins at the end of this tournament";

    }
    public void plane()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(true);
        Charactermodels[4].SetActive(false);
        Characternames.text = "Soldier";
        Infotext.text = "He is just a crazy soldier, that just it";
    }
    public void Champion()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(false);
        Charactermodels[4].SetActive(true);
        Characternames.text = "Grand Champion";
        Infotext.text = "This is the Grand Champion, at a young age " +
            "of 19 he defeated the previos champion and is able to " +
            "keep his title for 30 years";
    }
}
