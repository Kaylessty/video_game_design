using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class PauseMenuToggle : MonoBehaviour
{
	private CanvasGroup canvasGroup;
	// Start is called before the first frame update
	void Start()
    {
		canvasGroup = GetComponent<CanvasGroup>();
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			if (canvasGroup.interactable)
			{
				Time.timeScale = 1f;
				canvasGroup.interactable = false;
				canvasGroup.blocksRaycasts = false;
				canvasGroup.alpha = 0f;
			}
			else
			{
				Time.timeScale = 0f;
				canvasGroup.interactable = true;
				canvasGroup.blocksRaycasts = true;
				canvasGroup.alpha = 1f;
			}
		}
	}
}
