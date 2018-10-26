using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed;

    private float _horizontalAxis;
    private float _forwardAxis;

    private bool colliding;

    private Rigidbody _rigidBody = null;

    [SerializeField]private SliderController sliderController;

    private float sliderValue;


    // Use this for initialization
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
        _forwardAxis = Input.GetAxis("Vertical");

        if (colliding && Input.GetButtonDown("Activate"))
        {
            var result = sliderController.ActivateSlider();
            if (result)
            {
                sliderValue = sliderController.ReturnSliderValue();
            }
        }

        if (_horizontalAxis != 0 || _forwardAxis != 0)
        {
            _rigidBody.AddForce(new Vector3(_horizontalAxis, 0, _forwardAxis) * PlayerSpeed);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Floor")) return;

        colliding = true;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor")) return;

        colliding = false;

    }
}