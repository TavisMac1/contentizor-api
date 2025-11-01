using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contentizor.Models;
internal class UploadDocumentRequestModel
{
    private Guid Id = new Guid();
    public required string FileName { get; init; }
    public required string ContentType { get; init; }
    public required string Tag { get; init; }
    public required string FileContent { get; init; }

    private UploadDocumentRequestModel()
    { 
        this.Id = Guid.NewGuid();
    }
}
