﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingData
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger logger;

        public EmailSender(ILogger<EmailSender> logger)
        {
            this.logger = logger;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            this.logger.LogInformation($"{message}");
            return Task.CompletedTask;
        }
    }
}
