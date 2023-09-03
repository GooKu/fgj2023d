using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumberGenerator : MonoBehaviour
{
    public Text[] textElements; // �Ω���ܶüƪ�Text�����}�C
    private List<int> availableNumbers; // �i�Ϊ��Ʀr�C��
    private System.Random random = new System.Random();

    private void Start()
    {
        // ��l�ƥi�Ϊ��Ʀr�C��
        availableNumbers = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            availableNumbers.Add(i);
        }

        // �ͦ������ƪ��üƨä��t��Text����
        for (int i = 0; i < textElements.Length; i++)
        {
            int randomIndex = random.Next(0, availableNumbers.Count);
            int randomNumber = availableNumbers[randomIndex];
            textElements[i].text = randomNumber.ToString();

            // �q�i�Ϊ��Ʀr�C���R���w�ϥΪ��Ʀr
            availableNumbers.RemoveAt(randomIndex);
        }
    }
}
