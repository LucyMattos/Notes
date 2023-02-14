using AutoMapper;
using BlocodeNotasApi.Models.DTO;
using BlocodeNotasApi.Models.Entities;
using BlocodeNotasApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlocodeNotasApi.Controllers;

[ApiController]
[Route ("[controller]")]
public class NotesController : ControllerBase
{

    private NotesContext _context;
    private IMapper _mapper;

    public NotesController(NotesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpGet]
    public IEnumerable<BlocoDeNotas> VerNotas()
    {
        return _context.BlocoDeNotas;
    }


    [HttpGet ("{id}")]
    public IActionResult VerNotas( int id)
    {
        var x = _context.BlocoDeNotas.FirstOrDefault(x => x.Id == id);
        if (_context.BlocoDeNotas == null) return NotFound();
        return Ok(x);
    }


    [HttpPost]
    public void AdicionarNota([FromBody] AddNotesDTO NotesDTO)
    {
       BlocoDeNotas nota = _mapper.Map<BlocoDeNotas>(NotesDTO);
        _context.BlocoDeNotas.Add(nota);
        _context.SaveChanges();
        
    }

    [HttpPut ("{id}")]
    public IActionResult AtualizarNota(int id, [FromBody] UpdateNotesDTO NotesDTO)
    {
        var nota = _context.BlocoDeNotas.FirstOrDefault(nota=> nota.Id == id);
        if(nota == null) return NotFound();
        _mapper.Map(NotesDTO, nota);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete ("{id}")]
    public IActionResult DeletarNota(int id)
    {
        var nota = _context.BlocoDeNotas.FirstOrDefault(nota => nota.Id == id);
        if (nota == null) return NotFound();
        _context.Remove(nota);
        _context.SaveChanges();
        return NoContent();
    }
}
