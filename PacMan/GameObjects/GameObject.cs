﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PacMan.GameObjects
{
    public abstract class GameObject
    {
        public abstract void Start();
        public abstract void Update();
        public abstract void Render();
    }
}
