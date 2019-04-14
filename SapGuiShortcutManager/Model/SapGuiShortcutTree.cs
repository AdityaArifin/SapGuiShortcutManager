using Aga.Controls.Tree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapGuiShortcutManager.Model
{
    class SapGuiShortcutTree : ITreeModel
    {
        protected IList<SapGuiService> sapGuiServices = new List<SapGuiService>();

        public IEnumerable GetChildren(object parent)
        {
            if (parent == null)
            {
                for (int i = 0; i < 3; i++)
                {
                    SapGuiService dummy = CreateDummySystem(i);
                    sapGuiServices.Add(dummy);
                    yield return dummy;
                }
            }
            else
            {
                var service = parent as SapGuiService;
                foreach(SapGuiShortcut logon in service._logons)
                {
                    yield return new ShortcutValue
                    {
                        SystemName = service.SystemName,
                        Client = logon.Client,
                        UserName = logon.Username
                    };
                }
            }
        }

        public bool HasChildren(object parent)
        {
            return parent is SapGuiService;
        }

        private SapGuiService CreateDummySystem(int index)
        {
            switch (index)
            {
                case 0:
                    SapGuiService sapGuiService = new SapGuiService(
                        "819a83ae-4ed5-471e-903c-98aec23ec060",
                        "ABEAM ECP[127.0.0.1]", "ECP");

                    sapGuiService.Add(new SapGuiShortcut(sapGuiService, "101", "abeam01", "test"));
                    sapGuiService.Add(new SapGuiShortcut(sapGuiService, "101", "abeam02", "test"));
                    sapGuiService.Add(new SapGuiShortcut(sapGuiService, "101", "abeam03", "test"));
                    return sapGuiService;
                case 1:
                    sapGuiService = new SapGuiService(
                        "109cf020-fecd-470b-a132-c7d9044da5aa",
                        "ABEAM S4H[127.0.0.1]", "S4H");

                    sapGuiService.Add(new SapGuiShortcut(sapGuiService, "101", "abeams41", "test"));
                    sapGuiService.Add(new SapGuiShortcut(sapGuiService, "101", "abeams42", "test"));
                    return sapGuiService;
                default:
                    sapGuiService = new SapGuiService(
                        "dummy",
                        "DUMMY SYS[127.0.0.1]", "ZZZ");

                    sapGuiService.Add(new SapGuiShortcut(sapGuiService, "101", "dummy", "test"));
                    sapGuiService.Add(new SapGuiShortcut(sapGuiService, "101", "dummy", "test"));
                    return sapGuiService;
            }
        }
    }

    public struct ShortcutValue
    {
        public string SystemName { get; set; }
        public string Client { get; set; }
        public string UserName { get; set; }
    }
}
