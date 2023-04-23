using SimpleLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLayout.ViewModels
{

    internal class UserVM : ViewModelBase
    {
        private User user;
        private string userName;

        public UserVM()
        {
            user = new User();

        }

        public string UserName
        {
            get => user.Username;
            set
            {
                user.Username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        
    }
}
