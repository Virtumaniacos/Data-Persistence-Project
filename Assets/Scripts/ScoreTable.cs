using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTable : MonoBehaviour
{
    void Start()
    {
        if (MainManagerMenu.Instance != null)
        {
            gameObject.GetComponent<Text>().text = "Actual Player: " + MainManagerMenu.Instance.playerNameTable + " - " + MainManagerMenu.Instance.scorePlayerTable;
        }
    }
}
