namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
public record ErrorResponse
{
    // "error": {
    //	"status": 404,
    //	"name": "NotFoundError",
    //	"message": "Not Found",
    //	"details": {}
    //}
    public int Status { get; set; }
    public string Name { get; set; }
    public string Message { get; set; }
}
