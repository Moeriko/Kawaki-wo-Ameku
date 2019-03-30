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
            Post_Intro_Square_8();
            Post_Intro_Square_9();
            Post_Intro_Square_10();
            Post_Intro_Square_11();
            Post_Intro_Gray_Grid_BG();
            Post_Intro_Cyan_Grid_Square();
            Pre_Chorus_Square_1();
            Pre_Chorus_Square_2();
            Pre_Chorus_Gap_Closer();
            Pre_Chorus_Gap_Line();
            Dropple_Effect_1();
            Dropple_Effect_2();
            Dropple_Effect_3();
            Dropple_Effect_4();
            Dropple_Effect_5();
            Dropple_Effect_6();
            Dropple_Effect_7();
            Dropple_Effect_8();
        }

        public string Sprite = "sb/sprites/white.png";
        public string Sprite2 = "sb/sprites/whiteb.png";
        public double Rotation = Math.PI / 4;
        public double RotationFlipped = -1.25 * Math.PI;
        public double RotationSmall = -0.5 * Math.PI;

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
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA, 100, 100, 100, 100);
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
            sprite.ScaleVec(OsbEasing.Out, OffsetA2, OffsetB2, 80, 80, 40, 40);

            int OffsetA3 = 22472;
            int OffsetB3 = 25030;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 90, 240, 420, 240);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 40, 40, 40, 40);

            int OffsetA4 = 25030;
            int OffsetB4 = 25960;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 420, 240, 780, 0);
            sprite.ScaleVec(OsbEasing.Out, OffsetA4, OffsetB4, 40, 40, 60, 60);

            int OffsetA5 = 25960;
            int OffsetB5 = 27123;
            sprite.Move(OsbEasing.None, OffsetA5, OffsetB5, 780, 0, 1175, 0);
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
            sprite.ScaleVec(OsbEasing.Out, OffsetA4, 25960, 60, 60, 70, 70);

            int OffsetA5 = 29681;
            int OffsetB5 = 36658;
            sprite.Move(OsbEasing.None, OffsetA5, OffsetB5, 500, 360, 720, 360);
            sprite.ScaleVec(OsbEasing.Out, OffsetA5, 30611, 70, 70, 60, 60);

            int OffsetA6 = 36658;
            int OffsetB6 = 37356;
            sprite.Move(OsbEasing.None, OffsetA6, OffsetB6, 720, 360, 730, 280);
            sprite.ScaleVec(OsbEasing.Out, OffsetA6, OffsetB6, 60, 60, 15, 15);

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
            sprite.ScaleVec(OsbEasing.Out, OffsetA2, OffsetB2, 20, 20, 25, 25);

            int OffsetA3 = 25960;
            int OffsetB3 = 29681;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, -250, 340, 100, 340);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 25, 25, 25, 25);

            int OffsetA4 = 29681;
            int OffsetB4 = 30611;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 100, 340, 200, 340);
            sprite.ScaleVec(OsbEasing.Out, OffsetA4, OffsetB4, 25, 25, 20, 20);

            int OffsetA5 = 30611;
            int OffsetB5 = 36658;
            sprite.Move(OsbEasing.None, OffsetA5, OffsetB5, 200, 340, 440, 340);
            sprite.ScaleVec(OsbEasing.None, OffsetA5, OffsetB5, 20, 20, 20, 20);

            int OffsetA6 = 36658;
            int OffsetB6 = 37356;
            sprite.Move(OsbEasing.Out, OffsetA6, OffsetB6, 440, 340, 690, 285);
            sprite.ScaleVec(OsbEasing.Out, OffsetA6, OffsetB6, 20, 20, 7.5, 7.5);

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
            sprite.ScaleVec(OsbEasing.Out, OffsetA2, OffsetB2, 100, 100, 70, 70);

            int OffsetA3 = 30611;
            int OffsetB3 = 36658;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, -50, 160, 600, 160);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 70, 70, 70, 70);

            int OffsetA4 = 36658;
            int OffsetB4 = 37356;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 600, 160, 650, 240);
            sprite.ScaleVec(OsbEasing.Out, OffsetA4, OffsetB4, 70, 70, 10, 10);

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
            sprite.ScaleVec(OsbEasing.Out, OffsetA2, OffsetB2, 37.5, 37.5, 12, 12);

            int OffsetA3 = 37356;
            int OffsetB3 = 50611;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 400, 230, 700, 230);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 12, 12, 12, 12);

            int OffsetA4 = 50611;
            int OffsetB4 = 51309;
            sprite.Move(OsbEasing.None, OffsetA4, OffsetB4, 700, 230, 1000, 0);
            sprite.ScaleVec(OsbEasing.Out, OffsetA4, OffsetB4, 12, 12, 36, 36);
        }

        public void Post_Intro_Square_7()
        {
            int OffsetA = 38053;
            int OffsetB = 51542;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.Out, OffsetA, 39216, -300, 100, 275, 100);
            sprite.ColorHsb(OffsetA, 0, 0, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            sprite.Rotate(OsbEasing.Out, OffsetA, 39216, RotationFlipped, Rotation);

            int OffsetA2 = 39216;
            int OffsetB2 = 50611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, 275, 100, 600, 100);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 22.5, 22.5, 22.5, 22.5);

            int OffsetA3 = 50611;
            int OffsetB3 = 51542;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 600, 100, 900, -250);
            sprite.ScaleVec(OsbEasing.Out, OffsetA3, OffsetB3, 22.5, 22.5, 50, 50);
        }

        public void Post_Intro_Square_8()
        {
            int OffsetA = 39216;
            int OffsetB = 51774;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.Out, OffsetA, 40379, -300, 275, 175, 275);
            sprite.ColorHsb(OffsetA, 333, .3, .7);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 15, 15, 15, 15);
            sprite.Rotate(OsbEasing.Out, OffsetA, 40379, RotationFlipped, Rotation);

            int OffsetA2 = 40379;
            int OffsetB2 = 50611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, 175, 275, 400, 275);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 15, 15, 15, 15);

            int OffsetA3 = 50611;
            int OffsetB3 = 51774;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 400, 275, 650, 800);
            sprite.ScaleVec(OsbEasing.Out, OffsetA3, OffsetB3, 15, 15, 40, 40);
        }

        public void Post_Intro_Square_9()
        {
            int OffsetA = 41774;
            int OffsetB = 51309;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .75);
            sprite.Fade(OffsetB, OffsetB, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, 42937, -300, 100, -75, 100);
            sprite.ColorHsb(OffsetA, 0, .7, .8);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 15, 15, 15, 15);
            sprite.Rotate(OsbEasing.Out, OffsetA, 42937, RotationSmall, Rotation);

            int OffsetA2 = 42937;
            int OffsetB2 = 50611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -75, 100, 400, 100);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 15, 15, 15, 15);

            int OffsetA3 = 50611;
            int OffsetB3 = 51309;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 400, 100, 800, -200);
            sprite.ScaleVec(OsbEasing.Out, OffsetA3, OffsetB3, 15, 15, 35, 35);
        }

        public void Post_Intro_Square_10()
        {
            int OffsetA = 43170;
            int OffsetB = 51542;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.Out, OffsetA, 44797, -300, 250, -75, 250);
            sprite.ColorHsb(OffsetA, 185, .5, .7);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            sprite.Rotate(OsbEasing.Out, OffsetA, 44797, RotationSmall, Rotation);

            int OffsetA2 = 44797;
            int OffsetB2 = 50611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -75, 250, 170, 250);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 22.5, 22.5, 22.5, 22.5);

            int OffsetA3 = 50611;
            int OffsetB3 = 51542;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 170, 250, -350, 630);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, 22.5, 22.5, 50, 50);
        }

        public void Post_Intro_Square_11()
        {
            int OffsetA = 43867;
            int OffsetB = 52239;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.Out, OffsetA, 44797, -300, 220, 260, 220);
            sprite.ColorHsb(OffsetA, 0, 0, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 10, 10, 10, 10);
            sprite.Rotate(OsbEasing.Out, OffsetA, 44797, RotationFlipped, Rotation);

            int OffsetA2 = 44797;
            int OffsetB2 = 50611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, 260, 220, 310, 220);
            sprite.ScaleVec(OsbEasing.None, OffsetA2, OffsetB2, 10, 10, 10, 10);

            int OffsetA3 = 50611;
            int OffsetB3 = 52239;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 310, 220, 320, 220);
            sprite.ScaleVec(OsbEasing.In, OffsetA3, OffsetB3, 10, 10, 100, 100);
        }

        public void Post_Intro_Gray_Grid_BG()
        {
            int OffsetA = 37123;
            int OffsetB = 38053;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);

            var spriteGray11 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray11.Move(OsbEasing.Out, OffsetA, OffsetB, 0, -80, 0, -80);
            spriteGray11.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray11.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray11.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray12 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray12.Move(OsbEasing.Out, OffsetA, OffsetB, 320, -80, 320, -80);
            spriteGray12.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray12.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray12.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray13 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray13.Move(OsbEasing.Out, OffsetA, OffsetB, 640, -80, 640, -80);
            spriteGray13.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray13.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray13.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray31 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray31.Move(OsbEasing.Out, OffsetA, OffsetB, 0, 240, 0, 240);
            spriteGray31.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray31.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray31.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray32 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray32.Move(OsbEasing.Out, OffsetA, OffsetB, 320, 240, 320, 240);
            spriteGray32.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray32.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray32.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray33 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray33.Move(OsbEasing.Out, OffsetA, OffsetB, 640, 240, 640, 240);
            spriteGray33.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray33.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray33.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray51 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray51.Move(OsbEasing.Out, OffsetA, OffsetB, 0, 560, 0, 560);
            spriteGray51.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray51.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray51.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray52 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray52.Move(OsbEasing.Out, OffsetA, OffsetB, 320, 560, 320, 560);
            spriteGray52.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray52.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray52.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray53 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray53.Move(OsbEasing.Out, OffsetA, OffsetB, 640, 560, 640, 560);
            spriteGray53.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray53.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray53.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray21 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray21.Move(OsbEasing.Out, OffsetA, OffsetB, -160, 80, -160, 80);
            spriteGray21.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray21.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray21.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray22 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray22.Move(OsbEasing.Out, OffsetA, OffsetB, 480, 80, 480, 80);
            spriteGray22.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray22.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray22.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray23 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray23.Move(OsbEasing.Out, OffsetA, OffsetB, 160, 80, 160, 80);
            spriteGray23.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray23.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray23.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray24 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray24.Move(OsbEasing.Out, OffsetA, OffsetB, 800, 80, 800, 80);
            spriteGray24.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray24.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray24.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray41 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray41.Move(OsbEasing.Out, OffsetA, OffsetB, -160, 400, -160, 400);
            spriteGray41.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray41.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray41.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray42 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray42.Move(OsbEasing.Out, OffsetA, OffsetB, 480, 400, 480, 400);
            spriteGray42.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray42.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray42.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray43 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray43.Move(OsbEasing.Out, OffsetA, OffsetB, 160, 400, 160, 400);
            spriteGray43.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray43.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray43.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteGray44 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteGray44.Move(OsbEasing.Out, OffsetA, OffsetB, 800, 400, 800, 400);
            spriteGray44.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            spriteGray44.ColorHsb(OffsetA, 320, .1, .1);
            spriteGray44.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);
        }

        public void Post_Intro_Cyan_Grid_Square()
        {
            int OffsetA = 37123;
            int OffsetB = 38053;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);

            var spriteCyan11 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan11.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan11.Move(OsbEasing.Out, OffsetA, OffsetB, 0, -80, 0, -80);
            spriteCyan11.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan11.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan11.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteCyan12 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan12.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan12.Move(OsbEasing.Out, OffsetA, OffsetB, 320, -80, 320, -80);
            spriteCyan12.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan12.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan12.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteCyan13 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan13.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan13.Move(OsbEasing.Out, OffsetA, OffsetB, 640, -80, 640, -80);
            spriteCyan13.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan13.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan13.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteCyan31 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan31.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan31.Move(OsbEasing.Out, OffsetA, OffsetB, 0, 240, 0, 240);
            spriteCyan31.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan31.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan31.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteCyan32 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan32.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan32.Move(OsbEasing.Out, OffsetA, OffsetB, 320, 240, 320, 240);
            spriteCyan32.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan32.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan32.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteCyan33 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan33.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan33.Move(OsbEasing.Out, OffsetA, OffsetB, 640, 240, 640, 240);
            spriteCyan33.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan33.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan33.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteCyan51 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan51.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan51.Move(OsbEasing.Out, OffsetA, OffsetB, 0, 560, 0, 560);
            spriteCyan51.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan51.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan51.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteCyan52 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan52.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan52.Move(OsbEasing.Out, OffsetA, OffsetB, 320, 560, 320, 560);
            spriteCyan52.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan52.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan52.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);

            var spriteCyan53 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            spriteCyan53.Fade(OffsetA, OffsetB, .8, .8);
            spriteCyan53.Move(OsbEasing.Out, OffsetA, OffsetB, 640, 560, 640, 560);
            spriteCyan53.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            spriteCyan53.ColorHsb(OffsetA, 185, .9, .6);
            spriteCyan53.Rotate(OsbEasing.Out, OffsetA, OffsetB, Rotation, Rotation);
        }

        public void Pre_Chorus_Square_1()
        {
            int OffsetA = 50611;
            int OffsetAA = 52239;
            int OffsetB = 52704;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.Out, OffsetA, 52239, 310, 220, 320, 220);
            sprite.ColorHsb(OffsetA, 20, .3, .35);
            sprite.ScaleVec(OsbEasing.In, OffsetA, OffsetAA, 5, 5, 50, 50);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);
        }

        public void Pre_Chorus_Square_2()
        {
            int OffsetA = 52937;
            int OffsetAA = 53170;
            int OffsetB = 55263;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 280, 280, 280, 280);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.In, OffsetA, OffsetAA, 25, 25, 40, 40);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);

            int OffsetA2 = 52937;
            int OffsetAA2 = 53170;
            var sprite2 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA2, OffsetAA2, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite2.Move(OsbEasing.None, OffsetA, OffsetB, 360, 200, 360, 200);
            sprite2.ColorHsb(OffsetA, 15, .2, .7);
            sprite2.ScaleVec(OsbEasing.In, OffsetA, OffsetAA, 65, 65, 50, 50);
            sprite2.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, Rotation);
        }

        public void Pre_Chorus_Gap_Closer()
        {
            int OffsetA = 54797;
            int OffsetB = 58518;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.OutCirc, OffsetA, 55263, 320, -240, 320, 120);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 24, 86, 24);

            var sprite2 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite2.Fade(OffsetA, OffsetA, 0, 1);
            sprite2.Fade(OffsetB, OffsetB, 1, 0);
            sprite2.Move(OsbEasing.OutCirc, OffsetA, 55263, 320, 840, 320, 360);
            sprite2.ColorHsb(OffsetA, 0, 0, 0);
            sprite2.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, 24, 86, 24);
        }

        public void Pre_Chorus_Gap_Line()
        {
            int OffsetA = 55263;
            int OffsetB = 58518;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 1180, 240, 540, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, .25, 86, .25);
        }

        public void Dropple_Effect_1()
        {
            int OffsetA = 22472;
            double PositionXA = 680;
            double PositionYA = 235;
            double SquareSize = 1.8;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA + 43, 0, .75);
            sprite.Fade(OffsetA + 172, OffsetA + 349, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA + 172, PositionXA, PositionYA, PositionXA, PositionYA);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetA + 86, RotationSmall, Rotation);

            int OffsetB = OffsetA + 349;
            double PositionXB = PositionXA - 75;
            double PositionYB = PositionYA - 15;
            var spriteB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteB.Fade(OffsetB, OffsetB + 43, 0, .75);
            spriteB.Fade(OffsetB + 172, OffsetB + 349, .75, 0);
            spriteB.Move(OsbEasing.Out, OffsetB, OffsetB + 172, PositionXB, PositionYB, PositionXB, PositionYB);
            spriteB.ColorHsb(OffsetB, 0, 0, 1);
            spriteB.ScaleVec(OsbEasing.Out, OffsetB, OffsetB + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteB.Rotate(OsbEasing.Out, OffsetB, OffsetB + 86, RotationSmall, Rotation);

            int OffsetC = OffsetB + 349;
            double PositionXC = PositionXB - 50;
            double PositionYC = PositionYB + 45;
            var spriteC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteC.Fade(OffsetC, OffsetC + 43, 0, .75);
            spriteC.Fade(OffsetC + 172, OffsetC + 349, .75, 0);
            spriteC.Move(OsbEasing.Out, OffsetC, OffsetC + 172, PositionXC, PositionYC, PositionXC, PositionYC);
            spriteC.ColorHsb(OffsetB, 0, 0, 1);
            spriteC.ScaleVec(OsbEasing.Out, OffsetC, OffsetC + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteC.Rotate(OsbEasing.Out, OffsetC, OffsetC + 86, RotationSmall, Rotation);
        }

        public void Dropple_Effect_2()
        {
            int OffsetA = 24332;
            double PositionXA = 100;
            double PositionYA = 450;
            double SquareSize = 1.75;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA + 43, 0, .75);
            sprite.Fade(OffsetA + 172, OffsetA + 349, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA + 172, PositionXA, PositionYA, PositionXA, PositionYA);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetA + 86, RotationSmall, Rotation);

            int OffsetB = OffsetA + 349;
            double PositionXB = PositionXA - 75;
            double PositionYB = PositionYA - 15;
            var spriteB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteB.Fade(OffsetB, OffsetB + 43, 0, .75);
            spriteB.Fade(OffsetB + 172, OffsetB + 349, .75, 0);
            spriteB.Move(OsbEasing.Out, OffsetB, OffsetB + 172, PositionXB, PositionYB, PositionXB, PositionYB);
            spriteB.ColorHsb(OffsetB, 0, 0, 1);
            spriteB.ScaleVec(OsbEasing.Out, OffsetB, OffsetB + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteB.Rotate(OsbEasing.Out, OffsetB, OffsetB + 86, RotationSmall, Rotation);

            int OffsetC = OffsetB + 349;
            double PositionXC = PositionXB - 50;
            double PositionYC = PositionYB + 45;
            var spriteC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteC.Fade(OffsetC, OffsetC + 43, 0, .75);
            spriteC.Fade(OffsetC + 172, OffsetC + 349, .75, 0);
            spriteC.Move(OsbEasing.Out, OffsetC, OffsetC + 172, PositionXC, PositionYC, PositionXC, PositionYC);
            spriteC.ColorHsb(OffsetB, 0, 0, 1);
            spriteC.ScaleVec(OsbEasing.Out, OffsetC, OffsetC + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteC.Rotate(OsbEasing.Out, OffsetC, OffsetC + 86, RotationSmall, Rotation);
        }

        public void Dropple_Effect_3()
        {
            int OffsetA = 26193;
            double PositionXA = 680;
            double PositionYA = 80;
            double SquareSize = 1.65;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA + 43, 0, .75);
            sprite.Fade(OffsetA + 172, OffsetA + 349, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA + 172, PositionXA, PositionYA, PositionXA, PositionYA);
            sprite.ColorHsb(OffsetA, 220, .3, .9);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetA + 86, RotationSmall, Rotation);

            int OffsetB = OffsetA + 349;
            double PositionXB = PositionXA - 75;
            double PositionYB = PositionYA - 15;
            var spriteB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteB.Fade(OffsetB, OffsetB + 43, 0, .75);
            spriteB.Fade(OffsetB + 172, OffsetB + 349, .75, 0);
            spriteB.Move(OsbEasing.Out, OffsetB, OffsetB + 172, PositionXB, PositionYB, PositionXB, PositionYB);
            spriteB.ColorHsb(OffsetB, 220, .3, .9);
            spriteB.ScaleVec(OsbEasing.Out, OffsetB, OffsetB + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteB.Rotate(OsbEasing.Out, OffsetB, OffsetB + 86, RotationSmall, Rotation);

            int OffsetC = OffsetB + 349;
            double PositionXC = PositionXB - 50;
            double PositionYC = PositionYB + 45;
            var spriteC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteC.Fade(OffsetC, OffsetC + 43, 0, .75);
            spriteC.Fade(OffsetC + 172, OffsetC + 349, .75, 0);
            spriteC.Move(OsbEasing.Out, OffsetC, OffsetC + 172, PositionXC, PositionYC, PositionXC, PositionYC);
            spriteC.ColorHsb(OffsetB, 220, .3, .9);
            spriteC.ScaleVec(OsbEasing.Out, OffsetC, OffsetC + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteC.Rotate(OsbEasing.Out, OffsetC, OffsetC + 86, RotationSmall, Rotation);
        }

        public void Dropple_Effect_4()
        {
            int OffsetA = 28053;
            double PositionXA = 350;
            double PositionYA = 400;
            double SquareSize = 1.4;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA + 43, 0, .75);
            sprite.Fade(OffsetA + 172, OffsetA + 349, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA + 172, PositionXA, PositionYA, PositionXA, PositionYA);
            sprite.ColorHsb(OffsetA, 220, .3, .9);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetA + 86, RotationSmall, Rotation);

            int OffsetB = OffsetA + 349;
            double PositionXB = PositionXA - 75;
            double PositionYB = PositionYA - 15;
            var spriteB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteB.Fade(OffsetB, OffsetB + 43, 0, .75);
            spriteB.Fade(OffsetB + 172, OffsetB + 349, .75, 0);
            spriteB.Move(OsbEasing.Out, OffsetB, OffsetB + 172, PositionXB, PositionYB, PositionXB, PositionYB);
            spriteB.ColorHsb(OffsetB, 220, .3, .9);
            spriteB.ScaleVec(OsbEasing.Out, OffsetB, OffsetB + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteB.Rotate(OsbEasing.Out, OffsetB, OffsetB + 86, RotationSmall, Rotation);

            int OffsetC = OffsetB + 349;
            double PositionXC = PositionXB - 50;
            double PositionYC = PositionYB + 45;
            var spriteC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteC.Fade(OffsetC, OffsetC + 43, 0, .75);
            spriteC.Fade(OffsetC + 172, OffsetC + 349, .75, 0);
            spriteC.Move(OsbEasing.Out, OffsetC, OffsetC + 172, PositionXC, PositionYC, PositionXC, PositionYC);
            spriteC.ColorHsb(OffsetB, 220, .3, .9);
            spriteC.ScaleVec(OsbEasing.Out, OffsetC, OffsetC + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteC.Rotate(OsbEasing.Out, OffsetC, OffsetC + 86, RotationSmall, Rotation);
        }

        public void Dropple_Effect_5()
        {
            int OffsetA = 29914;
            double PositionXA = 720;
            double PositionYA = 400;
            double SquareSize = 2.4;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA + 43, 0, .75);
            sprite.Fade(OffsetA + 172, OffsetA + 349, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA + 172, PositionXA, PositionYA, PositionXA, PositionYA);
            sprite.ColorHsb(OffsetA, 155, .1, .8);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetA + 86, RotationSmall, Rotation);

            int OffsetB = OffsetA + 349;
            double PositionXB = PositionXA - 75;
            double PositionYB = PositionYA - 15;
            var spriteB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteB.Fade(OffsetB, OffsetB + 43, 0, .75);
            spriteB.Fade(OffsetB + 172, OffsetB + 349, .75, 0);
            spriteB.Move(OsbEasing.Out, OffsetB, OffsetB + 172, PositionXB, PositionYB, PositionXB, PositionYB);
            spriteB.ColorHsb(OffsetA, 155, .1, .8);
            spriteB.ScaleVec(OsbEasing.Out, OffsetB, OffsetB + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteB.Rotate(OsbEasing.Out, OffsetB, OffsetB + 86, RotationSmall, Rotation);

            int OffsetC = OffsetB + 349;
            double PositionXC = PositionXB - 50;
            double PositionYC = PositionYB + 45;
            var spriteC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteC.Fade(OffsetC, OffsetC + 43, 0, .75);
            spriteC.Fade(OffsetC + 172, OffsetC + 349, .75, 0);
            spriteC.Move(OsbEasing.Out, OffsetC, OffsetC + 172, PositionXC, PositionYC, PositionXC, PositionYC);
            spriteC.ColorHsb(OffsetA, 155, .1, .8);
            spriteC.ScaleVec(OsbEasing.Out, OffsetC, OffsetC + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteC.Rotate(OsbEasing.Out, OffsetC, OffsetC + 86, RotationSmall, Rotation);
        }

        public void Dropple_Effect_6()
        {
            int OffsetA = 31774;
            double PositionXA = 300;
            double PositionYA = 400;
            double SquareSize = 2.3;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA + 43, 0, .75);
            sprite.Fade(OffsetA + 172, OffsetA + 349, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA + 172, PositionXA, PositionYA, PositionXA, PositionYA);
            sprite.ColorHsb(OffsetA, 155, .1, .8);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetA + 86, RotationSmall, Rotation);

            int OffsetB = OffsetA + 349;
            double PositionXB = PositionXA - 75;
            double PositionYB = PositionYA - 15;
            var spriteB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteB.Fade(OffsetB, OffsetB + 43, 0, .75);
            spriteB.Fade(OffsetB + 172, OffsetB + 349, .75, 0);
            spriteB.Move(OsbEasing.Out, OffsetB, OffsetB + 172, PositionXB, PositionYB, PositionXB, PositionYB);
            spriteB.ColorHsb(OffsetA, 155, .1, .8);
            spriteB.ScaleVec(OsbEasing.Out, OffsetB, OffsetB + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteB.Rotate(OsbEasing.Out, OffsetB, OffsetB + 86, RotationSmall, Rotation);

            int OffsetC = OffsetB + 349;
            double PositionXC = PositionXB - 50;
            double PositionYC = PositionYB + 45;
            var spriteC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteC.Fade(OffsetC, OffsetC + 43, 0, .75);
            spriteC.Fade(OffsetC + 172, OffsetC + 349, .75, 0);
            spriteC.Move(OsbEasing.Out, OffsetC, OffsetC + 172, PositionXC, PositionYC, PositionXC, PositionYC);
            spriteC.ColorHsb(OffsetA, 155, .1, .8);
            spriteC.ScaleVec(OsbEasing.Out, OffsetC, OffsetC + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteC.Rotate(OsbEasing.Out, OffsetC, OffsetC + 86, RotationSmall, Rotation);
        }

        public void Dropple_Effect_7()
        {
            int OffsetA = 33635;
            double PositionXA = 460;
            double PositionYA = 380;
            double SquareSize = 1.6;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA + 43, 0, .75);
            sprite.Fade(OffsetA + 172, OffsetA + 349, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA + 172, PositionXA, PositionYA, PositionXA, PositionYA);
            sprite.ColorHsb(OffsetA, 220, .3, .9);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetA + 86, RotationSmall, Rotation);

            int OffsetB = OffsetA + 349;
            double PositionXB = PositionXA - 75;
            double PositionYB = PositionYA - 15;
            var spriteB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteB.Fade(OffsetB, OffsetB + 43, 0, .75);
            spriteB.Fade(OffsetB + 172, OffsetB + 349, .75, 0);
            spriteB.Move(OsbEasing.Out, OffsetB, OffsetB + 172, PositionXB, PositionYB, PositionXB, PositionYB);
            spriteB.ColorHsb(OffsetA, 220, .3, .9);
            spriteB.ScaleVec(OsbEasing.Out, OffsetB, OffsetB + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteB.Rotate(OsbEasing.Out, OffsetB, OffsetB + 86, RotationSmall, Rotation);

            int OffsetC = OffsetB + 349;
            double PositionXC = PositionXB - 50;
            double PositionYC = PositionYB + 45;
            var spriteC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteC.Fade(OffsetC, OffsetC + 43, 0, .75);
            spriteC.Fade(OffsetC + 172, OffsetC + 349, .75, 0);
            spriteC.Move(OsbEasing.Out, OffsetC, OffsetC + 172, PositionXC, PositionYC, PositionXC, PositionYC);
            spriteC.ColorHsb(OffsetA, 220, .3, .9);
            spriteC.ScaleVec(OsbEasing.Out, OffsetC, OffsetC + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteC.Rotate(OsbEasing.Out, OffsetC, OffsetC + 86, RotationSmall, Rotation);
        }

        public void Dropple_Effect_8()
        {
            int OffsetA = 35495;
            double PositionXA = 300;
            double PositionYA = 200;
            double SquareSize = 2;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA + 43, 0, .75);
            sprite.Fade(OffsetA + 172, OffsetA + 349, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetA + 172, PositionXA, PositionYA, PositionXA, PositionYA);
            sprite.ColorHsb(OffsetA, 220, .3, .9);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetA + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetA + 86, RotationSmall, Rotation);

            int OffsetB = OffsetA + 349;
            double PositionXB = PositionXA - 75;
            double PositionYB = PositionYA - 15;
            var spriteB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteB.Fade(OffsetB, OffsetB + 43, 0, .75);
            spriteB.Fade(OffsetB + 172, OffsetB + 349, .75, 0);
            spriteB.Move(OsbEasing.Out, OffsetB, OffsetB + 172, PositionXB, PositionYB, PositionXB, PositionYB);
            spriteB.ColorHsb(OffsetA, 220, .3, .9);
            spriteB.ScaleVec(OsbEasing.Out, OffsetB, OffsetB + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteB.Rotate(OsbEasing.Out, OffsetB, OffsetB + 86, RotationSmall, Rotation);

            int OffsetC = OffsetB + 349;
            double PositionXC = PositionXB - 50;
            double PositionYC = PositionYB + 45;
            var spriteC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            spriteC.Fade(OffsetC, OffsetC + 43, 0, .75);
            spriteC.Fade(OffsetC + 172, OffsetC + 349, .75, 0);
            spriteC.Move(OsbEasing.Out, OffsetC, OffsetC + 172, PositionXC, PositionYC, PositionXC, PositionYC);
            spriteC.ColorHsb(OffsetA, 220, .3, .9);
            spriteC.ScaleVec(OsbEasing.Out, OffsetC, OffsetC + 86, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            spriteC.Rotate(OsbEasing.Out, OffsetC, OffsetC + 86, RotationSmall, Rotation);
        }
    }
}
