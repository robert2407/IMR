using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator cactusAnimator;
    public Transform character;
    public float detectionDistance = 0.25f;

    void Update()
    {
        CheckCharacterProximityAndChangeAnimation();
    }

    void CheckCharacterProximityAndChangeAnimation()
    {
        float distance = Vector3.Distance(transform.position, character.position);

        if (distance < detectionDistance)
        {
            cactusAnimator.SetTrigger("isCloser");
        }
        else cactusAnimator.SetTrigger("isNotCloseEnough");
    }
}
