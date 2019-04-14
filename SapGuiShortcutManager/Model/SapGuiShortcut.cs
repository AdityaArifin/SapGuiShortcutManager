using Aga.Controls.Tree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapGuiShortcutManager.Model
{
    class SapGuiShortcut
    {
        protected SapGuiService Parent;
        public String Client { get; set; }
        public String Username { get; set; }
        protected String Password;

        public SapGuiShortcut(SapGuiService parent, string client, string username, string password)
        {
            this.Parent = parent;
            this.Client = client;
            this.Username = username;
            this.Password = password;
        }
    }
}
