using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using System.Numerics;

namespace Raylib_FrameWork
{
    public class Scene : Entity
    {
        private List<Entity> entities;
        public List<Entity> Entities { get { return entities; } set { entities = value; } }

        public Scene()
        {
            entities = new List<Entity>();
        }
    }
}
