﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    public class StandardFood : Food
    {
        public StandardFood() : base()
        {
            Pos = Food.SpawnPoint();
            rect = new Rectangle(Position, new Size(Settings.size, Settings.size));
            
            while (CheckFoodPosition())
            {
                Pos = Food.SpawnPoint();
                rect = new Rectangle(Position, new Size(Settings.size, Settings.size));
            }

            Matrix = new MatrixPoint(Pos.X/15, Pos.Y/15);
        }

        internal override void AddEffect(ref List<Player> playerList)
        {
            return;                 //Absolutely do nothing about this code, no effect is supposed to be added from the standard type
        }

        internal override void Draw(Graphics g)
        {
            //g.DrawIcon(new Icon("Apple.ico"), Pos.X, Pos.Y);
            g.FillRectangle(new SolidBrush(Color.Black), rect);
        }

        internal override void Hit(Collider collider)
        {
            collider.Collide(this);
        }

        internal override void IncreaseLength(ref Player player)
        {
            player.AddParts(Settings.standardLength);
        }

        internal override void IncreaseScore(ref Player player) => player.Score += Settings.standardFood;
    }
}
