using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SISPAE.Model
{
    [Serializable]
    public class SimpleMailMessage
    {
        public string From { get; set; }
        public string DisplayName { get; set; }
        public string To { get; set; }
        public string ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public AttachmentCollection Attachments { get; set; }
        public Guid IdGuid { get; set; }

        public MailMessage ToMailMessage()
        {
            return new MailMessage
            {
                Body = Body,
                From = new MailAddress(From, DisplayName),
                IsBodyHtml = true,
                Subject = Subject,
                To = { To },
                ReplyToList = { ReplyTo }
            };
        }



    }

    public class TS_SMTP
    {
        [Required]
        [Display(Name = "ID")]
        public Int32 ID { get; set; }

        [Required]
        public String NOMBRE { get; set; }

        [Required]
        public String SMTP { get; set; }

        [Required]
        public Int32 PUERTO { get; set; }

        [Required]
        public Boolean SSL { get; set; }

        [Required]
        [Display(Name = "ESTADO")]
        public Boolean ESTADO { get; set; }

        [Required]
        public String USUARIO { get; set; }

        [Required]
        public String CONTRASENA { get; set; }

    }
}

