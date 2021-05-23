using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text healtText;
    Player player;

    void Start()
    {
        healtText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        healtText.text = player.GetHealth().ToString();
    }
}
