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
    public class Squares : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            Intro_Square();
            Post_Intro_Square_1();
            Post_Intro_Square_2();
            Post_Intro_Square_3();
            Post_Intro_Square_4();
            Post_Intro_Square_5();
            Post_Intro_Square_6();
            Post_Intro_Square_7();
        }

        public string Sprite = "sb/sprites/white.png";
        public double Rotation = Math.PI / 4;

        public void Intro_Square()
        {
            int OffsetA = 1598;
            int OffsetAA = 6861;
            int OffsetB = 7306;
            int OffsetBB = 7774;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name + "_Big");
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, .75);
            sprite.Fade(OffsetB, OffsetBB, .75, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetBB, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 20, .3, .35);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetBB, 50, 50, 47.5, 47.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetBB, 0, 0.5);

            int OffsetA2 = 7306;
            int OffsetAA2 = 7774;
            int OffsetB2 = 14565;
            int OffsetBB2 = 15030;
            var layer2 = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name + "_Small");
            var sprite2 = layer2.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite2.Fade(OffsetA2, OffsetAA2, 0, .75);
            sprite2.Fade(OffsetB2, OffsetBB2, .75, 0);
            sprite2.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 25, 25, 22.5, 22.5);
            sprite2.Rotate(OsbEasing.None, 7540, OffsetBB2, 1.37, 1.73);
            sprite2.ColorHsb(OffsetA, 20, .3, .35);

            int OffsetA3 = 14565;
            int OffsetB3 = 15030;
            sprite2.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 22.5, 22.5, 0, 0);
        }

        public void Post_Intro_Square_1()
        {
            int OffsetA = 20611;
            int OffsetB = 24681;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 100, 100, 100, 100);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);

            int OffsetA2 = 21542;
            int OffsetB2 = 22239;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, 320, 240, 650, 240);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 100, 100, 12.5, 12.5);

            int OffsetA3 = 22239;
            int OffsetB3 = 24681;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 650, 240, 850, 240);
        }

        public void Post_Intro_Square_2()
        {
            int OffsetA = 20611;
            int OffsetB = 27123;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 80, 80, 80, 80);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);

            int OffsetA2 = 21542;
            int OffsetB2 = 22472;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -880, 240, 90, 240);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 80, 80, 40, 40);

            int OffsetA3 = 22472;
            int OffsetB3 = 25030;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 90, 240, 420, 240);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 40, 40, 40, 40);

            int OffsetA4 = 25030;
            int OffsetB4 = 25960;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 420, 240, 780, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 40, 40, 60, 60);

            int OffsetA5 = 25960;
            int OffsetB5 = 27123;
            sprite.Move(OsbEasing.None, OffsetA5, OffsetB5, 780, 0, 1050, 0);
        }

        public void Post_Intro_Square_3()
        {
            int OffsetA = 20611;
            int OffsetB = 45960;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, -600, 240, -600, 240);
            sprite.ColorHsb(OffsetA, 0, 0, .7);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 100, 100, 100, 100);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);

            int OffsetA2 = 21542;
            int OffsetB2 = 22472;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -600, 240, 0, 360);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 100, 100, 60, 60);

            int OffsetA3 = 22472;
            int OffsetB3 = 25030;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 0, 360, 150, 360);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 60, 60, 60, 60);

            int OffsetA4 = 25030;
            int OffsetB4 = 29681;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 150, 360, 500, 360);
            sprite.ScaleVec(OsbEasing.None, OffsetA4, 25960, 60, 60, 70, 70);

            int OffsetA5 = 29681;
            int OffsetB5 = 36658;
            sprite.Move(OsbEasing.None, OffsetA5, OffsetB5, 500, 360, 720, 360);
            sprite.ScaleVec(OsbEasing.None, OffsetA5, 30611, 70, 70, 60, 60);

            int OffsetA6 = 36658;
            int OffsetB6 = 37356;
            sprite.Move(OsbEasing.None, OffsetA6, OffsetB6, 720, 360, 730, 280);
            sprite.ScaleVec(OsbEasing.None, OffsetA6, OffsetB6, 60, 60, 15, 15);

            int OffsetA7 = 37356;
            int OffsetB7 = 45960;
            sprite.Move(OsbEasing.None, OffsetA7, OffsetB7, 730, 280, 855, 280);
            sprite.ScaleVec(OsbEasing.None, OffsetA7, OffsetB7, 15, 15, 15, 15);
        }

        public void Post_Intro_Square_4()
        {
            int OffsetA = 23635;
            int OffsetB = 44797;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, 25030, -250, 340, -125, 340);
            sprite.ColorHsb(OffsetA, 220, .3, .5);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 20, 20, 20, 20);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);

            int OffsetA2 = 25030;
            int OffsetB2 = 25960;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -125, 340, -250, 340);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 20, 20, 25, 25);

            int OffsetA3 = 25960;
            int OffsetB3 = 29681;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, -250, 340, 100, 340);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 25, 25, 25, 25);

            int OffsetA4 = 29681;
            int OffsetB4 = 30611;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 100, 340, 200, 340);
            sprite.ScaleVec(OsbEasing.None, OffsetA4, OffsetB4, 25, 25, 20, 20);

            int OffsetA5 = 30611;
            int OffsetB5 = 36658;
            sprite.Move(OsbEasing.None, OffsetA5, OffsetB5, 200, 340, 440, 340);
            sprite.ScaleVec(OsbEasing.None, OffsetA5, OffsetB5, 20, 20, 20, 20);

            int OffsetA6 = 36658;
            int OffsetB6 = 37356;
            sprite.Move(OsbEasing.None, OffsetA6, OffsetB6, 440, 340, 690, 285);
            sprite.ScaleVec(OsbEasing.None, OffsetA6, OffsetB6, 20, 20, 7.5, 7.5);

            int OffsetA7 = 37356;
            int OffsetB7 = 44797;
            sprite.Move(OsbEasing.None, OffsetA7, OffsetB7, 690, 285, 800, 285);
            sprite.ScaleVec(OsbEasing.None, OffsetA7, OffsetB7, 7.5, 7.5, 7.5, 7.5);
        }

        public void Post_Intro_Square_5()
        {
            int OffsetA = 28751;
            int OffsetB = 44797;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, 29681, -800, -30, -450, -30);
            sprite.ColorHsb(OffsetA, 0, 0, .5);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 100, 100, 100, 100);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);

            int OffsetA2 = 29681;
            int OffsetB2 = 30611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -450, -30, -50, 160);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 100, 100, 70, 70);

            int OffsetA3 = 30611;
            int OffsetB3 = 36658;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, -50, 160, 600, 160);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 70, 70, 70, 70);

            int OffsetA4 = 36658;
            int OffsetB4 = 37356;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 600, 160, 650, 240);
            sprite.ScaleVec(OsbEasing.None, OffsetA4, OffsetB4, 70, 70, 10, 10);

            int OffsetA5 = 37356;
            int OffsetB5 = 44797;
            sprite.Move(OsbEasing.None, OffsetA5, OffsetB5, 650, 240, 825, 240);
            sprite.ScaleVec(OsbEasing.None, OffsetA5, OffsetB5, 10, 10, 10, 10);
        }

        public void Post_Intro_Square_6()
        {
            int OffsetA = 32007;
            int OffsetB = 51309;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, 36658, -300, 230, 100, 230);
            sprite.ColorHsb(OffsetA, 290, .1, .5);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 37.5, 37.5, 37.5, 37.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);

            int OffsetA2 = 36658;
            int OffsetB2 = 37356;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, 100, 230, 400, 230);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 37.5, 37.5, 12, 12);

            int OffsetA3 = 37356;
            int OffsetB3 = 50611;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 400, 230, 700, 230);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 12, 12, 12, 12);

            int OffsetA4 = 50611;
            int OffsetB4 = 51309;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 700, 230, 1000, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA4, OffsetB4, 12, 12, 36, 36);
        }

        public void Post_Intro_Square_7()
        {
            
        }

    }
}
