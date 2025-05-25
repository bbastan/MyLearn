using ElectronicLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary
{
    internal class Library
    {
        private List<Entity> entities = new List<Entity>();

        public void AddEntity(Entity entity)
        {
            entities.Add(entity);
        }
    }
}
