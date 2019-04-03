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
    public class Lyrics : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            mjk();
            mju();
            srd();
            utkskar();
            kwk();
            w();
            amk();
            kwkwamk();
            e_no();
            e_des();
            e_ti();
            e_ny();
            fswskni();
            knnnj();
            kt();
            mntrni();
            kri();
            kttkb();
            umkik();
            mnknaikt();
            mujkknj();
            akt();
            ksk();
            ksk_2();
            nngsnnfmnnnd();
            snznwgmm();
            kttit();
            krijhknnngir();
            snntkrmwrtk();
        }

        public string Path = "sb/lyrics/";

        public void mjk()
        {
            string Lyric = "mijuku";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 1597;
            int OffsetAA = 1955;
            int OffsetB = 7305;
            int OffsetBB = 7773;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetBB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetBB, 600, 85, 600, 125);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetBB, .5, .5, .5, .5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetBB, 0, 0);
        }

        public void mju()
        {
            string Lyric = "mujou";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 3359;
            int OffsetAA = 3718;
            int OffsetB = 7305;
            int OffsetBB = 7773;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetBB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetBB, 550, 190, 550, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetBB, .5, .5, .5, .5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetBB, 0, 0);
        }

        public void srd()
        {
            string Lyric = "saredo";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 5114;
            int OffsetAA = 5438;
            int OffsetB = 7305;
            int OffsetBB = 7773;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetBB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetBB, 105, 75, 105, 125);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetBB, .4, .4, .4, .4);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetBB, 0, 0);
        }

        public void utkskar()
        {
            string Lyric = "utsukushikuare";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 7774;
            int OffsetAA = 8662;
            int OffsetB = 11551;
            int OffsetBB = 14565;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetBB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetBB, 320, 240, 320, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetBB, .4, .4, .5, .5);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetBB, 0, 0);
        }

        public void kwk()
        {
            string Lyric = "kawaki";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 15030;
            int OffsetB = 16890;
            double PosX = 120;
            double PosY = 240;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, PosX, PosY, PosX, PosY);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, .3, .3, .3, .3);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, 0, 0);
        }

        public void w()
        {
            string Lyric = "wo";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 16890;
            int OffsetB = 18751;
            double PosX = 320;
            double PosY = 240;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, PosX, PosY, PosX, PosY);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, .3, .3, .3, .3);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, 0, 0);
        }

        public void amk()
        {
            string Lyric = "ameku";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 18751;
            int OffsetB = 20611;
            double PosX = 520;
            double PosY = 240;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetB, PosX, PosY, PosX, PosY);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetB, .3, .3, .3, .3);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, 0, 0);
        }

        public void kwkwamk()
        {
            string Lyric = "kawakiwoameku";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 20611;
            int OffsetB = 23635;
            double PosX = 320;
            double PosY = 240;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetB, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetA, PosX, PosY, PosX, PosY);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .45, .45, .45, .45);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetB, 0, 0);

            int OffsetA2 = 21542;
            int OffsetB2 = 22239;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, 320, 240, 650, 240);
            sprite.ScaleVec(OsbEasing.In, OffsetA2, OffsetB2, .45, .45, .15, .15);

            int OffsetA3 = 22239;
            int OffsetB3 = 24681;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 650, 240, 850, 240);
        }

        public void e_no()
        {
            string Lyric = "en_no";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 22239;
            int OffsetAA = 22472;
            int OffsetB = 24797;
            int OffsetC = 25030;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetAA, -360, 200, -30, 200);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .55, .55, .55, .55);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
            sprite.Move(OsbEasing.None, OffsetAA, OffsetC, -30, 200, 300, 200);
        }

        public void e_des()
        {
            string Lyric = "en_des";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 22472;
            int OffsetAA = 22704;
            int OffsetB = 24797;
            int OffsetC = 25030;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 80, 200, 410, 200);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .55, .55, .55, .55);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void e_ti()
        {
            string Lyric = "en_ti";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 22821;
            int OffsetAA = 23053;
            int OffsetB = 24797;
            int OffsetC = 25030;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 190, 200, 475, 200);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .55, .55, .55, .55);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void e_ny()
        {
            string Lyric = "en_ny";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 23170;
            int OffsetAA = 23402;
            int OffsetB = 24797;
            int OffsetC = 25030;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 285, 200, 525, 200);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .55, .55, .55, .55);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void fswskni()
        {
            string Lyric = "fusawashikunai";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 23635;
            int OffsetAA = 23867;
            int OffsetB = 24797;
            int OffsetC = 25030;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 240, 280, 420, 280);
            sprite.ColorHsb(OffsetA, 0, 0, 0);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .3, .3, .3, .3);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void knnnj()
        {
            string Lyric = "konnanja";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 25960;
            int OffsetAA = 26193;
            int OffsetB = 29449;
            int OffsetC = 29681;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(OffsetA, OffsetAA, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 300, 240, 600, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .4, .4, .4, .4);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void kt()
        {
            string Lyric = "kitto";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 25960;
            int OffsetB = 29449;
            int OffsetC = 29681;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(26425, 26658, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 300, 240, 600, 240);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .4, .4, .4, .4);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void mntrni()
        {
            string Lyric = "monotarinai";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 25960;
            int OffsetB = 29449;
            int OffsetC = 29681;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(26890, 27123, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 0, 320, 300, 320);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .3, .3, .3, .3);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void kri()
        {
            string Lyric = "kurai";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 25960;
            int OffsetB = 29449;
            int OffsetC = 29681;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(27588, 27821, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, -200, 300, 150, 300);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .3, .3, .3, .3);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void kttkb()
        {
            string Lyric = "kattatokeba";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 25960;
            int OffsetB = 29449;
            int OffsetC = 29681;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(27821, 28053, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, -240, 360, 110, 360);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .3, .3, .3, .3);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void umkik()
        {
            string Lyric = "umakuiku";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 25960;
            int OffsetB = 29449;
            int OffsetC = 29681;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(28518, 28751, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, OffsetC, -300, 320, 50, 320);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetC, .3, .3, .3, .3);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);
        }

        public void mnknaikt()
        {
            string Lyric = "monokaneaikoto";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 28751;
            int OffsetB = 36425;
            int OffsetC = 36658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(29681, 29914, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, 29681, -700, -50, -350, -50);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, 29681, 29681, 1, 1, 1, 1);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);

            int OffsetA2 = 29681;
            int OffsetB2 = 30611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -350, -50, 140, 140);
            sprite.ScaleVec(OsbEasing.Out, OffsetA2, OffsetB2, 1, 1, .6, .6);

            int OffsetA3 = 30611;
            int OffsetB3 = 36658;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, 140, 140, 790, 140);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, .6, .6, .6, .6);
        }

        public void mujkknj()
        {
            string Lyric = "moujikokenji";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 28751;
            int OffsetB = 36425;
            int OffsetC = 36658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(31774, 32007, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, 29681, -1050, 50, -700, 50);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, 29681, 29681, 1, 1, 1, 1);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);

            int OffsetA2 = 29681;
            int OffsetB2 = 30611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -700, 50, -210, 240);
            sprite.ScaleVec(OsbEasing.Out, OffsetA2, OffsetB2, .6, .6, .6, .6);

            int OffsetA3 = 30611;
            int OffsetB3 = 36658;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, -210, 240, 440, 240);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, .6, .6, .6, .6);
        }

        public void akt()
        {
            string Lyric = "akita";
            string Sprite = Path + Lyric + ".png";
            int OffsetA = 28751;
            int OffsetB = 36425;
            int OffsetC = 36658;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            sprite.Fade(33518, 33635, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite.Move(OsbEasing.None, OffsetA, 29681, -1050, 50, -700, 50);
            sprite.ColorHsb(OffsetA, 0, 0, 1);
            sprite.ScaleVec(OsbEasing.None, 29681, 29681, 1, 1, 1, 1);
            sprite.Rotate(OsbEasing.None, OffsetA, OffsetC, 0, 0);

            int OffsetA2 = 29681;
            int OffsetB2 = 30611;
            sprite.Move(OsbEasing.None, OffsetA2, OffsetB2, -700, 50, -210, 240);
            sprite.ScaleVec(OsbEasing.Out, OffsetA2, OffsetB2, .6, .6, .6, .6);

            int OffsetA3 = 30611;
            int OffsetB3 = 36658;
            sprite.Move(OsbEasing.None, OffsetA3, OffsetB3, -210, 240, 440, 240);
            sprite.ScaleVec(OsbEasing.None, OffsetA3, OffsetB3, .6, .6, .6, .6);
        }

        public void ksk()
        {
            string Lyric = "ki";
            string Lyric2 = "shi_k";
            string Lyric3 = "kan";
            string Lyric4 = "dejabu";

            string Sprite = Path + Lyric + ".png";
            string Sprite2 = Path + Lyric2 + ".png";
            string Sprite3 = Path + Lyric3 + ".png";
            string Sprite4 = Path + Lyric4 + ".png";

            int OffsetA = 37123;
            int OffsetB = 37356;
            int OffsetC = 38053;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            var sprite2 = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            var sprite3 = layer.CreateSprite(Sprite3, OsbOrigin.Centre);
            var sprite4 = layer.CreateSprite(Sprite4, OsbOrigin.Centre);

            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetC, OffsetC, 1, 0);
            sprite2.Fade(OffsetA, OffsetA, 0, 1);
            sprite2.Fade(OffsetC, OffsetC, 1, 0);
            sprite3.Fade(OffsetA, OffsetA, 0, 1);
            sprite3.Fade(OffsetC, OffsetC, 1, 0);
            sprite4.Fade(OffsetA, OffsetA, 0, 1);
            sprite4.Fade(OffsetC, OffsetC, 1, 0);

            sprite.Move(OsbEasing.Out, OffsetA, OffsetB, 140, 100, 160, 100);
            sprite2.Move(OsbEasing.Out, OffsetA, OffsetB, 460, 100, 480, 100);
            sprite3.Move(OsbEasing.None, OffsetA, OffsetB, 160, 400, 160, 400);
            sprite4.Move(OsbEasing.None, OffsetA, OffsetB, 480, 400, 480, 400);
            sprite4.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .5, .5, .5, .5);
        }

        public void ksk_2()
        {
            string Lyric = "ki";
            string Lyric2 = "shi_k";
            string Lyric3 = "kan";
            string Lyric4 = "dejabu2";

            string Sprite = Path + Lyric + ".png";
            string Sprite2 = Path + Lyric2 + ".png";
            string Sprite3 = Path + Lyric3 + ".png";
            string Sprite4 = Path + Lyric4 + ".png";

            int OffsetA = 38053;
            int OffsetB = 50379;
            int OffsetC = 50611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            var sprite2 = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            var sprite3 = layer.CreateSprite(Sprite3, OsbOrigin.Centre);
            var sprite4 = layer.CreateSprite(Sprite4, OsbOrigin.Centre);

            sprite.Fade(OffsetA, OffsetA, 0, 1);
            sprite.Fade(OffsetB, OffsetC, 1, 0);
            sprite2.Fade(OffsetA, OffsetA, 0, 1);
            sprite2.Fade(OffsetB, OffsetC, 1, 0);
            sprite3.Fade(OffsetA, OffsetA, 0, 1);
            sprite3.Fade(OffsetB, OffsetC, 1, 0);
            sprite4.Fade(OffsetA, OffsetA, 0, 1);
            sprite4.Fade(OffsetB, OffsetC, 1, 0);

            sprite.Move(OsbEasing.None, OffsetA, OffsetC, 415, 190, 700, 190);
            sprite2.Move(OsbEasing.None, OffsetA, OffsetC, 415, 230, 700, 230);
            sprite3.Move(OsbEasing.None, OffsetA, OffsetC, 415, 270, 700, 270);
            sprite4.Move(OsbEasing.None, OffsetA, OffsetC, 440, 230, 725, 230);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .35, .35, .35, .35);
            sprite2.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .35, .35, .35, .35);
            sprite3.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .35, .35, .35, .35);
            sprite4.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .15, .15, .15, .15);
        }

        public void nngsnnfmnnnd()
        {
            string Lyric = "nanigasonnafumannanda";

            string Sprite = Path + Lyric + ".png";

            int OffsetA = 39216;
            int OffsetB = 39449;
            int OffsetC = 50379;
            int OffsetD = 50611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);

            sprite.Fade(OffsetA, OffsetB, 0, 1);
            sprite.Fade(OffsetC, OffsetD, 1, 0);

            sprite.Move(OsbEasing.None, OffsetA, OffsetD, 240, 120, 565, 120);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .175, .175, .175, .175);
        }

        public void snznwgmm()
        {
            string Lyric = "sanzanwagamama";

            string Sprite = Path + Lyric + ".png";

            int OffsetA = 40379;
            int OffsetB = 40611;
            int OffsetC = 50379;
            int OffsetD = 50611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);

            sprite.Fade(OffsetA, OffsetB, 0, 1);
            sprite.Fade(OffsetC, OffsetD, 1, 0);

            sprite.Move(OsbEasing.None, OffsetA, OffsetD, 195, 275, 420, 275);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .2, .2, .2, .2);
        }

        public void kttit()
        {
            string Lyric = "katattoite";

            string Sprite = Path + Lyric + ".png";

            int OffsetA = 40379;
            int OffsetB = 40611;
            int OffsetC = 50379;
            int OffsetD = 50611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);

            sprite.Fade(OffsetB, 40844, 0, 1);
            sprite.Fade(OffsetC, OffsetD, 1, 0);

            sprite.Move(OsbEasing.None, OffsetA, OffsetD, 145, 275, 370, 275);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .175, .175, .175, .175);
        }

        public void krijhknnngir()
        {
            string Lyric = "kore";
            string Lyric2 = "ijou";
            string Lyric3 = "hokaninanigairu";

            string Sprite = Path + Lyric + ".png";
            string Sprite2 = Path + Lyric2 + ".png";
            string Sprite3 = Path + Lyric3 + ".png";

            int OffsetA = 42704;
            int OffsetB = 42937;
            int OffsetC = 43170;
            int OffsetD = 43402;
            int OffsetE = 50379;
            int OffsetF = 50611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            var sprite2 = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            var sprite3 = layer.CreateSprite(Sprite3, OsbOrigin.Centre);

            sprite.Fade(OffsetA, OffsetB, 0, 1);
            sprite.Fade(OffsetE, OffsetF, 1, 0);
            sprite2.Fade(OffsetB, OffsetC, 0, 1);
            sprite2.Fade(OffsetE, OffsetF, 1, 0);
            sprite3.Fade(OffsetC, OffsetD, 0, 1);
            sprite3.Fade(OffsetE, OffsetF, 1, 0);

            sprite.Move(OsbEasing.None, OffsetB, OffsetF, 10, 90, 435, 90);
            sprite2.Move(OsbEasing.None, OffsetB, OffsetF, -60, 90, 365, 90);
            sprite3.Move(OsbEasing.None, OffsetB, OffsetF, -25, 100, 400, 100);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .175, .175, .175, .175);
            sprite2.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .175, .175, .175, .175);
            sprite3.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .225, .225, .225, .225);
        }

        public void snntkrmwrtk()
        {
            string Lyric = "sonnatokoromo";
            string Lyric2 = "warito";
            string Lyric3 = "kiraijanai";

            string Sprite = Path + Lyric + ".png";
            string Sprite2 = Path + Lyric2 + ".png";
            string Sprite3 = Path + Lyric3 + ".png";

            int OffsetA = 44565;
            int OffsetB = 44797;
            int OffsetC = 46658;
            int OffsetD = 46890;
            int OffsetE = 47356;
            int OffsetF = 47588;
            int OffsetG = 50379;
            int OffsetH = 50611;
            var layer = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var sprite = layer.CreateSprite(Sprite, OsbOrigin.Centre);
            var sprite2 = layer.CreateSprite(Sprite2, OsbOrigin.Centre);
            var sprite3 = layer.CreateSprite(Sprite3, OsbOrigin.Centre);

            sprite.Fade(OffsetA, OffsetB, 0, 1);
            sprite.Fade(OffsetG, OffsetH, 1, 0);
            sprite2.Fade(OffsetC, OffsetD, 0, 1);
            sprite2.Fade(OffsetG, OffsetH, 1, 0);
            sprite3.Fade(OffsetE, OffsetF, 0, 1);
            sprite3.Fade(OffsetG, OffsetH, 1, 0);

            sprite.Move(OsbEasing.None, OffsetB, OffsetH, 40, 250, 210, 250);
            sprite2.Move(OsbEasing.None, OffsetB, OffsetH, 0, 195, 170, 195);
            sprite3.Move(OsbEasing.None, OffsetB, OffsetH, -40, 250, 130, 250);
            sprite.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .225, .225, .225, .225);
            sprite2.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .25, .25, .25, .25);
            sprite3.ScaleVec(OsbEasing.None, OffsetA, OffsetA, .275, .275, .275, .275);
        }
    }
}
