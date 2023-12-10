using UnityEngine;

public class AudioController : MonoBehaviour
{
    // 音频剪辑
    public AudioClip myAudioClip;

    // AudioSource 组件
    private AudioSource myAudioSource;

    void Start()
    {
        // 获取或添加 AudioSource 组件
        myAudioSource = GetComponent<AudioSource>();
        if (myAudioSource == null)
        {
            myAudioSource = gameObject.AddComponent<AudioSource>();
        }

        // 设置音频剪辑
        myAudioSource.clip = myAudioClip;

        // 如果你希望在 Prefab 初始化时自动播放，可以取消下一行的注释
        // myAudioSource.Play();
    }

    // 在事件中调用此方法来播放音频
    public void PlayAudio()
    {
        if (myAudioSource != null && myAudioClip != null)
        {
            // 取消下一行的注释以播放音频
            // myAudioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource or AudioClip not set.");
        }
    }
}
