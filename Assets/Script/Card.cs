using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card : MonoBehaviour
{
    public int ID;
    public string CardString;

    // �L�Ѽƪ��غc��ơ]�i��^
    public Card()
    {
        ID = 0;
        CardString = "";
    }

    // ���Ѽƪ��غc��ơA�Ω��l�ƥd��
    public Card(int id, string cardString)
    {
        ID = id;
        CardString = cardString;
    }
}
