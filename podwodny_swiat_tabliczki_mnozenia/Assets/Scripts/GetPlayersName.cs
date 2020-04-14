using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayersName : MonoBehaviour
{
    private string playerName;
    public GameObject inputField; 

    public void Button_Click()
    {
        playerName = inputField.GetComponent<Text>().text;
        Debug.Log( "Witaj " + playerName + " w podwodnym świecie tabliczki mnożenia!");
    }
}