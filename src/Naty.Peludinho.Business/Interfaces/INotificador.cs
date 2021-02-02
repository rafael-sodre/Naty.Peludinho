using Naty.Peludinho.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Naty.Peludinho.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotification();
        List<Notificacao> ObterNotificacoes();
        void handle(Notificacao notificacao);
    }
}
