using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapGuiShortcutManager.Model
{
    class SapGuiServices
    {
        #region Constructors
        public SapGuiServices(String name, Guid uuid, String systemId)
        {
            this.Name = Name;
            this.Uuid = Uuid;
            this.SystemId = systemId;
        }
        #endregion

        #region Properties
        public String Name { get; set; }
        public Guid Uuid { get; set; }
        public String SystemId { get; set; }
        #endregion
    }
}
