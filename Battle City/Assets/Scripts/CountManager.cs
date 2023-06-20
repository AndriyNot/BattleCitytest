using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountManager : MonoBehaviour
{
    public int Countenemy = 5;
    public TextMeshProUGUI TextCountEnemy;
    public GameObject Winpanel;

    // Update is called once per frame
    void Update()
    {
        TextCountEnemy.text = "" + Countenemy;

        if (Countenemy == 0)
        {
            Winpanel.SetActive(true);
        }
        else
        {
            Winpanel.SetActive(false);
        }
    }

    public void countDestroyEnemy()
    {
        Countenemy -= 1;
    }
}
