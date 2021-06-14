using UnityEngine;

public class RadialRotationController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 0.6f;

    public bool RotationEnabled = true;

    private void Update()
    {
        if (RotationEnabled)
        {
            ConstantRotation();
        }
    }

    private void ConstantRotation()
    {
        float axis = Input.GetAxis("Horizontal");
        if (axis != 0)
        {
            transform.Rotate(new Vector3(0f,0f,-axis * _rotationSpeed));
        }
    }
}
