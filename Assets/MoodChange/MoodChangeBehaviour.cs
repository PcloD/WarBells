using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

[Serializable]
public class MoodChangeBehaviour : PlayableBehaviour
{
    public Light Light;
    public Camera Camera;
    public Color LightColor;
    public Texture2D GradientFog;
    public Color DistanceFogColor;

    public override void OnPlayableCreate (Playable playable)
    {
        
    }

}
