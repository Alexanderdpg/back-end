using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Filtros
{
    public class FiltroDeExcepion: ExceptionFilterAttribute
    {
        private readonly ILogger<FiltroDeExcepion> logger;

        public FiltroDeExcepion(ILogger<FiltroDeExcepion> logger)
        {
            this.logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }
    }
}
