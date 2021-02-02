using System;
using System.Collections.Generic;
using System.Text;

namespace Naty.Peludinho.Business.Notifications
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; set; }
    }
}
