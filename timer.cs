using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    public delegate void TimerEnded();
    public event TimerEnded OnTimerEnd;

    private bool hasTriggered = false;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else if (!hasTriggered)
        {
            hasTriggered = true;
            timerText.text = "00:00";

            // Notify listeners
            OnTimerEnd?.Invoke();
        }
    }
}
