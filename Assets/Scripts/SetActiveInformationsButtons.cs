using UnityEngine;

public class SetActiveInformationsButtons : MonoBehaviour
{
    private Animator currentAnimator;
    private bool isActive = false;

    private void Start()
    {
        currentAnimator = GetComponent<Animator>();
    }

    public void setActive()
    {
        if (isActive == false)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            isActive = true;
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            isActive = false;
        }
    }
}
