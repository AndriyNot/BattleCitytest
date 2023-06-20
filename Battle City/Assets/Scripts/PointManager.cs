using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    private int _points;
    public TextMeshProUGUI Textpoints;
    

    void Start()
    {
        
    }

    private void Update()
    {
        Textpoints.text = "" + _points;
    }

    public void pointmanager()
    {
        _points += 100;
    }
}
