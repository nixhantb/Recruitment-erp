﻿using JobLeet.WebApi.JobLeet.Api.Logging;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher;
using Microsoft.AspNetCore.Components;

namespace JobLeet.WebApi.JobLeet.Api.Controllers.Common.V1
{
    [Route("api/v1/leet-experiences")]
    public class ExperienceController : BaseApiController<ExperienceModel, IExperienceRepository>
    {
        public ExperienceController(IExperienceRepository experienceRepository, ILoggerManagerV1 logger, RabbitMQService rabbitMQService)

            : base(experienceRepository, logger, rabbitMQService)
        {
            
        }
    }
}
