using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (MainManagerMenu.Instance != null)
        {
            gameObject.GetComponent<Text>().text = "Best Score: " + MainManagerMenu.Instance.bestPlayer + " " + MainManagerMenu.Instance.scorePlayer;
        }
    }

}
