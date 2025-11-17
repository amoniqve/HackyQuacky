using UnityEngine;

public class TestAudio : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (AudioManager.Instance != null)
                AudioManager.Instance.PlayPowerupSound();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (AudioManager.Instance != null)
                AudioManager.Instance.PlayPowerdownSound();
        }
    }
}
