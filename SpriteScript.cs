using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class SpriteScript : StoryboardObjectGenerator
    {

        [Configurable]
        public string SpritePath = "";

        /* start opacity */

        [Configurable]
        public int StartFadeA = 0; // startTime

        [Configurable]
        public int StartFadeB = 500; // endTime

        [Configurable]
        public float StartFadeOA = 0; // startOpacity

        [Configurable]
        public float StartFadeOB = 1; // endOpacity

        /* end opacity */

        [Configurable]
        public int EndFadeA = 1000; // startTime

        [Configurable]
        public int EndFadeB = 1500; // endTime

        [Configurable]
        public float EndFadeOA = 1; // startOpacity

        [Configurable]
        public float EndFadeOB = 0; // endOpacity

        /* movement */

        [Configurable]
        public OsbEasing MoveEasing = OsbEasing.None; // movement easing

        [Configurable]
        public int MoveA = 0; // start move time

        [Configurable]
        public int MoveAX = 320; // start move X

        [Configurable]
        public int MoveAY = 240; // start move Y

        [Configurable]
        public int MoveB = 0; // end move time

        [Configurable]
        public int MoveBX = 320; // end move X

        [Configurable]
        public int MoveBY = 240; // end move Y

        /* scaling */

        [Configurable]
        public OsbEasing ScaleEasing = OsbEasing.None; // scaling easing

        [Configurable]
        public int ScaleA = 0; // scaleStart

        [Configurable]
        public int ScaleB = 0; // scaleEnd

        [Configurable]
        public float ScaleXA = 1; // scaleStart X

        [Configurable]
        public float ScaleYA = 1; // scaleStart Y

        [Configurable]
        public float ScaleXB = 1; // scaleEnd X

        [Configurable]
        public float ScaleYB = 1; // scaleEnd Y

        /* rotation */

        [Configurable]
        public OsbEasing RotateEasing = OsbEasing.None; // rotation easing

        [Configurable]
        public int RotationA = 0; // start rotation time

        [Configurable]
        public int RotationB = 0; // end rotation time

        [Configurable]
        public float RotationARad = 0; // start rotation radian

        [Configurable]
        public float RotationBRad = 0; // end rotation radian

        /* coloring */

        [Configurable]
        public Color4 Color = new Color4(); // color palette

        [Configurable]
        public int ColorO = 0; // color offset

        /* sprite origin */

        [Configurable]
        public OsbOrigin Origin = OsbOrigin.Centre; // sprite origin

        /* layer */

        [Configurable]
        public string Layer = ""; // input layer

        /* main */

        public override void Generate()
        {
            var layer = GetLayer(Layer); // set layer

            var sprite = layer.CreateSprite("sb/" + SpritePath, Origin); // get sprite
            //CreateSprite(path, origin, initialPosition)

            sprite.Fade(StartFadeA, StartFadeB, StartFadeOA, StartFadeOB); // start opacity : fade-in
            sprite.Fade(EndFadeA, EndFadeB, EndFadeOA, EndFadeOB); // end opacity : fade-out
            // Fade(easing, startTime, endTime, startOpacity, endOpacity)

            sprite.Move(MoveEasing, MoveA, MoveB, MoveAX, MoveAY, MoveBX, MoveBY); // movement
            //Move(easing, startTime, endTime, startX, startY, endX, endY)

            sprite.Color(ColorO, Color); // set color
            // Color(time, color)

            sprite.ScaleVec(ScaleEasing, ScaleA, ScaleB, ScaleXA, ScaleYA, ScaleXB, ScaleYB); // scaling
            // ScaleVec(easing, startTime, endTime, startX, startY, endX, endY)

            sprite.Rotate(RotateEasing, RotationA, RotationB, RotationARad, RotationBRad); // rotate
            // Rotate(easing, startTime, endTime, startRotation, endRotation)
        }
    }
}
