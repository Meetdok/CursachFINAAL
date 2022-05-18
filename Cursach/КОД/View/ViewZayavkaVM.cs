using Cursach.DTO;
using Cursach.Model;
using Cursach.ViewModel;
using Cursach.Данные;
using System.Collections.Generic;

namespace Cursach.КОД.View
{
    internal class ViewZayavkaVM : BaseVM
    {
        private User selectedUser;
        private Employ selectedEmploy;
        private Kind selectedKind;

        public ViewZayavkaVM(User selectedUser, Employ selectedEmploy)
        {
            this.selectedUser = selectedUser;
            this.selectedEmploy = selectedEmploy;
            Kind = SqlModel.GetInstance().GetKinds();
        }

        public List<Kind> Kind { get; set; }
        public Kind SelectedKind
        {
            get => selectedKind;
            set
            {
                selectedKind = value;
                SearchZayavkaByName = SqlModel.GetInstance().SearchZayavkaByKind(value);
                Signal(nameof(SearchZayavkaByName));
            }
        }
        public UserZayavka SelectedUserAndEmploy { get; set;}
        public List<UserZayavka> SearchZayavkaByName { get; set; }






    }
}