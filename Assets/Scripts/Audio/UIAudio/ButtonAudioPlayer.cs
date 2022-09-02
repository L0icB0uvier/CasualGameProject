using Audio.SFXPlayers;
using UnityEngine;

namespace Audio.UIAudio
{
    public class ButtonAudioPlayer : SFXAudioPlayer
    {
        [SerializeField] private AudioCueSO buttonSelectedAudioCue;
        [SerializeField] private AudioCueSO buttonClickedAudioCue;

        public void PlayButtonSelectedAudio() => PlayAudio(buttonSelectedAudioCue);
        public void PlayButtonClickedAudio() => PlayAudio(buttonClickedAudioCue);
    }
}
