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

    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //Fields
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private KeyboardState ks, oks;

        public PyramidPanic()
        {
            //maakt de muis zichtbaar 
            this.IsMouseVisible = true;

            this.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            //Hier wordt de schermtitel gekozen.
            this.Window.Title = "Pyramid Panic";

            //Hier wordt de breedte van het canvas gedefineerd.
            this.graphics.PreferredBackBufferWidth = 640;

            //Hier wordt de hoogte van het canvas gedefineerd.
            this.graphics.PreferredBackBufferHeight = 480;

            //Hier wordt de verandering van het canvas toegepast.
            this.graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            this.ks = Keyboard.GetState();
            //het indrukken van 'Escape' sluit het spel
            if (this.ks.IsKeyDown(Keys.Escape))
            {
                this.Exit();
            }
            //Dit zorgt ervoor dat het spel gesloten kan worden met de 'Back' knop van een gamepad.
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Purple);


            base.Draw(gameTime);
        }
    }
}
