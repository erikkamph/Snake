﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    public class CoffeeFood : Food
    {
        Random random;

        public CoffeeFood() : base()
        {
            random = new Random();

            Pos = Food.SpawnPoint();
            rect = new Rectangle(Position, new Size(Settings.size, Settings.size));

            while (CheckFoodPosition())
            {
                Pos = Food.SpawnPoint();
                rect = new Rectangle(Position, new Size(Settings.size, Settings.size));
            }
            //icon = new Icon("CoffieCup.ico");
        }

        internal override void AddEffect(ref List<Player> playerList)
        {
            playerList[random.Next(playerList.Count)].activateEffect(this);
        }

        internal override void Draw(Graphics g)
        {
            //g.DrawIcon(icon, Pos.X, Pos.Y);
            g.FillRectangle(new SolidBrush(Color.RosyBrown), rect);
        }

        internal override void Hit(Collider collider)
        {
            collider.Collide(this);
        }

        internal override void IncreaseLength(ref Player player)
        {
            return; //Implemented on the other food types but since coffee food is just gonna speed up a snake we just return this call
        }

        internal override void IncreaseScore(ref Player player)
        {
            return; //Implemented on the other food types but since coffee food is just gonna speed up a snake we just return this call
        }
    }
}
