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
            Post_Intro_Square_7_A();
            Post_Intro_Square_8();
            Post_Intro_Square_9();
            Post_Intro_Square_10();
            Post_Intro_Square_11();
            Post_Intro_Gray_Grid_BG();
            Post_Intro_Cyan_Grid_Square();
            Pre_Chorus_Square_1();
            Pre_Chorus_Square_2();
            Pre_Chorus_Lyric_Square_1();
            Pre_Chorus_Lyric_Square_2();
            Pre_Chorus_Gap_Closer();
            Pre_Chorus_Gap_Line();
            Chorus_S_Square_1();
            Chorus_S_Square_1_Inner();
            Chorus_T_Square_1();
            Chorus_T_Square_2();
            Chorus_S_Square_2();
            Chorus_T_Square_3();
            Chorus_T_Square_4();
            Chorus_S_Square_3();
            Dropple_Effect_9();
            Chorus_S_Square_4();
            Chorus_Line_Square_1();
            Chorus_S_Square_5();
            Chorus_T_Square_5();
            Chorus_S_Square_6();
            Chorus_T_Square_6();
            Chorus_Line_Square_2();
            Chorus_S_Square_7();
            Chorus_S_Square_8();
            Chorus_T_Square_7();
            Chorus_S_Square_9();
            Chorus_T_Square_8();
            Chorus_Spin_Transition_Square();
            Chorus_Transistion_Lines();
            Chorus_Transition_Square();
            Chorus_Transition_Square_Inner();
            Chorus_Spin_Square_1();
            Chorus_T_Square_9();
            Chorus_Spin_Square_2();
            Chorus_T_Square_10();
            Chorus_T_Square_11();
            Chorus_T_Square_12();
            Chorus_T_Square_13();
            Chorus_Spin_Square_3();
            Chorus_Spin_Square_4();
            Chorus_T_Square_14();
            Chorus_T_Square_15();
            Chorus_T_Square_16();
            Chorus_T_Square_17();
            Chorus_S_Square_10();
            Chorus_T_Square_18();
            Chorus_T_Square_19();
            Chorus_Line_Square_3();
            Chorus_T_Square_20();
            Chorus_T_Square_21();
            Chorus_S_Square_11();
            Chorus_T_Square_22();
            Chorus_T_Square_23();
            Chorus_T_Square_24();
            Chorus_T_Square_25();
            Chorus_T_Square_26();
            Chorus_S_Square_12();
            Dropple_Effect(
/* StartTime */     22472,
/* PositionX */     680,
/* PositionY */     235,
/* Scale */         .8,
/* Opacity */       .9,
/* LayerName */     "Dropple 1",
/* Hue */           0,
/* Saturation */    0,
/* Brightness */    100
            );
            Dropple_Effect(
/* StartTime */     24332,
/* PositionX */     100,
/* PositionY */     450,
/* Scale */         .7,
/* Opacity */       .9,
/* LayerName */     "Dropple 2",
/* Hue */           0,
/* Saturation */    0,
/* Brightness */    100
            );
            Dropple_Effect(
/* StartTime */     26193,
/* PositionX */     680,
/* PositionY */     80,
/* Scale */         .65,
/* Opacity */       .9,
/* LayerName */     "Dropple 3",
/* Hue */           220,
/* Saturation */    30,
/* Brightness */    100
            );
            Dropple_Effect(
/* StartTime */     28053,
/* PositionX */     380,
/* PositionY */     400,
/* Scale */         .55,
/* Opacity */       .9,
/* LayerName */     "Dropple 4",
/* Hue */           220,
/* Saturation */    30,
/* Brightness */    100
            );
            Dropple_Effect(
/* StartTime */     29914,
/* PositionX */     720,
/* PositionY */     400,
/* Scale */         .95,
/* Opacity */       .9,
/* LayerName */     "Dropple 5",
/* Hue */           155,
/* Saturation */    10,
/* Brightness */    100
            );
            Dropple_Effect(
/* StartTime */     31774,
/* PositionX */     300,
/* PositionY */     400,
/* Scale */         .9,
/* Opacity */       .9,
/* LayerName */     "Dropple 6",
/* Hue */           155,
/* Saturation */    10,
/* Brightness */    100
            );
            Dropple_Effect(
/* StartTime */     33635,
/* PositionX */     460,
/* PositionY */     380,
/* Scale */         .65,
/* Opacity */       .9,
/* LayerName */     "Dropple 7",
/* Hue */           220,
/* Saturation */    30,
/* Brightness */    100
            );
            Dropple_Effect(
/* StartTime */     35495,
/* PositionX */     300,
/* PositionY */     200,
/* Scale */         .8,
/* Opacity */       .9,
/* LayerName */     "Dropple 8",
/* Hue */           220,
/* Saturation */    30,
/* Brightness */    100
            );
        }

        public string Sprite = "sb/sprites/white.png";
        public string Sprite2 = "sb/sprites/whiteb.png";
        public string Sprite3 = "sb/sprites/whitebs.png";
        public string Sprite4 = "sb/sprites/line.png";
        public double Rotation = Math.PI / 4;
        public double RotationFlipped = -1.25 * Math.PI;
        public double RotationSmall = -0.5 * Math.PI;
        public double RotationMini = 0;

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

        public void Post_Intro_Square_7_A()
        {
            int OffsetA = 39216;
            int OffsetB = 39449;
            int OffsetC = 50379;
            int OffsetD = 50611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);

            sprite.Fade(OffsetA, OffsetB, 0, 1);
            sprite.Fade(OffsetC, OffsetD, 1, 0);

            sprite.Move(OsbEasing.None, OffsetA, OffsetD, 320, 80, 645, 80);
            sprite.ColorHsb(OffsetA, 20, .3, .35);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 7.5, 7.5, 7.5, 7.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, 1.25, 1.25);
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
            sprite.Move(OsbEasing.OutSine, OffsetA, 42937, -300, 100, -25, 100);
            sprite.ColorHsb(OffsetA, 0, .7, .8);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 15, 15, 15, 15);
            sprite.Rotate(OsbEasing.OutSine, OffsetA, 42937, RotationSmall, Rotation);

            int OffsetA2 = 42937;
            int OffsetB2 = 50611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -25, 100, 400, 100);
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
            sprite.Move(OsbEasing.OutSine, OffsetA, 44797, -300, 250, 0, 250);
            sprite.ColorHsb(OffsetA, 185, .5, .7);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            sprite.Rotate(OsbEasing.OutSine, OffsetA, 44797, RotationSmall, Rotation);

            int OffsetA2 = 44797;
            int OffsetB2 = 50611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, 0, 250, 170, 250);
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
            sprite.ColorHsb(OffsetA, 0, .1, .05);
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

        public void Pre_Chorus_Lyric_Square_1()
        {
            int OffsetA = 52239;
            int OffsetAA = 52704;
            int OffsetB = 52937;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ColorHsb(OffsetAA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.In, OffsetA, OffsetB, 5, 25, 5, 20);
        }

        public void Pre_Chorus_Lyric_Square_2()
        {
            int OffsetA = 52937;
            int OffsetAA = 53170;
            int OffsetB = 55263;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.InQuart, OffsetA, OffsetAA, 12.5, 0, 12.5, 35);
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
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 1180, 240, 525, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 86, .15, 86, .15);
        }

        public void Chorus_S_Square_1()
        {
            int OffsetA = 59681;
            int OffsetB = 60611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 460, 160, 875, 160);
            sprite.ColorHsb(OffsetA, 300, 0, .5);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 15, 15, 15, 15);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_1_Inner()
        {
            int OffsetA = 59681;
            int OffsetB = 60611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 460, 160, 875, 160);
            sprite.ColorHsb(OffsetA, 20, .5, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 7.5, 7.5, 7.5, 7.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, -.1, -.1);
        }

        public void Chorus_T_Square_1()
        {
            int OffsetA = 59681;
            int OffsetB = 61542;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .25);
            sprite.Fade(OffsetB, OffsetB, .25, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 350, 20, 890, 20);
            sprite.ColorHsb(OffsetA, 180, .3, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 18, 18, 18, 18);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_2()
        {
            int OffsetA = 59681;
            int OffsetB = 62588;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .25);
            sprite.Fade(OffsetB, OffsetB, .25, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -25, 400, 880, 400);
            sprite.ColorHsb(OffsetA, 180, .3, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 15, 15, 15, 15);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_2()
        {
            int OffsetA = 59681;
            int OffsetAA = 59914;
            int OffsetB = 62704;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, .85);
            sprite.Fade(OffsetB, OffsetB, .85, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -10, 240, 885, 240);
            sprite.ColorHsb(OffsetA, 345, .8, .9);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 16, 16, 16, 16);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_3()
        {
            int OffsetA = 60030;
            int OffsetB = 63867;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .25);
            sprite.Fade(OffsetB, OffsetB, .25, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -185, -35, 830, -35);
            sprite.ColorHsb(OffsetA, 180, .3, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 15, 15, 15, 15);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_4()
        {
            int OffsetA = 60146;
            int OffsetB = 64797;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .25);
            sprite.Fade(OffsetB, OffsetB, .25, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -275, 500, 910, 500);
            sprite.ColorHsb(OffsetA, 180, .3, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 25, 25, 25, 25);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_3()
        {
            int OffsetA = 60379;
            int OffsetAA = 60495;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 375, 200, 725, 200);
            sprite.ColorHsb(OffsetA, 200, .1, .5);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 12.5, 12.5, 12.5, 12.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Dropple_Effect_9()
        {
            int OffsetA = 60379;
            int OffsetAA = 60611;
            int OffsetB = 60844;
            int OffsetBB = 61076;
            double PositionXA = 200;
            double PositionYA = 160;
            double SquareSize = 1.25;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite3, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, .75, .75);
            sprite.Fade(OffsetB, OffsetBB, .75, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetBB, PositionXA, PositionYA, PositionXA + 50, PositionYA);
            sprite.ColorHsb(OffsetA, 180, .4, .9);
            sprite.ScaleVec(OsbEasing.InBack, OffsetA, OffsetAA, SquareSize / 10, SquareSize / 10, SquareSize, SquareSize);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetAA, RotationMini, RotationMini);
            sprite.Rotate(OsbEasing.In, OffsetAA, OffsetBB, RotationMini, Rotation);
        }

        public void Chorus_S_Square_4()
        {
            int OffsetA = 60611;
            int OffsetAA = 60844;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -100, 320, 260, 320);
            sprite.ColorHsb(OffsetA, 200, .3, .8);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 12.5, 12.5, 12.5, 12.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_Line_Square_1()
        {
            int OffsetA = 60960;
            int OffsetAA = 61076;
            int OffsetB = 61309;
            int OffsetBB = 61425;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite4, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, .5);
            sprite.Fade(OffsetB, OffsetBB, .5, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -250, 200, -225, 200);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .75, .75, .75, .75);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);

            var sprite2 = layer.CreateSprite(Sprite4, OsbOrigin.Centre);
            sprite2.Fade(OffsetA, OffsetAA, 0, .5);
            sprite2.Fade(OffsetB, OffsetBB, .5, 0);
            sprite2.Move(OsbEasing.None, OffsetA, OffsetB, 280, 200, 305, 200);
            sprite2.ColorHsb(OffsetA, 0, 0, 0);
            sprite2.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .75, .75, .75, .75);
            sprite2.Rotate(OsbEasing.None, OffsetA, OffsetA, -Rotation, -Rotation);
        }

        public void Chorus_S_Square_5()
        {
            int OffsetA = 60960;
            int OffsetAA = 61076;
            int OffsetB = 63402;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, .8);
            sprite.Fade(OffsetB, OffsetB, .8, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 0, 100, 900, 100);
            sprite.ColorHsb(OffsetA, 330, .6, .9);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_5()
        {
            int OffsetA = 61076;
            int OffsetB = 64565;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .25);
            sprite.Fade(OffsetB, OffsetB, .25, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -180, 200, 830, 200);
            sprite.ColorHsb(OffsetA, 180, .3, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 10, 10, 10, 10);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_6()
        {
            int OffsetA = 62356;
            int OffsetAA = 62472;
            int OffsetB = 65728;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, .8);
            sprite.Fade(OffsetB, OffsetB, .8, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 160, 350, 860, 350);
            sprite.ColorHsb(OffsetA, 200, .9, .9);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 13.5, 13.5, 13.5, 13.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_6()
        {
            int OffsetA = 61425;
            int OffsetB = 65728;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .25);
            sprite.Fade(OffsetB, OffsetB, .25, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -240, 310, 885, 310);
            sprite.ColorHsb(OffsetA, 180, .3, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 18.5, 18.5, 18.5, 18.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_Line_Square_2()
        {
            int OffsetA = 64565;
            int OffsetB = 65844;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite4, OsbOrigin.Centre);
            sprite.Fade(62239, 62239, .75, .75);
            sprite.Fade(63518, 63518, .75, 0);
            sprite.Move(OsbEasing.None, 62239, 63518, -350, 240, 1015, 240);
            sprite.ColorHsb(62239, 265, .2, .4);
            sprite.ScaleVec(OsbEasing.None, 62239, 62239, 1.5, 1.5, 1.5, 1.5);
            sprite.Rotate(OsbEasing.None, 62239, 62239, -Rotation, -Rotation);

            var sprite2 = layer.CreateSprite(Sprite4, OsbOrigin.Centre);
            sprite2.Fade(OffsetA, OffsetA, .75, .75);
            sprite2.Fade(OffsetB, OffsetB, .75, 0);
            sprite2.Move(OsbEasing.None, OffsetA, OffsetB, -350, 240, 1015, 240);
            sprite2.ColorHsb(OffsetA, 265, .2, .4);
            sprite2.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 1.5, 1.5, 1.5, 1.5);
            sprite2.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_7()
        {
            int OffsetA = 61542;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -195, 240, 0, 240);
            sprite.ColorHsb(OffsetA, 200, .1, .5);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 13.5, 13.5, 13.5, 13.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_8()
        {
            int OffsetA = 62704;
            int OffsetAA = 62937;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, .9);
            sprite.Fade(OffsetB, OffsetB, .9, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -50, 130, 800, 130);
            sprite.ColorHsb(OffsetA, 115, .8, .8);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_7()
        {
            int OffsetA = 62588;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .25);
            sprite.Fade(OffsetB, OffsetB, .25, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -335, 50, 690, 50);
            sprite.ColorHsb(OffsetA, 180, .3, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 32.5, 32.5, 32.5, 32.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_9()
        {
            int OffsetA = 65030;
            int OffsetAA = 65263;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, .9);
            sprite.Fade(OffsetB, OffsetB, .9, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 0, 175, 400, 175);
            sprite.ColorHsb(OffsetA, 270, .7, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_8()
        {
            int OffsetA = 65379;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .25);
            sprite.Fade(OffsetB, OffsetB, .25, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -250, 400, 0, 400);
            sprite.ColorHsb(OffsetA, 180, .3, .6);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 20, 20, 20, 20);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_Spin_Transition_Square()
        {
            int OffsetA = 66193;
            int OffsetB = 66658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -800, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, .1, .15);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetB, 100, 100, 100, 100);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, -1, 0);
        }

        public void Chorus_Transition_Square()
        {
            int OffsetA = 73402;
            int OffsetB = 74100;
            int OffsetC = 74332;
            int OffsetD = 75263;
            int OffsetE = 73867;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetD, OffsetD, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.Move(OsbEasing.In, OffsetC, OffsetD, 320, 240, 1280, 240);
            sprite.ColorHsb(OffsetA, 0, .1, .15);
            sprite.ColorHsb(OffsetE, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetB, 95, 95, 75, 75);
            sprite.ScaleVec(OsbEasing.None, OffsetC, OffsetD, 75, 75, 75, 75);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
            sprite.Rotate(OsbEasing.In, OffsetC, OffsetD, Rotation, -RotationFlipped);
        }

        public void Chorus_Transition_Square_Inner()
        {
            int OffsetA = 73402;
            int OffsetB = 73867;
            int OffsetC = 74332;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite3, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .5);
            sprite.Fade(OffsetB, OffsetC, .5, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, .85);
            sprite.ColorHsb(OffsetB, 0, 0, .5);
            sprite.ScaleVec(OsbEasing.InOutExpo, OffsetA, OffsetB, 0, 0, 2.25, 2.25);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_Spin_Square_1()
        {
            int OffsetA = 73402;
            int OffsetB = 74100;
            int OffsetC = 75379;
            int OffsetD = 75960;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .8);
            sprite.Fade(OffsetD, OffsetD, .8, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, 25, 320, 25, 320);
            sprite.Move(OsbEasing.In, OffsetC, OffsetD, 25, 320, 930, 320);
            sprite.ColorHsb(OffsetA, 232, .6, .8);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, 25, 25, 25, 25);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
            sprite.Rotate(OsbEasing.In, OffsetC, OffsetD, Rotation, -RotationFlipped);
        }

        public void Chorus_T_Square_9()
        {
            int OffsetA = 74565;
            int OffsetB = 75728;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .025);
            sprite.Fade(OffsetB, OffsetB, .025, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -250, 300, 900, 300);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 20, 20, 20, 20);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_Spin_Square_2()
        {
            int OffsetA = 74565;
            int OffsetB = 75263;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .9);
            sprite.Fade(OffsetB, OffsetB, .9, 0);
            sprite.Move(OsbEasing.In, OffsetA, OffsetB, -210, 280, 940, 280);
            sprite.ColorHsb(OffsetA, 140, .2, .9);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetB, 14, 14, 14, 14);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, -RotationFlipped);
        }

        public void Chorus_T_Square_10()
        {
            int OffsetA = 74565;
            int OffsetB = 76193;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .025);
            sprite.Fade(OffsetB, OffsetB, .025, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -475, 0, 1100, 0);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 40, 40, 40, 40);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_11()
        {
            int OffsetA = 75263;
            int OffsetB = 76890;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .025);
            sprite.Fade(OffsetB, OffsetB, .025, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -400, 100, 1020, 100);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 35, 35, 35, 35);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_12()
        {
            int OffsetA = 75611;
            int OffsetB = 77472;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .025);
            sprite.Fade(OffsetB, OffsetB, .025, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -450, 400, 1110, 400);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 47.5, 47.5, 47.5, 47.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_13()
        {
            int OffsetA = 76425;
            int OffsetB = 77588;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .025);
            sprite.Fade(OffsetB, OffsetB, .025, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -200, 480, 860, 480);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 12.5, 12.5, 12.5, 12.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_Spin_Square_3()
        {
            int OffsetA = 75960;
            int OffsetB = 76425;
            int OffsetC = 77123;
            int OffsetD = 77588;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .8);
            sprite.Fade(OffsetD, OffsetD, .8, 0);
            sprite.Move(OsbEasing.Out, OffsetA, OffsetB, -270, 480, 25, 220);
            sprite.Move(OsbEasing.In, OffsetC, OffsetD, 25, 220, 1015, 400);
            sprite.ColorHsb(OffsetA, 185, .9, .7);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, 22.5, 22.5, 22.5, 22.5);
            sprite.Rotate(OsbEasing.Out, OffsetA, OffsetB, -Rotation, Rotation);
            sprite.Rotate(OsbEasing.In, OffsetC, OffsetD, Rotation, -RotationFlipped);
        }

        public void Chorus_Spin_Square_4()
        {
            int OffsetA = 76193;
            int OffsetB = 76774;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .9);
            sprite.Fade(OffsetB, OffsetB, .9, 0);
            sprite.Move(OsbEasing.In, OffsetA, OffsetB, -210, 230, 940, 230);
            sprite.ColorHsb(OffsetA, 0, 0, .95);
            sprite.ScaleVec(OsbEasing.Out, OffsetA, OffsetB, 16.5, 16.5, 16.5, 16.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, Rotation, -RotationFlipped);
        }

        public void Chorus_T_Square_14()
        {
            int OffsetA = 76890;
            int OffsetB = 77588;
            int OffsetC = 77472;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .025);
            sprite.Fade(OffsetB, OffsetB, .025, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -220, 0, 220, 0);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 15, 15, 15, 15);
            sprite.ScaleVec(OsbEasing.None, OffsetC, OffsetB, 15, 15, 27.5, 27.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_15()
        {
            int OffsetA = 77239;
            int OffsetB = 77588;
            int OffsetC = 77472;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .025);
            sprite.Fade(OffsetB, OffsetB, .025, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -220, 480, -75, 400);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 10, 10, 10, 10);
            sprite.ScaleVec(OsbEasing.None, OffsetC, OffsetB, 10, 10, 22.5, 22.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_16()
        {
            int OffsetA = 77588;
            int OffsetB = 80030;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .05);
            sprite.Fade(OffsetB, OffsetB, .05, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 220, 0, 950, 0);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 27.5, 27.5, 27.5, 27.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_17()
        {
            int OffsetA = 77588;
            int OffsetB = 80960;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .05);
            sprite.Fade(OffsetB, OffsetB, .05, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -75, 400, 915, 400);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 22.5, 22.5, 22.5, 22.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_10()
        {
            int OffsetA = 77588;
            int OffsetAA = 77821;
            int OffsetB = 80960;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, 100, 240, 880, 240);
            sprite.ColorHsb(OffsetA, 223, .6, .7);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 17.5, 17.5, 17.5, 17.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_18()
        {
            int OffsetA = 78751;
            int OffsetB = 82007;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .1);
            sprite.Fade(OffsetB, OffsetB, .1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -160, 0, 810, 0);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 7.5, 7.5, 7.5, 7.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_19()
        {
            int OffsetA = 78983;
            int OffsetB = 81774;
            int OffsetC = 82007;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .125);
            sprite.Fade(OffsetB, OffsetC, .125, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -220, 480, 680, 480);
            sprite.Move(OsbEasing.None, OffsetB, OffsetC, 680, 480, 860, 750);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, 30, 30, 30, 30);
            sprite.ScaleVec(OsbEasing.None, OffsetB, OffsetC, 30, 30, 45, 45);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_Line_Square_3()
        {
            int OffsetA = 79681;
            int OffsetB = 81542;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite4, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, .75, .75);
            sprite.Fade(OffsetB, OffsetB, .75, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -350, 240, 1015, 240);
            sprite.ColorHsb(OffsetA, 265, .2, .4);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, 1.5, 1.5, 1.5, 1.5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, -Rotation, -Rotation);
        }

        public void Chorus_T_Square_20()
        {
            int OffsetA = 79681;
            int OffsetB = 81774;
            int OffsetC = 82007;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .15);
            sprite.Fade(OffsetB, OffsetC, .15, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -220, 140, 700, 140);
            sprite.Move(OsbEasing.None, OffsetB, OffsetC, 700, 140, 860, -100);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, 12.5, 12.5, 12.5, 12.5);
            sprite.ScaleVec(OsbEasing.None, OffsetB, OffsetC, 12.5, 12.5, 25, 25);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_21()
        {
            int OffsetA = 80146;
            int OffsetB = 81774;
            int OffsetC = 82007;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .175);
            sprite.Fade(OffsetB, OffsetC, .175, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -255, 280, 360, 280);
            sprite.Move(OsbEasing.None, OffsetB, OffsetC, 360, 280, 400, 100);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, 20, 20, 20, 20);
            sprite.ScaleVec(OsbEasing.None, OffsetB, OffsetC, 20, 20, 50, 50);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_11()
        {
            int OffsetA = 80728;
            int OffsetAA = 81076;
            int OffsetB = 81774;
            int OffsetBB = 82007;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetBB, OffsetBB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -200, 140, 260, 140);
            sprite.Move(OsbEasing.None, OffsetB, OffsetBB, 260, 100, 300, -100);
            sprite.ColorHsb(OffsetA, 180, .7, .7);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, 17.5, 17.5, 17.5, 17.5);
            sprite.ScaleVec(OsbEasing.None, OffsetB, OffsetBB, 17.5, 17.5, 35, 35);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_22()
        {
            int OffsetA = 81542;
            int OffsetB = 81774;
            int OffsetC = 82007;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, .2);
            sprite.Fade(OffsetB, OffsetC, .2, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, -180, 0, 0, 0);
            sprite.Move(OsbEasing.None, OffsetB, OffsetC, 0, 0, 100, -200);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, 10, 10, 10, 10);
            sprite.ScaleVec(OsbEasing.None, OffsetB, OffsetC, 10, 10, 20, 20);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_23()
        {
            int OffsetA = 81774;
            int OffsetB = 82007;
            int OffsetC = 83635;
            int OffsetD = 83867;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetB, 0, .15);
            sprite.Fade(OffsetC, OffsetD, .15, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetD, 180, 400, 800, 400);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetD, 25, 25, 25, 25);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_24()
        {
            int OffsetA = 81774;
            int OffsetB = 82007;
            int OffsetC = 82937;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetB, 0, .15);
            sprite.Fade(OffsetC, OffsetC, .15, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 500, 0, 830, 0);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, 10, 10, 10, 10);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_25()
        {
            int OffsetA = 82239;
            int OffsetB = 83635;
            int OffsetC = 83867;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetB, 0, .15);
            sprite.Fade(OffsetB, OffsetC, .15, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, -330, 480, 260, 480);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, 30, 30, 30, 30);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_T_Square_26()
        {
            int OffsetA = 83170;
            int OffsetB = 83635;
            int OffsetC = 83867;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetB, 0, .15);
            sprite.Fade(OffsetB, OffsetC, .15, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, -200, 30, 50, 30);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, 10, 10, 10, 10);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
        }

        public void Chorus_S_Square_12()
        {
            int OffsetA = 83635;
            int OffsetAA = 83867;
            int OffsetB = 85728;
            int OffsetBB = 89332;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetBB, 1, 0);
            sprite.Move(OsbEasing.In, OffsetA, OffsetAA, 320, -100, 320, 200);
            sprite.Move(OsbEasing.None, OffsetAA, OffsetB, 320, 200, 320, 240);
            sprite.ColorHsb(OffsetA, 20, .3, .35);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, 35, 35, 35, 35);
            sprite.ScaleVec(OsbEasing.None, OffsetB, OffsetBB, 35, 35, 0, 0);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetA, Rotation, Rotation);
            sprite.Rotate(OsbEasing.Out, OffsetB, OffsetBB, Rotation, -RotationFlipped);
        }

        public void Chorus_Transistion_Lines()
        {
            int OffsetA = 70263;
            int OffsetB = 70728;
            int OffsetC = 71193;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetC, OffsetC, 1, 0);
            sprite.Move(OsbEasing.In, OffsetA, OffsetA, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, .9);
            sprite.ColorHsb(OffsetB, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, .1, 5, .1, 20);
            sprite.ScaleVec(OsbEasing.None, OffsetB, OffsetC, .1, 15, .1, 7.5);

            var sprite2 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite2.Fade(OffsetA, OffsetA, 0, 1);
            sprite2.Fade(OffsetC, OffsetC, 1, 0);
            sprite2.Move(OsbEasing.In, OffsetA, OffsetB, 200, 240, 180, 200);
            sprite2.Move(OsbEasing.In, OffsetB, OffsetC, 240, 200, 240, 240);
            sprite2.ColorHsb(OffsetA, 0, 0, .9);
            sprite2.ColorHsb(OffsetB, 0, 0, 0);
            sprite2.ScaleVec(OsbEasing.None, OffsetA, OffsetB, .05, 5, .05, 10);
            sprite2.ScaleVec(OsbEasing.None, OffsetB, OffsetC, .05, 7.5, .05, 3.75);

            var sprite3 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite3.Fade(OffsetA, OffsetA, 0, 1);
            sprite3.Fade(OffsetC, OffsetC, 1, 0);
            sprite3.Move(OsbEasing.In, OffsetA, OffsetB, 460, 240, 480, 280);
            sprite3.Move(OsbEasing.In, OffsetB, OffsetC, 400, 280, 400, 240);
            sprite3.ColorHsb(OffsetA, 0, 0, .9);
            sprite3.ColorHsb(OffsetB, 0, 0, 0);
            sprite3.ScaleVec(OsbEasing.None, OffsetA, OffsetB, .05, 5, .05, 10);
            sprite3.ScaleVec(OsbEasing.None, OffsetB, OffsetC, .05, 7.5, .05, 3.75);

            var sprite4 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite4.Fade(OffsetB, OffsetB, 0, 1);
            sprite4.Fade(OffsetC, OffsetC, 1, 0);
            sprite4.Move(OsbEasing.In, OffsetB, OffsetC, 160, 260, 160, 240);
            sprite4.ColorHsb(OffsetB, 0, 0, 0);
            sprite4.ScaleVec(OsbEasing.None, OffsetB, OffsetC, .05, 5, .05, 2.5);

            var sprite5 = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite5.Fade(OffsetB, OffsetB, 0, 1);
            sprite5.Fade(OffsetC, OffsetC, 1, 0);
            sprite5.Move(OsbEasing.In, OffsetB, OffsetC, 480, 220, 480, 240);
            sprite5.ColorHsb(OffsetB, 0, 0, 0);
            sprite5.ScaleVec(OsbEasing.None, OffsetB, OffsetC, .05, 5, .05, 2.5);
        }

        public void Dropple_Effect(
            int StartTime,
            double PositionX,
            double PositionY,
            double Scale,
            double Opacity,
            string LayerName,
            double Hue,
            double Saturation,
            double Brightness
            )
        {
            /* static variables */
            int Beat_1_16 = 29; // 1/16 = 29ms
            int Beat_1_8 = Beat_1_16 * 2;
            int Beat_1_4 = Beat_1_8 * 2;
            int Beat_1_2 = Beat_1_4 * 2;
            int Beat_1_1 = Beat_1_2 * 2;

            // position of last two dropples
            double PositionX_B = PositionX - 75;
            double PositionY_B = PositionY - 15;
            double PositionX_C = PositionX_B - 50;
            double PositionY_C = PositionY_B + 45;

            // convert to decimal scale
            double SaturationConv = Saturation / 100;
            double BrightnessConv = Brightness / 100;

            // create sprites
            var layer = GetLayer(LayerName);
            var droppleA = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            var droppleB = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            var droppleC = layer.CreateSprite(Sprite2, OsbOrigin.Centre);

            // global offset
            int Offset = -3 * Beat_1_4;

            // sprite manipulation
            // first dropple
            int StartTimeA = StartTime + Offset;
            droppleA.Fade(StartTimeA, StartTimeA + Beat_1_2, 0, Opacity);
            droppleA.Fade(StartTimeA + Beat_1_1, StartTimeA + Beat_1_2 * 3, Opacity, 0);
            droppleA.Move(StartTimeA, PositionX, PositionY);
            droppleA.ColorHsb(StartTimeA, Hue, SaturationConv, BrightnessConv);
            droppleA.ScaleVec(OsbEasing.In, StartTimeA, StartTimeA + 3 * Beat_1_4, Scale / 10, Scale / 10, Scale, Scale);
            droppleA.Rotate(OsbEasing.Out, StartTimeA + 3 * Beat_1_4, StartTimeA + 5 * Beat_1_4, RotationMini, Rotation);

            // second dropple
            int StartTimeB = StartTimeA + 3 * Beat_1_4;
            droppleB.Fade(StartTimeB, StartTimeB + Beat_1_2, 0, Opacity);
            droppleB.Fade(StartTimeB + Beat_1_1, StartTimeB + Beat_1_2 * 3, Opacity, 0);
            droppleB.Move(StartTimeB, PositionX_B, PositionY_B);
            droppleB.ColorHsb(StartTimeB, Hue, SaturationConv, BrightnessConv);
            droppleB.ScaleVec(OsbEasing.In, StartTimeB, StartTimeB + 3 * Beat_1_4, Scale / 10, Scale / 10, Scale, Scale);
            droppleB.Rotate(OsbEasing.Out, StartTimeB + 3 * Beat_1_4, StartTimeB + 5 * Beat_1_4, RotationMini, Rotation);

            // third dropple
            int StartTimeC = StartTimeB + 3 * Beat_1_4;
            droppleC.Fade(StartTimeC, StartTimeC + Beat_1_2, 0, Opacity);
            droppleC.Fade(StartTimeC + Beat_1_1, StartTimeC + Beat_1_2 * 3, Opacity, 0);
            droppleC.Move(StartTimeC, PositionX_C, PositionY_C);
            droppleC.ColorHsb(StartTimeC, Hue, SaturationConv, BrightnessConv);
            droppleC.ScaleVec(OsbEasing.In, StartTimeC, StartTimeC + 3 * Beat_1_4, Scale / 10, Scale / 10, Scale, Scale);
            droppleC.Rotate(OsbEasing.Out, StartTimeC + 3 * Beat_1_4, StartTimeC + 5 * Beat_1_4, RotationMini, Rotation);
        }
    }
}