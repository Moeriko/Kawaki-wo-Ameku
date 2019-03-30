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
    public class RainScript : StoryboardObjectGenerator
    {
        [Configurable]
        public string SpritePath = "";

        [Configurable]
        public Vector2 StartPosition = new Vector2(-107, -50);

        [Configurable]
        public Vector2 EndPosition = new Vector2(747, 530);

        [Configurable]
        public float Opacity = 0f;

        [Configurable]
        public float OpacityTime = 200;

        [Configurable]
        public int MinVelocity = 500;

        [Configurable]
        public int MaxVelocity = 2000;

        [Configurable]
        public float ScaleX = 1;

        [Configurable]
        public float ScaleY = 5;

        [Configurable]
        public bool Additive = false;

        [Configurable]
        public bool RandomColor = true;

        [Configurable]
        public Color4 MinColor = Color4.White;

        [Configurable]
        public Color4 MaxColor = Color4.LightGray;

        public override void Generate()
        {
            GenerateRain(0, 10000);
        }

        public void GenerateRain(int startTime, int endTime)
        {
            var RandomVelocity = Random(MinVelocity, MaxVelocity);

            var sprite = GetLayer("").CreateSprite(SpritePath, OsbOrigin.Centre);
            var RealColor = RandomColor ? new Color4((float)Random(MinColor.R, MaxColor.R),
                                                    (float)Random(MinColor.G, MaxColor.G),
                                                    (float)Random(MinColor.B, MaxColor.B),
                                                    255) : MinColor;

            for (int i = 0; i <= RandomVelocity - OpacityTime; i += RandomVelocity)
            {
                var loopCount = 1;

                sprite.StartLoopGroup(startTime, loopCount);
                sprite.Move(i, i + RandomVelocity, Random(StartPosition.X, EndPosition.X));
                sprite.Move(i + RandomVelocity, i + RandomVelocity, Random(StartPosition.Y, EndPosition.Y));

                sprite.Fade(i, OpacityTime, 0, Opacity);
                sprite.Fade(RandomVelocity - OpacityTime, RandomVelocity, Opacity, 0);

                sprite.ScaleVec(1, ScaleX, ScaleY);
                sprite.Color(1, RealColor);

                if (Additive)
                {
                    sprite.Additive(1, endTime);
                }
            }
            sprite.EndGroup();
        }
    }
}
