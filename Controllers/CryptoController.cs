using Microsoft.AspNetCore.Mvc;

namespace CryptoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CryptoController : ControllerBase
{
    private readonly CryptoService _cryptoService = new();

    [HttpGet("encrypt/{text}")]
    public IActionResult Encrypt(string text) 
    {
        var result = _cryptoService.Encrypt(text);
        return Ok(result);
    }

    [HttpGet("decrypt/{text}")]
    public IActionResult Decrypt(string text) 
    {
        var result = _cryptoService.Decrypt(text);
        return Ok(result);
    }
}