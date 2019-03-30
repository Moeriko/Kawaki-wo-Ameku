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
    public class Backgrounds : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            Intro_Black_BG();
            Intro_White_BG();
            Post_Intro_Gray_BG();
            Post_Intro_Black_BG();
            Pre_Chorus_Gray_BG();
            Pre_Chorus_Black_BG();
            Pre_Chorus_White_BG();
            BuildUp_White_BG();
            Chorus_Blue_BG();
            Chorus_Gray_BG();
            Chorus_White_BG();
            Chorus_Outro_Blue_BG();
            Outro_Black_BG();
        }

        public string Sprite = "sb/sprites/white.png";

        public void Intro_Black_BG()
        {
            int OffsetA = -1;
            int OffsetB = 1597;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 1, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Intro_White_BG()
        {
            int OffsetA = 0;
            int OffsetB = 21542;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(850, 1598, 0, 1);
            sprite.Fade(21542, 21542, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetB, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Post_Intro_Gray_BG()
        {
            int OffsetA = 21542;
            int OffsetB = 52239;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, .2);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Post_Intro_Black_BG()
        {
            int OffsetA = 37123;
            int OffsetB = 38053;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Pre_Chorus_Gray_BG()
        {
            int OffsetA = 52239;
            int OffsetB = 53170;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, .65);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void BuildUp_White_BG()
        {
            int OffsetA = 52704;
            int OffsetB = 52937;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Pre_Chorus_Black_BG()
        {
            int OffsetA = 52937;
            int OffsetB = 58518;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, .1, .05);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Pre_Chorus_White_BG()
        {
            int OffsetA = 58518;
            int OffsetB = 59681;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Chorus_Blue_BG()
        {
            int OffsetA = 59681;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 180, .25, .8);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Chorus_Gray_BG()
        {
            int OffsetA = 66658;
            int OffsetB = 73635;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, .1, .15);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }

        public void Chorus_White_BG()
        {
            int OffsetA = 66890;
            int OffsetB = 67123;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);

            int OffsetA2 = 68053;
            int OffsetB2 = 68286;
            sprite.Fade(OffsetA2, OffsetA2, 0, 1);
            sprite.Fade(OffsetB2, OffsetB2, 1, 0);

            int OffsetA3 = 68751;
            int OffsetB3 = 68983;
            sprite.Fade(OffsetA3, OffsetA3, 0, 1);
            sprite.Fade(OffsetB3, OffsetB3, 1, 0);

            int OffsetA4 = 70146;
            int OffsetB4 = 70379;
            sprite.Fade(OffsetA4, OffsetA4, 0, 1);
            sprite.Fade(OffsetB4, OffsetB4, 1, 0);

            int OffsetA5 = 70844;
            int OffsetB5 = 71309;
            sprite.Fade(OffsetA5, OffsetA5, 0, 1);
            sprite.Fade(OffsetB5, OffsetB5, 1, 0);
        }

        public void Chorus_Outro_Blue_BG()
        {
            int Offset = 73635;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(Offset, Offset, 0, 1);
            sprite.Fade(85728, 89332, 1, 0);
            sprite.Move(OsbEasing.None, Offset, Offset, 320, 240, 320, 240);
            sprite.ColorHsb(Offset, 220, .4, .2);
            sprite.ColorHsb(78286, 82007, 220, .4, .2, 215, .4, .8);
            sprite.ScaleVec(OsbEasing.None, Offset, Offset, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, Offset, Offset, 0, 0);
        }

        public void Outro_Black_BG()
        {
            int OffsetA = 85728;
            int OffsetB = 92578;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 1, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 48, 86, 48);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 0, 0);
        }
    }
}
