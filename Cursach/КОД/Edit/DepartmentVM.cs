using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cursach.Model;
using Cursach.Tools;
using Cursach.Данные;

namespace Cursach.КОД.Edit
{
    public class DepartmentVM
    {
        public Department EditDepartment { get; set; }
        public CommandVM SaveDepartment { get; set; }

        private CurrentPageControl currentPageControl;
        public DepartmentVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDepartment = new Department();
            InitCommand();
        }
        public DepartmentVM(Department editDepartment, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditDepartment = editDepartment;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveDepartment = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (EditDepartment.ID == 0)
                    model.Insert(EditDepartment);
                else
                    model.Update(EditDepartment);
                currentPageControl.Back();
            });
        }
    }
}
