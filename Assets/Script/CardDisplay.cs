using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using System;

public class CardDisplay : MonoBehaviour
{
    public Text card1IDText;
    public Text card1DepictionText;

    public Text card2IDText;
    public Text card2DepictionText;

    public Text card3IDText;
    public Text card3DepictionText;

    private CardDatabase cardDatabase;
    private List<Card> drawnCards = new List<Card>();

    public Action OnDrawCards { get; internal set; }
    public Action OnUpdateUI { get; internal set; }

    private void Start()
    {
        cardDatabase = GetComponent<CardDatabase>();
        DrawRandomCards();
        UpdateUI();
    }

    private void DrawRandomCards()
    {
        // �q�d����Ʈw���H������T�i�����Ъ��d��
        drawnCards = cardDatabase.GetRandomCards(3);
    }

    private void UpdateUI()
    {
        if (drawnCards.Count >= 3)
        {
            // �]�m�Ĥ@�i�d���H��
            card1IDText.text = "ID: " + drawnCards[0].ID.ToString();
            card1DepictionText.text = "Depiction: " + drawnCards[0].CardString;

            // �]�m�ĤG�i�d���H��
            card2IDText.text = "ID: " + drawnCards[1].ID.ToString();
            card2DepictionText.text = "Depiction: " + drawnCards[1].CardString;

            // �]�m�ĤT�i�d���H��
            card3IDText.text = "ID: " + drawnCards[2].ID.ToString();
            card3DepictionText.text = "Depiction: " + drawnCards[2].CardString;
        }
        else
        {
            // �p�G�S���������d���A�z�i�H��ܤ@�ӿ��~�T���Ϊ̤�������ާ@�C
        }
    }
}
