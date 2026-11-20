using MauiMvvmSample.Models;
using MauiMvvmSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmSample.ViewModels
{
    public partial class Page2ViewModel
    {
        private readonly IUserSession _userSession;

        public Page2ViewModel(IUserSession userSession)
        {
            _userSession = userSession;
        }

        public User? CurrentUser => _userSession.CurrentUser;
    }
}
