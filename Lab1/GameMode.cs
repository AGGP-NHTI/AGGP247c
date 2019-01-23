using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineDraw;
using Microsoft.Xna.Framework;

namespace Lecture247
{
    class GameMode : GameApp
    {
        public GameMode() : base()
        {

        }

        protected override void Initialize()
        {
            base.Initialize();
            // do other Code after... 
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        protected override void GameUpdate(GameTime gameTime)
        {
           
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(clearColor);

            base.Draw(gameTime);
        }


    }
}
