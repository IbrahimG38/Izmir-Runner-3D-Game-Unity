using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Collections_Counter_Script : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI total_collections_text;
    [SerializeField] TextMeshProUGUI current_score_text;

    [SerializeField] Transform Player;

    void Start()
    {
        // Skoru sýfýrla
        PlayerPrefs.SetInt("total_collections", 0);
        PlayerPrefs.Save(); // Deðiþiklikleri kaydet
    }

    void Update()
    {
        // Skoru ekranda göster
        total_collections_text.text = PlayerPrefs.GetInt("total_collections", 0).ToString("00");
        current_score_text.text = Player.transform.position.z.ToString("00.0") + "m";

        float currentScore = Player.transform.position.z;

        if (currentScore >= PlayerPrefs.GetFloat("high_score", 0f))
        {
            PlayerPrefs.SetFloat("high_score", currentScore);
            PlayerPrefs.Save(); // Yeni yüksek skoru kaydet
        }
    }
}

