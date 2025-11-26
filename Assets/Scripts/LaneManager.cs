using UnityEngine;

public class LaneManager : MonoBehaviour
{

    [SerializeField]
    private Lane[] lanes;
    private Lane[] Lanes
    
    {
    
        get {return lanes;}
    }
    

    public Transform GetFrameInLane()
    {
        int laneIndex = Random.Range(0, lanes.Length);
        Lane selectedLane = lanes[laneIndex];
        int frameIndex = Random.Range(0, selectedLane.Frames.Count);
        return selectedLane.Frames[frameIndex];
    }


}
