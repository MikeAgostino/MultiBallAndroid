using System;
using System.Collections.Generic;
using CocosSharp;
using Microsoft.Xna.Framework;

namespace MultiBall
{
    public class GameLayer : CCLayerColor
    {

        // Define a label variable
        CCLabel label;
        CCSprite paddleSprite, ballSprite;

        public GameLayer() : base(CCColor4B.Black)
        {

            // create and initialize a Label
            label = new CCLabel("Hello CocosSharp", "Fonts/MarkerFelt", 22, CCLabelFormat.SpriteFont);

            // add the label as a child to this Layer
            AddChild(label);

            paddleSprite = new CCSprite("paddle");
            AddChild(paddleSprite);

            ballSprite = new CCSprite("ball");
            AddChild(ballSprite);


        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            // Use the bounds to layout the positioning of our drawable assets
            var bounds = VisibleBoundsWorldspace;

            // position the label on the center of the screen
            label.PositionY = bounds.MinY -30;

            paddleSprite.PositionX = 100;
            paddleSprite.PositionY = 100;

            ballSprite.PositionX = 320;
            ballSprite.PositionY = 640;

            // Register for touch events
            var touchListener = new CCEventListenerTouchAllAtOnce();
            touchListener.OnTouchesEnded = OnTouchesEnded;
            AddEventListener(touchListener, this);
        }

        void OnTouchesEnded(List<CCTouch> touches, CCEvent touchEvent)
        {
            if (touches.Count > 0)
            {
                // Perform touch handling here
            }
        }
    }
}

