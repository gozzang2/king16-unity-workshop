using UnityEngine;

namespace Team4
{
    public class BGMController : MonoBehaviour
    {
        private AudioSource audioSource;

        void Awake()
        {
            // 이 스크립트가 붙은 오브젝트의 AudioSource를 가져옵니다.
            audioSource = GetComponent<AudioSource>();
        }

        // 음악 재생/정지 제어 함수 (필요할 때 호출)
        public void SetMusic(bool play)
        {
            if (play && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else
            {
                audioSource.Stop();
            }
        }
    }
}