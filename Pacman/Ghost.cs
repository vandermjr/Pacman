﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    public class Ghost
    {
        private Rectangle rect;
        private int xSpeed, ySpeed;
        public Color colour;
        private string behavior;

        public Ghost(int _x, int _y, int _size, int _xSpeed, int _ySpeed, string _behavior)
        {
            rect.X = _x;
            rect.Y = _y;
            rect.Width = _size;
            rect.Height = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            behavior = _behavior;
        }

        public void move(PacMan player)
        {
            // TODO: Move ghost based on the behavior and where
            // pacman is
            rect.X += xSpeed;
            rect.Y += ySpeed;
        }

        public void setSpeed(int _xSpeed, int _ySpeed)
        {
            xSpeed += _xSpeed;
            ySpeed += _ySpeed;
        }

        public void setPosition(int _x, int _y)
        {
            rect.X = _x;
            rect.Y = _y;
        }
    }
}