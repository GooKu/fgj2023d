using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDrawButton : MonoBehaviour
{
    public Button drawButton; // �z�LInspector�]�m�A�즲Button�����o��
    public CardDisplay cardDisplay; // �z�LInspector�]�m�A�즲CardDisplay�}���Ҧb�����o��

    private void Start()
    {
        drawButton.onClick.AddListener(DrawCard);
        cardDisplay.OnDrawCards += DrawCard;
        cardDisplay.OnUpdateUI += UpdateUI;
    }

    private void DrawCard()
    {
        // Your code here
    }

    private void UpdateUI()
    {
        // Your code here
    }
}
