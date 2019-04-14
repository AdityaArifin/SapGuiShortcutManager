using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapGuiShortcutManager.Model
{
    class SapGuiService
    {
        public SapGuiService(string uuid, string name, string systemId)
        {
            this.Uuid = uuid;
            this.SystemName = name;
            this.SystemId = systemId;
        }

        #region Properties
        protected String Uuid;
        public String SystemName { get; set; }
        protected String SystemId;
        public IList<SapGuiShortcut> _logons = new List<SapGuiShortcut>();
        #endregion

        public void Add(SapGuiShortcut c)
        {
            _logons.Add(c);
        }

        public void Display(int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(SapGuiShortcut c)
        {
            _logons.Remove(c);
        }

    }
}
