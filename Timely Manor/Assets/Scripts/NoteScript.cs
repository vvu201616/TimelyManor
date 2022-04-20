using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoteScript : MonoBehaviour
{
	public Image noteImg;
	public TextMeshProUGUI noteText;
	public Button textButton;

    public void toggleNoteImg()
	{
		if (noteImg.isActiveAndEnabled == false)
		{
			noteImg.gameObject.SetActive(true);
			textButton.gameObject.SetActive(true);
		}
		else
		{
			noteImg.gameObject.SetActive(false);
			textButton.gameObject.SetActive(false);
			noteText.gameObject.SetActive(false);
		}
	}

	public void toggleNoteText()
	{

		if (noteText.isActiveAndEnabled == false)
			noteText.gameObject.SetActive(true);
		else
			noteText.gameObject.SetActive(false);
	}
}
