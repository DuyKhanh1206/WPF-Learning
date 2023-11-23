using ListViewGridView_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProsesserUser
{
    public class ProsesserUsers
    {
        private ObservableCollection<User> data;
        public ObservableCollection<User> Data
        {
            get { return data; }
            set { data = value; }
        }

        public ProsesserUsers()
        {
            this.Data = Data;
        }

        public ProsesserUsers(ObservableCollection<User> data)
        {
            this.data = data;
        }

        public void Remove(object p)
        {
            Data.Remove(p as User);
        }
        

        public void AddCommand(UIElementCollection p)
        {
            int stt = 0;
            string name = "";
            string mail = "";
            bool isSttInt = false;
            foreach (var item in p)
            {
                TextBox txt = item as TextBox;
                if (txt != null)
                {
                    switch (txt.Name)
                    {
                        case ("txtStt"):
                            isSttInt = Int32.TryParse(txt.Text, out stt);
                            break;
                        case ("txtName"):
                            name = txt.Text;
                            break;
                        case ("txtMail"):
                            mail = txt.Text;
                            break;
                    }
                }
            }
            if (!isSttInt || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mail))
            {
                return;
            }
            User newUser = new User() { Stt = stt, Name = name, Mail = mail };
            Data.Add(newUser);


        }
    }
}
