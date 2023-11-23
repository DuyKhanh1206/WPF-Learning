using ListViewGridView_Model;
using ProsesserUser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ListViewGridView_ViewModel
{
  
    public class User_ViewModel
    {
        private ObservableCollection<User> data;
        public ObservableCollection<User> Data
        {
            get { return data; }
            set { data = value; }
        }

        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public ProsesserUsers Prossess
        {
            get
            {
                return prossess;
            }

            set
            {
                prossess = value;
            }
        }

        private ProsesserUsers prossess;

        public User_ViewModel()
        {
            Data = new ObservableCollection<User>();
            Data.Add(new User() { Stt = 1, Name = "Nguyễn Duy Khánh", Mail = "ngkhanh1206@gmail.com" });
            Data.Add(new User() { Stt = 2, Name = "湯浅さん", Mail = "湯浅さん@gmail.com" });
            Data.Add(new User() { Stt = 3, Name = "Nguyễn Duy Khánh", Mail = "ngkhanh1206@gmail.com" });

            prossess = new ProsesserUsers(Data);


            DeleteCommand = new RelayCommand<object>((p) => p != null, prossess.Remove);


            AddCommand = new RelayCommand<UIElementCollection>((p) => true, prossess.AddCommand);
        }


    }
}
