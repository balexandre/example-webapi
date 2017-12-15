using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_core.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = Startup.Configuration["MailSettings:mailTo"];

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
