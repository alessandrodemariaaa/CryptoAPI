using Microsoft.AspNetCore.Mvc;

namespace CryptoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CryptoController : ControllerBase
{
    private readonly CryptoService _cryptoService = new();

    [HttpGet("encrypt/{text}")]
    public IActionResult Encrypt(string text) => Ok(_cryptoService.Encrypt(text));

    [HttpGet("decrypt/{text}")]
    public IActionResult Decrypt(string text) => Ok(_cryptoService.Decrypt(text));
}