using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameText : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        if (MainManagerMenu.Instance != null)
        {
            gameObject.GetComponent<Text>().text = MainManagerMenu.Instance.playerName;
        }
    }


}
