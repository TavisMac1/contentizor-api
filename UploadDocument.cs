using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace contentizor
{
    public class UploadDocument
    {
        private readonly ILogger<UploadDocument> _logger;

        public UploadDocument
        (
            ILogger<UploadDocument> logger
        )
        {
            _logger = logger;
        }

        [Function("UploadDocument")]
        public IActionResult Run
        (
            [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req, 
            CancellationToken cancellationToken
        )
        {
            _logger.LogInformation("Contentizor/Upload is processing a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
