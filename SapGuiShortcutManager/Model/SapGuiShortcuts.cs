using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapGuiShortcutManager.Model
{
    class SapGuiShortcuts
    {
        #region Constructors
        public SapGuiShortcuts()
        {

        }
        #endregion

        #region Properties
        public Guid Uuid { get; set; }
        public String SystemName { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Client { get; set; }
        #endregion
    }
}
