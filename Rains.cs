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
    public class Rains : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            Rain(
/* StartTime */                 14565,
/* StartRainFadeInStart */      15030,
/* StartRainFadeInEnd */        15030,
/* FinishRainFadeOutStart */    20611,
/* EndTime */                   20611,
/* RainOpacity */               .25f,
/* RainCount */                 100,
/* LoopCount */                 100,
/* PositionXMin */              25,
/* PositionXMax */              25,
/* ScaleXMin */                 .25,
/* ScaleXMax */                 .75,
/* ScaleYMin */                 100,
/* ScaleYMax */                 250,
/* MinDuration */               500,
/* MaxDuration */               1000,
/* Hue */                       0,
/* Saturation */                0,
/* Brightness */                0,
/* Additive */                  false,
/* LayerName */                 "IntroRain 1"
            );

            Rain(
/* StartTime */                 20146,
/* StartRainFadeInStart */      20611,
/* StartRainFadeInEnd */        20611,
/* FinishRainFadeOutStart */    21542,
/* EndTime */                   21774,
/* RainOpacity */               .25f,
/* RainCount */                 200,
/* LoopCount */                 100,
/* PositionXMin */              25,
/* PositionXMax */              25,
/* ScaleXMin */                 .25,
/* ScaleXMax */                 1,
/* ScaleYMin */                 100,
/* ScaleYMax */                 250,
/* MinDuration */               500,
/* MaxDuration */               1000,
/* Hue */                       0,
/* Saturation */                0,
/* Brightness */                0,
/* Additive */                  false,
/* LayerName */                 "IntroRain 2"
            );

            Rain(
/* StartTime */                 21076,
/* StartRainFadeInStart */      21542,
/* StartRainFadeInEnd */        21542,
/* FinishRainFadeOutStart */    50611,
/* EndTime */                   51425,
/* RainOpacity */               .25f,
/* RainCount */                 160,
/* LoopCount */                 100,
/* PositionXMin */              -30,
/* PositionXMax */              80,
/* ScaleXMin */                 .25,
/* ScaleXMax */                 .75,
/* ScaleYMin */                 25,
/* ScaleYMax */                 75,
/* MinDuration */               750,
/* MaxDuration */               1500,
/* Hue */                       0,
/* Saturation */                0,
/* Brightness */                100,
/* Additive */                  false,
/* LayerName */                 "Post-Intro Rain"
            );

            Rain(
/* StartTime */                 52472,
/* StartRainFadeInStart */      52937,
/* StartRainFadeInEnd */        52937,
/* FinishRainFadeOutStart */    55263,
/* EndTime */                   55263,
/* RainOpacity */               .5f,
/* RainCount */                 180,
/* LoopCount */                 100,
/* PositionXMin */              10,
/* PositionXMax */              10,
/* ScaleXMin */                 .1,
/* ScaleXMax */                 .5,
/* ScaleYMin */                 25,
/* ScaleYMax */                 100,
/* MinDuration */               100,
/* MaxDuration */               200,
/* Hue */                       0,
/* Saturation */                0,
/* Brightness */                0,
/* Additive */                  false,
/* LayerName */                 "Post-Intro Transition Rain"
            );

            Rain(
/* StartTime */                 59216,
/* StartRainFadeInStart */      59681,
/* StartRainFadeInEnd */        59681,
/* FinishRainFadeOutStart */    81774,
/* EndTime */                   82007,
/* RainOpacity */               .5f,
/* RainCount */                 300,
/* LoopCount */                 1000,
/* PositionXMin */              -300,
/* PositionXMax */              400,
/* ScaleXMin */                 .1,
/* ScaleXMax */                 1,
/* ScaleYMin */                 25,
/* ScaleYMax */                 150,
/* MinDuration */               100,
/* MaxDuration */               250,
/* Hue */                       0,
/* Saturation */                0,
/* Brightness */                100,
/* Additive */                  false,
/* LayerName */                 "Chorus Rain Main 1"
            );

            Rain(
/* StartTime */                 65728,
/* StartRainFadeInStart */      66193,
/* StartRainFadeInEnd */        66658,
/* FinishRainFadeOutStart */    73635,
/* EndTime */                   74100,
/* RainOpacity */               .5f,
/* RainCount */                 240,
/* LoopCount */                 1000,
/* PositionXMin */              25,
/* PositionXMax */              25,
/* ScaleXMin */                 .1,
/* ScaleXMax */                 .5,
/* ScaleYMin */                 25,
/* ScaleYMax */                 100,
/* MinDuration */               100,
/* MaxDuration */               250,
/* Hue */                       0,
/* Saturation */                0,
/* Brightness */                100,
/* Additive */                  false,
/* LayerName */                 "Chorus Transition Rain"
            );

            Rain(
/* StartTime */                 81309,
/* StartRainFadeInStart */      81774,
/* StartRainFadeInEnd */        82007,
/* FinishRainFadeOutStart */    85728,
/* EndTime */                   89332,
/* RainOpacity */               .5f,
/* RainCount */                 120,
/* LoopCount */                 1000,
/* PositionXMin */              25,
/* PositionXMax */              25,
/* ScaleXMin */                 .1,
/* ScaleXMax */                 .5,
/* ScaleYMin */                 25,
/* ScaleYMax */                 100,
/* MinDuration */               100,
/* MaxDuration */               250,
/* Hue */                       0,
/* Saturation */                0,
/* Brightness */                100,
/* Additive */                  false,
/* LayerName */                 "Chorus Main Rain 2"
            );
        }

        public void Rain(
            int StartTime, // start time 
            int StartRainFadeInStart, // start fade begin
            int StartRainFadeInEnd, // start fade end

            int FinishRainFadeOutStart, // end fade begin
            int EndTime, // end time 

            float RainOpacity, // opacity for rain sprites

            int RainCount, // rain amount
            int LoopCount, // intensity

            // randomness
            double PositionXMin,
            double PositionXMax,

            double ScaleXMin,
            double ScaleXMax,
            double ScaleYMin,
            double ScaleYMax,

            // falling speed
            int MinDuration,
            int MaxDuration,

            // color
            double Hue,
            int Saturation,
            int Brightness,

            // additive
            bool Additive,

            string LayerName
        ){
            for (var i = 0; i < RainCount; i++)
            {
                // function general settings
                string SpritePath = "sb/sprites/white.png";
                var Sprite = GetLayer(LayerName).CreateSprite(SpritePath, OsbOrigin.Centre);

                // fixed variable values
                int Offset = 0;
                double ScaleX = .1;
                double ScaleY = .1;
                double SaturationConv = Saturation / 100;
                double BrightnessConv = Brightness / 100;

                // move speed
                double RainDuration = Random(MinDuration, MaxDuration);

                // sprite positioning
                double StartPostionX = Random(-107 - PositionXMax, 747 + PositionXMax);
                double StartPositionY = 0 - ScaleYMax * 2;
                double EndPositionX = Random(StartPostionX - PositionXMin, StartPostionX + PositionXMax); // randomize the ending position of x
                double EndPositionY = 480 + ScaleYMax * 2;

                // angle measurements
                double DeltaX = EndPositionX - StartPostionX; // diff in x
                double DeltaY = EndPositionY - StartPositionY; // diff in y
                double RotationRad = Math.Atan2(DeltaY, DeltaX); // delta result in radians

                // start loop
                Sprite.StartLoopGroup(Random(StartTime, (EndTime - MaxDuration)), LoopCount);

                // sprite manipulation
                Sprite.MoveX(Offset, RainDuration, StartPostionX, EndPositionX); // position of rain for X axis
                Sprite.MoveY(Offset, RainDuration, StartPositionY, EndPositionY); // position of rain for Y axis
                Sprite.ScaleVec(Offset, Random(ScaleX * ScaleXMin, ScaleX * ScaleXMax), Random(ScaleY * ScaleYMin, ScaleY * ScaleYMax)); // rain scale
                Sprite.ColorHsb(Offset, Hue, SaturationConv, BrightnessConv); // rain color
                Sprite.Rotate(Offset, RotationRad + Math.PI / 2); // rain angle
                if (Additive) // additive switch
                {
                    Sprite.Additive(Offset, RainDuration);
                }

                // end loop
                Sprite.EndGroup();

                // global fade
                Sprite.Fade(StartRainFadeInStart, StartRainFadeInEnd, 0, RainOpacity); // fade-in
                Sprite.Fade(FinishRainFadeOutStart, EndTime, RainOpacity, 0); // fade-out
            }
        }
    }
}