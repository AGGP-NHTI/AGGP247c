using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LineDraw; 

namespace DrawingExample
{
    class GameMode : GameApp
    {
        Texture2D Enterprise;

        Sprite Falcon;
        Sprite tie;
        Sprite tieAdvanced;

        bool MouseShow = false;

        Line theline;

        Vector2 PointA;
        Vector2 PointB;  

        /// <summary>
        /// Default Constructor. Most of the work you need to do should be in Initalize
        /// </summary>
        public GameMode() : base()
        {
            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
            // TODO: use this.Content to load your game content here

            // Setting up Screen Resolution
            // Read more here: http://rbwhitaker.wikidot.com/changing-the-window-size
            graphics.PreferredBackBufferWidth = 640;
            graphics.PreferredBackBufferHeight = 480;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

            theline = new Line();
            theline.width *= 3;
            theline.color = Color.GreenYellow;

            PointA = new Vector2(0, 0);
            PointB = new Vector2(640, 480);

            

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            Enterprise = Content.Load<Texture2D>("Enterprise");
        
            Falcon = new Sprite("MFalcon");
            Falcon.scale = .25f;
            Falcon.position = new Vector2(10, 10);
            Falcon.origin.X = Falcon.texture.Width / 2;
            Falcon.origin.Y = Falcon.texture.Height / 2;
        

            tie = new Sprite("Tie");
            tie.scale = .25f;
            tie.position = new Vector2(100, 100);
            tie.origin.X = tie.texture.Width / 2;
            tie.origin.Y = tie.texture.Height / 2;

            tieAdvanced = new Sprite("TieAdvanced");
            tieAdvanced.scale = .25f;
            tieAdvanced.position = new Vector2(200, 200);
            tieAdvanced.origin.X = tieAdvanced.texture.Width / 2;
            tieAdvanced.origin.Y = tieAdvanced.texture.Height / 2;

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            // If you create textures on the fly, you need to unload them. 
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void GameUpdate(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                    || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
          
            // FALCON SPRITE

            // Move and Rotate via Game Pad 
            if (gamePadsCurrrent[0].IsConnected)
            {
                Falcon.position += (gamePadsCurrrent[0].ThumbSticks.Left * gameTime.ElapsedGameTime.Milliseconds * .25f);
                //Falcon.position.X += (gamePadsCurrrent[0].ThumbSticks.Left.X * gameTime.ElapsedGameTime.Milliseconds * .25f);
                //Falcon.position.Y += (gamePadsCurrrent[0].ThumbSticks.Left.Y * gameTime.ElapsedGameTime.Milliseconds * .25f);
                Falcon.rotation += (gamePadsCurrrent[0].ThumbSticks.Right.X * gameTime.ElapsedGameTime.Milliseconds * .001f);
                Falcon.dontDraw = false; 
            } else
            {
                Falcon.dontDraw = true; // don't draw if a controller isn't connected. 
            }

            // TIE FIGHTER SPRITE

            // Show and Hide the Mouse via Space Bar
            if (IsKeyPressed(Keys.Space))
            {
                MouseShow = !MouseShow;
                this.IsMouseVisible = MouseShow;
            }

            // Move the Tie Fighter is mouse is hidden
            if (!MouseShow)
            {
                tie.position.X = mouseCurrent.Position.X; 
                tie.position.Y = mouseCurrent.Position.Y;
            }

            if (MouseButtonIsPressed("LeftButton"))
            {
                tie.rotation -= 15 * (MathHelper.Pi / 180);
            }

            if (MouseButtonIsPressed("RightButton"))
            {
                tie.rotation += 15 * (MathHelper.Pi / 180);
            }


            // TIE Advanced SPRITE

            // Move + Rotate Tie Advanced Via WASD+QE
            if (IsKeyPressed(Keys.W))
            {
                tieAdvanced.position.Y -= 30; 
            }
            if (IsKeyPressed(Keys.S))
            {
                tieAdvanced.position.Y += 30;
            }
            if (IsKeyPressed(Keys.A))
            {
                tieAdvanced.position.X -= 30;
            }
            if (IsKeyPressed(Keys.D))
            {
                tieAdvanced.position.X += 30;
            }
            if (IsKeyPressed(Keys.Q))
            {
                tieAdvanced.rotation += 15 * (MathHelper.Pi/180);
            }
            if (IsKeyPressed(Keys.E))
            {
                tieAdvanced.rotation -= 15 * (MathHelper.Pi / 180);
            }

            // Line Drawing 
            theline.startPoint = tie.position;
            theline.endPoint = tieAdvanced.position; 

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(clearColor);

            spriteBatch.Begin();

            spriteBatch.Draw(Enterprise, new Vector2(400, 300), Color.Blue); 
            Falcon.Draw(spriteBatch);
            tie.Draw(spriteBatch);
            tieAdvanced.Draw(spriteBatch);

            LineDrawer.DrawLine(spriteBatch, 3.0f, Color.Yellow, PointA, PointB); 
            theline.Draw(spriteBatch); 

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
