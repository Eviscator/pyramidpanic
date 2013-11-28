using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class StartScene
    {
        //Fields
        private GraphicsDeviceManager graphics;


        //Constructor
        public StartScene()
        {

            this.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        //Initialize
        protected override void Initialize()
        {
            base.Initialize();
        }


        //Update
        protected void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }


        //Draw
        protected void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Blue);


            base.Draw(gameTime);
        }
    }
}
