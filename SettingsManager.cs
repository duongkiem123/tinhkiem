using UnityEngine;
using UnityEngine.Audio;

namespace GameCore
{
    public class SettingsManager : MonoBehaviour
    {
        public AudioMixer audioMixer;

        public void SetVolume(float volume)
        {
            audioMixer.SetFloat("volume", volume);
        }
    }
}