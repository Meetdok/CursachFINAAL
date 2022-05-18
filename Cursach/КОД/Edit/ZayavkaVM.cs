
using Cursach.DTO;
using Cursach.Model;
using Cursach.Tools;
using Cursach.ViewModel;
using Cursach.Данные;
using Cursach.Страницы.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.КОД.Edit
{
    class ZayavkaVM : BaseVM
    {
        public Zayavka EditZay { get; set; }
        public CommandVM SaveZay { get; set; }

        public User SelectedUser
        {
            get => selectedUser;
            set
            {
                selectedUser = value;
                Signal();
            }
        }

        public Kind SelectedKind
        {
            get => selectedKind;
            set
            {
                selectedKind = value;
                Signal();
            }
        }

        public Employ SelectedEmploy
        {
            get => selectedEmploy;
            set
            {
                selectedEmploy = value;
                Signal();
            }
        }


        public List<User> Users { get; set; }
        public List<Employ> Employs { get; set; }
        public List<Kind> Kinds { get; set; }

        private CurrentPageControl currentPageControl;
        private User selectedUser;
        private Employ selectedEmploy;
        private Kind selectedKind;

        public ZayavkaVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditZay = new Zayavka();
            InitCommand();
        }
        public ZayavkaVM(Zayavka editZay, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditZay = editZay;
            InitCommand();
            SelectedUser = Users.FirstOrDefault(s => s.ID == editZay.UserId);
            SelectedEmploy = Employs.FirstOrDefault(s => s.ID == editZay.EmployerId);
            SelectedKind = Kinds.FirstOrDefault(s => s.ID == editZay.KindId);
        }

        private void InitCommand()
        {
            Users = SqlModel.GetInstance().UserCreate(0, 100);
            Employs = SqlModel.GetInstance().EmployCreate(0, 100);
            Kinds = SqlModel.GetInstance().KindsCreate(0, 100);
            SaveZay = new CommandVM(() =>
            {
                if (SelectedUser == null || SelectedEmploy == null || selectedKind == null)
                {
                    System.Windows.MessageBox.Show("Введены не все данные");
                    return;
                }
                EditZay.UserId = SelectedUser.ID;
                EditZay.EmployerId = SelectedEmploy.ID;
                EditZay.KindId = SelectedKind.ID;
                var model = SqlModel.GetInstance();
                if (EditZay.ID == 0)
                    model.Insert(EditZay);
                else
                    model.Update(EditZay);
                currentPageControl.SetPage(new ZayavkaView(SelectedUser, SelectedEmploy, SelectedKind));
            });
        }
    }
}