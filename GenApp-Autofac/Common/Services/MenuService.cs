using Infrastructure.Common.Interfaces;
using Infrastructure.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Common.Services
{
    public class MenuService : IMenuService
    {
        public event Action<TopMenu> OnMenuAdded;

        public MenuService()
        {
            OnMenuAdded = new Action<TopMenu>((x) => { });
        }

        public void AddMenu(TopMenu menu)
        {
            OnMenuAdded.Invoke(menu);
        }
    }
}
