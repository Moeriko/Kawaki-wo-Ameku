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
    public class ShakeEffect : StoryboardObjectGenerator
    {
        [Configurable]
        public bool Shake = true;

        [Configurable]
        public OsbEasing ShakeEasing = OsbEasing.None;

        [Configurable]
        public OsbOrigin Origin = OsbOrigin.Centre;

        [Configurable]
        public string SpritePath = "sb/shake.jpg";

        [Configurable]
        public float PosX = 320;

        [Configurable]
        public float PosY = 240;

        [Configurable]
        public int ShakeAmount = 100;

        [Configurable]
        public int Radius = 20;

        [Configurable]
        public float Scale = 1;

        [Configurable]
        public float Fade = 1;

        [Configurable]
        public int FadeTime = 200;

        [Configurable]
        public bool Rotate = false;

        [Configurable]
        public OsbEasing RotateEasing = OsbEasing.InOutSine;

        [Configurable]
        public int RotationAngle = 0;

        [Configurable]
        public int RotationVelocity = 1000;

        [Configurable]
        public bool Additive = false;

        [Configurable]
        public Color4 Color = Color4.White;

        public override void Generate()
        {
            ShakeGen(73402, 89332);
        }

        public Vector2 CirclePos(double angle, int radius)
        {
            double posX = PosX + (radius * Math.Cos(angle));
            double posY = PosY + ((radius * 5) * Math.Sin(angle));

            return new Vector2((float)posX, (float)posY);
        }

        public void ShakeGen(int StartTime, int EndTime)
        {
            var layer = GetLayer("");
            var sprite = layer.CreateSprite(SpritePath, Origin, new Vector2(PosX, PosY));

            sprite.Fade(OsbEasing.None, StartTime, StartTime + FadeTime, 0, Fade);
            sprite.Fade(OsbEasing.None, EndTime - FadeTime, EndTime, Fade, 0);
            sprite.Scale(StartTime, Scale);
            sprite.Color(StartTime, Color);

            if (Rotate)
            {
                var angleStart = MathHelper.DegreesToRadians(RotationAngle - (RotationAngle * 2));
                var angleEnd = MathHelper.DegreesToRadians(RotationAngle);

                sprite.StartLoopGroup(StartTime, 999999);
                sprite.Rotate(RotateEasing, 0, RotationVelocity / 2, angleStart, angleEnd);
                sprite.Rotate(RotateEasing, RotationVelocity / 2, RotationVelocity, angleEnd, angleStart);
                sprite.EndGroup();
            }

            if (Additive)
            {
                sprite.Additive(StartTime, EndTime);
            }

            if (Shake)
            {
                var angleCurrent = 0d;
                var radiusCurrent = 0;
                // ShakeAmount -> smaller number = more shaking!
                for (int i = StartTime; i < EndTime - ShakeAmount; i += ShakeAmount)
                {
                    var angle = Random(angleCurrent - Math.PI / 4, angleCurrent + Math.PI / 4);
                    var radius = Math.Abs(Random(radiusCurrent - Radius / 4, radiusCurrent + Radius / 4));

                    while (radius > Radius)
                    {
                        radius = Math.Abs(Random(radiusCurrent - Radius / 4, radiusCurrent + Radius / 4));
                    }

                    var start = sprite.PositionAt(i);
                    var end = CirclePos(angle, radius);

                    if (i + ShakeAmount >= EndTime)
                    {
                        sprite.Move(ShakeEasing, i, EndTime, start, end);
                    }
                    else
                    {
                        sprite.Move(ShakeEasing, i, i + ShakeAmount, start, end);
                    }

                    angleCurrent = angle;
                    radiusCurrent = radius;
                }
            }
        }
    }
}