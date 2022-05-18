using Cursach.Model;
using Cursach.Tools;
using Cursach.Данные;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.КОД.Edit
{
    public class KindVM
    {
        public Kind EditKind { get; set; }
        public CommandVM SaveKind { get; set; }

        private CurrentPageControl currentPageControl;
        public KindVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditKind = new Kind();
            InitCommand();
        }
        public KindVM(Kind editKind, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditKind = editKind;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveKind = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (EditKind.ID == 0)
                    model.Insert(EditKind);
                else
                    model.Update(EditKind);
                currentPageControl.Back();
            });
        }
    }
}
