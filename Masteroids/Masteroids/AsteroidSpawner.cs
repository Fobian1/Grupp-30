﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masteroids
{
    class AsteroidSpawner
    {
        Viewport viewport;
        EntityManager entityMgr;
        private Random rnd;

        public AsteroidSpawner(EntityManager entityMgr, Viewport viewport)
        {
            this.entityMgr = entityMgr;
            this.viewport = viewport;
            rnd = new Random();
        }

        public void Update(GameTime gameTime)
        {
            if (entityMgr.Asteroids.Count < 10)
            {
                int positionX = rnd.Next(0, viewport.Width - Art.AsteroidTex.Width);
                int positionY = rnd.Next(0, viewport.Height + Art.AsteroidTex.Height);
                int speedX = 2;
                int speedY = 2;
                Vector2 position = new Vector2(positionX, positionY);

                // if removed, asteroids moves in the same path. Cant get this too work
                //if (position.X <= 0)
                //{
                //    speedX = 2;
                //}
                //if (position.Y <= 0)
                //{
                //    speedY = 2;
                //}
                //if (position.X >= 800)
                //{
                //    speedX = -2;
                //}
                //if (position.Y >= 800)
                //{
                //    speedY = -2;
                //}
                Vector2 speed = new Vector2(speedX, speedY);
                entityMgr.CreateAsteroid(position, speed);
            }
        }
    }
}
