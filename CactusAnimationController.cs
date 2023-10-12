using UnityEngine;

public class CactusAnimationController : MonoBehaviour
{
    public Animator sharedAnimator;
    public Transform character1;
    public Transform character2;
    public float detectionDistance = 0.25f;

    void Update()
    {
        CheckCharacterProximityAndChangeAnimation();
    }

    void CheckCharacterProximityAndChangeAnimation()
    {
        float distance1 = Vector3.Distance(transform.position, character1.position);
        float distance2 = Vector3.Distance(transform.position, character2.position);

        if (distance1 < detectionDistance || distance2 < detectionDistance)
        {
            sharedAnimator.SetTrigger("isCloser");
        }
        else
        {
            sharedAnimator.SetTrigger("isNotCloseEnough");
        }
    }
}
