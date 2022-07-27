using Microsoft.AspNetCore.Mvc;
using Pacientes.API.Models;

namespace Pacientes.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PacienteController : ControllerBase
{
    private readonly DataContext _context;

    public PacienteController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Paciente> Get(){
        return _context.Pacientes;
    }
}
