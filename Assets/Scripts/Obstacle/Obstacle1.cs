using Random = UnityEngine.Random;

public class Obstacle1 : Obstacle
{
    public bool OverrideStartPosition;
    public bool SetRandomPosition;
    public float InitialPositionAngle;
    
    private void Start()
    {
        if (!OverrideStartPosition) return;
        
        if (SetRandomPosition)
        {
            InitialPositionAngle = Random.Range(0f, 360.0f);
        }
        SetRadialPosition(InitialPositionAngle);
    }
}