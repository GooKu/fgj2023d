using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CardDatabase : MonoBehaviour
{
   


    // �bAwake��k����l�ƥd����Ʈw
    private void Awake()
    {
        InitializeCardDatabase(); // �եΪ�l�Ƥ�k
    }

    // ��l�ƥd����Ʈw����k�A�K�[�w�]�d��
    // ��l�ƥd����Ʈw����k�A�K�[�w�]�d��
    public void InitializeCardDatabase()
    {
        cards.Add(new Card(1, "Card1"));
        cards.Add(new Card(2, "Card2"));
        cards.Add(new Card(3, "Card3"));
        cards.Add(new Card(4, "Card4"));
        cards.Add(new Card(5, "Card5"));
        cards.Add(new Card(6, "Card6"));
        cards.Add(new Card(7, "Card7"));
        cards.Add(new Card(8, "Card8"));
        cards.Add(new Card(9, "Card9"));
        cards.Add(new Card(10, "Card10"));
    }
    public List<Card> cards = new();

    internal List<Card> GetRandomCards(int v)
    {
        throw new NotImplementedException();
    }
}
