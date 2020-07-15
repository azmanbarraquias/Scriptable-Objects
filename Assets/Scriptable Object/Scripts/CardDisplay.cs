using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI descriptionTMP;
    public Image artwork;
    public TextMeshProUGUI manaTMP;
    public TextMeshProUGUI attackTMP;
    public TextMeshProUGUI healthTMP;

    private void Start()
    {
        this.name = card.name;
        nameTMP.text = card.name;
        descriptionTMP.text = card.description;
        artwork.sprite = card.artwork;
        manaTMP.text = card.manaCost.ToString();
        attackTMP.text = card.attack.ToString();
        healthTMP.text = card.health.ToString();
    }
}
