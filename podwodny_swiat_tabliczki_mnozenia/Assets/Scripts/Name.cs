using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{

    public string player_name;
    public GameObject inputField; 


    public void Button_Click()
    {
        player_name = inputField.GetComponent<Text>().text;
        Debug.Log( "Witaj " + player_name + " w podwodnym świecie tabliczki mnożenia!");
    }

}
