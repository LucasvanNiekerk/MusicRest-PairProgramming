using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib;

namespace MusicRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private static List<Record> _records = new List<Record>
        {
            new Record("Mozard", "Mozard", 334, 1965),
            new Record("Pink floyd", "Mozard", 334, 1965),
            new Record("Dance of knights", "Mozard", 334, 1965),
            new Record("Through fire and flames", "Mozard", 334, 1965),
            new Record("we didn't start the fire", "Mozard", 334, 1965)
        };

        // GET: api/Records
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return _records;
        }

        [Route("title/{title}")]
        [HttpGet("{title}")]
        public IEnumerable<Record> GetByTitle(string title)
        {
            return _records.FindAll(record => record.Title.ToLower().Contains(title.ToLower()));
        }

        [Route("artist/{artist}")]
        [HttpGet("{artist}")]
        public IEnumerable<Record> GetByArtist(string artist)
        {
            return _records.FindAll(record => record.Artist.ToLower().Contains(artist.ToLower()));
        }

        [Route("publicationYear/{publicationYear}")]
        [HttpGet("{publicationYear}")]
        public IEnumerable<Record> GetByYear(int publicationYear)
        {
            return _records.FindAll(record => record.PublicationYear == publicationYear);
        }

        [HttpGet]
        [Route("Search")]
        public IEnumerable<Record> SearchByPublicationYear([FromQuery] FilterRecord filter)
        {
            if (filter.MinimumLength != 0 && filter.MaximumLength != 0)
            {
                return _records.FindAll(i => i.PublicationYear > filter.MinimumLength && i.PublicationYear < filter.MaximumLength);
            }
            else if (filter.MaximumLength != 0)
            {
                return _records.FindAll(i => i.PublicationYear < filter.MaximumLength);
            }
            else if (filter.MinimumLength != 0)
            {
                return _records.FindAll(i => i.PublicationYear > filter.MinimumLength);
            }
            else
            {
                return null;
            }
        }


        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Records/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
