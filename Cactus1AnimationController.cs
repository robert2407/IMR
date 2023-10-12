using UnityEngine;

public class Cactus1AnimationController : MonoBehaviour
{
    public Animator cactusAnimator;
    public Transform character;
    public float detectionDistance = 0.25f;

    void Update()
    {
        CheckCharacterProximityAndChangeAnimation();
    }

    public void CheckCharacterProximityAndChangeAnimation()
    {
        if (character == null)
        {
            Debug.LogError("Character transform not assigned.");
            return;
        }

        float distance = Vector3.Distance(transform.position, character.position);

        if (distance < detectionDistance)
        {
            cactusAnimator.SetTrigger("isCloser");
            Debug.Log("Trigger set to isCloser");
        }
        else
        {
            cactusAnimator.SetTrigger("isNotCloseEnough");
            Debug.Log("Trigger set to isNotCloseEnough");
        }
    }
}
