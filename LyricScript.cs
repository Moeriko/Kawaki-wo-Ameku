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
    public class LyricScript : StoryboardObjectGenerator
    {
        private FontGenerator Font;

        public override void Generate()
        {
            Font = SetFont(); // generates the font
            GenerateText(0, 10000, "カワキヲアメク"); // StartTime, Endtime, Text
        }

        private FontGenerator SetFont()
        {
            var font = LoadFont("sb/fonts", new FontDescription
            {
                FontPath = "UD Digi Kyokasho N-R", // path to font name (can be "font.tff" for example).
                FontSize = 100, // size of generated font.
                Color = Color4.Red // color of generated font.
            });

            return font; // returns function value.
        }

        private void GenerateText(int StartTime, int EndTime, string Text)
        {
            // sets position of generated string.
            float PosX = 320;
            float PosY = 240;

            // font scale multiply.
            float Scale = 0.3f;

            // lineheight and width settings.
            float lineWidth = 0f;
            var lineHeight = 0f;
            int letterSpacing = 10;
            foreach (var letter in Text)
            {
                var texture = Font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * Scale + letterSpacing;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight * Scale);
            }
            var PositionX = PosX - (lineWidth / 2); // sets position for centering.

            foreach (var letter in Text)
            {
                var texture = Font.GetTexture(letter.ToString()); // sets characters into string.
                if (!texture.IsEmpty) // if texture is NOT empty.
                {
                    var Position = new Vector2(PositionX, PosY)
                        + texture.OffsetFor(OsbOrigin.TopCentre) * Scale;

                    var sprite = GetLayer("Lyrics").CreateSprite(texture.Path, OsbOrigin.Centre, Position);
                    sprite.Fade(StartTime, EndTime, 1, 1);
                    sprite.Scale(StartTime, Scale);
                }
                PositionX += texture.BaseWidth * Scale + letterSpacing; // responsive when Scale changes.
            }
        }
    }
}
