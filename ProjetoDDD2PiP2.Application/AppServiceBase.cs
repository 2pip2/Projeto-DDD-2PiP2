using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ProjetoDDD2PiP2.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        
        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
        
        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _serviceBase.GetAll();
        }

        public TEntity GetById(string id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }
    }

    public  class Util
    {

        public  static void Alertar(string mensagem)
        {
            HttpContext.Current.Session["Alerta"] = mensagem;
        }
        public static void EnviarEmail(string Assunto, string mensagem, string destinatario)
        {
            var smtp = new SmtpClient("smtp.2pip2.com", 587);
            smtp.EnableSsl = true;
            var msg = new MailMessage("paulo.perez@2pip2.com", destinatario,Assunto,mensagem);
            msg.IsBodyHtml = true;
            var cred = new NetworkCredential("paulo.perez@2pip2.com", "2pip2");
            smtp.Credentials = cred;
            smtp.Send(msg);

        }
    }

}
