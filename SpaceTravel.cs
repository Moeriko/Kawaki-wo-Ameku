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
    public class SpaceTravel : StoryboardObjectGenerator
    {
        [Configurable]
        public OsbEasing easing = OsbEasing.None;

        [Configurable]
        public OsbOrigin TrailOrigin = OsbOrigin.BottomCentre;

        [Configurable]
        public string TrailSpritePath = "sb/particle.png";

        [Configurable]
        public bool ReverseTrails = true;

        [Configurable]
        public bool TrailAdditive = false;

        [Configurable]
        public float FadeTime = 100;

        [Configurable]
        public float Delay = 200;

        [Configurable]
        public float centreX = 427;

        [Configurable]
        public float centreY = 240;

        [Configurable]
        public float borderX = 854;

        [Configurable]
        public float borderY = 480;

        [Configurable]
        public float speed = 1f;

        [Configurable]
        public double spawnDelay = 25;

        [Configurable]
        public bool RandomColor = false;

        [Configurable]
        public Color4 MinColor = new Color4(255, 255, 255, 255);

        [Configurable]
        public Color4 MaxColor = new Color4(255, 255, 255, 255);

        public override void Generate()
        {
            //This is where code execution starts
            //In storybrew *always* the "Generate()" method!

            //We first get a layer with a method called "GetLayer"
            var layer = GetLayer("SpaceTravel");

            //Here we call another method called "SpaceTravelGenerate"
            SpaceTravelGenerate(layer, 11551, 15030);

            /*
                Note that "GetLayer()" works the same way as "SpaceTravelGenerate()"!
                The difference is only that you can't see the "GetLayer()" Method.
                "GetLayer" is part of a class called "StoryboardObjectGenerator"
                And "public class SpaceTravel : StoryboardObjectGenerator" means that we extend our "SpaceTravel" Class
                Or in other words: we can use every method defined in "StoryboardObjectGenerator" (without seeing them)
            */

        }

        public void SpaceTravelGenerate(StoryboardLayer layer, int startTime, int endTime)
        {
            var centre = new Vector2(centreX + Random(-20, 20), centreY + Random(-20, 20));
            var border = new Vector2(borderX, borderY);

            //The loop
            for (var i = startTime; i < endTime; i += (int)spawnDelay)
            {
                var sPos = new Vector2(Random(0, (int)border.X), Random(0, (int)border.Y));

                var dir = Vector2.Normalize(sPos - centre);
                var dist = Vector2.Divide(sPos, dir);
                var movement = Math.Min(Math.Abs(dist.X), Math.Abs(dist.Y));
                var time = movement / speed;

                var ePos = sPos + Vector2.Multiply(dir, movement + 10f);

                var RadiusMin = 0;
                var RadiusMax = 10;

                //Convert positions back to our -107 position
                sPos = new Vector2(sPos.X - 107, sPos.Y);
                ePos = new Vector2((ePos.X - 107) + Random(RadiusMin, RadiusMax), ePos.Y + Random(RadiusMin, RadiusMax));

                //Colors for the sprites
                var RealColor = RandomColor ? new Color4(
                    (float)Random(MinColor.R, MaxColor.R),
                    (float)Random(MinColor.G, MaxColor.G),
                    (float)Random(MinColor.B, MaxColor.B), 255) : MinColor;

                //Trail sprite section
                float length = (ePos - sPos).Length;
                var trail = layer.CreateSprite(TrailSpritePath, TrailOrigin, ePos);

                if (ReverseTrails)
                {
                    trail.Fade(i + time, i + time + FadeTime, 0.4f, 0f);
                    trail.Fade(14972, 16472, 0, 0);
                    trail.Color(i, RealColor);
                    trail.Rotate(i, Math.Atan2((ePos.Y - sPos.Y), (ePos.X - sPos.X)) - Math.PI / 2f);
                    trail.ScaleVec(easing, i - Delay, i + time, .1f, 0f, .1f, length / 15f);
                }

                else
                {
                    trail.Rotate(i, Math.Atan2((sPos.Y - ePos.Y), (sPos.X - ePos.X)) - Math.PI / 2f);
                    trail.ScaleVec(easing, i - Delay, i + time, .1f, 0f, .1f, length / 10f);
                }

                if (TrailAdditive)
                {
                    trail.Additive(i, i - Delay);
                }
            }
        }
    }
}
