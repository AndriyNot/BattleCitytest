using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifemanager : MonoBehaviour
{
    public int Index;
    public Image[] ImageLife;
    public GameObject LossPanel;

    void Update()
    {
        lifeManager();
    }

    public void lifeManager()
    {
        if (Index == 1)
        {
            Destroy(ImageLife[0]);
        }
        if (Index == 2)
        {
            Destroy(ImageLife[1]);
        }
        if (Index == 3)
        {
            Destroy(ImageLife[2]);
            LossPanel.SetActive(true);
        }
        if (Index != 3)
        {
            LossPanel.SetActive(false);
        }
       

    }
}
