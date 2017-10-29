using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Diagnostics;

namespace FehlerMailSenden
{
    class Program
    {
        // Aufruf FehlerMailSenden "Betreff" "Mailtext"
        static void Main(string[] args)
        {
            SmtpClient smtp = new SmtpClient("10.0.0.50");
            MailMessage Mail = new MailMessage();

            if (args.Length == 2)
            {
                Mail.From = new MailAddress("admin@atzwanger.net");
                Mail.To.Add("rupert@atzwanger.net");
                Mail.Subject = args[0];
                Mail.Body = args[1];
                smtp.Port = 25;
                smtp.Credentials = new System.Net.NetworkCredential("admin@atzwanger.net", "");
                smtp.Send(Mail);
            }
            else
            {
                Console.WriteLine("Aufrufparameter: fehlermailsenden \"betreff\", \"mailtext\"");
                System.Threading.Thread.Sleep(30000);
            }
            }
        }
    }
