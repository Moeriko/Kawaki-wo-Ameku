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
    public class Unravel : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            TriangleEffect(
/* Appear */            58518,
/* AppearFadeInTime */  58751,
/* Reverse Time */      59449,
/* Disappear */         59681,
/* InitialPosX */       240,
/* InitialPosY */       240,
/* MovePosAX */         200,
/* MovePosAY */         250,
/* InitialScale */      .35,
/* MovePosScale */      .5,
/* Rotation */          1.2,
/* SpritePath */        "sb/unravel/kaneki_1_f.png",
/* Layer */             "Kaneki Main"
            );

            TriangleEffect(
/* Appear */            58751,
/* AppearFadeInTime */  58983,
/* Reverse Time */      59449,
/* Disappear */         59681,
/* InitialPosX */       100,
/* InitialPosY */       250,
/* MovePosAX */         200,
/* MovePosAY */         200,
/* InitialScale */      .35,
/* MovePosScale */      .5,
/* Rotation */          1.3,
/* SpritePath */        "sb/unravel/kaneki_1_a.png",
/* Layer */             "Kaneki Fragment"
            );

            TriangleEffect(
/* Appear */            58751,
/* AppearFadeInTime */  58983,
/* Reverse Time */      59449,
/* Disappear */         59681,
/* InitialPosX */       100,
/* InitialPosY */       250,
/* MovePosAX */         100,
/* MovePosAY */         200,
/* InitialScale */      .35,
/* MovePosScale */      .5,
/* Rotation */          .8,
/* SpritePath */        "sb/unravel/kaneki_1_b.png",
/* Layer */             "Kaneki Fragment"
            );

            TriangleEffect(
/* Appear */            59100,
/* AppearFadeInTime */  59332,
/* Reverse Time */      59449,
/* Disappear */         59681,
/* InitialPosX */       100,
/* InitialPosY */       250,
/* MovePosAX */         400,
/* MovePosAY */         200,
/* InitialScale */      .35,
/* MovePosScale */      .5,
/* Rotation */          1.5,
/* SpritePath */        "sb/unravel/kaneki_1_c.png",
/* Layer */             "Kaneki Fragment"
            );

            TriangleEffect(
/* Appear */            59100,
/* AppearFadeInTime */  59332,
/* Reverse Time */      59449,
/* Disappear */         59681,
/* InitialPosX */       100,
/* InitialPosY */       250,
/* MovePosAX */         50,
/* MovePosAY */         180,
/* InitialScale */      .35,
/* MovePosScale */      .5,
/* Rotation */          1,
/* SpritePath */        "sb/unravel/kaneki_1_d.png",
/* Layer */             "Kaneki Fragment"
            );

            TriangleEffect(
/* Appear */            59100,
/* AppearFadeInTime */  59332,
/* Reverse Time */      59449,
/* Disappear */         59681,
/* InitialPosX */       100,
/* InitialPosY */       250,
/* MovePosAX */         150,
/* MovePosAY */         220,
/* InitialScale */      .35,
/* MovePosScale */      .5,
/* Rotation */          1,
/* SpritePath */        "sb/unravel/kaneki_1_e.png",
/* Layer */             "Kaneki Fragment"
            );

            Chorus_BG();
        }

        /* for the triangle effect right before chorus */
        public void TriangleEffect(
            int Appear,
            int AppearFadeInTime,
            int ReverseTime,
            int Disappear,
            double InitialPosX,
            double InitialPosY,
            double MovePosAX,
            double MovePosAY,
            double InitialScale,
            double MovePosScale,
            double Rotation,
            string SpritePath,
            string Layer
        )
        {
            var sprite = GetLayer(Layer).CreateSprite(SpritePath, OsbOrigin.Centre);

            // fade
            sprite.Fade(Appear, AppearFadeInTime, 0, .8);
            sprite.Fade(AppearFadeInTime, ReverseTime, .8, 1);
            sprite.Fade(ReverseTime, Disappear, 1, 0);

            // first move
            sprite.Move(OsbEasing.Out, Appear, AppearFadeInTime, InitialPosX, InitialPosY, MovePosAX, MovePosAY);

            // first scale
            sprite.ScaleVec(OsbEasing.Out, Appear, AppearFadeInTime, InitialScale, InitialScale, MovePosScale, MovePosScale);

            // first rotate
            sprite.Rotate(OsbEasing.Out, Appear, AppearFadeInTime, 0, Rotation);

            // reverse move
            sprite.Move(OsbEasing.In, ReverseTime, Disappear, MovePosAX, MovePosAY, 320, 240);

            // reverse scale
            sprite.ScaleVec(OsbEasing.In, ReverseTime, Disappear, MovePosScale, MovePosScale, InitialScale, InitialScale);

            // reverse rotate
            sprite.Rotate(OsbEasing.In, ReverseTime, Disappear, Rotation, 0);
        }

        /* for the first part of chorus */
        public void Chorus_BG()
        {
            int StartTime = 59681;
            int EndTime = 66658;
            string SpritePath = "sb/unravel/kaneki_1.png";
            var sprite = GetLayer("Chorus BG 1").CreateSprite(SpritePath, OsbOrigin.Centre);
            sprite.Fade(StartTime, StartTime, 0, .33);
            sprite.Fade(EndTime, EndTime, .33, 0);
            sprite.Move(StartTime, 320, 240);
            sprite.ScaleVec(OsbEasing.None, StartTime, StartTime, .5, .5, .5, .5);
        }
    }
}
