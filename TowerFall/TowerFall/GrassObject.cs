﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowerFall {
    class GrassObject : GameObject {
        Rectangle grassSheet, roadSheet;

        public GrassObject(Texture2D spriteSheet, Vector2 pos):base(spriteSheet) {
            this.pos = pos;
            this.spriteSheet = spriteSheet;
            grassSheet = new Rectangle(2432, 768, 50, 50);
            roadSheet = new Rectangle(2688, 768, 50, 50);
        }
        public override void Update(GameTime gameTime) {

        }

        public override void Draw(SpriteBatch SB) {
            SB.Draw(spriteSheet, pos, grassSheet, Color.White);
        }
    }

}