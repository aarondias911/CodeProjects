using System;
using Infrastructure.Common.Model;

namespace Infrastructure.Common.Interfaces
{
    public interface IMenuService
    {
        event Action<TopMenu> OnMenuAdded;

        void AddMenu(TopMenu menu);
    }
}