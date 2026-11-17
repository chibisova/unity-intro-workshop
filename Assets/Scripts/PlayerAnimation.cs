using UnityEngine;

// Prepared for the workshop - you don't need to edit this.
// Plays idle / walk / sprint / jump animations based on how the character moves.
// Put it on the Player root; it drives the Animator on the model underneath.
public class PlayerAnimation : MonoBehaviour
{
    Animator animator;
    CharacterController controller;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        // The CharacterController is added during the workshop, so look for it every frame until found
        if (controller == null) controller = GetComponent<CharacterController>();

        float speed = 0f;
        bool grounded = true;
        if (controller != null && controller.enabled)
        {
            Vector3 v = controller.velocity;
            speed = new Vector3(v.x, 0f, v.z).magnitude;
            grounded = controller.isGrounded;
        }

        animator.SetFloat("Speed", speed, 0.1f, Time.deltaTime);
        animator.SetBool("Grounded", grounded);
    }
}
