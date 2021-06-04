using UnityEngine;

public class RadialRotationController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    public bool RotationEnabled;

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
