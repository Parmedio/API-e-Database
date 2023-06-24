using Microsoft.AspNetCore.Mvc;
using Database.Gateway;
using API_e_Database.Dto;
using Database.Models;

namespace LibraryCatalog.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ArtistController : ControllerBase
{
    private readonly IGatewayArtist _gatewayArtist;
    private readonly ILogger<ArtistController> _logger;

    public ArtistController(IGatewayArtist gateway, ILogger<ArtistController> logger)
    {
        _gatewayArtist = gateway;
        _logger = logger;
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetArtistById([FromRoute] int id)
    {
        try
        {
            var artist = _gatewayArtist.GetArtistById(id);

            if (artist is null)
                return Problem("Id not found in database");

            var result = BuildArtistDto(artist);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest($"{ex.Message}");
        }
    }

    [HttpPost]
    public IActionResult CreateAuthor([FromBody] ArtistDto dto)
    {
        try
        {
            var artistToCreate = BuildArtist(dto);

            var newlyCreatedArtist = _gatewayArtist.InsertArtist(artistToCreate);

            var result = BuildArtistDto(newlyCreatedArtist);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest($"{ex.Message}");
        }
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateArtist([FromRoute] int id, [FromBody] ArtistDto dto)
    {
        try
        {
            var artistToUpdate = BuildArtist(dto);
            artistToUpdate.Id = id;

            var updatedArtist = _gatewayArtist.UpdateArtist(artistToUpdate);

            var result = BuildArtistDto(updatedArtist);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest($"{ex.Message}");
        }
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAuthor([FromRoute] int id)
    {
        try
        {
            var deletedAuthor = _gatewayArtist.DeleteArtistById(id);

            var result = BuildArtistDto(deletedAuthor);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest($"{ex.Message}");
        }
    }

    private ArtistDto BuildArtistDto(Artist artist)
        => new ArtistDto
        (
            artist.Id,
            artist.Name,
            artist.YearOfBirth
        );

    private Artist BuildArtist(ArtistDto artist)
        => new Artist
        (
            artist.Name,
            artist.YearOfBirth
        );
}
