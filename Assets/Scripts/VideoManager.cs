using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer m_VideoPlayer;
    public VideoClip[] videoClips = new VideoClip[4];
    public GameObject[] canvasGameObject = new GameObject[4];
    public GameObject fadeImage;
    private Animator fadeImageAnimator;

    private void Awake()
    {
        fadeImageAnimator = fadeImage.GetComponent<Animator>();
    }

    private void Update()
    {
        if (!fadeImageAnimator.GetCurrentAnimatorStateInfo(0).IsName("Empty"))
        {
            fadeImageAnimator.SetBool("Animate", false);
        }
    }

    private void setUnactiveCanvasGO()
    {
        foreach (GameObject m_gameObject in canvasGameObject)
        {
            m_gameObject.SetActive(false);
        }
    }

    private void StartVideo(int index)
    {
        m_VideoPlayer.clip = videoClips[index];
        setUnactiveCanvasGO();
        canvasGameObject[index].SetActive(true);

        if (fadeImageAnimator.GetCurrentAnimatorStateInfo(0).IsName("Empty"))
        {
            fadeImageAnimator.SetBool("Animate", true);
        }
    }

    public void LivingRoomVideo()
    {
        int index = 0;

        StartVideo(index);
    }

    public void CantinaVideo()
    {
        int index = 1;

        StartVideo(index);
    }

    public void CubeVideo()
    {
        int index = 2;

        StartVideo(index);
    }

    public void MezzanineVideo()
    {
        int index = 3;

        StartVideo(index);
    }
}
