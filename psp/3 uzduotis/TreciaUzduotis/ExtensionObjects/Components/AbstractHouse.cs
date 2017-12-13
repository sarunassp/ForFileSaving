using System.Collections.Generic;
using ExtensionObjects.Extensions;

namespace ExtensionObjects.Components
{
    public class AbstractHouse
    {
        private Dictionary<string, HouseExtension> m_extensions;
        protected internal int Height = 50;
        protected internal int Width = 50;

        public AbstractHouse ()
        {
            m_extensions = new Dictionary<string, HouseExtension> ();
        }
        
        public void AddExntesion (HouseExtension extension, string role)
        {
            m_extensions.Add (role, extension);
        }

        public void RemoveExtension (string role)
        {
            m_extensions.Remove (role);
        }

        public HouseExtension GetExtension (string role)
        {
            return m_extensions[role];
        }

        public void Draw ()
        {
            // some super logic how this thing draws itself
            foreach (var extension in m_extensions)
            {
                extension.Value.Draw ();
            }
        }

        public string GetDescription ()
        {
            var description = "simple house";
            
            foreach (var extension in m_extensions)
            {
                description += extension.Value.GetDescription ();
            }
            return description;
        }
    }
}